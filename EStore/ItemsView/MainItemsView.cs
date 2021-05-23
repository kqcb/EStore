using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore.ItemsView
{
    public partial class MainItemsView : MetroFramework.Forms.MetroForm
    {
        private User _user;
        private static List<Item> _selectedItems;
        public MainItemsView(User user)
        {
            _selectedItems = new List<Item>();
            _user = user;
            InitializeComponent();
            CheckForAdmin(true);
      
      
          
            ShowData();
        }

        private void tileCreate_Click(object sender, EventArgs e)
        {
            new ItemsView.ItemsCreate().Show();
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemId = Convert.ToInt32(dgItems.Rows[e.RowIndex].Cells[1].Value.ToString());
            Item item = EStoreContext.Items.Read(itemId);
            new ItemsView.ItemDetails(item).Show();
        }

        private void CheckForAdmin(bool isAdmin)
        {
            if (!isAdmin)
            {
                tileCreate.Visible = false;
            }
        }

        private void ShowData()
        {
            DataTable itemTable = EStoreContext.Items.FillDataTable();
            dgItems.DataSource = itemTable;

            DataGridViewCheckBoxColumn chx = new();
            chx.TrueValue = true;
            chx.FalseValue = false;
            
            chx.Width = 100;
            dgItems.Columns.Add(chx);

            dgItems.Columns[dgItems.ColumnCount - 1].Name = "Add to Cart";
            
        }

        private void dgItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgItems.CurrentCell.ColumnIndex == 0)
            {
                dgItems.CurrentCell.Value ??= false;
                dgItems.CurrentCell.Value = !(bool)dgItems.CurrentCell.Value;

                    int itemId = Convert.ToInt32(dgItems.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Item item = EStoreContext.Items.Read(itemId);
                if ((bool)dgItems.CurrentCell.Value)
                {

                    AddToList(item);
                }
                else
                    RemovFromList(item);
             

            }
        }

        private void AddToList(Item item)
        {
            var itm = _selectedItems.FirstOrDefault(f => f.Id == item.Id);

            if (itm is null)
                _selectedItems.Add(item);
        }

        private void RemovFromList(Item item)
        {
            var itm = _selectedItems.FirstOrDefault(f => f.Id == item.Id);

            if (itm is not null)
                _selectedItems.Remove(itm);
        }

        private void tileCart_Click(object sender, EventArgs e)
        {

        }
    }
}

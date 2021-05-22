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
        public MainItemsView(User user)
        {
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
            int itemId = Convert.ToInt32(dgItems.Rows[e.RowIndex].Cells[0].Value.ToString());
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
        }
    }
}

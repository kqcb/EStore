using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;

namespace EStore.UserControls
{
    public partial class ItemsUserControl : UserControl
    {
        private User _user;
        public ItemsUserControl(User user)
        {
            _user = user;
            InitializeComponent();
            CheckForAdmin(true);
            ShowData();
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            new ItemsView.ItemsCreate().Show();
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemId = Convert.ToInt32(dgItems.Rows[e.RowIndex].Cells[0].Value.ToString());
            Item item = EStoreContext.Items.Read("usp_Item_Read", itemId);
            new ItemsView.ItemDetails(item);
        }

        private void CheckForAdmin(bool isAdmin)
        {
            if (!isAdmin)
            {
                btnCreate.Visible = false;
            }
        }

        private void ShowData()
        {
            DataTable itemTable = EStoreContext.Items.FillDataTable();
            dgItems.DataSource = itemTable;
        }
    }
}
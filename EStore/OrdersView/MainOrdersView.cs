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

namespace EStore.OrdersView
{
    public partial class MainOrdersView : MetroFramework.Forms.MetroForm
    {
        private User _user;
        public MainOrdersView(User user)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            _user = user;
            CheckForAdmin(true);
            ShowData();
        }

        private void tileCreate_Click(object sender, EventArgs e)
        {
           // new OrdersView.OrdersCreate().Show();
        }

        private void CheckForAdmin(bool isAdmin)
        {
            //if (!isAdmin)
            //{
            //    tileCreate.Visible = false;
            //}
        }

        private void ShowData()
        {
                DataTable itemTable = EStoreContext.Orders.FillDataTable();
                dgOrders.DataSource = itemTable;
        }

        private void dgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            Order order = EStoreContext.Orders.Read(orderId);
            new OrdersView.OrdersDetails(order).Show();
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainOrdersView_Load(object sender, EventArgs e)
        {

        }

        private void tileBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm(_user);
        }
    }
}

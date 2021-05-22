using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.UserControls
{
    public partial class OrdersUserControl : UserControl
    {
        private User _user;
        public OrdersUserControl(User user)
        {
            this._user = user;
            InitializeComponent();
            CheckForAdmin(true);
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            new OrdersView.OrdersCreate().Show();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            new OrdersView.UpdateOrders().Show();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            new OrdersView.DeleteOrders().Show();
        }

        private void CheckForAdmin(bool isAdmin)
        {
            if(!isAdmin)
            {
                //btnCreate.Visible = false;
                //btnEdit.Visible = false;
                //btnDelete.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
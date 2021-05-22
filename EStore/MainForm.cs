using System;
using System.Windows.Forms;
using EStore.UserControls;
using EStoreBusinessObjects;

namespace EStore
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private User _user;
        public MainForm(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void tileClients_Click(object sender, EventArgs e)
        {
            new ClientsView.MainClientsView(_user).Show();
        }

        private void tileItems_Click(object sender, EventArgs e)
        {
            new ItemsView.MainItemsView(_user).Show();
        }

        private void tileOrders_Click(object sender, EventArgs e)
        {
            new OrdersView.MainOrdersView(_user).Show();
        }
    }
}
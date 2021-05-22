using System;
using System.Windows.Forms;
using EStore.UserControls;
using EStoreBusinessObjects;

namespace EStore
{
    public partial class MainForm : Form
    {
        private ClientsUserControl _clientsUserControl;
        private ItemsUserControl _itemsUserControl;
        private InvoicesUserControl _invoicesUserControl;
        private OrdersUserControl _ordersUserControl;
        private MainUserControl _mainUserControl;
        private User _user;
        public MainForm(User user)
        {
            _user = user;
            InitializeComponent();
            pnldataGrid.Controls.Add(_mainUserControl ?? new MainUserControl(_user));
        }


        private void btnClients_Click(object sender, EventArgs e)
        {
            pnldataGrid.Controls.Clear();
            pnldataGrid.Controls.Add(_clientsUserControl ??= new ClientsUserControl(_user));
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            pnldataGrid.Controls.Clear();
            pnldataGrid.Controls.Add(_itemsUserControl ??= new ItemsUserControl(_user));
        }

       

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnldataGrid.Controls.Clear();
            pnldataGrid.Controls.Add(_ordersUserControl ??= new OrdersUserControl(_user));
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            pnldataGrid.Controls.Clear();
            pnldataGrid.Controls.Add(_invoicesUserControl ??= new InvoicesUserControl(_user));
        }
    }
}
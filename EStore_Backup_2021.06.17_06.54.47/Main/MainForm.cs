using System;
using System.Windows.Forms;
using EStore.CartView;
using EStore.ClientsView;
using EStore.ItemsView;
using EStore.OrdersView;
using EStore.Utils;
using EStoreBusinessObjects;

namespace EStore
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private User _user;
        private MainOrdersControl _mainOrdersControl;
        private ClientsMainControl _clientsMainControl;
        private ClientProfileControl _clientProfileControl;
        private ItemsMainControl _itemsMainControl;
        private CartMainControl _cartMainControl;
 
        private MainControl _mainControl;
        public MainForm(User user)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            _user = user;

            IsClient(user.Role.Id == 2);
            GoToOtherUserControl(_mainControl ??= new MainControl());

            btnGoBack.Visible = false;

        }

       
       
        private void btnProfile_Click(object sender, EventArgs e)
        {
            GoToOtherUserControl(_clientProfileControl ??= new ClientProfileControl(panelMain.Controls,_user));
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            GoToOtherUserControl(_itemsMainControl ??= new ItemsMainControl(_user));
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            GoToOtherUserControl(_mainOrdersControl ??= new MainOrdersControl(panelMain.Controls, _user)); 
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            GoToOtherUserControl(_clientsMainControl ??= new ClientsMainControl(panelMain.Controls, _user));
        }

              
        public void GoToOtherUserControl(UserControl userControl)
        {
            btnGoBack.Visible = true;
            
            Common.ChangeContorl(panelMain.Controls, userControl);

        }
       
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Common.RemoveControl(panelMain.Controls);

            if (panelMain.Controls.Count < 1)
            {
                GoToOtherUserControl(_mainControl);
                btnGoBack.Visible = false;
            }
        }

        private void IsClient(bool isClient)
        {
           btnCart.Visible = isClient;
           btnUsers.Visible = !isClient;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            GoToOtherUserControl(_cartMainControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
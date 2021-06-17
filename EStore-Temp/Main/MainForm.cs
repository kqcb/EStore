using EStore.Auth;
using EStore.Utils;
using EStore_Temp.ClientsView;
using EStore_Temp.DashboardView;
using EStore_Temp.ItemsView;
using EStore_Temp.OrdersView;
using EStore_Temp.ShoppingCartView;
using EStoreBusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EStore_Temp.Main
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private ClientsMainControl _clientsMainControl;
        private ItemsMainControl _itemsMainControl;
        private OrdersMainControl _ordersMainControl;
        private ShoppingCartMainControl _shoppingCartMainControl;
        private DashboardMainControl _dashboardMainControl;
        private readonly User user;

        public MainForm(User user)
        {
            InitializeComponent();

            btnGoBack.Visible = false;
            _clientsMainControl = new();
            _itemsMainControl = new(radPanelMain.Controls, user);
            _ordersMainControl = new();
            _shoppingCartMainControl = new();
            _dashboardMainControl = new();

            Common.ChangeContorl(radPanelMain.Controls, _dashboardMainControl);
            this.user = user;
        } 
        private void ChangeControl(UserControl userControl)
        {
            Common.ChangeContorl(radPanelMain.Controls, userControl);

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = true;
            Common.ChangeContorl(radPanelMain.Controls, _clientsMainControl); 
           
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = false;
            Common.ChangeContorl(radPanelMain.Controls, _dashboardMainControl); 
        }

        private void btnItems_Click(object sender, EventArgs e)
        {

            _itemsMainControl.FillTable();
            btnGoBack.Visible = true;
            Common.ChangeContorl(radPanelMain.Controls, _itemsMainControl); 
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

            btnGoBack.Visible = true;
            Common.ChangeContorl(radPanelMain.Controls, _ordersMainControl);
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {

            btnGoBack.Visible = true;
            Common.ChangeContorl(radPanelMain.Controls, _shoppingCartMainControl); 
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Hide();
            new AuthForm().Show();

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Common.RemoveControl(radPanelMain.Controls);

            if (radPanelMain.Controls.Count < 1)
            {
                Common.ChangeContorl(radPanelMain.Controls, _dashboardMainControl);
                btnGoBack.Visible = false;
            }
        }
    }
}

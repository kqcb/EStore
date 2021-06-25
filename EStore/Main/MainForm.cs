﻿using System;
using System.Windows.Forms;
using EStore.Auth;
using EStore.ClientsView;
using EStore.Utils;
using EStore_Temp.ItemsView;
using EStore_Temp.OrdersView;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;

namespace EStore.Main
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private ClientsMainControl _clientsMainControl;
        private ItemsMainControl _itemsMainControl;
        private OrdersMainControl _ordersMainControl;
        private DashboardView.DashboardControl _dashboard;
        //private Dashboard _dashboard;
        private readonly User user;

        public MainForm(User user)
        {
            InitializeComponent();

            btnGoBack.Visible = false;
            _clientsMainControl = new(radPanelMain.Controls);
            _itemsMainControl = new(radPanelMain.Controls, flowLayoutSelectedList, user);
            _ordersMainControl = new(radPanelMain.Controls, user);
            _dashboard = new();
            lblTitle.Text = "Dashboard";
            lblUser.Text = "Welcome " + user.Name + " " + user.LastName;
            Common.ChangeContorl(radPanelMain.Controls, _dashboard);
            this.user = user;
        } 

        public void ChangeTitleName()
        {

        }


        private void ChangeControl(UserControl userControl)
        {
            Common.ChangeContorl(radPanelMain.Controls, userControl);

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = true;
            lblTitle.Text = "Users";
            Common.ChangeContorl(radPanelMain.Controls, _clientsMainControl); 
           
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";
            btnGoBack.Visible = false;
            Common.ChangeContorl(radPanelMain.Controls, _dashboard); 
        }

        private void btnItems_Click(object sender, EventArgs e)
        {

            _itemsMainControl.FillTable();
            btnGoBack.Visible = true;
            lblTitle.Text = "Items";
            Common.ChangeContorl(radPanelMain.Controls, _itemsMainControl); 
        }

      
        private void btnOrders_Click(object sender, EventArgs e)
        {

            btnGoBack.Visible = true;
            lblTitle.Text = "Orders";
            _ordersMainControl.FillList();
            Common.ChangeContorl(radPanelMain.Controls, _ordersMainControl);
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {

            btnGoBack.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Common.RemoveControl(radPanelMain.Controls);

            if (radPanelMain.Controls.Count < 1)
            {
                lblTitle.Text = "Dashboard";
                Common.ChangeContorl(radPanelMain.Controls, _dashboard);
                btnGoBack.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            flowLayoutSelectedList.Controls.Clear();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                User = user,
                City = user.City,
                Street = "",
                IsPaid = false,
                OrderDate = DateTime.Now
            };

            int id = EStoreContext.Orders.Create(order);

            foreach (var item in ItemsMainControl.selectedItems)
            {

                var orderDetails = new OrderDetails()
                {
                    Item = item,
                    Order = new Order()
                    {
                        Id = id
                    },
                    Discount = 0,
                    Price = item.UnitPrice,
                    Quantity = 1
                };

                if (EStoreContext.OrderDetails.Create(orderDetails) != -1)
                {
                    MessageBox.Show("Order created succesfully");
                }
                else
                {
                    MessageBox.Show("Order could not be created");
                }

            }

            flowLayoutSelectedList.Controls.Clear();
        }
    }
}

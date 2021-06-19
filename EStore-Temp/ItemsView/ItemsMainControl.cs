﻿using EStore.Utils;
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
using static System.Windows.Forms.Control;

namespace EStore_Temp.ItemsView
{
    public partial class ItemsMainControl : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly User _user;
        public static List<Item> selectedItems = new List<Item>(); 

        public ItemsMainControl(ControlCollection controls, User user)
        {
            this._controls = controls;
            this._user = user;
            InitializeComponent();

            if (user.Role.Id == 1)
            {
                radPanel3.Visible = true;
                btnNew.Visible = true;
            }
            else
            {
                btnNew.Visible = false;
            }

            FillTable();
        }

        public void FillTable()
        {

            flowLayoutPanel1.Controls.Clear();

            var items = EStoreContext.Items.Read();
            
            items.ForEach(item => flowLayoutPanel1.Controls.Add(new ItemView(_controls, flowLayoutSelectedList , _user, item)));  
        }
        
         public static void FillCartList(){
           flowLayoutSelectedList.Controls.Clear();
            int count = 0;
            ItemsMainControl.selectedItems.ForEach(item =>
            {
                var itemSelectedControl = new ItemSelectedControl(item);
                itemSelectedControl.SetIndex(++count);
                flowLayoutSelectedList.Controls.Add(itemSelectedControl);

            });

         }


   

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                User = _user,
                City = _user.City,
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
                    Order = new Order() { 
                        Id = id 
                    },
                    Discount = 0,
                    Price = item.UnitPrice,
                    Quantity = 1
                };

                EStoreContext.OrderDetails.Create(orderDetails);

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var itmCreateControl = new ItemCreateControl();

            itmCreateControl.Dock = DockStyle.Fill;

            Common.AddControl(_controls, itmCreateControl);
        }
    }
}

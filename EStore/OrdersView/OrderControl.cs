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

namespace EStore_Temp.OrdersView
{
    public partial class OrderControl : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly Order _order;
        private readonly User _user;

        public OrderControl(ControlCollection controls, Order order, User user)
        {
            InitializeComponent();
            this._controls = controls;
            this._order = order;
            this._user = user;
            this.lblId.Text = order.Id.ToString();
            this.lblStatus.Text = order.IsPaid ? "Order is paid" : "Order is not payed yet";
            this.lblClient.Text = order.User.Name + " " + order.User.LastName;
            this.lblDate.Text = order.OrderDate.ToShortDateString();

            _order.OrderDetails = EStoreContext.OrderDetails.ReadByOrderId(_order.Id);
            decimal amount = 0;
            _order.OrderDetails.ForEach(od =>{

                amount += (od.Price - od.Discount); 
            
            });

            this.lblTotal.Text = amount.ToString().Length > 2 ? amount.ToString().Substring(0, amount.ToString().Length - 3) : 0.ToString();

            if(_user.Role.Description != "Admin")
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }

        }

        public void ChangeColor(Color color)
        {
            this.flowLayoutPanel1.BackColor = color;
            this.BackColor = color;
            this.flowLayoutPanel2.BackColor = color;
            this.radPanel1.BackColor = color;
        }


        private void btnDetails_Click(object sender, EventArgs e)
        {
            List<OrderDetails> orderDetails = EStoreContext.OrderDetails.ReadByOrderId(_order.Id);
            new OrderDetailsForm(orderDetails).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EStoreContext.Orders.Delete(_order.Id))
            {
                ((OrdersMainControl)_controls[0]).FillList();
            }
            else
                MessageBox.Show("Order could not be deleted");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new OrderEditForm(_order).ShowDialog();
        }
    }
}

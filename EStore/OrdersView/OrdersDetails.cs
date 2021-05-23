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
using EStoreBusinessLogicLayer;

namespace EStore.OrdersView
{
    public partial class OrdersDetails : MetroFramework.Forms.MetroForm
    {
        Order order;
        public OrdersDetails(Order order)
        {
            InitializeComponent();
            this.order = order;
            ShowData(order);
        }

        private void ShowData(Order order)
        {
            txbDate.Text = order.OrderDate.ToString();
            txbStreet.Text = order.Street;
            radioIsPaid.Checked = order.IsPaid ? true : false;
            radioNotPaid.Checked = order.IsPaid ? false : true;
            cmbCity.Text = order.City.ToString();
        }

        private void OrdersDetails_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void tileDelete_Click(object sender, EventArgs e)
        {
            EStoreContext.Orders.Delete(order.Id);
            this.Close();
        }

        private void tileEdit_Click(object sender, EventArgs e)
        {
            Order temp = new Order();
            temp.OrderDate = order.OrderDate;
            temp.Street = txbStreet.Text ;
            temp.IsPaid = radioIsPaid.Checked ? true : false;
            temp.City = order.City;
            EStoreContext.Orders.Update(temp);
        }   
    }
}

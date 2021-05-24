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
            //txbQuantity.Text = order.;
            radioIsPaid.Checked = order.IsPaid ? true : false;
            radioNotPaid.Checked = order.IsPaid ? false : true;
            //txbPrice.Text = order.OrderDetails;

        }

        private void OrdersDetails_Load(object sender, EventArgs e)
        {

        }


        private void tileDelete_Click_1(object sender, EventArgs e)
        {
            EStoreContext.Orders.Delete(order.Id);
            this.Close();
        }

        private void tileEdit_Click_1(object sender, EventArgs e)
        {
            OrderDetails temp = new OrderDetails();
            //temp.Quantity = quant  ;
           // temp.IsPaid = radioIsPaid.Checked ? true : false;
           // temp.
           // EStoreContext.Orders.Update(temp);
            this.Close();
        }

        private void txbCity_Click(object sender, EventArgs e)
        {

        }
    }
}

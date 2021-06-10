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

namespace EStore.OrdersView
{
    public partial class OrderDetailsControl : UserControl
    {
        private Order _order;
        public OrderDetailsControl(Order order)
        {
            InitializeComponent();
            _order = order;
            ShowData();

        }
       
        private void ShowData()
        {
            //dgItems.DataSource = EStoreContext.OrderDetails.FillDataTableByOrderId(order.Id);
            //txbCity.Text = order.City.Name;
            //txbDate.Text = order.OrderDate.ToShortDateString();
            //decimal total = 0;
            ////var list = EStoreContext.OrderDetails.ReadByOrderId(order.Id);
            //// list.ForEach(or => total+=or.Price);
            //txbPrice.Text = total.ToString();
            //radioIsPaid.Checked = order.IsPaid ? true : false;
            //radioNotPaid.Checked = order.IsPaid ? false : true;
            //txbStreet.Text = order.Street;

        }

        private void OrdersDetails_Load(object sender, EventArgs e)
        {

        }


        private void tileDelete_Click_1(object sender, EventArgs e)
        {
            //EStoreContext.Orders.Delete(order.Id);
            //this.Close();
        }

        private void tileEdit_Click_1(object sender, EventArgs e)
        {
            //OrderDetails temp = new OrderDetails();
            //this.Close();
        }

        private void txbCity_Click(object sender, EventArgs e)
        {

        }

    }
}

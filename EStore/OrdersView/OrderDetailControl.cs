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
    public partial class OrderDetailControl : UserControl
    {
        private readonly OrderDetails _orderDetail;

        public OrderDetailControl(OrderDetails orderDetail)
        {
            InitializeComponent();
            this._orderDetail = orderDetail;

            lblId.Text = _orderDetail.Id.ToString();
            lblName.Text = _orderDetail.Item.Name;
            lblDescription.Text = _orderDetail.Item.Description;
            lblPrice.Text = _orderDetail.Price.ToString().Substring(0, orderDetail.Price.ToString().Length - 2);
            lblQuantity.Text = _orderDetail.Quantity.ToString();
        }
    }
}

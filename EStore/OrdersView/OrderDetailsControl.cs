using EStore.Utils;
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
    public partial class OrderDetailsControl : UserControl
    {
        private readonly OrderDetails _orderDetails;

        public OrderDetailsControl(OrderDetails orderDetails)
        {
            InitializeComponent();
            this._orderDetails = orderDetails;

            lblName.Text = _orderDetails.Item.Name;
            lblPrice.Text = _orderDetails.Price.ToString();
            lblQuantity.Text = _orderDetails.Quantity.ToString();
            lblDescription.Text = _orderDetails.Item.Description;

            radImage.Image = _orderDetails.Item.Image is not null ? Common.ToImage(_orderDetails.Item.Image) : null;



        }
    }
}

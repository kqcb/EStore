using EStore.OrdersView;
using EStore.Utils;
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
    public partial class OrderDetailsForm : Telerik.WinControls.UI.RadForm
    {
        private readonly List<OrderDetails> _orderDetails;

        public OrderDetailsForm(List<OrderDetails> orderDetails)
        {
            InitializeComponent();
            this._orderDetails = orderDetails;

            FillList();
        }

        public void FillList()
        {
            flowLayoutOrderDetails.Controls.Clear();

            Color[] colors = new Color[] {
                Color.FromArgb(240, 240, 240, 240),
                Color.White

            };
            int i = 0;

            _orderDetails.ForEach(o =>
            {
                var orderDetailControl = new OrderDetailControl(o);
                flowLayoutOrderDetails.Controls.Add(orderDetailControl);

                if (++i == 2)
                {
                    i = 0;
                }
            });

        }
    }
}

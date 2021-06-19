using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using System.Windows.Forms;

namespace EStore_Temp.OrdersView
{
    public partial class OrderDetailsMainControl : UserControl
    {
        private readonly Order order;

        public OrderDetailsMainControl(Order order)
        {
            InitializeComponent();
            this.order = order;
            FillList();
        }

        public void FillList()
        {
            EStoreContext.OrderDetails.ReadByOrderId(order.Id).ForEach(orderDetails => flowLayoutPanelList.Controls.Add(new OrderDetailsControl(orderDetails)));

        }
    }
}

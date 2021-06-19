using EStoreBusinessObjects;
using System.Windows.Forms;

namespace EStore_Temp.OrdersView
{
    public partial class OrderDetailsControl : UserControl
    {
        private readonly Order order;

        public OrderDetailsControl(Order order)
        {
            InitializeComponent();
            this.order = order;
        }
    }
}

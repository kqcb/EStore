using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.UserControls
{
    public partial class OrdersUserControl : UserControl
    {
        private User _user;
        public OrdersUserControl(User user)
        {
            this._user = user;
            InitializeComponent();
        }
    }
}
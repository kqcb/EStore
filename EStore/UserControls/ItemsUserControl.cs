using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.UserControls
{
    public partial class ItemsUserControl : UserControl
    {
        private User _user;
        public ItemsUserControl(User user)
        {
            _user = user;
            InitializeComponent();
        }
    }
}
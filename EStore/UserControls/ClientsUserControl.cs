using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.UserControls
{
    public partial class ClientsUserControl : UserControl
    {
        private User _user;
        public ClientsUserControl(User user)
        {
            _user = user;
            InitializeComponent();
        }
    }
}
using EStoreBusinessObjects;
using System.Windows.Forms;

namespace EStore.ClientsView
{
    public partial class ClientProfileControl : UserControl
    {
        private User _user;
        public ClientProfileControl(ControlCollection controlCollection, User user )
        {
            _user = user;
            InitializeComponent();
        }
    }
}

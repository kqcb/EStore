using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.UserControls
{
    public partial class MainUserControl : UserControl
    {
        private User _user;
        public MainUserControl(User user)
        {
            this._user = user;
            InitializeComponent();
        }
    }
}
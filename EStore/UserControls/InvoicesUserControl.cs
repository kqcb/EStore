using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.UserControls
{
    public partial class InvoicesUserControl : UserControl
    {
        
        private User _user;
        public InvoicesUserControl(User user)
        {
            this._user = user;
            InitializeComponent();
        }
    }
}
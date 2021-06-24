using System;
using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.ClientsView
{
    public partial class ClientEditControl : UserControl
    {
        private readonly User _user;

        public ClientEditControl(User user)
        {
            InitializeComponent();
            this._user = user;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            CheckAdmin(true);
           
        }

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClientUpdate_Click(object sender, System.EventArgs e)
        {

        }

        private void ClientsUserControl_Load(object sender, System.EventArgs e)
        {

        }

        public void CheckAdmin(bool isAdmin)
        {
            if (!isAdmin)
            {
                btnClientUpdate.Visible = false;
                btnCreateClient.Visible = false;
                btnDeleteClient.Visible = false;
            }
        }
    }
}
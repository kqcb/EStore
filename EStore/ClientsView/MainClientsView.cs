using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore.ClientsView
{
    public partial class MainClientsView : MetroFramework.Forms.MetroForm
    {
        private User _user;
        public MainClientsView(User user)
        {
            _user = user;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CheckForAdmin(true);
            ShowData();
        }

        private void tileCreate_Click(object sender, EventArgs e)
        {
            new ClientsView.ClientsCreate().Show();
        }

        private void CheckForAdmin(bool isAdmin)
        {
            if (!isAdmin)
            {
                tileCreate.Visible = false;
            }
        }

        private void ShowData()
        {
            DataTable itemTable = EStoreContext.Users.FillDataTable();
            dgClients.DataSource = itemTable;
        }

        private void dgClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int clientId = Convert.ToInt32(dgClients.Rows[e.RowIndex].Cells[0].Value.ToString());
            User user = EStoreContext.Users.Read(clientId);
            new ClientsView.ClientsDetails(user).Show();
        }

        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

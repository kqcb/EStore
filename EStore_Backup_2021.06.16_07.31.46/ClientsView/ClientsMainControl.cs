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
    public partial class ClientsMainControl : UserControl
    {
        private User _admin;
        private ControlCollection _controlCollection;
        public ClientsMainControl(ControlCollection controlCollection,  User admin)
        {
            _admin = admin;
            _controlCollection = controlCollection;
            InitializeComponent();
            FillTable();
        }

        private void tileBack_Click(object sender, EventArgs e)
        {

        }

        private void tileCreate_Click(object sender, EventArgs e)
        {

        }

        private void FillTable()
        {
                    DataTable itemTable = EStoreContext.Users.ToDataTable();
                dgClients.DataSource = itemTable;
        }
    }
}

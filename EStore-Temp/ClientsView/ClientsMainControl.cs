using EStoreBusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore_Temp.ClientsView
{
    public partial class ClientsMainControl : UserControl
    {
        public ClientsMainControl()
        {
            InitializeComponent();
            FillTable();
        }


        private void FillTable()
        {
            // DataTable itemTable = EStoreContext.Users.ToDataTable();

            EStoreContext.Users.Read().ForEach(user =>
            {
                var clientControl = new ClientControl(user);
                flowLayoutPanel1.Controls.Add(clientControl);
            });

        }
    }
}

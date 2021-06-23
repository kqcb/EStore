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
        private readonly ControlCollection _controls;

        public ClientsMainControl(ControlCollection controls)
        {
            InitializeComponent();
            this._controls = controls;
            FillTable();
        }


        public void FillTable()
        {
            // DataTable itemTable = EStoreContext.Users.ToDataTable();

            EStoreContext.Users.Read().ForEach(user =>
            {
                var clientControl = new ClientControl(_controls, user);
                flowLayoutPanel1.Controls.Add(clientControl);
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            User user = new User();

            Services<User> service = new Services<User>();
            service.ToExcel(user);
        }
    }
}

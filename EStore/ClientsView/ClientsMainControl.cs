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
            FillList();
        }


        public void FillList()
        {
            // DataTable itemTable = EStoreContext.Users.ToDataTable();

            //EStoreContext.Users.Read().ForEach(user =>
            //{
            //    var clientControl = new ClientControl(_controls, user);
            //    clientControl.Margin = new Padding(30, 10, 10, 10);
            //    flowLayoutPanel1.Controls.Add(clientControl);
            //});

            flowLayoutPanel1.Controls.Clear();

            Color[] colors = new Color[] {
                Color.FromArgb(240, 240, 240, 240),
                Color.White

            };
            int i = 0;

            EStoreContext.Users.Read().ForEach(u =>
            {
                var clientControl = new ClientControl(_controls, u);
                clientControl.ChangeColor(colors[i]);
                flowLayoutPanel1.Controls.Add(clientControl);

                if (++i == 2)
                {
                    i = 0;
                }
            });

        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            EStoreContext.Users.ToExcel();
        }
    }
}

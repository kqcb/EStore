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

namespace EStore_Temp.OrdersView
{
    public partial class OrdersMainControl : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly User _user;

        public OrdersMainControl(ControlCollection controls, User user)
        {
            this._controls = controls;
            this._user = user;
            InitializeComponent();
            
        }

        public void FillList()
        {
            //DataTable itemTable = EStoreContext.Orders.ToDataTable();
            //radGridView1.DataSource = itemTable;
            Color[] colors = new Color[] {
                Color.FromArgb(240, 240, 240, 240),
                Color.White

            };
            int i = 0;
            EStoreContext.Orders.Read().ForEach(order =>
            {
                var orderControl = new OrderControl(_controls, order);
                orderControl.ChangeColor(colors[i]);
                flowLayoutPanel1.Controls.Add(orderControl);

                if(++i == 2)
                {
                    i = 0;
                }
            });
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            EStoreContext.Orders.ToExcel();
        }
    }
}

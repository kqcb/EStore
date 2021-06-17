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

namespace EStore_Temp.OrdersView
{
    public partial class OrdersMainControl : UserControl
    {
        public OrdersMainControl()
        {
            InitializeComponent();
            FillTable();
        }

        private void FillTable()
        {
            DataTable itemTable = EStoreContext.Orders.ToDataTable();

            radGridView1.DataSource = itemTable;
        }
    }
}

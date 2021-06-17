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

namespace EStore_Temp.ItemsView
{
    public partial class ItemsMainControl : UserControl
    {
        public ItemsMainControl()
        {
            InitializeComponent();
            FillTable();
        }

        private void FillTable()
        {
            DataTable itemTable = EStoreContext.Items.ToDataTable();

            radGridView1.DataSource = itemTable;
        }
    }
}

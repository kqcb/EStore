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
using static System.Windows.Forms.Control;

namespace EStore_Temp.ItemsView
{
    public partial class ItemsMainControl : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly User _user;

        public ItemsMainControl(ControlCollection controls, User user)
        {
            this._controls = controls;
            this._user = user;
            InitializeComponent();
            FillTable();
        }

        public void FillTable()
        {
            DataTable itemTable = EStoreContext.Items.ToDataTable();

            //radListView1.DataSource = itemTable;

            EStoreContext.Items.Read().ForEach(item => flowLayoutPanel1.Controls.Add(new ItemView(_controls, _user, item)));  
        }
    }
}

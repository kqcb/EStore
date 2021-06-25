using EStore.Utils;
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
        public static List<Item> selectedItems = new List<Item>();
        private FlowLayoutPanel flowLayoutSelectedList;

        public ItemsMainControl(ControlCollection controls, FlowLayoutPanel flowLayoutSelectedList, User user)
        {
            this.flowLayoutSelectedList = flowLayoutSelectedList;
            this._controls = controls;
            this._user = user;
            InitializeComponent();
            btnNew.Visible = true;

            if (user.Role.Id == 1)
            {
                btnNew.Visible = true;
            }
            else
            {
                btnNew.Visible = true;
            }

            FillTable();
        }

        public void FillTable()
        {

            panelMain.Controls.Clear();

            var items = EStoreContext.Items.Read();
            
            items.ForEach(item => panelMain.Controls.Add(new ItemView(_controls, flowLayoutSelectedList , _user, item)));  
        }
        
         public void FillCartList(){
           flowLayoutSelectedList.Controls.Clear();
            int count = 0;
            ItemsMainControl.selectedItems.ForEach(item =>
            {
                var itemSelectedControl = new ItemSelectedControl(_controls, item);
                itemSelectedControl.SetIndex(++count);
                flowLayoutSelectedList.Controls.Add(itemSelectedControl);

            });

         }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new ItemCreateControl(_controls).ShowDialog();
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            EStoreContext.Items.ToExcel();
        }
    }
}

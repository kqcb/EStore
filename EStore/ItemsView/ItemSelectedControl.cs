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

namespace EStore_Temp.ItemsView
{
    public partial class ItemSelectedControl : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly Item _item;


        public ItemSelectedControl(ControlCollection controls, Item item)
        {
            InitializeComponent();
            Random r = new Random();
            this.BackColor = Color.FromArgb(26, 161, 155);
            this._controls = controls;
            this._item = item;
            this.lblName.Text = item.Name;
            this.lblPrice.Text = item.UnitPrice.ToString();
        }

        public void SetIndex(int index)
        {
            lblIndex.Text = index.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var item = ItemsMainControl.selectedItems.FirstOrDefault(item => item.Id == _item.Id);
            ItemsMainControl.selectedItems.Remove(item);
            ((ItemsMainControl)_controls["ItemsMainControl"]).FillCartList();
        }
    }
}

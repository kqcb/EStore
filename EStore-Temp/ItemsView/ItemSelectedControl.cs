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
        private readonly Item _item;

        public ItemSelectedControl(Item item)
        {
            InitializeComponent();
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
            int index = ItemsMainControl.selectedItems.FirstOrDefault(item => item.Id == _item.Id).Id;
            ItemsMainControl.selectedItems.RemoveAt(index);
            ItemsMainControl.FillCartList();
        }
    }
}

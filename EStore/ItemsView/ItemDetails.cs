using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.ItemsView
{
    public partial class ItemDetails : Form
    {
        Item item;
        public ItemDetails(Item item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = txtName.Text;
            item.Description =txtDescription.Text;
            //item. = txtIsActive.Text;
            item.Quantity = int.Parse(txtQuantity.Text);
            item.UnitPrice = double.Parse(txtUnitPrice.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ShowData(Item item)
        {
            txtName.Text = item.Name;
            txtDescription.Text = item.Description;
            txtIsActive.Text = item.IsActive ? "Active" : "Not active";
            txtQuantity.Text = item.Quantity.ToString();
            txtUnitPrice.Text = item.UnitPrice.ToString();
        }
    }
}

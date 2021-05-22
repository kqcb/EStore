using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EStoreBusinessLogicLayer;
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
            Item temp = new Item();
            temp.Name = txtName.Text;
            temp.Description = txtDescription.Text;
            temp.IsActive = rbActive.Checked ? true : false;
            temp.Quantity = int.Parse(txtQuantity.Text);
            temp.UnitPrice = double.Parse(txtUnitPrice.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EStoreContext.Items.Delete("usp_Item_Delete", item.Id);
            this.Close();
        }

        private void ShowData(Item item)
        {
            txtName.Text = item.Name;
            txtDescription.Text = item.Description;
            rbActive.Checked = item.IsActive ? true : false;
            rbInactive.Checked = item.IsActive ? false : true;
            txtQuantity.Text = item.Quantity.ToString();
            txtUnitPrice.Text = item.UnitPrice.ToString();
        }
    }
}

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
    public partial class ItemDetails : MetroFramework.Forms.MetroForm
    {
        Item item;
        public ItemDetails(Item item)
        {
            InitializeComponent();
            this.item = item;
            ShowData(item);
        }

        private void tileDelete_Click(object sender, EventArgs e)
        {
            EStoreContext.Items.Delete(item.Id);
            this.Close();
        }

        private void tileEdit_Click(object sender, EventArgs e)
        {
            Item temp = new Item();
            temp.Id = item.Id;
            temp.Name = txtName.Text;
            temp.Description = txtDescription.Text;
            temp.IsActive = radioActive.Checked ? true : false;
            temp.Brand = new Brand()
            {
                Id = 1
            };
            temp.UnitPrice = double.Parse(txtUnitPrice.Text);

            EStoreContext.Items.Update(temp);
        }

        private void ShowData(Item item)
        {
            txtName.Text = item.Name;
            txtDescription.Text = item.Description;
            radioActive.Checked = item.IsActive ? true : false;
            radioInactive.Checked = item.IsActive ? false : true;
            txtUnitPrice.Text = item.UnitPrice.ToString();
        }
    }
}

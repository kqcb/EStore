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
    public partial class ItemsCreate : Form
    {
        public ItemsCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = txtName.Text;
            item.Description = txtDescription.Text;
            item.IsActive = rbActive.Checked ? true : false;
            item.Brand = new Brand()
            {
                Id = 1
            };
            item.UnitPrice = double.Parse(txtUnitPrice.Text);

            EStoreContext.Items.Create(item);
        }
    }
}

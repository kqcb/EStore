using System;
using System.Windows.Forms;
using EStoreBusinessObjects;

namespace EStore.ItemsView
{
    public partial class ItemsCreate : MetroFramework.Forms.MetroForm
    {
        public ItemsCreate()
        {
            InitializeComponent();
        }


        private void tileCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description) ||
                String.IsNullOrEmpty(txtUnitPrice.Text))
            {
                MessageBox.Show("Please fill all the boxes");
            }
            else
            {

                if (decimal.TryParse(this.txtUnitPrice.Text, out decimal price))
                    MessageBox.Show("Please type a valid price");
                else
                {
                    Item temp = new Item()
                    {
                        Name = name,
                        Description = description,
                        UnitPrice = price,
                        IsActive = radioActive.Checked,
                    };
                    
                    
                }
            }


        }
    }
}

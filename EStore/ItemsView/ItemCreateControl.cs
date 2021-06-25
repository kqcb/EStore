using EStore.Utils;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore_Temp.ItemsView
{
    public partial class ItemCreateControl : Telerik.WinControls.UI.RadForm
    {
        private List<Brand> _brands;
        private List<Category> _categories;
        private readonly Control.ControlCollection _controls;

        public ItemCreateControl(Control.ControlCollection controls)
        {
            InitializeComponent();

            _brands = EStoreContext.Brands.Read();
            _categories = EStoreContext.Categories.Read();

            foreach(var brand in _brands) 
                drlBrand.Items.Add(brand.Name);

            foreach (var category in _categories)
                drlCategory.Items.Add(category.Description);
            this._controls = controls;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                radImage.Image =  Image.FromStream(openFileDialog1.OpenFile());
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var description = txtDescription.Text;
            var image = Common.ToByteArray(radImage.Image);
            
            if(String.IsNullOrEmpty(txtUnitPrice.Text) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description)) {

                MessageBox.Show("Please fill all the boxes");
            } else if (!decimal.TryParse(txtUnitPrice.Text, out var unitPrice))
            {
                MessageBox.Show("Please type a valid price");
            } else
            {
                var item = new Item()
                {
                    Name = name,
                    Description = description,
                    Brand = new Brand()
                    {
                        Id = _brands[drlBrand.SelectedIndex].Id
                    },
                    Category = new Category()
                    {
                        Id = _categories[drlCategory.SelectedIndex].Id
                    },
                    UnitPrice = unitPrice,
                    Image = image
                };

                if (EStoreContext.Items.Create(item) > 0)
                {
                    MessageBox.Show("Item created succesfully");
                }
                else
                    MessageBox.Show("Item could not be created");

                ((ItemsMainControl)_controls["ItemsMainControl"]).FillTable();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace EStore_Temp.ItemsView
{
    public partial class ItemEditControl : UserControl
    {
        private readonly Item _item;
        private List<Brand> _brands;
        private List<Category> _categories;
        public ItemEditControl(Item item)
        {
            _item = item;


            InitializeComponent();

            _brands = EStoreContext.Brands.Read();
            _categories = EStoreContext.Categories.Read();

            foreach (var brand in _brands)
                drlBrand.Items.Add(brand.Name);

            foreach (var category in _categories)
                drlCategory.Items.Add(category.Description);

            txtName.Text = _item.Name;
            txtDescription.Text = _item.Description;
            drlBrand.SelectedItem = drlBrand.Items.FirstOrDefault(i => i.Text == _item.Brand.Name);
            drlBrand.SelectedIndex = drlBrand.Items.IndexOf(drlBrand.SelectedItem);
            drlCategory.SelectedItem = drlCategory.Items.FirstOrDefault(c => c.Text == _item.Category.Description);
            drlCategory.SelectedIndex = drlCategory.Items.IndexOf(drlCategory.SelectedItem);
            txtUnitPrice.Text = _item.UnitPrice.ToString();
            //radImage.Image = Common.ToImage(_item.Image);

            
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                radImage.Image = Image.FromStream(openFileDialog1.OpenFile());
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var description = txtDescription.Text;
            var image = Common.ToByteArray(radImage.Image);

            if (String.IsNullOrEmpty(txtUnitPrice.Text) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description))
            {

                MessageBox.Show("Please fill all the boxes");
            }
            else if (!decimal.TryParse(txtUnitPrice.Text, out var unitPrice))
            {
                MessageBox.Show("Please type a valid price");
            }
            else
            {
                var item = new Item()
                {
                    Id = _item.Id,
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

                if (EStoreContext.Items.Update(item))
                {
                    MessageBox.Show("Item edited succesfully");
                }
                else
                    MessageBox.Show("Item could not be edited");

            }
        }

      
    }
}

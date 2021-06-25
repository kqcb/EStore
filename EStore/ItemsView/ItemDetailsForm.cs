using EStoreBusinessObjects;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EStore_Temp.ItemsView
{
    public partial class ItemDetailsForm : Telerik.WinControls.UI.RadForm
    {
        private readonly Item _item;

        public ItemDetailsForm(Item item)
        {
            InitializeComponent();
            this._item = item;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ItemDetailsForm_Load(object sender, System.EventArgs e)
        {
            txtDescription.Text = _item.Description;
            txtName.Text = _item.Name;
            txtUnitPrice.Text = _item.UnitPrice.ToString();
            txtBrand.Text = _item.Brand.Name;
            txtCategory.Text = _item.Category.Description;

            MemoryStream ms = new MemoryStream(_item.Image);
            radImage.Image = Image.FromStream(ms);
        }
    }
}

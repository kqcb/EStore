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
    public partial class ItemView : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly FlowLayoutPanel _flowLayoutSelectedList;
        private readonly User _user;
        private readonly Item _item;

        public ItemView(ControlCollection controls, FlowLayoutPanel flowLayoutSelectedList,  User user, Item item)
        {
            InitializeComponent();
            this._controls = controls;
            this._flowLayoutSelectedList = flowLayoutSelectedList;
            this._user = user;
            this._item = item;

            if (user.Role.Description == "Admin")
            {
                btnDelete.Visible = true;
                btnEdit.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }

            this.radImage.Image = Common.ToImage(item.Image);
            this.lblItemName.Text = _item.Name;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new ItemEditForm(_item, _controls).ShowDialog();

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            ItemsMainControl.selectedItems.Add(_item);

            ((ItemsMainControl)_controls["ItemsMainControl"]).FillCartList();


        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            new ItemDetailsForm(_item).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EStoreContext.Items.Delete(_item.Id))
            {
                ((ItemsMainControl)_controls[0]).FillTable();

            }
            else
            {
                MessageBox.Show("Item could not be deleted");
            }
        }
    }
}

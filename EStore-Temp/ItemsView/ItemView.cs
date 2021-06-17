using EStore.Utils;
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
        private readonly User _user;
        private readonly Item _item;

        public ItemView(ControlCollection controls ,User user, Item item)
        {
            InitializeComponent();
            this._controls = controls;
            this._user = user;
            this._item = item;

            if (user.Role.Name == "Admin")
            {
                btnEdit.Visible = true;
                btnAddToCart.Visible = false;
            }
            else
            {
                btnEdit.Visible = false;
                btnAddToCart.Visible = true;
            }

            this.lblItemName.Text = _item.Name;

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

       
        private void btnDetails_Click(object sender, EventArgs e)
        {
             
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
             ItemEditControl itemEdit = new ItemEditControl();
            itemEdit.Dock = DockStyle.Fill;
            Common.AddControl(_controls, itemEdit);
          //  Common.AddControl(_controls, itemEdit);

        }
    }
}

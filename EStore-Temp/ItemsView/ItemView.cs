﻿using EStore.Utils;
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

            if (user.Role.Id == 1)
            {
                btnEdit.Visible = true;
                btnAddToCart.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
                btnAddToCart.Visible = true;
            }

            this.lblItemName.Text = _item.Name;

        }

       
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
             ItemEditControl itemEdit = new ItemEditControl(_item);
            itemEdit.Dock = DockStyle.Fill;
            Common.AddControl(_controls, itemEdit);
          //  Common.AddControl(_controls, itemEdit);

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            ItemsMainControl.selectedItems.Add(_item);

            ItemsMainControl.FillCartList();
          

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var itemDetailsControl = new ItemDetailsControl(_item);
            itemDetailsControl.Dock = DockStyle.Fill;
            Common.AddControl(_controls, itemDetailsControl);
        }

       
    }
}
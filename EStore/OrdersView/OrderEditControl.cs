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

namespace EStore_Temp.OrdersView
{
    public partial class OrderEditForm : Telerik.WinControls.UI.RadForm
    {
        private readonly Order _order;

        public OrderEditForm(Order order)
        {
            InitializeComponent();
            this._order = order;

        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = _order.Id.ToString();
            txtUserId.Text = _order.User.Id.ToString();
            txtOrderDate.Text = _order.OrderDate.ToString();
            txtIsPaid.Text = _order.IsPaid.ToString();
            txtAddress.Text = _order.City.Name + " " + _order.Street;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

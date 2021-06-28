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

namespace EStore_Temp.OrdersView
{
    public partial class OrderEditForm : Telerik.WinControls.UI.RadForm
    {
        private readonly Order _order;

        private readonly List<City> _cities;

        public OrderEditForm(Order order)
        {
            InitializeComponent();
            this._order = order;
            this._cities = EStoreContext.Cities.Read();

            foreach (var item in _cities)
            {
                cmbCities.Items.Add(item.Name);
            }

            txtOrderId.Text = _order.Id.ToString();
            txtUserId.Text = _order.User.Id.ToString();
            txtOrderDate.Text = _order.OrderDate.ToString();

            cmbCities.SelectedItem = cmbCities.Items.FirstOrDefault(i => i.Text == _order.City.Name);
            cmbCities.SelectedIndex = cmbCities.Items.IndexOf(cmbCities.SelectedItem);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                User = _order.User,
                City = new City()
                {

                    Id = cmbCities.SelectedIndex,
                },
                Street = _order.Street,
                IsPaid = radioCity.Checked,
                OrderDate = _order.OrderDate
            };

            bool id = EStoreContext.Orders.Update(order);

            if (id)
            {
                MessageBox.Show("Order created succesfully");
            }
            else
            {

                MessageBox.Show("Order could not be created");
            }
        }
    }
}

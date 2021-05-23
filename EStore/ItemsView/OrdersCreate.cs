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

namespace EStore.OrdersView
{
    public partial class OrdersCreate : MetroFramework.Forms.MetroForm
    {
        private List<Item> _items;
        private User _user;
        private List<City> _cities;
        public OrdersCreate(List<Item> items, User user)
        {
            InitializeComponent();
            _items = items;
            _user = user;

            _cities = EStoreContext.Cities.Read();
            for (int i = 0; i < _cities.Count; i++)
                metroComboBoxCities.Items.Add(_cities[i].Name);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var orderDetails = new List<OrderDetails>();
            for (int i = 0; i < _items.Count; i++)
            {
                orderDetails.Add(new OrderDetails()
                {
                    Item = _items[i],
                    Price = _items[i].UnitPrice,
                    Quantity = 1,
                    Discount = 0

                });
            }
            Order order = new Order()
            {
                City = _cities[metroComboBoxCities.SelectedIndex],
                User = _user,
            };

            EStoreContext.Orders.Create(order);

            for (int i = 0; i < orderDetails.Count; i++)
            {
                EStoreContext.OrderDetails.Create(orderDetails[i]);
            }
        }
    }
}

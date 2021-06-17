using System;
using System.Collections.Generic;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;

namespace EStore.CartView
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
            foreach (var city in _cities)
                metroComboBoxCities.Items.Add(city.Name);
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

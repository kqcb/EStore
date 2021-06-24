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
using static System.Windows.Forms.Control;

namespace EStore_Temp.ItemsView
{
    public partial class ItemsMainControl : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly User _user;
        public static List<Item> selectedItems = new List<Item>(); 

        public ItemsMainControl(ControlCollection controls, User user)
        {
            this._controls = controls;
            this._user = user;
            InitializeComponent();
            btnNew.Visible = true;

            if (user.Role.Id == 1)
            {
                radPanel3.Visible = true;
                btnNew.Visible = true;
            }
            else
            {
                btnNew.Visible = true;
            }

            FillTable();
        }

        public void FillTable()
        {

            panelMain.Controls.Clear();

            var items = EStoreContext.Items.Read();
            
            items.ForEach(item => panelMain.Controls.Add(new ItemView(_controls, flowLayoutSelectedListTop , _user, item)));  
        }
        
         public void FillCartList(){
           flowLayoutSelectedList.Controls.Clear();
            int count = 0;
            ItemsMainControl.selectedItems.ForEach(item =>
            {
                var itemSelectedControl = new ItemSelectedControl(_controls, item);
                itemSelectedControl.SetIndex(++count);
                flowLayoutSelectedList.Controls.Add(itemSelectedControl);

            });

         }


   

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                User = _user,
                City = _user.City,
                Street = "",
                IsPaid = false,
                OrderDate = DateTime.Now
            };

           int id = EStoreContext.Orders.Create(order);

            foreach (var item in ItemsMainControl.selectedItems)
            {

                var orderDetails = new OrderDetails()
                {
                    Item = item,
                    Order = new Order() { 
                        Id = id 
                    },
                    Discount = 0,
                    Price = item.UnitPrice,
                    Quantity = 1
                };

                if(EStoreContext.OrderDetails.Create(orderDetails) != -1)
                {
                    MessageBox.Show("Order created succesfully");
                } else
                {
                    MessageBox.Show("Order could not be created");
                }

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var itmCreateControl = new ItemCreateControl(_controls);

            itmCreateControl.Dock = DockStyle.Fill;

            Common.AddControl(_controls, itmCreateControl);
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            EStoreContext.Items.ToExcel();
        }
    }
}

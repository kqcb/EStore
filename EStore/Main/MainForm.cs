using System;
using System.Windows.Forms;
using EStore.Auth;
using EStore.ClientsView;
using EStore.Utils;
using EStore_Temp.ItemsView;
using EStore_Temp.OrdersView;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;

namespace EStore.Main
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private ClientsMainControl _clientsMainControl;
        private ItemsMainControl _itemsMainControl;
        private OrdersMainControl _ordersMainControl;
        private DashboardView.DashboardControl _dashboard;
        //private Dashboard _dashboard;
        private readonly User user;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;

            btnGoBack.Visible = false;
            _clientsMainControl = new(radPanelMain.Controls);
            _itemsMainControl = new(radPanelMain.Controls, flowLayoutSelectedList, user);
            _ordersMainControl = new(radPanelMain.Controls, user);
            _dashboard = new();
            lblTitle.Text = "Dashboard";
            lblUser.Text = "Welcome " + user.Name + " " + user.LastName;

            if (user.Role.Description == "Admin")
            {
                Common.ChangeContorl(radPanelMain.Controls, _dashboard);
            }
            else
            {
                btnUsers.Visible = false;
                btnDashBoard.Visible = false;
                Common.ChangeContorl(radPanelMain.Controls, _itemsMainControl);
            }
        } 

        public void ChangeTitleName()
        {

        }


        private void ChangeControl(UserControl userControl)
        {
            Common.ChangeContorl(radPanelMain.Controls, userControl);

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = true;
            lblTitle.Text = "Users";
            Common.ChangeContorl(radPanelMain.Controls, _clientsMainControl); 
           
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";
            btnGoBack.Visible = false;
            Common.ChangeContorl(radPanelMain.Controls, _dashboard); 
        }

        private void btnItems_Click(object sender, EventArgs e)
        {

            _itemsMainControl.FillTable();
            btnGoBack.Visible = true;
            lblTitle.Text = "Items";
            Common.ChangeContorl(radPanelMain.Controls, _itemsMainControl); 
        }

      
        private void btnOrders_Click(object sender, EventArgs e)
        {

            btnGoBack.Visible = true;
            lblTitle.Text = "Orders";
            _ordersMainControl.FillList();
            Common.ChangeContorl(radPanelMain.Controls, _ordersMainControl);
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {

            btnGoBack.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Common.RemoveControl(radPanelMain.Controls);

            if (radPanelMain.Controls.Count < 1)
            {
                lblTitle.Text = "Dashboard";
                Common.ChangeContorl(radPanelMain.Controls, _dashboard);
                btnGoBack.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            flowLayoutSelectedList.Controls.Clear();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                User = user,
                City = user.City,
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
                    Order = new Order()
                    {
                        Id = id
                    },
                    Discount = 0,
                    Price = item.UnitPrice,
                    Quantity = 1
                };

                EStoreContext.OrderDetails.Create(orderDetails);

            }

            if(id != -1)
            {
                MessageBox.Show("Order created succesfully");
            } else
            {

                MessageBox.Show("Order could not be created");
            }


            flowLayoutSelectedList.Controls.Clear();
        }

        private void helper_Click(object sender, EventArgs e)
        {
            //GetHelpProvider(this, "Mainform.htm");
            Help.ShowHelp(this, @"F:\Apps\EStore\EStore\EStoreHelp.chm", HelpNavigator.Topic, "Mainform.htm");
        }

        //public static void GetHelpProvider(Form frm, string topic)
        //{
        //    //HelpProvider hp = new HelpProvider();
        //    //hp.SetHelpNavigator(frm, HelpNavigator.Topic);
        //    //hp.SetHelpKeyword(frm, topic);
        //    //hp.HelpNamespace = Application.StartupPath + @"\EStoreHelp.chm";
        //    //hp.SetShowHelp(frm, true);



        //    ////Help.ShowHelp(frm, Application.StartupPath + @"\Fixed Assets.chm", HelpNavigator.TopicId, "rev_journal.htm");

        //    //Help.ShowHelp(frm, "EStoreHelp.chm", HelpNavigator.Topic, topic);// "Second_topic.htm");

        //    Help.ShowHelp(frm, "EStoreHelp.chm");


        //}
    }
}

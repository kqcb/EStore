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

namespace EStore.ClientsView
{
    public partial class ClientsDetails : MetroFramework.Forms.MetroForm
    {
        User user;
        public ClientsDetails(User user)
        {
            InitializeComponent();
            this.user = user;
            ShowData(user);
        }

        private void tileDelete_Click(object sender, EventArgs e)
        {
            EStoreContext.Items.Delete(user.Id);
            this.Close();
        }

        private void tileEdit_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                IsActive = radioActive.Checked ? true : false,
                City = new City()
                {
                    Id = 1,
                    Name = "Prishtine"
                },
                Role = new Role()
                {
                    Id = 1,
                    Name = "Admin"
                }
            };
        }

        private void ShowData(User user)
        {
            txtName.Text = user.Name;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;

        }
    }
}

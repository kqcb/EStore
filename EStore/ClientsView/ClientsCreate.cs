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
    public partial class ClientsCreate : MetroFramework.Forms.MetroForm
    {
        public ClientsCreate()
        {
            InitializeComponent();
        }

        private void tileCreate_Click(object sender, EventArgs e)
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

            EStoreContext.Users.Create(user);
        }
    }
}

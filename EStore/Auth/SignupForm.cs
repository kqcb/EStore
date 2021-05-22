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
using static System.String;

namespace EStore.Auth
{
    public partial class SignupForm : MetroFramework.Forms.MetroForm
    {
        private List<City> _cities;
        private LoginForm _loginForm;
        public SignupForm()
        {
            InitializeComponent();
            _cities = EStoreContext.Cities.Read();
            for (int i = 0; i < _cities.Count; i++)
                cmbCities.Items.Add(_cities[i].Name);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginForm ??= new LoginForm();

            _loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int cityIndex = cmbCities.SelectedIndex;

            if (cityIndex == -1 || IsNullOrEmpty(name) || IsNullOrWhiteSpace(password) || IsNullOrEmpty(password) || IsNullOrEmpty(lastName) || IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill all the boxes");
            }
            //else if (!IsNullOrEmpty(password) && !IsNullOrEmpty(repassword) && !password.Equals(repassword))
            //{
            //    MessageBox.Show("Passwords dont match");
            //}
            else
            {
                User user = new User()
                {
                    Name = name,
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    IsActive = true,
                    City = _cities[cityIndex],
                    Role = new Role()
                    {
                        Id = 1
                    }
                };
                EStoreContext.Users.Create(user);
            }
        }
    }
}

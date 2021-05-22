using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using static System.String;

namespace EStore.Auth
{
    public partial class SignUpUserControl : UserControl
    {
        private LoginUserControl _loginUserControl;
        private List<City> _cities;
        public SignUpUserControl()
        {
            InitializeComponent();
            _cities = EStoreContext.Cities.Read();
            for(int i = 0; i < _cities.Count; i++) 
                comboBoxCities.Items.Add(_cities[i].Name);
        }


        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string repassword = textBoxRePassword.Text;
            int cityIndex = comboBoxCities.SelectedIndex;

            if (cityIndex == -1 || IsNullOrEmpty(name) || IsNullOrWhiteSpace(password) || IsNullOrEmpty(repassword) || IsNullOrEmpty(lastName) || IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill all the boxes");
            } else if (!IsNullOrEmpty(password) && !IsNullOrEmpty(repassword) && !password.Equals(repassword))
            {
                MessageBox.Show("Passwords dont match");
            }
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

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
        }
    }
}
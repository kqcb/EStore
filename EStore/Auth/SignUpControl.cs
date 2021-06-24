using EStore.Utils;
using EStore.Utils.Exceptions;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace EStore.Auth
{
    public partial class SignUpControl : UserControl
    {
        private List<City> _cities;
        public SignUpControl()
        {
            InitializeComponent();

            _cities = EStoreContext.Cities.Read();
            for (int i = 0; i < _cities.Count; i++)
                cmbCities.Items.Add(_cities[i].Name);
        }


        public bool Register()
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            string email = txtLastName.Text;
            string password = txtName.Text;
            int cityIndex = cmbCities.SelectedIndex;

            if (cityIndex == -1 || IsNullOrEmpty(name) || IsNullOrWhiteSpace(password) || IsNullOrEmpty(password) || IsNullOrEmpty(lastName) || IsNullOrEmpty(email))
            {
                throw new FieldsNotFilledException();
            }
            //else if (!IsNullOrEmpty(password) && !IsNullOrEmpty(repassword) && !password.Equals(repassword))
            //{
            //    MessageBox.Show("Passwords dont match");
            //}
            else
            {
                var image = EStore.Properties.Resources.Estore_logo;


                User temp = new User()
                {
                    Name = name,
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    City = new City()
                    {
                        Id = _cities[cityIndex].Id,
                    },
                    Role = new Role()
                    {
                        Id = 1
                    },
                    Image = Common.ToByteArray(image)
                };

                return EStoreContext.Users.Create(temp) > 0;

            }
        }

        #region Textboxs
        private void txtName_Click(object sender, EventArgs e)
        {
            changeText(txtName, "Name");
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            changeText(txtLastName, "Lastname");
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            changeText(txtEmail, "Email");
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password") txtPassword.PasswordChar = '*';
            changeText(txtPassword, "Password");
        }

        private void changeText(Telerik.WinControls.UI.RadTextBox textBox, string initialValue)
        {
            if(textBox.Text == initialValue) textBox.Text = "";
        }
        #endregion
    }
}

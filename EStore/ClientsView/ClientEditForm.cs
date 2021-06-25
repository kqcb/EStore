using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EStore.Utils;
using EStore.Utils.Exceptions;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using static System.String;
using System.Linq;
using System.Drawing;

namespace EStore.ClientsView
{
    public partial class ClientEditForm : Telerik.WinControls.UI.RadForm
    {
        private readonly Control.ControlCollection _controls;
        private readonly User _user;
        private readonly List<City> _cities;

        public ClientEditForm(Control.ControlCollection controls, User user)
        {
            InitializeComponent();
            this._controls = controls;
            this._user = user;
            this._cities = EStoreContext.Cities.Read();

            foreach (var item in _cities)
            {
                cmbCities.Items.Add(item.Name);
            }

            txtName.Text = _user.Name;
            txtLastName.Text = _user.LastName;
            txtEmail.Text = _user.Email;
            txtPassword.Text = _user.Password;

            cmbCities.SelectedItem = cmbCities.Items.FirstOrDefault(i => i.Text == _user.City.Name);
            cmbCities.SelectedIndex = cmbCities.Items.IndexOf(cmbCities.SelectedItem);
            
            radImage.Image = user.Image is not null ? Common.ToImage(user.Image) : EStore.Properties.Resources.Estore_logo;
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                    Image = Common.ToByteArray(radImage.Image)
                };

                if(EStoreContext.Users.Update(temp))
                {
                    ((ClientsMainControl)_controls["ClientsMainControl"]).FillList();
                    this.Close();

                } else
                {
                    MessageBox.Show("Client could not be edited");  
                }

            }
        }
    }
}

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

namespace EStore.ClientsView
{
    public partial class ClientsDetailsForm : Telerik.WinControls.UI.RadForm
    {
       
       
        private readonly User _user;
        private readonly List<City> _cities;

        public ClientsDetailsForm(User user)
        {
            InitializeComponent();
            
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
    }
}

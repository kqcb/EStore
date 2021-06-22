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

namespace EStore_Temp.ClientsView
{
    public partial class ClientControl : UserControl
    {
        private readonly ControlCollection _controls;
        private readonly User _user;

        public ClientControl(ControlCollection controls, User user)
        {
            InitializeComponent();
            this._controls = controls;
            this._user = user;
            lblFullName.Text = user.Name + " " +user.LastName;

            //radImage.BackgroundImage = Common.ToImage(user.Image);

            radImage.Image = EStore_Temp.Properties.Resources.Estore_logo;
            lblRole.Text = user.Role.Name;
            lblEmail.Text = user.Email;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EStoreContext.Users.Delete(_user.Id))
            {
                ((ClientsMainControl)_controls[0]).FillTable();
            }
            else
                MessageBox.Show("User could not be deleted");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Common.AddControl(_controls, new ClientEditControl(_user));
        }
    }
}

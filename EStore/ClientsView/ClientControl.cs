using EStore.Utils;
using EStoreBusinessLogicLayer;
using EStoreBusinessObjects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EStore.ClientsView
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
            lblId.Text = user.Id.ToString();
            lblName.Text = user.Name;
            lblLastname.Text = user.LastName;

            //radImage.BackgroundImage = user.Image is not null ? Common.ToImage(user.Image) :null;

            //radImage.Image = EStore.Properties.Resources.Estore_logo;
            lblEmail.Text = user.Email;
            lblIsActive.Text = user.IsActive.ToString();
        }

        public void ChangeColor(Color color)
        {
            this.flowLayoutPanel1.BackColor = color;
            this.BackColor = color;
            this.flowLayoutPanel2.BackColor = color;
            //this.BackColor = color;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EStoreContext.Users.Delete(_user.Id))
            {
                ((ClientsMainControl)_controls[0]).FillList();
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

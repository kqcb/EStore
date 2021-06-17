using EStore.Utils.Exceptions;
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

namespace EStore.Auth
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

      
        public User Login()
        {
            if (!ValidateFields())
                throw new FieldsNotFilledException();

            return EStoreContext.Users.Read(txtEmail.Text, txtPassword.Text);
        }

        public bool ValidateFields()
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
                return false;

            return true;
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
    }
}

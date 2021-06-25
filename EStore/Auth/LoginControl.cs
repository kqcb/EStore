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

        #region Textboxs
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
            if (textBox.Text == initialValue) textBox.Text = "";
        }

        #endregion

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Text = "";
        }
    }
}

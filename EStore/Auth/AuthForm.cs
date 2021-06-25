using EStore.Utils.Exceptions;
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
using EStore.Main;

namespace EStore.Auth
{
    public partial class AuthForm : Telerik.WinControls.UI.RadForm 
    {
        private SignUpControl _signUpControl;
        private MainForm _mainForm;
        private LoginControl _loginControl;
        public AuthForm()
        {
            InitializeComponent();
            btnGoBack.Visible = false;

            _loginControl ??= new LoginControl();

            _signUpControl ??= new SignUpControl();

            ChangeController(_loginControl);
        }

        private void ChangeController(UserControl control)
        {

            panelMain.Controls.Clear();
            control.Height = panelMain.Height;
            panelMain.Controls.Add(control);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user;
                if ((user = _loginControl.Login()) is null)

                    MessageBox.Show("User does not exists");
                else
                {
                    this.Hide();
                    new MainForm(user).ShowDialog();

                    this.Close();
                }
            }
            catch (FieldsNotFilledException)
            {
                MessageBox.Show("Please fill the fields");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = false;
            btnLogin.Visible = true;
            this.Text = "Login";
            ChangeController(_loginControl);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            this.Text = "Sign Up";
            if (btnGoBack.Visible)
            {
                try
                {
                    if (_signUpControl.Register())
                    {
                        MessageBox.Show("User registred succesfully");
                    }
                    else
                    {
                        MessageBox.Show("User could not be created");
                    }
                }
                catch (FieldsNotFilledException)
                {
                    MessageBox.Show("Please fill all the boxes");
                }
            }

            btnGoBack.Visible = true;
            btnLogin.Visible = false;
            ChangeController(_signUpControl);

        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {

            Common.ChangeLanguage("language", "en");
        }

        private void btnShqip_Click(object sender, EventArgs e)
        {

            Common.ChangeLanguage("language", "sq");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

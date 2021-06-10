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

namespace EStore.Auth
{
    public partial class AuthForm : MetroFramework.Forms.MetroForm 
    {
        private SignUpControl _signUpControl;
        private MainForm _mainForm;
        private LoginControl _loginControl;
        public AuthForm()
        {
            InitializeComponent();
            btnGoBack.Visible = false;
            Common.AddControl(panelMain.Controls, _loginControl ??= new LoginControl());
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
                    _mainForm ??= new MainForm(user);
                    _mainForm.Show();
                }
            } catch(FieldsNotFilledException)
            {
                MessageBox.Show("Please fill the fields");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = false;
            btnLogin.Visible = true;
            Common.ChangeContorl(panelMain.Controls, _loginControl ??= new LoginControl());
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
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


            Common.ChangeContorl(panelMain.Controls, _signUpControl ??= new SignUpControl());
        }

    }
}

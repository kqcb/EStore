﻿using EStore.Utils.Exceptions;
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
using EStore_Temp.Main;

namespace EStore.Auth
{
    public partial class AuthForm : Telerik.WinControls.UI.RadForm 
    {
        private SignUpControl _signUpControl;
        private MainForm _mainForm;
        private LoginControl _loginControl;
        private int loginHeight;
        private int signUpHight;
        public AuthForm()
        {
            InitializeComponent();
            btnGoBack.Visible = false;


            _loginControl ??= new LoginControl();

            _signUpControl ??= new SignUpControl();

            loginHeight = _loginControl.Height;
            signUpHight = _signUpControl.Height;



            ChangeController(_loginControl); 
        }

        private void ChangeController(UserControl control)
        {

            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
            panelMain.Height = (control.Height) + 10;
            panelBottom.Location = new Point(panelBottom.Location.X, panelMain.Location.Y + panelMain.Height + 5);
            panel1.Height = panelMain.Height + panelBottom.Height + panel2.Height;
            this.Height = panel1.Height + 70;

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
            } catch(FieldsNotFilledException)
            {
                MessageBox.Show("Please fill the fields");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            btnGoBack.Visible = false;
            btnLogin.Visible = true;
            ChangeController(_loginControl);
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
            ChangeController(_signUpControl);

        }

       
    }
}

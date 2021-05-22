using EStoreBusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace EStore.Auth
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private SignupForm _signupForm;
        private MainForm _mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            _signupForm ??= new SignupForm();
            _signupForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Please fill all the boxes");
            else
            {
                var user = EStoreContext.Users.Read(txtEmail.Text, txtPassword.Text);

                if (user == null)
                    MessageBox.Show("Username or password is incorrect");
                else
                {

                    this.Hide();
                    _mainForm ??= new MainForm(user);
                    _mainForm.Show();

                }
            }
        }
    }
}
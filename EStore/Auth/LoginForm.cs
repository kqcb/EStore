using EStoreBusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace EStore.Auth
{
    public partial class LoginForm : Form
    {
        private SignupForm _signupForm;
        private MainForm _mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
                MessageBox.Show("Please fill all the boxes");
            else
            {
                var user = EStoreContext.Users.Read(textBoxEmail.Text, textBoxPassword.Text);

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

        private void buttonSignUp_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _signupForm ??= new SignupForm();
            _signupForm.Show();
        }
    }
}
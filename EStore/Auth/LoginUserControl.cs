using System;
using System.Windows.Forms;
using EStoreBusinessLogicLayer;

namespace EStore.Auth
{
    public partial class LoginUserControl : UserControl
    {
        private EStore.MainForm _mainForm;
        private SignUpUserControl _signUpUserControl;
        public LoginUserControl()
        {
            InitializeComponent();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
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

        private void LoginUserControl_Load(object sender, EventArgs e)
        {
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
        }
    }
}
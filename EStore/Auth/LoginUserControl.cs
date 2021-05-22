using System;
using System.Windows.Forms;
using EStoreBusinessLogicLayer;

namespace EStore.Auth
{
    public partial class LoginUserControl : UserControl
    {
        private EStore.MainForm _adminMainForm;
        public LoginUserControl()
        {
            InitializeComponent();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUserName.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
                MessageBox.Show("Please fill all the boxes");
            else
            {
                var user = EStoreContext.Users.Read(textBoxUserName.Text, textBoxPassword.Text);

                if (user == null)
                    MessageBox.Show("Username or password is incorrect");
                else
                {

                    this.Hide();
                    if (user.Role.Id == 1)
                    {
                        _adminMainForm ??= new EStore.MainForm(user);
                        _adminMainForm.Show();
                    }
                    else if (user.Role.Id == 2)
                    {
                        //_userMainForm = _userMainForm ?? new UserMainForm();
                        //_userMainForm.Show();
                    }
                }
            }

        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {
        }
    }
}
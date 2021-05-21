using System;
using System.Windows.Forms;
using EStore.Admin;
using EStore.Client;
using EStore_BusinessLogicLayer;

namespace EStore
{
    public partial class LoginForm : Form
    {
        private UserMainForm _userMainForm;
        private AdminMainForm _adminMainForm;
        
        public LoginForm()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUserName.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
                MessageBox.Show("Please fill all the boxes");
            else
            {
                var user = Context.Users.Read(textBoxUserName.Text, textBoxPassword.Text);

                if (user == null)
                    MessageBox.Show("Username or password is incorrect");
                else
                {
                    
                        this.Hide();
                    if (user.Role.Id == 1)
                    {
                        _adminMainForm = _adminMainForm ?? new AdminMainForm();
                        _adminMainForm.Show();
                    } else if (user.Role.Id == 2)
                    {
                        _userMainForm = _userMainForm ?? new UserMainForm();
                        _userMainForm.Show(); 
                    }
                }
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lablePassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
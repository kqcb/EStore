using System.Windows.Forms;

namespace EStore.Auth
{
    public partial class AuthMainForm : Form
    {
        private LoginUserControl _loginUserControl;
        private SignUpUserControl _signUpUserControl;
        public AuthMainForm()
        {
            InitializeComponent();
            
            //panel1.Controls.Add(_loginUserControl ??= new LoginUserControl());
            panel1.Controls.Add(_signUpUserControl ??= new SignUpUserControl());
        }
    }
}
using EStore.Main;
using EStore.Utils;
using System;
using EStoreBusinessObjects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EStore.Auth
{
    public partial class AuthMainForm : Telerik.WinControls.UI.RadForm
    {
        private SignUpControl _signUpControl;
        private MainForm _mainForm;
        private LoginControl _loginControl;
        public AuthMainForm()
        {
            InitializeComponent();

            ChangeController(_loginControl);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            Common.ChangeLanguage("language", "en");
        }

        private void btnShqip_Click(object sender, EventArgs e)
        {
            Common.ChangeLanguage("language", "sq");
        }
    }
}

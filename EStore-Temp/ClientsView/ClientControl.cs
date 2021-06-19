using EStore.Utils;
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

namespace EStore_Temp.ClientsView
{
    public partial class ClientControl : UserControl
    {
        private readonly User user;

        public ClientControl(User user)
        {
            InitializeComponent();
            this.user = user;
            lblFullName.Text = user.Name + " " +user.LastName;

            //radImage.BackgroundImage = Common.ToImage(user.Image);

            radImage.Image = EStore_Temp.Properties.Resources.Estore_logo;
            lblRole.Text = user.Role.Name;
            lblEmail.Text = user.Email;
        }
    }
}

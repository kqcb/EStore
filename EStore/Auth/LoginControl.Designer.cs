
namespace EStore.Auth
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBoxControl();
            this.object_61eedfac_4b8e_41d1_b05b_6b39eb8e0b28 = new Telerik.WinControls.RootRadElement();
            this.object_b2069201_bb67_49e3_94eb_dcf9e6357595 = new Telerik.WinControls.RootRadElement();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtEmail);
            this.flowLayoutPanel1.Controls.Add(this.txtPassword);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 183);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtEmail.Size = new System.Drawing.Size(299, 45);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxControlElement)(this.txtEmail.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadTextBoxControlElement)(this.txtEmail.GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.None;
            ((Telerik.WinControls.UI.RadTextBoxControlElement)(this.txtEmail.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadTextBoxControlElement)(this.txtEmail.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            ((Telerik.WinControls.UI.TextBoxViewElement)(this.txtEmail.GetChildAt(0).GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.TextBoxViewElement)(this.txtEmail.GetChildAt(0).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.None;
            ((Telerik.WinControls.UI.TextBoxViewElement)(this.txtEmail.GetChildAt(0).GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.UI.TextBoxViewElement)(this.txtEmail.GetChildAt(0).GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.TextBoxWrapPanel)(this.txtEmail.GetChildAt(0).GetChildAt(1))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.TextBoxWrapPanel)(this.txtEmail.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadScrollBarElement)(this.txtEmail.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.ScrollBarButton)(this.txtEmail.GetChildAt(0).GetChildAt(2).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(3, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(299, 39);
            this.txtPassword.TabIndex = 1;
            // 
            // object_61eedfac_4b8e_41d1_b05b_6b39eb8e0b28
            // 
            this.object_61eedfac_4b8e_41d1_b05b_6b39eb8e0b28.Name = "object_61eedfac_4b8e_41d1_b05b_6b39eb8e0b28";
            this.object_61eedfac_4b8e_41d1_b05b_6b39eb8e0b28.StretchHorizontally = true;
            this.object_61eedfac_4b8e_41d1_b05b_6b39eb8e0b28.StretchVertically = true;
            // 
            // object_b2069201_bb67_49e3_94eb_dcf9e6357595
            // 
            this.object_b2069201_bb67_49e3_94eb_dcf9e6357595.Name = "object_b2069201_bb67_49e3_94eb_dcf9e6357595";
            this.object_b2069201_bb67_49e3_94eb_dcf9e6357595.StretchHorizontally = true;
            this.object_b2069201_bb67_49e3_94eb_dcf9e6357595.StretchVertically = true;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoginControl";
            this.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Size = new System.Drawing.Size(334, 189);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel htmlLabel1;
        private Telerik.WinControls.UI.RadLabel htmlLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadTextBoxControl txtEmail;
        private Telerik.WinControls.UI.RadTextBoxControl txtPassword;
        private Telerik.WinControls.RootRadElement object_61eedfac_4b8e_41d1_b05b_6b39eb8e0b28;
        private Telerik.WinControls.RootRadElement object_b2069201_bb67_49e3_94eb_dcf9e6357595;
    }
}

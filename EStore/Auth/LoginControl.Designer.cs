
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radLabel1);
            this.flowLayoutPanel1.Controls.Add(this.txtEmail);
            this.flowLayoutPanel1.Controls.Add(this.radLabel2);
            this.flowLayoutPanel1.Controls.Add(this.txtPassword);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 118);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = false;
            this.txtEmail.CausesValidation = false;
            this.txtEmail.EnableTheming = false;
            this.txtEmail.Location = new System.Drawing.Point(3, 30);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShowItemToolTips = false;
            this.txtEmail.Size = new System.Drawing.Size(175, 24);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.ThemeName = "ControlDefault";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 62);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = false;
            this.txtPassword.CausesValidation = false;
            this.txtPassword.EnableTheming = false;
            this.txtPassword.Location = new System.Drawing.Point(3, 88);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ShowItemToolTips = false;
            this.txtPassword.Size = new System.Drawing.Size(175, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.ThemeName = "ControlDefault";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 4);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(33, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Email";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoginControl";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Size = new System.Drawing.Size(188, 122);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel htmlLabel1;
        private Telerik.WinControls.UI.RadLabel htmlLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}


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
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(11, 49);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 39);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(11, 133);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(254, 39);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(13, 22);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 29);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Email";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(13, 96);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 29);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "LoginControl";
            this.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Size = new System.Drawing.Size(305, 220);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel htmlLabel1;
        private Telerik.WinControls.UI.RadLabel htmlLabel2;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
    }
}


namespace EStore.Auth
{
    partial class AuthForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnSignUp = new Telerik.WinControls.UI.RadButton();
            this.btnGoBack = new Telerik.WinControls.UI.RadButton();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EStore.Properties.Resources.test1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(221, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 248);
            this.panel1.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(13, 9);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 204);
            this.panelMain.TabIndex = 6;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(8, 44);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 35);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(94, 3);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 35);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(8, 3);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnLogin);
            this.panelBottom.Controls.Add(this.btnGoBack);
            this.panelBottom.Controls.Add(this.btnSignUp);
            this.panelBottom.Location = new System.Drawing.Point(15, 219);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(200, 38);
            this.panelBottom.TabIndex = 7;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(440, 268);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AuthForm";
            this.Padding = new System.Windows.Forms.Padding(33, 50, 33, 33);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "AuthForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private Telerik.WinControls.UI.RadButton btnSignUp;
        private Telerik.WinControls.UI.RadButton btnGoBack;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private System.Windows.Forms.FlowLayoutPanel panelBottom;
    }
}

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
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.panelBottom = new MetroFramework.Controls.MetroPanel();
            this.btnSignUp = new MetroFramework.Controls.MetroTile();
            this.btnGoBack = new MetroFramework.Controls.MetroTile();
            this.btnLogin = new MetroFramework.Controls.MetroTile();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMain.Location = new System.Drawing.Point(20, 30);
            this.panelMain.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(312, 487);
            this.panelMain.TabIndex = 0;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnSignUp);
            this.panelBottom.Controls.Add(this.btnGoBack);
            this.panelBottom.Controls.Add(this.btnLogin);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.HorizontalScrollbarBarColor = true;
            this.panelBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBottom.HorizontalScrollbarSize = 10;
            this.panelBottom.Location = new System.Drawing.Point(20, 542);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.panelBottom.Size = new System.Drawing.Size(312, 68);
            this.panelBottom.TabIndex = 1;
            this.panelBottom.VerticalScrollbarBarColor = true;
            this.panelBottom.VerticalScrollbarHighlightOnWheel = false;
            this.panelBottom.VerticalScrollbarSize = 10;
            // 
            // btnSignUp
            // 
            this.btnSignUp.ActiveControl = null;
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSignUp.Location = new System.Drawing.Point(10, 4);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(120, 60);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.UseSelectable = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.ActiveControl = null;
            this.btnGoBack.AutoSize = true;
            this.btnGoBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGoBack.Location = new System.Drawing.Point(35, 4);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(129, 60);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseSelectable = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveControl = null;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.Location = new System.Drawing.Point(164, 4);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 60);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(352, 630);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.DisplayHeader = false;
            this.DoubleBuffered = false;
            this.Name = "AuthForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "AuthForm";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMain;
        private MetroFramework.Controls.MetroPanel panelBottom;
        private MetroFramework.Controls.MetroTile btnSignUp;
        private MetroFramework.Controls.MetroTile btnGoBack;
        private MetroFramework.Controls.MetroTile btnLogin;
       
    }
}
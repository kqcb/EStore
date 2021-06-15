
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
            this.panelMain = new Telerik.WinControls.UI.RadPanel();
            this.panelBottom = new Telerik.WinControls.UI.RadPanel();
            this.btnSignUp = new Telerik.WinControls.UI.RadButton();
            this.btnGoBack = new Telerik.WinControls.UI.RadButton();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMain.Location = new System.Drawing.Point(856, 266);
            this.panelMain.Margin = new System.Windows.Forms.Padding(17, 5, 5, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(521, 447);
            this.panelMain.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnSignUp);
            this.panelBottom.Controls.Add(this.btnGoBack);
            this.panelBottom.Controls.Add(this.btnLogin);
            this.panelBottom.Location = new System.Drawing.Point(856, 716);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(5);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.panelBottom.Size = new System.Drawing.Size(521, 113);
            this.panelBottom.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSignUp.Location = new System.Drawing.Point(17, 7);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 167);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(200, 99);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.AutoSize = true;
            this.btnGoBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGoBack.Location = new System.Drawing.Point(221, 7);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(53, 24);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.Location = new System.Drawing.Point(274, 7);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(17);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 99);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EStore_Temp.Properties.Resources.test1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 758);
            this.panel1.TabIndex = 4;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.BackgroundImage = global::EStore_Temp.Properties.Resources.Estore_logo;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Location = new System.Drawing.Point(857, 71);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(516, 189);
            this.metroPanel1.TabIndex = 2;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1408, 880);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.DoubleBuffered = false;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AuthForm";
            this.Padding = new System.Windows.Forms.Padding(33, 50, 33, 33);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "AuthForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panelMain;
        private Telerik.WinControls.UI.RadPanel panelBottom;
        private Telerik.WinControls.UI.RadButton btnSignUp;
        private Telerik.WinControls.UI.RadButton btnGoBack;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.btnSignUp = new Telerik.WinControls.UI.RadButton();
            this.btnGoBack = new Telerik.WinControls.UI.RadButton();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4 = new Telerik.WinControls.RootRadElement();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(149, 44);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 35);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(63, 3);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 35);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(149, 3);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnLogin.Name = "btnLogin";
            // 
            // 
            // 
            this.btnLogin.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnLogin.RootElement.BorderHighlightThickness = 3;
            this.btnLogin.RootElement.EnableBorderHighlight = true;
            this.btnLogin.RootElement.EnableElementShadow = true;
            this.btnLogin.RootElement.EnableHighlight = true;
            this.btnLogin.RootElement.Shape = this.roundRectShape1;
            this.btnLogin.RootElement.ShouldPaint = true;
            this.btnLogin.Size = new System.Drawing.Size(75, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogin.GetChildAt(0))).Text = "Login";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogin.GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogin.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnLogin.GetChildAt(0).GetChildAt(0))).GradientPercentage = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnLogin.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnLogin.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radPictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panelMain);
            this.splitContainer1.Panel1.Controls.Add(this.panelBottom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(567, 317);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 8;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(12, 89);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(227, 167);
            this.panelMain.TabIndex = 10;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnLogin);
            this.panelBottom.Controls.Add(this.btnGoBack);
            this.panelBottom.Controls.Add(this.btnSignUp);
            this.panelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelBottom.Location = new System.Drawing.Point(12, 262);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(227, 43);
            this.panelBottom.TabIndex = 9;
            // 
            // object_16b44ec2_e7c4_4203_8dff_26daab68a4f4
            // 
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4.BorderHighlightThickness = 3;
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4.Name = "object_16b44ec2_e7c4_4203_8dff_26daab68a4f4";
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4.Shape = this.roundRectShape1;
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4.ShouldPaint = true;
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4.StretchHorizontally = true;
            this.object_16b44ec2_e7c4_4203_8dff_26daab68a4f4.StretchVertically = true;
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.radPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radPictureBox1.DefaultImage = null;
            this.radPictureBox1.DefaultSvgImageXml = resources.GetString("radPictureBox1.DefaultSvgImageXml");
            this.radPictureBox1.Image = global::EStore.Properties.Resources.user__1_;
            this.radPictureBox1.Location = new System.Drawing.Point(75, 12);
            this.radPictureBox1.Name = "radPictureBox1";
            // 
            // 
            // 
            this.radPictureBox1.RootElement.BorderHighlightColor = System.Drawing.Color.Empty;
            this.radPictureBox1.RootElement.BorderHighlightThickness = 2;
            this.radPictureBox1.Size = new System.Drawing.Size(104, 71);
            this.radPictureBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.panel1.BackgroundImage = global::EStore.Properties.Resources.test1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 317);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 317);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AuthForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "AuthForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btnSignUp;
        private Telerik.WinControls.UI.RadButton btnGoBack;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.RootRadElement object_16b44ec2_e7c4_4203_8dff_26daab68a4f4;
    }
}
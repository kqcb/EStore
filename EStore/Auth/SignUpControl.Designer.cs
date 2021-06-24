
namespace EStore.Auth
{
    partial class SignUpControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCities);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 224);
            this.panel1.TabIndex = 1;
            // 
            // cmbCities
            // 
            this.cmbCities.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCities.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(16, 175);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(244, 29);
            this.cmbCities.TabIndex = 5;
            this.cmbCities.Text = "Choose city";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(16, 75);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtEmail.Name = "txtEmail";
            // 
            // 
            // 
            this.txtEmail.RootElement.AccessibleDescription = "Password";
            this.txtEmail.RootElement.ShadowDepth = 0;
            this.txtEmail.Size = new System.Drawing.Size(244, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtEmail.GetChildAt(0))).Text = "Email";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtEmail.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtEmail.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtEmail.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtEmail.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtEmail.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(16, 125);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtPassword.Name = "txtPassword";
            // 
            // 
            // 
            this.txtPassword.RootElement.AccessibleDescription = "Password";
            this.txtPassword.RootElement.ShadowDepth = 0;
            this.txtPassword.Size = new System.Drawing.Size(244, 31);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPassword.GetChildAt(0))).Text = "Password";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPassword.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtPassword.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtPassword.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtPassword.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtPassword.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(16, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(107, 31);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtName.GetChildAt(0))).Text = "Name";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtName.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtName.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtName.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLastName.Location = new System.Drawing.Point(151, 27);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(109, 31);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Lastname";
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtLastName.GetChildAt(0))).Text = "Lastname";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtLastName.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtLastName.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtLastName.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtLastName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtLastName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SignUpControl";
            this.Size = new System.Drawing.Size(282, 460);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbCities;
    }
}

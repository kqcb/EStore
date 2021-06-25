
namespace EStore.ClientsView
{
    partial class ClientsDetailsForm
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
            this.radImage = new Telerik.WinControls.UI.RadPictureBox();
            this.cmbCities = new Telerik.WinControls.UI.RadDropDownList();
            this.btnGoBack = new Telerik.WinControls.UI.RadButton();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radImage
            // 
            this.radImage.ImageLayout = Telerik.WinControls.UI.RadImageLayout.Stretch;
            this.radImage.Location = new System.Drawing.Point(12, 21);
            this.radImage.Name = "radImage";
            this.radImage.Size = new System.Drawing.Size(154, 119);
            this.radImage.SvgImageXml = null;
            this.radImage.TabIndex = 12;
            // 
            // cmbCities
            // 
            this.cmbCities.DropDownAnimationEnabled = true;
            this.cmbCities.Enabled = false;
            this.cmbCities.Location = new System.Drawing.Point(195, 169);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(371, 24);
            this.cmbCities.TabIndex = 20;
            this.cmbCities.Text = "Choose City";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoBack.Location = new System.Drawing.Point(456, 228);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(110, 36);
            this.btnGoBack.TabIndex = 25;
            this.btnGoBack.Text = "Go Back";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(195, 69);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtEmail.Name = "txtEmail";
            // 
            // 
            // 
            this.txtEmail.RootElement.AccessibleDescription = "Password";
            this.txtEmail.RootElement.ShadowDepth = 0;
            this.txtEmail.Size = new System.Drawing.Size(371, 31);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Text = "Email";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtEmail.GetChildAt(0))).Text = "Email";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtEmail.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtEmail.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtEmail.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtEmail.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtEmail.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(195, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtPassword.Name = "txtPassword";
            // 
            // 
            // 
            this.txtPassword.RootElement.AccessibleDescription = "Password";
            this.txtPassword.RootElement.ShadowDepth = 0;
            this.txtPassword.Size = new System.Drawing.Size(371, 31);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.Text = "Password";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPassword.GetChildAt(0))).Text = "Password";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPassword.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtPassword.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtPassword.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtPassword.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtPassword.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(195, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 31);
            this.txtName.TabIndex = 21;
            this.txtName.Text = "Name";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtName.GetChildAt(0))).Text = "Name";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtName.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtName.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtName.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLastName.Location = new System.Drawing.Point(386, 21);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 31);
            this.txtLastName.TabIndex = 22;
            this.txtLastName.Text = "Lastname";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtLastName.GetChildAt(0))).Text = "Lastname";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtLastName.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtLastName.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtLastName.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtLastName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtLastName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // ClientsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 282);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.radImage);
            this.Name = "ClientsDetailsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Details";
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadPictureBox radImage;
        private Telerik.WinControls.UI.RadDropDownList cmbCities;
        private Telerik.WinControls.UI.RadButton btnGoBack;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
    }
}

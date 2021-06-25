
namespace EStore.ClientsView
{
    partial class ClientEditForm
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
            this.btnSelectImage = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.radImage = new Telerik.WinControls.UI.RadPictureBox();
            this.btnGoBack = new Telerik.WinControls.UI.RadButton();
            this.cmbCities = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(12, 136);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(151, 36);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "Select Image";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(345, 213);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(187, 60);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtEmail.Name = "txtEmail";
            // 
            // 
            // 
            this.txtEmail.RootElement.AccessibleDescription = "Password";
            this.txtEmail.RootElement.ShadowDepth = 0;
            this.txtEmail.Size = new System.Drawing.Size(268, 31);
            this.txtEmail.TabIndex = 8;
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
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(187, 110);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtPassword.Name = "txtPassword";
            // 
            // 
            // 
            this.txtPassword.RootElement.AccessibleDescription = "Password";
            this.txtPassword.RootElement.ShadowDepth = 0;
            this.txtPassword.Size = new System.Drawing.Size(268, 31);
            this.txtPassword.TabIndex = 9;
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
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(187, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 31);
            this.txtName.TabIndex = 6;
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
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLastName.Location = new System.Drawing.Point(322, 12);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 31);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.Text = "Lastname";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtLastName.GetChildAt(0))).Text = "Lastname";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtLastName.GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtLastName.GetChildAt(0).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txtLastName.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtLastName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).ShadowDepth = 0;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.txtLastName.GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radImage
            // 
            this.radImage.ImageLayout = Telerik.WinControls.UI.RadImageLayout.Stretch;
            this.radImage.Location = new System.Drawing.Point(12, 12);
            this.radImage.Name = "radImage";
            this.radImage.Size = new System.Drawing.Size(151, 100);
            this.radImage.SvgImageXml = null;
            this.radImage.TabIndex = 11;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(232, 213);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(107, 36);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "Go Back";
            // 
            // cmbCities
            // 
            this.cmbCities.DropDownAnimationEnabled = true;
            this.cmbCities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCities.Location = new System.Drawing.Point(187, 161);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(265, 24);
            this.cmbCities.TabIndex = 13;
            this.cmbCities.Text = "Choose city";
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.radImage);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSelectImage);
            this.Name = "ClientEditForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Client";
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSelectImage;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
        private Telerik.WinControls.UI.RadPictureBox radImage;
        private Telerik.WinControls.UI.RadButton btnGoBack;
        private Telerik.WinControls.UI.RadDropDownList cmbCities;
    }
}

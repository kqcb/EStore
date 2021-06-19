
namespace EStore_Temp.ClientsView
{
    partial class ClientControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientControl));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDetails = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radImage = new Telerik.WinControls.UI.RadPictureBox();
            this.lblFullName = new Telerik.WinControls.UI.RadLabel();
            this.lblRole = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblEmail = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.flowLayoutPanel1);
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.lblEmail);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1269, 171);
            this.radPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnDetails);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(889, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 55, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 171);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 36);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(117, 58);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(109, 36);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(232, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.radImage);
            this.radPanel3.Controls.Add(this.lblFullName);
            this.radPanel3.Controls.Add(this.lblRole);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel3.Location = new System.Drawing.Point(0, 0);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(300, 171);
            this.radPanel3.TabIndex = 14;
            // 
            // radImage
            // 
            this.radImage.DefaultSvgImageXml = resources.GetString("radImage.DefaultSvgImageXml");
            this.radImage.ImageLayout = Telerik.WinControls.UI.RadImageLayout.Stretch;
            this.radImage.Location = new System.Drawing.Point(91, 14);
            this.radImage.Name = "radImage";
            this.radImage.Size = new System.Drawing.Size(112, 85);
            this.radImage.TabIndex = 16;
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(115, 116);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 18);
            this.lblFullName.TabIndex = 14;
            this.lblFullName.Text = "Full Name";
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(128, 140);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(28, 18);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(348, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(38, 18);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Email: ";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(392, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(33, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(1269, 171);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblEmail;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadLabel lblFullName;
        private Telerik.WinControls.UI.RadLabel lblRole;
        private Telerik.WinControls.UI.RadPictureBox radImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDetails;
        private Telerik.WinControls.UI.RadButton btnDelete;
    }
}

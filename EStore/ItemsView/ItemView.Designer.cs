
namespace EStore_Temp.ItemsView
{
    partial class ItemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemView));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAddToCart = new Telerik.WinControls.UI.RadButton();
            this.btnDetails = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.lblItemName = new Telerik.WinControls.UI.RadLabel();
            this.radImage = new Telerik.WinControls.UI.RadPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radImage);
            this.radPanel1.Controls.Add(this.flowLayoutPanel1);
            this.radPanel1.Controls.Add(this.lblItemName);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(307, 388);
            this.radPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnAddToCart);
            this.flowLayoutPanel1.Controls.Add(this.btnDetails);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 250);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 91);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(85, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(77, 36);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(3, 45);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 36);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(133, 213);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(36, 18);
            this.lblItemName.TabIndex = 6;
            this.lblItemName.Text = "Name";
            // 
            // radImage
            // 
            this.radImage.Location = new System.Drawing.Point(85, 46);
            this.radImage.Name = "radImage";
            this.radImage.Size = new System.Drawing.Size(150, 150);
            this.radImage.TabIndex = 8;
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ItemView";
            this.Size = new System.Drawing.Size(307, 388);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAddToCart;
        private Telerik.WinControls.UI.RadButton btnDetails;
        private Telerik.WinControls.UI.RadLabel lblItemName;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadPictureBox radImage;
    }
}

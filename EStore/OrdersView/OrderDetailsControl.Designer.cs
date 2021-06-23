
namespace EStore_Temp.OrdersView
{
    partial class OrderDetailsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsControl));
            this.radImage = new Telerik.WinControls.UI.RadPictureBox();
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            this.lblDescription = new Telerik.WinControls.UI.RadLabel();
            this.lblPrice = new Telerik.WinControls.UI.RadLabel();
            this.lblQuantity = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // radImage
            // 
            this.radImage.DefaultSvgImageXml = resources.GetString("radImage.DefaultSvgImageXml");
            this.radImage.Location = new System.Drawing.Point(54, 16);
            this.radImage.Name = "radImage";
            this.radImage.Size = new System.Drawing.Size(140, 126);
            this.radImage.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(234, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Item Name";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(271, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 18);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Item Description";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(406, 82);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 18);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(492, 112);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 18);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // OrderDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.radImage);
            this.Name = "OrderDetailsControl";
            this.Size = new System.Drawing.Size(1138, 183);
            ((System.ComponentModel.ISupportInitialize)(this.radImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPictureBox radImage;
        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadLabel lblDescription;
        private Telerik.WinControls.UI.RadLabel lblPrice;
        private Telerik.WinControls.UI.RadLabel lblQuantity;
    }
}

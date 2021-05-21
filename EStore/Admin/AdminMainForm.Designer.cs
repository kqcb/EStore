using System.ComponentModel;

namespace EStore.Admin
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlSideMenu.Controls.Add(this.btnInvoices);
            this.pnlSideMenu.Controls.Add(this.btnCategory);
            this.pnlSideMenu.Controls.Add(this.btnOrders);
            this.pnlSideMenu.Controls.Add(this.btnItem);
            this.pnlSideMenu.Controls.Add(this.btnClient);
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Location = new System.Drawing.Point(22, 12);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(484, 1071);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnInvoices
            // 
            this.btnInvoices.FlatAppearance.BorderSize = 2;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoices.Location = new System.Drawing.Point(18, 882);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(333, 86);
            this.btnInvoices.TabIndex = 1;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 2;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(18, 580);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(333, 86);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 2;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(18, 729);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(333, 86);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnItem
            // 
            this.btnItem.FlatAppearance.BorderSize = 2;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItem.Location = new System.Drawing.Point(18, 427);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(333, 86);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "Items";
            this.btnItem.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.FlatAppearance.BorderSize = 2;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(18, 282);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(333, 86);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EStore.Properties.Resources._72579_5454192_979319_imagei;
            this.pictureBox1.Location = new System.Drawing.Point(-50, -13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlTopMenu.Location = new System.Drawing.Point(499, 12);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1636, 157);
            this.pnlTopMenu.TabIndex = 0;
            this.pnlTopMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(512, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1623, 908);
            this.panel1.TabIndex = 1;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2147, 1083);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlTopMenu);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panel1;
    }
}
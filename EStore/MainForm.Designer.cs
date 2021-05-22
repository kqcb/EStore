using System.ComponentModel;

namespace EStore
{
    partial class MainForm
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlSideMenu.Controls.Add(this.btnOrders);
            this.pnlSideMenu.Controls.Add(this.btnItems);
            this.pnlSideMenu.Controls.Add(this.btnClients);
            this.pnlSideMenu.Controls.Add(this.pictureBox1);
            this.pnlSideMenu.Location = new System.Drawing.Point(12, 8);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(272, 691);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 2;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(34, 364);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(187, 55);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnItems
            // 
            this.btnItems.FlatAppearance.BorderSize = 2;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Location = new System.Drawing.Point(34, 267);
            this.btnItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(187, 55);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnClients
            // 
            this.btnClients.FlatAppearance.BorderSize = 2;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(34, 174);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(187, 55);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-28, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlTopMenu.Location = new System.Drawing.Point(281, 8);
            this.pnlTopMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(920, 101);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(288, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 586);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlTopMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnItems;

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panel1;
    }
}
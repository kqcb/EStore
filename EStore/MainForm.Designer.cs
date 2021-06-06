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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tileClients = new MetroFramework.Controls.MetroTile();
            this.tileItems = new MetroFramework.Controls.MetroTile();
            this.tileOrders = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileClients
            // 
            this.tileClients.ActiveControl = null;
            this.tileClients.BackColor = System.Drawing.Color.Transparent;
            this.tileClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileClients.Location = new System.Drawing.Point(13, 21);
            this.tileClients.Name = "tileClients";
            this.tileClients.Size = new System.Drawing.Size(199, 179);
            this.tileClients.TabIndex = 2;
            this.tileClients.Text = "Clients";
            this.tileClients.TileImage = ((System.Drawing.Image)(resources.GetObject("tileClients.TileImage")));
            this.tileClients.UseSelectable = true;
            this.tileClients.UseTileImage = true;
            this.tileClients.Click += new System.EventHandler(this.tileClients_Click);
            // 
            // tileItems
            // 
            this.tileItems.ActiveControl = null;
            this.tileItems.BackColor = System.Drawing.Color.Transparent;
            this.tileItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileItems.Location = new System.Drawing.Point(249, 21);
            this.tileItems.Name = "tileItems";
            this.tileItems.Size = new System.Drawing.Size(199, 179);
            this.tileItems.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileItems.TabIndex = 3;
            this.tileItems.Text = "Items";
            this.tileItems.TileImage = ((System.Drawing.Image)(resources.GetObject("tileItems.TileImage")));
            this.tileItems.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileItems.UseSelectable = true;
            this.tileItems.UseTileImage = true;
            this.tileItems.Click += new System.EventHandler(this.tileItems_Click);
            // 
            // tileOrders
            // 
            this.tileOrders.ActiveControl = null;
            this.tileOrders.BackColor = System.Drawing.Color.Transparent;
            this.tileOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileOrders.Location = new System.Drawing.Point(489, 21);
            this.tileOrders.Name = "tileOrders";
            this.tileOrders.Size = new System.Drawing.Size(199, 179);
            this.tileOrders.Style = MetroFramework.MetroColorStyle.Green;
            this.tileOrders.TabIndex = 4;
            this.tileOrders.Text = "Orders";
            this.tileOrders.TileImage = ((System.Drawing.Image)(resources.GetObject("tileOrders.TileImage")));
            this.tileOrders.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tileOrders.UseSelectable = true;
            this.tileOrders.UseTileImage = true;
            this.tileOrders.Click += new System.EventHandler(this.tileOrders_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tileClients);
            this.panel1.Controls.Add(this.tileOrders);
            this.panel1.Controls.Add(this.tileItems);
            this.panel1.Location = new System.Drawing.Point(3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 221);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 318);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "EStore";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnClient;
        private MetroFramework.Controls.MetroTile tileClients;
        private MetroFramework.Controls.MetroTile tileItems;
        private MetroFramework.Controls.MetroTile tileOrders;
        private System.Windows.Forms.Panel panel1;
    }
}
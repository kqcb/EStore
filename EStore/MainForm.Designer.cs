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
            this.SuspendLayout();
            // 
            // tileClients
            // 
            this.tileClients.ActiveControl = null;
            this.tileClients.BackColor = System.Drawing.Color.Transparent;
            this.tileClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileClients.Location = new System.Drawing.Point(17, 91);
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
            this.tileItems.Location = new System.Drawing.Point(253, 91);
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
            this.tileOrders.Location = new System.Drawing.Point(493, 91);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 310);
            this.Controls.Add(this.tileOrders);
            this.Controls.Add(this.tileItems);
            this.Controls.Add(this.tileClients);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "EStore";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnClient;
        private MetroFramework.Controls.MetroTile tileClients;
        private MetroFramework.Controls.MetroTile tileItems;
        private MetroFramework.Controls.MetroTile tileOrders;
    }
}
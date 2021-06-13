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
            this.panelTop = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnCart = new MetroFramework.Controls.MetroTile();
            this.btnLogout = new MetroFramework.Controls.MetroTile();
            this.btnUsers = new MetroFramework.Controls.MetroTile();
            this.btnOrders = new MetroFramework.Controls.MetroTile();
            this.btnProducts = new MetroFramework.Controls.MetroTile();
            this.btnProfile = new MetroFramework.Controls.MetroTile();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.panelImage = new MetroFramework.Controls.MetroPanel();
            this.btnGoBack = new MetroFramework.Controls.MetroTile();
            this.panelTop.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnGoBack);
            this.panelTop.HorizontalScrollbarBarColor = true;
            this.panelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTop.HorizontalScrollbarSize = 10;
            this.panelTop.Location = new System.Drawing.Point(297, 38);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1130, 97);
            this.panelTop.TabIndex = 3;
            this.panelTop.VerticalScrollbarBarColor = true;
            this.panelTop.VerticalScrollbarHighlightOnWheel = false;
            this.panelTop.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(488, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.metroPanel1.Controls.Add(this.btnCart);
            this.metroPanel1.Controls.Add(this.btnLogout);
            this.metroPanel1.Controls.Add(this.btnUsers);
            this.metroPanel1.Controls.Add(this.btnOrders);
            this.metroPanel1.Controls.Add(this.btnProducts);
            this.metroPanel1.Controls.Add(this.btnProfile);
            this.metroPanel1.Controls.Add(this.panelImage);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(268, 796);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnCart
            // 
            this.btnCart.ActiveControl = null;
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCart.Location = new System.Drawing.Point(0, 670);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(268, 63);
            this.btnCart.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnCart.TabIndex = 9;
            this.btnCart.Text = "Shopping Cart";
            this.btnCart.UseSelectable = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveControl = null;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 733);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(268, 63);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseSelectable = true;
            // 
            // btnUsers
            // 
            this.btnUsers.ActiveControl = null;
            this.btnUsers.Location = new System.Drawing.Point(3, 298);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(268, 64);
            this.btnUsers.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseSelectable = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.ActiveControl = null;
            this.btnOrders.Location = new System.Drawing.Point(3, 234);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(268, 64);
            this.btnOrders.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseSelectable = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.ActiveControl = null;
            this.btnProducts.Location = new System.Drawing.Point(3, 170);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(268, 64);
            this.btnProducts.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseSelectable = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ActiveControl = null;
            this.btnProfile.Location = new System.Drawing.Point(3, 106);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(265, 73);
            this.btnProfile.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnProfile.UseSelectable = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.ForeColor = System.Drawing.SystemColors.Control;
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.Location = new System.Drawing.Point(297, 144);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1116, 687);
            this.panelMain.TabIndex = 2;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImage = global::EStore.Properties.Resources.Estore_logo1;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.HorizontalScrollbarBarColor = true;
            this.panelImage.HorizontalScrollbarHighlightOnWheel = false;
            this.panelImage.HorizontalScrollbarSize = 10;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(268, 100);
            this.panelImage.TabIndex = 3;
            this.panelImage.VerticalScrollbarBarColor = true;
            this.panelImage.VerticalScrollbarHighlightOnWheel = false;
            this.panelImage.VerticalScrollbarSize = 10;
            // 
            // btnGoBack
            // 
            this.btnGoBack.ActiveControl = null;
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnGoBack.Location = new System.Drawing.Point(1000, 24);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(85, 59);
            this.btnGoBack.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGoBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGoBack.TileImage = global::EStore.Properties.Resources.x_symbol__2_;
            this.btnGoBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoBack.UseCustomBackColor = true;
            this.btnGoBack.UseSelectable = true;
            this.btnGoBack.UseTileImage = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 876);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = ":w";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnClient;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel panelImage;
        private MetroFramework.Controls.MetroTile btnProfile;
        private MetroFramework.Controls.MetroTile btnOrders;
        private MetroFramework.Controls.MetroTile btnProducts;
        private MetroFramework.Controls.MetroTile btnUsers;
        private MetroFramework.Controls.MetroTile btnLogout;
        private MetroFramework.Controls.MetroPanel panelTop;
        private MetroFramework.Controls.MetroTile btnGoBack;
        private MetroFramework.Controls.MetroTile btnCart;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private MetroFramework.Controls.MetroPanel panelMain;
    }
}
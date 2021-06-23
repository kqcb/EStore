namespace EStore.Main
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnShoppingCart = new Telerik.WinControls.UI.RadButton();
            this.btnLogOut = new Telerik.WinControls.UI.RadButton();
            this.btnOrders = new Telerik.WinControls.UI.RadButton();
            this.btnUsers = new Telerik.WinControls.UI.RadButton();
            this.btnItems = new Telerik.WinControls.UI.RadButton();
            this.btnDashBoard = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutTopMid = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.flowLayoutTopRight = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSignOut = new Telerik.WinControls.UI.RadButton();
            this.lblUser = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutTopLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGoBack = new Telerik.WinControls.UI.RadButton();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.radPanelTop2 = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutTop2Mid = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutTop2Right = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutTop2Left = new System.Windows.Forms.FlowLayoutPanel();
            this.radPanelMain = new Telerik.WinControls.UI.RadPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.radPanelTop.SuspendLayout();
            this.flowLayoutTopMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            this.flowLayoutTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).BeginInit();
            this.flowLayoutTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop2)).BeginInit();
            this.radPanelTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnShoppingCart);
            this.radPanel1.Controls.Add(this.btnLogOut);
            this.radPanel1.Controls.Add(this.btnOrders);
            this.radPanel1.Controls.Add(this.btnUsers);
            this.radPanel1.Controls.Add(this.btnItems);
            this.radPanel1.Controls.Add(this.btnDashBoard);
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(226, 1084);
            this.radPanel1.TabIndex = 0;
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 984);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(226, 50);
            this.btnShoppingCart.TabIndex = 9;
            this.btnShoppingCart.Text = "ShoppingCart";
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Location = new System.Drawing.Point(0, 1034);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(226, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.Location = new System.Drawing.Point(0, 290);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(226, 50);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.Location = new System.Drawing.Point(0, 240);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(226, 50);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnItems
            // 
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.Location = new System.Drawing.Point(0, 190);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(226, 50);
            this.btnItems.TabIndex = 5;
            this.btnItems.Text = "Items";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 140);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(226, 50);
            this.btnDashBoard.TabIndex = 4;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(226, 140);
            this.radPanel2.TabIndex = 3;
            // 
            // radPanelTop
            // 
            this.radPanelTop.Controls.Add(this.flowLayoutTopMid);
            this.radPanelTop.Controls.Add(this.flowLayoutTopRight);
            this.radPanelTop.Controls.Add(this.flowLayoutTopLeft);
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(226, 0);
            this.radPanelTop.Name = "radPanelTop";
            this.radPanelTop.Size = new System.Drawing.Size(1079, 90);
            this.radPanelTop.TabIndex = 1;
            // 
            // flowLayoutTopMid
            // 
            this.flowLayoutTopMid.Controls.Add(this.btnSearch);
            this.flowLayoutTopMid.Controls.Add(this.radTextBox1);
            this.flowLayoutTopMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTopMid.Location = new System.Drawing.Point(357, 0);
            this.flowLayoutTopMid.Name = "flowLayoutTopMid";
            this.flowLayoutTopMid.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayoutTopMid.Size = new System.Drawing.Size(411, 90);
            this.flowLayoutTopMid.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(33, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(123, 33);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(219, 31);
            this.radTextBox1.TabIndex = 0;
            // 
            // flowLayoutTopRight
            // 
            this.flowLayoutTopRight.Controls.Add(this.btnSignOut);
            this.flowLayoutTopRight.Controls.Add(this.lblUser);
            this.flowLayoutTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutTopRight.Location = new System.Drawing.Point(768, 0);
            this.flowLayoutTopRight.Name = "flowLayoutTopRight";
            this.flowLayoutTopRight.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.flowLayoutTopRight.Size = new System.Drawing.Size(311, 90);
            this.flowLayoutTopRight.TabIndex = 1;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(212, 23);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(76, 28);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblUser.Location = new System.Drawing.Point(165, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 26);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // flowLayoutTopLeft
            // 
            this.flowLayoutTopLeft.Controls.Add(this.btnGoBack);
            this.flowLayoutTopLeft.Controls.Add(this.lblTitle);
            this.flowLayoutTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutTopLeft.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTopLeft.Name = "flowLayoutTopLeft";
            this.flowLayoutTopLeft.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutTopLeft.Size = new System.Drawing.Size(357, 90);
            this.flowLayoutTopLeft.TabIndex = 0;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(35, 35);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(15);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(104, 30);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTitle.Location = new System.Drawing.Point(157, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // radPanelTop2
            // 
            this.radPanelTop2.Controls.Add(this.flowLayoutTop2Mid);
            this.radPanelTop2.Controls.Add(this.flowLayoutTop2Right);
            this.radPanelTop2.Controls.Add(this.flowLayoutTop2Left);
            this.radPanelTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop2.Location = new System.Drawing.Point(226, 90);
            this.radPanelTop2.Name = "radPanelTop2";
            this.radPanelTop2.Size = new System.Drawing.Size(1079, 50);
            this.radPanelTop2.TabIndex = 2;
            // 
            // flowLayoutTop2Mid
            // 
            this.flowLayoutTop2Mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTop2Mid.Location = new System.Drawing.Point(357, 0);
            this.flowLayoutTop2Mid.Name = "flowLayoutTop2Mid";
            this.flowLayoutTop2Mid.Size = new System.Drawing.Size(411, 50);
            this.flowLayoutTop2Mid.TabIndex = 2;
            // 
            // flowLayoutTop2Right
            // 
            this.flowLayoutTop2Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutTop2Right.Location = new System.Drawing.Point(768, 0);
            this.flowLayoutTop2Right.Name = "flowLayoutTop2Right";
            this.flowLayoutTop2Right.Size = new System.Drawing.Size(311, 50);
            this.flowLayoutTop2Right.TabIndex = 1;
            // 
            // flowLayoutTop2Left
            // 
            this.flowLayoutTop2Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutTop2Left.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTop2Left.Name = "flowLayoutTop2Left";
            this.flowLayoutTop2Left.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutTop2Left.Size = new System.Drawing.Size(357, 50);
            this.flowLayoutTop2Left.TabIndex = 0;
            // 
            // radPanelMain
            // 
            this.radPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanelMain.Location = new System.Drawing.Point(226, 140);
            this.radPanelMain.Name = "radPanelMain";
            this.radPanelMain.Size = new System.Drawing.Size(1079, 944);
            this.radPanelMain.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 1084);
            this.Controls.Add(this.radPanelMain);
            this.Controls.Add(this.radPanelTop2);
            this.Controls.Add(this.radPanelTop);
            this.Controls.Add(this.radPanel1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.radPanelTop.ResumeLayout(false);
            this.flowLayoutTopMid.ResumeLayout(false);
            this.flowLayoutTopMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            this.flowLayoutTopRight.ResumeLayout(false);
            this.flowLayoutTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).EndInit();
            this.flowLayoutTopLeft.ResumeLayout(false);
            this.flowLayoutTopLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop2)).EndInit();
            this.radPanelTop2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnShoppingCart;
        private Telerik.WinControls.UI.RadButton btnLogOut;
        private Telerik.WinControls.UI.RadButton btnOrders;
        private Telerik.WinControls.UI.RadButton btnUsers;
        private Telerik.WinControls.UI.RadButton btnItems;
        private Telerik.WinControls.UI.RadButton btnDashBoard;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadButton btnGoBack;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTopMid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTopRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTopLeft;
        private Telerik.WinControls.UI.RadPanel radPanelTop2;
        private Telerik.WinControls.UI.RadPanel radPanelMain;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTop2Right;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTop2Left;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTop2Mid;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton btnSignOut;
        private Telerik.WinControls.UI.RadLabel lblUser;
    }
}

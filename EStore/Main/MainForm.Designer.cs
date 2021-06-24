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
            this.btnLogOut = new Telerik.WinControls.UI.RadButton();
            this.btnOrders = new Telerik.WinControls.UI.RadButton();
            this.btnUsers = new Telerik.WinControls.UI.RadButton();
            this.btnItems = new Telerik.WinControls.UI.RadButton();
            this.btnDashBoard = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutTopMid = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutTopRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUser = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutTopLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGoBack = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.radPanelTop.SuspendLayout();
            this.flowLayoutTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).BeginInit();
            this.flowLayoutTopLeft.SuspendLayout();
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
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.radPanel1.Controls.Add(this.btnLogOut);
            this.radPanel1.Controls.Add(this.btnOrders);
            this.radPanel1.Controls.Add(this.btnUsers);
            this.radPanel1.Controls.Add(this.btnItems);
            this.radPanel1.Controls.Add(this.btnDashBoard);
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(226, 1067);
            this.radPanel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 1017);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(226, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogOut.GetChildAt(0))).Text = "Log Out";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnLogOut.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnLogOut.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnLogOut.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(0, 290);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(226, 50);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOrders.GetChildAt(0))).Text = "Orders";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(3))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 240);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(226, 50);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUsers.GetChildAt(0))).Text = "Users";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnUsers.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnUsers.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnUsers.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            // 
            // btnItems
            // 
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(0, 190);
            this.btnItems.Name = "btnItems";
            // 
            // 
            // 
            this.btnItems.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(223)))), ((int)(((byte)(21)))));
            this.btnItems.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnItems.Size = new System.Drawing.Size(226, 50);
            this.btnItems.TabIndex = 5;
            this.btnItems.Text = "Items";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnItems.GetChildAt(0))).Text = "Items";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnItems.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnItems.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnItems.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 140);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(226, 50);
            this.btnDashBoard.TabIndex = 4;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDashBoard.GetChildAt(0))).Text = "DashBoard";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(0))).ClipDrawing = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 20F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.pictureBox1);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(226, 140);
            this.radPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EStore.Properties.Resources.cart;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.flowLayoutTopMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTopMid.Location = new System.Drawing.Point(357, 0);
            this.flowLayoutTopMid.Name = "flowLayoutTopMid";
            this.flowLayoutTopMid.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayoutTopMid.Size = new System.Drawing.Size(411, 90);
            this.flowLayoutTopMid.TabIndex = 2;
            // 
            // flowLayoutTopRight
            // 
            this.flowLayoutTopRight.Controls.Add(this.lblUser);
            this.flowLayoutTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutTopRight.Location = new System.Drawing.Point(768, 0);
            this.flowLayoutTopRight.Name = "flowLayoutTopRight";
            this.flowLayoutTopRight.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.flowLayoutTopRight.Size = new System.Drawing.Size(311, 90);
            this.flowLayoutTopRight.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblUser.Location = new System.Drawing.Point(247, 23);
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
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.BackgroundImage = global::EStore.Properties.Resources.go_back_arrow;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(23, 23);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(65, 41);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTitle.Location = new System.Drawing.Point(94, 23);
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
            this.radPanelMain.ForeColor = System.Drawing.Color.White;
            this.radPanelMain.Location = new System.Drawing.Point(226, 140);
            this.radPanelMain.Name = "radPanelMain";
            this.radPanelMain.Size = new System.Drawing.Size(1079, 927);
            this.radPanelMain.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 1067);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.radPanelTop.ResumeLayout(false);
            this.flowLayoutTopRight.ResumeLayout(false);
            this.flowLayoutTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).EndInit();
            this.flowLayoutTopLeft.ResumeLayout(false);
            this.flowLayoutTopLeft.PerformLayout();
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
        private Telerik.WinControls.UI.RadButton btnLogOut;
        private Telerik.WinControls.UI.RadButton btnOrders;
        private Telerik.WinControls.UI.RadButton btnUsers;
        private Telerik.WinControls.UI.RadButton btnItems;
        private Telerik.WinControls.UI.RadButton btnDashBoard;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanelTop;
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
        private Telerik.WinControls.UI.RadLabel lblUser;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

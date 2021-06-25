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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.flowLayoutTopLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.radPanelMain = new Telerik.WinControls.UI.RadPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUser = new Telerik.WinControls.UI.RadButton();
            this.btnGoBack = new System.Windows.Forms.PictureBox();
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
            this.flowLayoutTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.radPanel1.Controls.Add(this.panel1);
            this.radPanel1.Controls.Add(this.btnLogOut);
            this.radPanel1.Controls.Add(this.radPanel2);
            resources.ApplyResources(this.radPanel1, "radPanel1");
            this.radPanel1.Name = "radPanel1";
            // 
            // btnLogOut
            // 
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogOut.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnLogOut.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnLogOut.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnLogOut.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            // 
            // btnOrders
            // 
            resources.ApplyResources(this.btnOrders, "btnOrders");
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOrders.GetChildAt(0))).Text = resources.GetString("resource.Text1");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.btnOrders.GetChildAt(0).GetChildAt(3))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            // 
            // btnUsers
            // 
            resources.ApplyResources(this.btnUsers, "btnUsers");
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUsers.GetChildAt(0))).Text = resources.GetString("resource.Text2");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnUsers.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnUsers.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnUsers.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            // 
            // btnItems
            // 
            resources.ApplyResources(this.btnItems, "btnItems");
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Name = "btnItems";
            // 
            // 
            // 
            this.btnItems.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(223)))), ((int)(((byte)(21)))));
            this.btnItems.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnItems.GetChildAt(0))).Text = resources.GetString("resource.Text3");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnItems.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnItems.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnItems.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            // 
            // btnDashBoard
            // 
            resources.ApplyResources(this.btnDashBoard, "btnDashBoard");
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDashBoard.GetChildAt(0))).Text = resources.GetString("resource.Text4");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(0))).ClipDrawing = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 20F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnDashBoard.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.radPanel2, "radPanel2");
            this.radPanel2.Name = "radPanel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::EStore.Properties.Resources.cart;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // radPanelTop
            // 
            this.radPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.radPanelTop.Controls.Add(this.flowLayoutTopMid);
            this.radPanelTop.Controls.Add(this.flowLayoutTopRight);
            this.radPanelTop.Controls.Add(this.flowLayoutTopLeft);
            resources.ApplyResources(this.radPanelTop, "radPanelTop");
            this.radPanelTop.Name = "radPanelTop";
            // 
            // flowLayoutTopMid
            // 
            resources.ApplyResources(this.flowLayoutTopMid, "flowLayoutTopMid");
            this.flowLayoutTopMid.Name = "flowLayoutTopMid";
            // 
            // flowLayoutTopRight
            // 
            resources.ApplyResources(this.flowLayoutTopRight, "flowLayoutTopRight");
            this.flowLayoutTopRight.Name = "flowLayoutTopRight";
            // 
            // flowLayoutTopLeft
            // 
            this.flowLayoutTopLeft.Controls.Add(this.btnGoBack);
            this.flowLayoutTopLeft.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.flowLayoutTopLeft, "flowLayoutTopLeft");
            this.flowLayoutTopLeft.Name = "flowLayoutTopLeft";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // radPanelMain
            // 
            this.radPanelMain.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.radPanelMain, "radPanelMain");
            this.radPanelMain.ForeColor = System.Drawing.Color.White;
            this.radPanelMain.Name = "radPanelMain";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.btnItems);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnOrders);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Name = "lblUser";
            // 
            // 
            // 
            this.lblUser.RootElement.CustomFontStyle = System.Drawing.FontStyle.Bold;
            ((Telerik.WinControls.UI.RadButtonElement)(this.lblUser.GetChildAt(0))).Text = resources.GetString("resource.Text5");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.lblUser.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.lblUser.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.lblUser.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.lblUser.GetChildAt(0).GetChildAt(1).GetChildAt(1))).CustomFontSize = 23F;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.lblUser.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment1")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.lblUser.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.lblUser.GetChildAt(0).GetChildAt(3))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            // 
            // btnGoBack
            // 
            resources.ApplyResources(this.btnGoBack, "btnGoBack");
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.TabStop = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanelMain);
            this.Controls.Add(this.radPanelTop);
            this.Controls.Add(this.radPanel1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
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
            this.flowLayoutTopLeft.ResumeLayout(false);
            this.flowLayoutTopLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
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
        private Telerik.WinControls.UI.RadPanel radPanelMain;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.RadButton lblUser;
        private System.Windows.Forms.PictureBox btnGoBack;
    }
}

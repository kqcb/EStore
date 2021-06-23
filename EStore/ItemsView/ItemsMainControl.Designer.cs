
namespace EStore_Temp.ItemsView
{
    partial class ItemsMainControl
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
            this.components = new System.ComponentModel.Container();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.uspItemReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutSelectedList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnMakeOrder = new Telerik.WinControls.UI.RadButton();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspItemReadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMakeOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(444, 8);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Create New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 516);
            this.radPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(835, 47);
            this.radPanel2.TabIndex = 1;
            // 
            // uspItemReadBindingSource
            // 
            this.uspItemReadBindingSource.DataMember = "usp_Item_Read";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.flowLayoutSelectedList);
            this.radPanel3.Controls.Add(this.flowLayoutPanel3);
            this.radPanel3.Controls.Add(this.flowLayoutPanel5);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel3.Location = new System.Drawing.Point(570, 0);
            this.radPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(265, 516);
            this.radPanel3.TabIndex = 2;
            // 
            // flowLayoutSelectedList
            // 
            this.flowLayoutSelectedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutSelectedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutSelectedList.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutSelectedList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutSelectedList.Name = "flowLayoutSelectedList";
            this.flowLayoutSelectedList.Size = new System.Drawing.Size(265, 407);
            this.flowLayoutSelectedList.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.radLabel1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(265, 63);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.radLabel1.Location = new System.Drawing.Point(47, 15);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(47, 2, 2, 2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(123, 28);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Shopping Cart";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.btnCancel);
            this.flowLayoutPanel5.Controls.Add(this.btnMakeOrder);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 470);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(265, 46);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(9, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 41);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(120, 2);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(110, 41);
            this.btnMakeOrder.TabIndex = 1;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.panelMain);
            this.radPanel4.Controls.Add(this.panelMainTop);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel4.Location = new System.Drawing.Point(0, 0);
            this.radPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(570, 516);
            this.radPanel4.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 45);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(27, 26, 27, 26);
            this.panelMain.Size = new System.Drawing.Size(570, 471);
            this.panelMain.TabIndex = 1;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.btnNew);
            this.panelMainTop.Controls.Add(this.btnToExcel);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelMainTop.Size = new System.Drawing.Size(570, 45);
            this.panelMainTop.TabIndex = 0;
            // 
            // btnToExcel
            // 
            this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnToExcel.ForeColor = System.Drawing.Color.White;
            this.btnToExcel.Location = new System.Drawing.Point(329, 9);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(110, 24);
            this.btnToExcel.TabIndex = 2;
            this.btnToExcel.Text = "To Excel";
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnToExcel.GetChildAt(0))).Text = "To Excel";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(3))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            // 
            // ItemsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ItemsMainControl";
            this.Size = new System.Drawing.Size(835, 563);
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspItemReadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMakeOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            this.panelMainTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.BindingSource uspItemReadBindingSource;
        private System.Windows.Forms.BindingSource eStoreDataSetBindingSource;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private System.Windows.Forms.FlowLayoutPanel panelMainTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnMakeOrder;
        private Telerik.WinControls.UI.RadButton btnNew;
        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSelectedList;
        private Telerik.WinControls.UI.RadButton btnToExcel;
    }
}

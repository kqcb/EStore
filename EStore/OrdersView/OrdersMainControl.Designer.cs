
namespace EStore_Temp.OrdersView
{
    partial class OrdersMainControl
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.uspOrderReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanelNames = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainTop = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspOrderReadBindingSource)).BeginInit();
            this.flowLayoutPanelNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.panelMainTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.panelMainTop);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(800, 53);
            this.radPanel1.TabIndex = 0;
            // 
            // btnToExcel
            // 
            this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnToExcel.ForeColor = System.Drawing.Color.White;
            this.btnToExcel.Location = new System.Drawing.Point(673, 9);
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
            // radPanel2
            // 
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 434);
            this.radPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(800, 44);
            this.radPanel2.TabIndex = 1;
            // 
            // uspOrderReadBindingSource
            // 
            this.uspOrderReadBindingSource.DataMember = "usp_Order_Read";
            // 
            // flowLayoutPanelNames
            // 
            this.flowLayoutPanelNames.AutoScroll = true;
            this.flowLayoutPanelNames.Controls.Add(this.radLabel1);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel6);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel5);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel4);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel3);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel2);
            this.flowLayoutPanelNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelNames.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanelNames.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelNames.Name = "flowLayoutPanelNames";
            this.flowLayoutPanelNames.Size = new System.Drawing.Size(800, 26);
            this.flowLayoutPanelNames.TabIndex = 2;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(2, 2);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 19);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Id";
            // 
            // radLabel6
            // 
            this.radLabel6.AutoSize = false;
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.radLabel6.Location = new System.Drawing.Point(72, 2);
            this.radLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(95, 19);
            this.radLabel6.TabIndex = 5;
            this.radLabel6.Text = "Total";
            // 
            // radLabel5
            // 
            this.radLabel5.AutoSize = false;
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.radLabel5.Location = new System.Drawing.Point(171, 2);
            this.radLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(133, 19);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "Delivery Date";
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(308, 2);
            this.radLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(126, 19);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Date";
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(438, 2);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(115, 19);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Client";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(557, 2);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(120, 19);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Status";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 355);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.btnToExcel);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelMainTop.Size = new System.Drawing.Size(800, 45);
            this.panelMainTop.TabIndex = 1;
            // 
            // OrdersMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelNames);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersMainControl";
            this.Size = new System.Drawing.Size(800, 478);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspOrderReadBindingSource)).EndInit();
            this.flowLayoutPanelNames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.panelMainTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.BindingSource uspOrderReadBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNames;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton btnToExcel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelMainTop;
    }
}

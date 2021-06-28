
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersMainControl));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.panelMainTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutPanelNames = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uspOrderReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.flowLayoutPanelNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspOrderReadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            resources.ApplyResources(this.radPanel1, "radPanel1");
            this.radPanel1.Controls.Add(this.panelMainTop);
            this.radPanel1.Name = "radPanel1";
            // 
            // panelMainTop
            // 
            resources.ApplyResources(this.panelMainTop, "panelMainTop");
            this.panelMainTop.Controls.Add(this.btnToExcel);
            this.panelMainTop.Name = "panelMainTop";
            // 
            // btnToExcel
            // 
            resources.ApplyResources(this.btnToExcel, "btnToExcel");
            this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnToExcel.ForeColor = System.Drawing.Color.White;
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnToExcel.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(3))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            // 
            // radPanel2
            // 
            resources.ApplyResources(this.radPanel2, "radPanel2");
            this.radPanel2.Name = "radPanel2";
            // 
            // flowLayoutPanelNames
            // 
            resources.ApplyResources(this.flowLayoutPanelNames, "flowLayoutPanelNames");
            this.flowLayoutPanelNames.Controls.Add(this.radLabel1);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel6);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel5);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel4);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel3);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel2);
            this.flowLayoutPanelNames.Name = "flowLayoutPanelNames";
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            // 
            // radLabel6
            // 
            resources.ApplyResources(this.radLabel6, "radLabel6");
            this.radLabel6.Name = "radLabel6";
            // 
            // radLabel5
            // 
            resources.ApplyResources(this.radLabel5, "radLabel5");
            this.radLabel5.Name = "radLabel5";
            // 
            // radLabel4
            // 
            resources.ApplyResources(this.radLabel4, "radLabel4");
            this.radLabel4.Name = "radLabel4";
            // 
            // radLabel3
            // 
            resources.ApplyResources(this.radLabel3, "radLabel3");
            this.radLabel3.Name = "radLabel3";
            // 
            // radLabel2
            // 
            resources.ApplyResources(this.radLabel2, "radLabel2");
            this.radLabel2.Name = "radLabel2";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // uspOrderReadBindingSource
            // 
            this.uspOrderReadBindingSource.DataMember = "usp_Order_Read";
            // 
            // OrdersMainControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelNames);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "OrdersMainControl";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.panelMainTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.flowLayoutPanelNames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspOrderReadBindingSource)).EndInit();
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

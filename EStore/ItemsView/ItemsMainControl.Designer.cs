
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsMainControl));
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutSelectedList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnMakeOrder = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.uspItemReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.uspItemReadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.flowLayoutSelectedList);
            this.radPanel3.Controls.Add(this.flowLayoutPanel3);
            this.radPanel3.Controls.Add(this.flowLayoutPanel5);
            resources.ApplyResources(this.radPanel3, "radPanel3");
            this.radPanel3.Name = "radPanel3";
            // 
            // flowLayoutSelectedList
            // 
            this.flowLayoutSelectedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.flowLayoutSelectedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.flowLayoutSelectedList, "flowLayoutSelectedList");
            this.flowLayoutSelectedList.Name = "flowLayoutSelectedList";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.radLabel1);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Name = "radLabel1";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.btnCancel);
            this.flowLayoutPanel5.Controls.Add(this.btnMakeOrder);
            this.flowLayoutPanel5.Controls.Add(this.panel1);
            this.flowLayoutPanel5.Controls.Add(this.panel2);
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(11)))), ((int)(((byte)(50)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(223)))), ((int)(((byte)(21)))));
            this.btnCancel.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(11)))), ((int)(((byte)(50)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(129)))), ((int)(((byte)(50)))));
            this.btnMakeOrder.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnMakeOrder, "btnMakeOrder");
            this.btnMakeOrder.Name = "btnMakeOrder";
            // 
            // 
            // 
            this.btnMakeOrder.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(223)))), ((int)(((byte)(21)))));
            this.btnMakeOrder.RootElement.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnMakeOrder.GetChildAt(0))).Text = resources.GetString("resource.Text1");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnMakeOrder.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(129)))), ((int)(((byte)(50)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnMakeOrder.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnMakeOrder.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.panelMain);
            this.radPanel4.Controls.Add(this.panelMainTop);
            resources.ApplyResources(this.radPanel4, "radPanel4");
            this.radPanel4.Name = "radPanel4";
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.btnNew);
            this.panelMainTop.Controls.Add(this.btnToExcel);
            resources.ApplyResources(this.panelMainTop, "panelMainTop");
            this.panelMainTop.Name = "panelMainTop";
            // 
            // btnToExcel
            // 
            this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnToExcel.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnToExcel, "btnToExcel");
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnToExcel.GetChildAt(0))).Text = resources.GetString("resource.Text2");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(3))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            // 
            // uspItemReadBindingSource
            // 
            this.uspItemReadBindingSource.DataMember = "usp_Item_Read";
            // 
            // ItemsMainControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Name = "ItemsMainControl";
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.uspItemReadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource uspItemReadBindingSource;
        private System.Windows.Forms.BindingSource eStoreDataSetBindingSource;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private System.Windows.Forms.FlowLayoutPanel panelMainTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnNew;
        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSelectedList;
        private Telerik.WinControls.UI.RadButton btnToExcel;
        private Telerik.WinControls.UI.RadButton btnMakeOrder;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

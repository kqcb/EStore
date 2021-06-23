
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
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(667, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(165, 36);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Create New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 794);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1252, 72);
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
            this.radPanel3.Location = new System.Drawing.Point(855, 0);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(397, 794);
            this.radPanel3.TabIndex = 2;
            // 
            // flowLayoutSelectedList
            // 
            this.flowLayoutSelectedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutSelectedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutSelectedList.Location = new System.Drawing.Point(0, 96);
            this.flowLayoutSelectedList.Name = "flowLayoutSelectedList";
            this.flowLayoutSelectedList.Size = new System.Drawing.Size(397, 628);
            this.flowLayoutSelectedList.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.radLabel1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(397, 96);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.radLabel1.Location = new System.Drawing.Point(70, 23);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(70, 3, 3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(188, 41);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Shopping Cart";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.btnCancel);
            this.flowLayoutPanel5.Controls.Add(this.btnMakeOrder);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 724);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(397, 70);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 63);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(180, 3);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(165, 63);
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
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(855, 794);
            this.radPanel4.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 69);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(40);
            this.panelMain.Size = new System.Drawing.Size(855, 725);
            this.panelMain.TabIndex = 1;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.btnNew);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelMainTop.Size = new System.Drawing.Size(855, 69);
            this.panelMainTop.TabIndex = 0;
            // 
            // ItemsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Name = "ItemsMainControl";
            this.Size = new System.Drawing.Size(1252, 866);
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
    }
}


namespace EStore_Temp.OrdersView
{
    partial class OrderDetailsMainControl
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
            this.radPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.flowLayoutPanelList = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelTop
            // 
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Name = "radPanelTop";
            this.radPanelTop.Size = new System.Drawing.Size(1100, 72);
            this.radPanelTop.TabIndex = 0;
            // 
            // flowLayoutPanelList
            // 
            this.flowLayoutPanelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelList.Location = new System.Drawing.Point(0, 72);
            this.flowLayoutPanelList.Name = "flowLayoutPanelList";
            this.flowLayoutPanelList.Size = new System.Drawing.Size(1100, 556);
            this.flowLayoutPanelList.TabIndex = 1;
            // 
            // OrderDetailsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelList);
            this.Controls.Add(this.radPanelTop);
            this.Name = "OrderDetailsMainControl";
            this.Size = new System.Drawing.Size(1100, 628);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelList;
    }
}

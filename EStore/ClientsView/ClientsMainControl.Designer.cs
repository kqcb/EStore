
namespace EStore.ClientsView
{
    partial class ClientsMainControl
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
            this.radPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.radPanelBottom = new Telerik.WinControls.UI.RadPanel();
            this.uspUserReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.radPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanelTop
            // 
            this.radPanelTop.BackColor = System.Drawing.Color.DarkGray;
            this.radPanelTop.Controls.Add(this.flowLayoutPanel2);
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Name = "radPanelTop";
            // 
            // 
            // 
            this.radPanelTop.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 300, 150);
            this.radPanelTop.Size = new System.Drawing.Size(1214, 55);
            this.radPanelTop.TabIndex = 0;
            // 
            // radPanelBottom
            // 
            this.radPanelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanelBottom.Location = new System.Drawing.Point(0, 734);
            this.radPanelBottom.Name = "radPanelBottom";
            // 
            // 
            // 
            this.radPanelBottom.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 477, 300, 150);
            this.radPanelBottom.Size = new System.Drawing.Size(1214, 71);
            this.radPanelBottom.TabIndex = 1;
            // 
            // uspUserReadBindingSource
            // 
            this.uspUserReadBindingSource.DataMember = "usp_User_Read";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1214, 679);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(122, 10);
            this.btnToExcel.Margin = new System.Windows.Forms.Padding(10);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(112, 35);
            this.btnToExcel.TabIndex = 0;
            this.btnToExcel.Text = "To Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnToExcel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(970, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(244, 55);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // ClientsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.radPanelBottom);
            this.Controls.Add(this.radPanelTop);
            this.Name = "ClientsMainControl";
            this.Size = new System.Drawing.Size(1214, 805);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.radPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadPanel radPanelBottom;
        private System.Windows.Forms.BindingSource uspUserReadBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

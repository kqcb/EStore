
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.radPanelBottom = new Telerik.WinControls.UI.RadPanel();
            this.uspUserReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.radPanelTop.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelTop
            // 
            this.radPanelTop.BackColor = System.Drawing.Color.White;
            this.radPanelTop.Controls.Add(this.flowLayoutPanel2);
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.radPanelTop.Name = "radPanelTop";
            // 
            // 
            // 
            this.radPanelTop.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.radPanelTop.Size = new System.Drawing.Size(809, 36);
            this.radPanelTop.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnToExcel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(646, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 36);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnToExcel
            // 
            this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnToExcel.ForeColor = System.Drawing.Color.White;
            this.btnToExcel.Location = new System.Drawing.Point(50, 3);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(110, 24);
            this.btnToExcel.TabIndex = 1;
            this.btnToExcel.Text = "To Excel";
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnToExcel.GetChildAt(0))).Text = "To Excel";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(3))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            // 
            // radPanelBottom
            // 
            this.radPanelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanelBottom.Location = new System.Drawing.Point(0, 477);
            this.radPanelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.radPanelBottom.Name = "radPanelBottom";
            // 
            // 
            // 
            this.radPanelBottom.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 477, 200, 100);
            this.radPanelBottom.Size = new System.Drawing.Size(809, 46);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(809, 441);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ClientsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.radPanelBottom);
            this.Controls.Add(this.radPanelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientsMainControl";
            this.Size = new System.Drawing.Size(809, 523);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.radPanelTop.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadPanel radPanelBottom;
        private System.Windows.Forms.BindingSource uspUserReadBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Telerik.WinControls.UI.RadButton btnToExcel;
    }
}

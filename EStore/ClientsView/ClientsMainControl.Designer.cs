
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
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.radPanelBottom = new Telerik.WinControls.UI.RadPanel();
            this.uspUserReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelNames = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanelNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToExcel
            // 
            this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.btnToExcel.ForeColor = System.Drawing.Color.White;
            this.btnToExcel.Location = new System.Drawing.Point(673, 9);
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
            this.radPanelBottom.Location = new System.Drawing.Point(0, 432);
            this.radPanelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.radPanelBottom.Name = "radPanelBottom";
            // 
            // 
            // 
            this.radPanelBottom.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 432, 200, 100);
            this.radPanelBottom.Size = new System.Drawing.Size(800, 46);
            this.radPanelBottom.TabIndex = 1;
            // 
            // uspUserReadBindingSource
            // 
            this.uspUserReadBindingSource.DataMember = "usp_User_Read";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnToExcel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 45);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanelNames
            // 
            this.flowLayoutPanelNames.AutoScroll = true;
            this.flowLayoutPanelNames.Controls.Add(this.radLabel1);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel6);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel5);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel4);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel3);
            this.flowLayoutPanelNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelNames.Location = new System.Drawing.Point(0, 45);
            this.flowLayoutPanelNames.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelNames.Name = "flowLayoutPanelNames";
            this.flowLayoutPanelNames.Size = new System.Drawing.Size(800, 26);
            this.flowLayoutPanelNames.TabIndex = 3;
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
            this.radLabel6.Text = "Name";
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
            this.radLabel5.Text = "Last name";
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
            this.radLabel4.Text = "Email";
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
            this.radLabel3.Text = "IsActive";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 361);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ClientsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelNames);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.radPanelBottom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientsMainControl";
            this.Size = new System.Drawing.Size(800, 478);
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanelNames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanelBottom;
        private System.Windows.Forms.BindingSource uspUserReadBindingSource;
        private Telerik.WinControls.UI.RadButton btnToExcel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNames;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

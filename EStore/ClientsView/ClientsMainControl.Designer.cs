
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
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanelTop
            // 
            this.radPanelTop.BackColor = System.Drawing.Color.DarkGray;
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radPanelTop.Name = "radPanelTop";
            // 
            // 
            // 
            this.radPanelTop.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.radPanelTop.Size = new System.Drawing.Size(809, 54);
            this.radPanelTop.TabIndex = 0;
            // 
            // radPanelBottom
            // 
            this.radPanelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanelBottom.Location = new System.Drawing.Point(0, 477);
            this.radPanelBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radPanelBottom.Name = "radPanelBottom";
            // 
            // 
            // 
            this.radPanelBottom.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.radPanelBottom.Size = new System.Drawing.Size(809, 46);
            this.radPanelBottom.TabIndex = 1;
            // 
            // uspUserReadBindingSource
            // 
            this.uspUserReadBindingSource.DataMember = "usp_User_Read";
            // 
            // eStoreDataSet
            // 
            // 
            // usp_User_ReadTableAdapter
            // 
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnToExcel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(809, 423);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(13, 13);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnToExcel.TabIndex = 0;
            this.btnToExcel.Text = "To Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // ClientsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.radPanelBottom);
            this.Controls.Add(this.radPanelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientsMainControl";
            this.Size = new System.Drawing.Size(809, 523);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadPanel radPanelBottom;
        private System.Windows.Forms.BindingSource uspUserReadBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnToExcel;
    }
}

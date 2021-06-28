
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsMainControl));
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
            resources.ApplyResources(this.btnToExcel, "btnToExcel");
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnToExcel.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.btnToExcel.GetChildAt(0).GetChildAt(3))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            // 
            // radPanelBottom
            // 
            this.radPanelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.radPanelBottom, "radPanelBottom");
            this.radPanelBottom.Name = "radPanelBottom";
            // 
            // 
            // 
            this.radPanelBottom.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 432, 200, 100);
            // 
            // uspUserReadBindingSource
            // 
            this.uspUserReadBindingSource.DataMember = "usp_User_Read";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnToExcel);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // flowLayoutPanelNames
            // 
            resources.ApplyResources(this.flowLayoutPanelNames, "flowLayoutPanelNames");
            this.flowLayoutPanelNames.Controls.Add(this.radLabel1);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel6);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel5);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel4);
            this.flowLayoutPanelNames.Controls.Add(this.radLabel3);
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
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // ClientsMainControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelNames);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.radPanelBottom);
            this.Name = "ClientsMainControl";
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

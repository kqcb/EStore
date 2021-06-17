
namespace EStore_Temp.ClientsView
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.radPanelBottom = new Telerik.WinControls.UI.RadPanel();
            this.radPanelMain = new Telerik.WinControls.UI.RadPanel();
            this.radGridUsers = new Telerik.WinControls.UI.RadGridView();
            this.eStoreDataSet = new EStore_Temp.EStoreDataSet();
            this.uspUserReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_User_ReadTableAdapter = new EStore_Temp.EStoreDataSetTableAdapters.usp_User_ReadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).BeginInit();
            this.radPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridUsers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelTop
            // 
            this.radPanelTop.BackColor = System.Drawing.Color.DarkGray;
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Name = "radPanelTop";
            this.radPanelTop.Size = new System.Drawing.Size(1214, 83);
            this.radPanelTop.TabIndex = 0;
            // 
            // radPanelBottom
            // 
            this.radPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanelBottom.Location = new System.Drawing.Point(0, 734);
            this.radPanelBottom.Name = "radPanelBottom";
            this.radPanelBottom.Size = new System.Drawing.Size(1214, 71);
            this.radPanelBottom.TabIndex = 1;
            // 
            // radPanelMain
            // 
            this.radPanelMain.Controls.Add(this.radGridUsers);
            this.radPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanelMain.Location = new System.Drawing.Point(0, 83);
            this.radPanelMain.Name = "radPanelMain";
            this.radPanelMain.Size = new System.Drawing.Size(1214, 651);
            this.radPanelMain.TabIndex = 2;
            // 
            // radGridUsers
            // 
            this.radGridUsers.AllowDrop = true;
            this.radGridUsers.AllowShowFocusCues = true;
            this.radGridUsers.AutoSizeRows = true;
            this.radGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridUsers.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridUsers.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridUsers.MasterTemplate.AllowRowReorder = true;
            this.radGridUsers.MasterTemplate.AllowSearchRow = true;
            this.radGridUsers.MasterTemplate.AutoExpandGroups = true;
            this.radGridUsers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "Id";
            gridViewDecimalColumn1.HeaderText = "Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 149;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 149;
            gridViewTextBoxColumn2.FieldName = "LastName";
            gridViewTextBoxColumn2.HeaderText = "LastName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "LastName";
            gridViewTextBoxColumn2.Width = 149;
            gridViewTextBoxColumn3.FieldName = "Email";
            gridViewTextBoxColumn3.HeaderText = "Email";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Email";
            gridViewTextBoxColumn3.Width = 149;
            gridViewTextBoxColumn4.FieldName = "Password";
            gridViewTextBoxColumn4.HeaderText = "Password";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Password";
            gridViewTextBoxColumn4.Width = 149;
            gridViewCheckBoxColumn1.FieldName = "IsActive";
            gridViewCheckBoxColumn1.HeaderText = "IsActive";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.Width = 149;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "CityId";
            gridViewDecimalColumn2.HeaderText = "CityId";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "CityId";
            gridViewDecimalColumn2.Width = 149;
            gridViewTextBoxColumn5.FieldName = "CityName";
            gridViewTextBoxColumn5.HeaderText = "CityName";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "CityName";
            gridViewTextBoxColumn5.Width = 149;
            this.radGridUsers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn5});
            this.radGridUsers.MasterTemplate.DataSource = this.uspUserReadBindingSource;
            this.radGridUsers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridUsers.Name = "radGridUsers";
            this.radGridUsers.Size = new System.Drawing.Size(1214, 651);
            this.radGridUsers.TabIndex = 1;
            // 
            // eStoreDataSet
            // 
            this.eStoreDataSet.DataSetName = "EStoreDataSet";
            this.eStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspUserReadBindingSource
            // 
            this.uspUserReadBindingSource.DataMember = "usp_User_Read";
            this.uspUserReadBindingSource.DataSource = this.eStoreDataSet;
            // 
            // usp_User_ReadTableAdapter
            // 
            this.usp_User_ReadTableAdapter.ClearBeforeFill = true;
            // 
            // ClientsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanelMain);
            this.Controls.Add(this.radPanelBottom);
            this.Controls.Add(this.radPanelTop);
            this.Name = "ClientsMainControl";
            this.Size = new System.Drawing.Size(1214, 805);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).EndInit();
            this.radPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridUsers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspUserReadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadPanel radPanelBottom;
        private Telerik.WinControls.UI.RadPanel radPanelMain;
        private Telerik.WinControls.UI.RadGridView radGridUsers;
        private System.Windows.Forms.BindingSource uspUserReadBindingSource;
        private EStoreDataSet eStoreDataSet;
        private EStoreDataSetTableAdapters.usp_User_ReadTableAdapter usp_User_ReadTableAdapter;
    }
}

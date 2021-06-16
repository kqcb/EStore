
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.eStoreDataSet = new EStore_Temp.EStoreDataSet();
            this.eStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eStoreDataSet1 = new EStore_Temp.EStoreDataSet1();
            this.uspItemReadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_Item_ReadTableAdapter = new EStore_Temp.EStoreDataSet1TableAdapters.usp_Item_ReadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspItemReadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1252, 79);
            this.radPanel1.TabIndex = 0;
            // 
            // radPanel2
            // 
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel2.Location = new System.Drawing.Point(0, 794);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1252, 72);
            this.radPanel2.TabIndex = 1;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.radGridView1);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel3.Location = new System.Drawing.Point(0, 79);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(1252, 715);
            this.radPanel3.TabIndex = 2;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "ItemId";
            gridViewDecimalColumn1.HeaderText = "ItemId";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ItemId";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 244;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 244;
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.Width = 244;
            gridViewDecimalColumn2.FieldName = "UnitPrice";
            gridViewDecimalColumn2.HeaderText = "UnitPrice";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "UnitPrice";
            gridViewDecimalColumn2.Width = 244;
            gridViewCheckBoxColumn1.FieldName = "IsActive";
            gridViewCheckBoxColumn1.HeaderText = "IsActive";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.Width = 246;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.uspItemReadBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1252, 715);
            this.radGridView1.TabIndex = 0;
            // 
            // eStoreDataSet
            // 
            this.eStoreDataSet.DataSetName = "EStoreDataSet";
            this.eStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eStoreDataSetBindingSource
            // 
            this.eStoreDataSetBindingSource.DataSource = this.eStoreDataSet;
            this.eStoreDataSetBindingSource.Position = 0;
            // 
            // eStoreDataSet1
            // 
            this.eStoreDataSet1.DataSetName = "EStoreDataSet1";
            this.eStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspItemReadBindingSource
            // 
            this.uspItemReadBindingSource.DataMember = "usp_Item_Read";
            this.uspItemReadBindingSource.DataSource = this.eStoreDataSet1;
            // 
            // usp_Item_ReadTableAdapter
            // 
            this.usp_Item_ReadTableAdapter.ClearBeforeFill = true;
            // 
            // ItemsMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "ItemsMainControl";
            this.Size = new System.Drawing.Size(1252, 866);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspItemReadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource uspItemReadBindingSource;
        private EStoreDataSet1 eStoreDataSet1;
        private EStoreDataSet eStoreDataSet;
        private System.Windows.Forms.BindingSource eStoreDataSetBindingSource;
        private EStoreDataSet1TableAdapters.usp_Item_ReadTableAdapter usp_Item_ReadTableAdapter;
    }
}

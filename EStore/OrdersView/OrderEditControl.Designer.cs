
namespace EStore_Temp.OrdersView
{
    partial class OrderEditForm
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
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderId = new Telerik.WinControls.UI.RadLabel();
            this.txtOrderId = new Telerik.WinControls.UI.RadTextBox();
            this.lblUserId = new Telerik.WinControls.UI.RadLabel();
            this.txtUserId = new Telerik.WinControls.UI.RadTextBox();
            this.lblOrderDate = new Telerik.WinControls.UI.RadLabel();
            this.txtOrderDate = new Telerik.WinControls.UI.RadTextBox();
            this.lblAddress = new Telerik.WinControls.UI.RadLabel();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.radioCity = new System.Windows.Forms.RadioButton();
            this.cmbCities = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(131, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).Text = "Cancel";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblOrderId);
            this.flowLayoutPanel1.Controls.Add(this.txtOrderId);
            this.flowLayoutPanel1.Controls.Add(this.lblUserId);
            this.flowLayoutPanel1.Controls.Add(this.txtUserId);
            this.flowLayoutPanel1.Controls.Add(this.lblOrderDate);
            this.flowLayoutPanel1.Controls.Add(this.txtOrderDate);
            this.flowLayoutPanel1.Controls.Add(this.lblAddress);
            this.flowLayoutPanel1.Controls.Add(this.cmbCities);
            this.flowLayoutPanel1.Controls.Add(this.radioCity);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 276);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Location = new System.Drawing.Point(3, 3);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(48, 18);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order Id";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(3, 27);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(206, 24);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(3, 57);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(62, 18);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User Name";
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(3, 81);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(206, 24);
            this.txtUserId.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Location = new System.Drawing.Point(3, 111);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(60, 18);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "Order date";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Location = new System.Drawing.Point(3, 135);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(206, 24);
            this.txtOrderDate.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(3, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(25, 18);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "City";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(245, 316);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 36);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnEdit.GetChildAt(0))).Text = "Edit";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioCity
            // 
            this.radioCity.AutoSize = true;
            this.radioCity.Location = new System.Drawing.Point(3, 215);
            this.radioCity.Name = "radioCity";
            this.radioCity.Size = new System.Drawing.Size(58, 17);
            this.radioCity.TabIndex = 0;
            this.radioCity.TabStop = true;
            this.radioCity.Text = "Is Paid";
            this.radioCity.UseVisualStyleBackColor = true;
            // 
            // cmbCities
            // 
            this.cmbCities.DropDownAnimationEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(3, 189);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(206, 20);
            this.cmbCities.TabIndex = 2;
            this.cmbCities.Text = "Choose City";
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 403);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OrderEditForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel lblOrderId;
        private Telerik.WinControls.UI.RadTextBox txtOrderId;
        private Telerik.WinControls.UI.RadLabel lblUserId;
        private Telerik.WinControls.UI.RadTextBox txtUserId;
        private Telerik.WinControls.UI.RadLabel lblOrderDate;
        private Telerik.WinControls.UI.RadTextBox txtOrderDate;
        private Telerik.WinControls.UI.RadLabel lblAddress;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private System.Windows.Forms.RadioButton radioCity;
        private Telerik.WinControls.UI.RadDropDownList cmbCities;
    }
}

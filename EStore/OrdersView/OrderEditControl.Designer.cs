
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
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.lblIsPaid = new Telerik.WinControls.UI.RadLabel();
            this.txtIsPaid = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIsPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 326);
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
            this.flowLayoutPanel1.Controls.Add(this.txtAddress);
            this.flowLayoutPanel1.Controls.Add(this.lblIsPaid);
            this.flowLayoutPanel1.Controls.Add(this.txtIsPaid);
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
            this.lblUserId.Size = new System.Drawing.Size(41, 18);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User Id";
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
            this.lblAddress.Size = new System.Drawing.Size(46, 18);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(3, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(206, 24);
            this.txtAddress.TabIndex = 2;
            // 
            // lblIsPaid
            // 
            this.lblIsPaid.Location = new System.Drawing.Point(3, 219);
            this.lblIsPaid.Name = "lblIsPaid";
            this.lblIsPaid.Size = new System.Drawing.Size(39, 18);
            this.lblIsPaid.TabIndex = 0;
            this.lblIsPaid.Text = "Is paid";
            // 
            // txtIsPaid
            // 
            this.txtIsPaid.Enabled = false;
            this.txtIsPaid.Location = new System.Drawing.Point(3, 243);
            this.txtIsPaid.Name = "txtIsPaid";
            this.txtIsPaid.ReadOnly = true;
            this.txtIsPaid.Size = new System.Drawing.Size(206, 24);
            this.txtIsPaid.TabIndex = 10;
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 403);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OrderEditForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIsPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsPaid)).EndInit();
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
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.UI.RadLabel lblIsPaid;
        private Telerik.WinControls.UI.RadTextBox txtIsPaid;
    }
}


namespace EStore.ItemsView
{
    partial class CartView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tileMakeOrder = new MetroFramework.Controls.MetroTile();
            this.metroGridSelectedItems = new MetroFramework.Controls.MetroGrid();
            this.tileGoBack = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSelectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tileMakeOrder
            // 
            this.tileMakeOrder.ActiveControl = null;
            this.tileMakeOrder.Location = new System.Drawing.Point(876, 459);
            this.tileMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.tileMakeOrder.Name = "tileMakeOrder";
            this.tileMakeOrder.Size = new System.Drawing.Size(141, 55);
            this.tileMakeOrder.TabIndex = 1;
            this.tileMakeOrder.Text = "Make Order";
            this.tileMakeOrder.UseSelectable = true;
            this.tileMakeOrder.Click += new System.EventHandler(this.tileMakeOrder_Click);
            // 
            // metroGridSelectedItems
            // 
            this.metroGridSelectedItems.AllowUserToResizeRows = false;
            this.metroGridSelectedItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridSelectedItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridSelectedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSelectedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridSelectedItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridSelectedItems.EnableHeadersVisualStyles = false;
            this.metroGridSelectedItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridSelectedItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridSelectedItems.Location = new System.Drawing.Point(30, 100);
            this.metroGridSelectedItems.Name = "metroGridSelectedItems";
            this.metroGridSelectedItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSelectedItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridSelectedItems.RowHeadersWidth = 51;
            this.metroGridSelectedItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridSelectedItems.RowTemplate.Height = 24;
            this.metroGridSelectedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridSelectedItems.Size = new System.Drawing.Size(987, 323);
            this.metroGridSelectedItems.TabIndex = 2;
            this.metroGridSelectedItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridSelectedItems_CellContentClick);
            // 
            // tileGoBack
            // 
            this.tileGoBack.ActiveControl = null;
            this.tileGoBack.Location = new System.Drawing.Point(726, 459);
            this.tileGoBack.Name = "tileGoBack";
            this.tileGoBack.Size = new System.Drawing.Size(132, 55);
            this.tileGoBack.TabIndex = 3;
            this.tileGoBack.Text = "Go Back";
            this.tileGoBack.UseSelectable = true;
            this.tileGoBack.Click += new System.EventHandler(this.tileGoBack_Click);
            // 
            // CartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tileGoBack);
            this.Controls.Add(this.metroGridSelectedItems);
            this.Controls.Add(this.tileMakeOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartView";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.CartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSelectedItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile tileMakeOrder;
        private MetroFramework.Controls.MetroGrid metroGridSelectedItems;
        private MetroFramework.Controls.MetroTile tileGoBack;
    }
}
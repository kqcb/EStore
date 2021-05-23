
namespace EStore.ItemsView
{
    partial class ItemDetails
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
            this.lblItem = new System.Windows.Forms.Label();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.radioActive = new MetroFramework.Controls.MetroRadioButton();
            this.tileEdit = new MetroFramework.Controls.MetroTile();
            this.radioInactive = new MetroFramework.Controls.MetroRadioButton();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtUnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tileDelete = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(266, 26);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(36, 14);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "label1";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(51, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(26, 209);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel3.TabIndex = 54;
            this.htmlLabel3.Text = "Is active";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(67, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(26, 259);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(106, 27);
            this.htmlLabel2.TabIndex = 49;
            this.htmlLabel2.Text = "Description";
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Location = new System.Drawing.Point(26, 238);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(56, 15);
            this.radioActive.TabIndex = 51;
            this.radioActive.Text = "Active";
            this.radioActive.UseSelectable = true;
            // 
            // tileEdit
            // 
            this.tileEdit.ActiveControl = null;
            this.tileEdit.Location = new System.Drawing.Point(128, 337);
            this.tileEdit.Name = "tileEdit";
            this.tileEdit.Size = new System.Drawing.Size(90, 36);
            this.tileEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.tileEdit.TabIndex = 53;
            this.tileEdit.Text = "Edit";
            this.tileEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEdit.UseSelectable = true;
            this.tileEdit.UseStyleColors = true;
            this.tileEdit.UseTileImage = true;
            this.tileEdit.Click += new System.EventHandler(this.tileEdit_Click);
            // 
            // radioInactive
            // 
            this.radioInactive.AutoSize = true;
            this.radioInactive.Location = new System.Drawing.Point(105, 238);
            this.radioInactive.Name = "radioInactive";
            this.radioInactive.Size = new System.Drawing.Size(64, 15);
            this.radioInactive.TabIndex = 52;
            this.radioInactive.Text = "Inactive";
            this.radioInactive.UseSelectable = true;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtDescription.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(26, 292);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(192, 27);
            this.txtDescription.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtDescription.TabIndex = 50;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.UseStyleColors = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUnitPrice
            // 
            // 
            // 
            // 
            this.txtUnitPrice.CustomButton.Image = null;
            this.txtUnitPrice.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtUnitPrice.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnitPrice.CustomButton.Name = "";
            this.txtUnitPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUnitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitPrice.CustomButton.TabIndex = 1;
            this.txtUnitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitPrice.CustomButton.UseSelectable = true;
            this.txtUnitPrice.CustomButton.Visible = false;
            this.txtUnitPrice.Lines = new string[0];
            this.txtUnitPrice.Location = new System.Drawing.Point(26, 176);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnitPrice.MaxLength = 32767;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.SelectionLength = 0;
            this.txtUnitPrice.SelectionStart = 0;
            this.txtUnitPrice.ShortcutsEnabled = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(192, 27);
            this.txtUnitPrice.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtUnitPrice.TabIndex = 48;
            this.txtUnitPrice.UseSelectable = true;
            this.txtUnitPrice.UseStyleColors = true;
            this.txtUnitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(58, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(26, 145);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(87, 25);
            this.htmlLabel1.TabIndex = 47;
            this.htmlLabel1.Text = "Unit price";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(26, 112);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(192, 27);
            this.txtName.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtName.TabIndex = 46;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(86, 22);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(26, 80);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(87, 25);
            this.htmlLabel5.TabIndex = 45;
            this.htmlLabel5.Text = "Product name";
            // 
            // tileDelete
            // 
            this.tileDelete.ActiveControl = null;
            this.tileDelete.Location = new System.Drawing.Point(26, 337);
            this.tileDelete.Name = "tileDelete";
            this.tileDelete.Size = new System.Drawing.Size(87, 36);
            this.tileDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.tileDelete.TabIndex = 55;
            this.tileDelete.Text = "Delete";
            this.tileDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDelete.Click += new System.EventHandler(this.tileDelete_Click);
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 427);
            this.Controls.Add(this.tileDelete);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.radioActive);
            this.Controls.Add(this.tileEdit);
            this.Controls.Add(this.radioInactive);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.htmlLabel5);
            this.Controls.Add(this.lblItem);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemDetails";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Text = "ItemDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroRadioButton radioActive;
        private MetroFramework.Controls.MetroTile tileEdit;
        private MetroFramework.Controls.MetroRadioButton radioInactive;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtUnitPrice;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Controls.MetroTile tileDelete;
    }
}
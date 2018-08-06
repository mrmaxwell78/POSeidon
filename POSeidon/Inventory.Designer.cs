namespace POSeidon
{
    partial class frmInventory
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(40, 74);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(100, 23);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name: ";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(114, 71);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(40, 185);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(35, 13);
            this.lblSKU.TabIndex = 2;
            this.lblSKU.Text = "SKU: ";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(40, 135);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(114, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(114, 178);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(100, 20);
            this.txtSKU.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(43, 236);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description: ";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(114, 236);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(190, 20);
            this.txtItemDescription.TabIndex = 7;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 359);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(117, 47);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(179, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 47);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(43, 280);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 23);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(114, 277);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 11;
            // 
            // frmInventory
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 457);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add to Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}
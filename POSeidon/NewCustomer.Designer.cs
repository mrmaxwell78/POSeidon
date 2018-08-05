namespace POSeidon
{
    partial class frmNewCustomer
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
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.chkCustomerLoyalty = new System.Windows.Forms.CheckBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtNewCustomerFirst = new System.Windows.Forms.TextBox();
            this.txtNewCustomerLast = new System.Windows.Forms.TextBox();
            this.txtNewCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtNewCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtNewCustomerEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.Location = new System.Drawing.Point(42, 51);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerFirstName.TabIndex = 0;
            this.lblCustomerFirstName.Text = "First Name: ";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.Location = new System.Drawing.Point(42, 115);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerLastName.TabIndex = 1;
            this.lblCustomerLastName.Text = "Last Name: ";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.Location = new System.Drawing.Point(42, 184);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Address: ";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.Location = new System.Drawing.Point(42, 260);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerPhone.TabIndex = 3;
            this.lblCustomerPhone.Text = "Phone Number: ";
            // 
            // chkCustomerLoyalty
            // 
            this.chkCustomerLoyalty.Location = new System.Drawing.Point(45, 388);
            this.chkCustomerLoyalty.Name = "chkCustomerLoyalty";
            this.chkCustomerLoyalty.Size = new System.Drawing.Size(104, 24);
            this.chkCustomerLoyalty.TabIndex = 4;
            this.chkCustomerLoyalty.Text = "Loyalty Member";
            this.chkCustomerLoyalty.UseVisualStyleBackColor = true;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.Location = new System.Drawing.Point(42, 319);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerEmail.TabIndex = 5;
            this.lblCustomerEmail.Text = "Email Address: ";
            // 
            // txtNewCustomerFirst
            // 
            this.txtNewCustomerFirst.Location = new System.Drawing.Point(169, 51);
            this.txtNewCustomerFirst.Name = "txtNewCustomerFirst";
            this.txtNewCustomerFirst.Size = new System.Drawing.Size(100, 20);
            this.txtNewCustomerFirst.TabIndex = 6;
            // 
            // txtNewCustomerLast
            // 
            this.txtNewCustomerLast.Location = new System.Drawing.Point(169, 112);
            this.txtNewCustomerLast.Name = "txtNewCustomerLast";
            this.txtNewCustomerLast.Size = new System.Drawing.Size(100, 20);
            this.txtNewCustomerLast.TabIndex = 7;
            // 
            // txtNewCustomerAddress
            // 
            this.txtNewCustomerAddress.Location = new System.Drawing.Point(169, 181);
            this.txtNewCustomerAddress.Name = "txtNewCustomerAddress";
            this.txtNewCustomerAddress.Size = new System.Drawing.Size(100, 20);
            this.txtNewCustomerAddress.TabIndex = 8;
            // 
            // txtNewCustomerPhone
            // 
            this.txtNewCustomerPhone.Location = new System.Drawing.Point(169, 257);
            this.txtNewCustomerPhone.Name = "txtNewCustomerPhone";
            this.txtNewCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtNewCustomerPhone.TabIndex = 9;
            // 
            // txtNewCustomerEmail
            // 
            this.txtNewCustomerEmail.Location = new System.Drawing.Point(169, 316);
            this.txtNewCustomerEmail.Name = "txtNewCustomerEmail";
            this.txtNewCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtNewCustomerEmail.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(64, 457);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(193, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewCustomer
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(392, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNewCustomerEmail);
            this.Controls.Add(this.txtNewCustomerPhone);
            this.Controls.Add(this.txtNewCustomerAddress);
            this.Controls.Add(this.txtNewCustomerLast);
            this.Controls.Add(this.txtNewCustomerFirst);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.chkCustomerLoyalty);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Name = "frmNewCustomer";
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.CheckBox chkCustomerLoyalty;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtNewCustomerFirst;
        private System.Windows.Forms.TextBox txtNewCustomerLast;
        private System.Windows.Forms.TextBox txtNewCustomerAddress;
        private System.Windows.Forms.TextBox txtNewCustomerPhone;
        private System.Windows.Forms.TextBox txtNewCustomerEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
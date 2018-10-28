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
            this.lblAddCust = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFirstName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(42, 92);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerFirstName.TabIndex = 0;
            this.lblCustomerFirstName.Text = "First Name: ";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLastName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerLastName.Location = new System.Drawing.Point(41, 149);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerLastName.TabIndex = 1;
            this.lblCustomerLastName.Text = "Last Name: ";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.White;
            this.lblCustomerAddress.Location = new System.Drawing.Point(42, 206);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Address: ";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.White;
            this.lblCustomerPhone.Location = new System.Drawing.Point(42, 263);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerPhone.TabIndex = 3;
            this.lblCustomerPhone.Text = "Phone Number: ";
            // 
            // chkCustomerLoyalty
            // 
            this.chkCustomerLoyalty.BackColor = System.Drawing.Color.Transparent;
            this.chkCustomerLoyalty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomerLoyalty.ForeColor = System.Drawing.Color.White;
            this.chkCustomerLoyalty.Location = new System.Drawing.Point(166, 366);
            this.chkCustomerLoyalty.Name = "chkCustomerLoyalty";
            this.chkCustomerLoyalty.Size = new System.Drawing.Size(104, 24);
            this.chkCustomerLoyalty.TabIndex = 4;
            this.chkCustomerLoyalty.Text = "Loyalty Member";
            this.chkCustomerLoyalty.UseVisualStyleBackColor = false;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.White;
            this.lblCustomerEmail.Location = new System.Drawing.Point(42, 320);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerEmail.TabIndex = 5;
            this.lblCustomerEmail.Text = "Email Address: ";
            // 
            // txtNewCustomerFirst
            // 
            this.txtNewCustomerFirst.Location = new System.Drawing.Point(166, 92);
            this.txtNewCustomerFirst.Name = "txtNewCustomerFirst";
            this.txtNewCustomerFirst.Size = new System.Drawing.Size(172, 20);
            this.txtNewCustomerFirst.TabIndex = 6;
            this.txtNewCustomerFirst.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewCustomerFirst_Validating);
            // 
            // txtNewCustomerLast
            // 
            this.txtNewCustomerLast.Location = new System.Drawing.Point(166, 149);
            this.txtNewCustomerLast.Name = "txtNewCustomerLast";
            this.txtNewCustomerLast.Size = new System.Drawing.Size(172, 20);
            this.txtNewCustomerLast.TabIndex = 7;
            this.txtNewCustomerLast.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewCustomerLast_Validating);
            // 
            // txtNewCustomerAddress
            // 
            this.txtNewCustomerAddress.Location = new System.Drawing.Point(166, 206);
            this.txtNewCustomerAddress.Name = "txtNewCustomerAddress";
            this.txtNewCustomerAddress.Size = new System.Drawing.Size(172, 20);
            this.txtNewCustomerAddress.TabIndex = 8;
            // 
            // txtNewCustomerPhone
            // 
            this.txtNewCustomerPhone.Location = new System.Drawing.Point(166, 263);
            this.txtNewCustomerPhone.Name = "txtNewCustomerPhone";
            this.txtNewCustomerPhone.Size = new System.Drawing.Size(172, 20);
            this.txtNewCustomerPhone.TabIndex = 9;
            // 
            // txtNewCustomerEmail
            // 
            this.txtNewCustomerEmail.Location = new System.Drawing.Point(166, 320);
            this.txtNewCustomerEmail.Name = "txtNewCustomerEmail";
            this.txtNewCustomerEmail.Size = new System.Drawing.Size(172, 20);
            this.txtNewCustomerEmail.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(166, 424);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 29);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(260, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddCust
            // 
            this.lblAddCust.AutoSize = true;
            this.lblAddCust.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCust.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblAddCust.Location = new System.Drawing.Point(39, 27);
            this.lblAddCust.Name = "lblAddCust";
            this.lblAddCust.Size = new System.Drawing.Size(68, 32);
            this.lblAddCust.TabIndex = 13;
            this.lblAddCust.Text = "Add";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(101, 27);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(145, 32);
            this.lblCustomer.TabIndex = 14;
            this.lblCustomer.Text = "Customer";
            // 
            // frmNewCustomer
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POSeidon.Properties.Resources.water2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(392, 492);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblAddCust);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label lblAddCust;
        private System.Windows.Forms.Label lblCustomer;
    }
}
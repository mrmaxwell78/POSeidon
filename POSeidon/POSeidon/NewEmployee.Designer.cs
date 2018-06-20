namespace POSeidon
{
    partial class frmNewEmployee
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
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdoManagerNo = new System.Windows.Forms.RadioButton();
            this.rdoManagerYes = new System.Windows.Forms.RadioButton();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.rdoTimeNo = new System.Windows.Forms.RadioButton();
            this.rdoTimeYes = new System.Windows.Forms.RadioButton();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.rdoSalesNo = new System.Windows.Forms.RadioButton();
            this.rdoSalesYes = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpSalary = new System.Windows.Forms.GroupBox();
            this.rdoHourly = new System.Windows.Forms.RadioButton();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblPay = new System.Windows.Forms.Label();
            this.grpStatus.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.grpSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewName
            // 
            this.lblNewName.Location = new System.Drawing.Point(12, 59);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(78, 23);
            this.lblNewName.TabIndex = 0;
            this.lblNewName.Text = "First Name:";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.Location = new System.Drawing.Point(12, 94);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(75, 23);
            this.lblNewLastName.TabIndex = 1;
            this.lblNewLastName.Text = "Last Name:";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(84, 59);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 20);
            this.txtNewName.TabIndex = 2;
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(84, 94);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(100, 20);
            this.txtNewLastName.TabIndex = 3;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdoManagerNo);
            this.grpStatus.Controls.Add(this.rdoManagerYes);
            this.grpStatus.Location = new System.Drawing.Point(15, 121);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(169, 44);
            this.grpStatus.TabIndex = 5;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Manager?";
            // 
            // rdoManagerNo
            // 
            this.rdoManagerNo.AutoSize = true;
            this.rdoManagerNo.Location = new System.Drawing.Point(81, 21);
            this.rdoManagerNo.Name = "rdoManagerNo";
            this.rdoManagerNo.Size = new System.Drawing.Size(39, 17);
            this.rdoManagerNo.TabIndex = 1;
            this.rdoManagerNo.TabStop = true;
            this.rdoManagerNo.Text = "No";
            this.rdoManagerNo.UseVisualStyleBackColor = true;
            // 
            // rdoManagerYes
            // 
            this.rdoManagerYes.AutoSize = true;
            this.rdoManagerYes.Location = new System.Drawing.Point(7, 21);
            this.rdoManagerYes.Name = "rdoManagerYes";
            this.rdoManagerYes.Size = new System.Drawing.Size(43, 17);
            this.rdoManagerYes.TabIndex = 0;
            this.rdoManagerYes.TabStop = true;
            this.rdoManagerYes.Text = "Yes";
            this.rdoManagerYes.UseVisualStyleBackColor = true;
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.rdoTimeNo);
            this.grpTime.Controls.Add(this.rdoTimeYes);
            this.grpTime.Location = new System.Drawing.Point(15, 183);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(169, 44);
            this.grpTime.TabIndex = 6;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Full Time?";
            // 
            // rdoTimeNo
            // 
            this.rdoTimeNo.AutoSize = true;
            this.rdoTimeNo.Location = new System.Drawing.Point(81, 21);
            this.rdoTimeNo.Name = "rdoTimeNo";
            this.rdoTimeNo.Size = new System.Drawing.Size(39, 17);
            this.rdoTimeNo.TabIndex = 1;
            this.rdoTimeNo.TabStop = true;
            this.rdoTimeNo.Text = "No";
            this.rdoTimeNo.UseVisualStyleBackColor = true;
            // 
            // rdoTimeYes
            // 
            this.rdoTimeYes.AutoSize = true;
            this.rdoTimeYes.Location = new System.Drawing.Point(7, 21);
            this.rdoTimeYes.Name = "rdoTimeYes";
            this.rdoTimeYes.Size = new System.Drawing.Size(43, 17);
            this.rdoTimeYes.TabIndex = 0;
            this.rdoTimeYes.TabStop = true;
            this.rdoTimeYes.Text = "Yes";
            this.rdoTimeYes.UseVisualStyleBackColor = true;
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.rdoSalesNo);
            this.grpSales.Controls.Add(this.rdoSalesYes);
            this.grpSales.Location = new System.Drawing.Point(15, 243);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(169, 44);
            this.grpSales.TabIndex = 7;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales Team?";
            // 
            // rdoSalesNo
            // 
            this.rdoSalesNo.AutoSize = true;
            this.rdoSalesNo.Location = new System.Drawing.Point(81, 21);
            this.rdoSalesNo.Name = "rdoSalesNo";
            this.rdoSalesNo.Size = new System.Drawing.Size(39, 17);
            this.rdoSalesNo.TabIndex = 1;
            this.rdoSalesNo.TabStop = true;
            this.rdoSalesNo.Text = "No";
            this.rdoSalesNo.UseVisualStyleBackColor = true;
            // 
            // rdoSalesYes
            // 
            this.rdoSalesYes.AutoSize = true;
            this.rdoSalesYes.Location = new System.Drawing.Point(7, 21);
            this.rdoSalesYes.Name = "rdoSalesYes";
            this.rdoSalesYes.Size = new System.Drawing.Size(43, 17);
            this.rdoSalesYes.TabIndex = 0;
            this.rdoSalesYes.TabStop = true;
            this.rdoSalesYes.Text = "Yes";
            this.rdoSalesYes.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(119, 415);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpSalary
            // 
            this.grpSalary.Controls.Add(this.rdoHourly);
            this.grpSalary.Controls.Add(this.rdoSalary);
            this.grpSalary.Location = new System.Drawing.Point(15, 310);
            this.grpSalary.Name = "grpSalary";
            this.grpSalary.Size = new System.Drawing.Size(169, 44);
            this.grpSalary.TabIndex = 10;
            this.grpSalary.TabStop = false;
            this.grpSalary.Text = "Payment Option?";
            // 
            // rdoHourly
            // 
            this.rdoHourly.AutoSize = true;
            this.rdoHourly.Location = new System.Drawing.Point(81, 21);
            this.rdoHourly.Name = "rdoHourly";
            this.rdoHourly.Size = new System.Drawing.Size(55, 17);
            this.rdoHourly.TabIndex = 1;
            this.rdoHourly.TabStop = true;
            this.rdoHourly.Text = "Hourly";
            this.rdoHourly.UseVisualStyleBackColor = true;
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.Location = new System.Drawing.Point(7, 21);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(61, 17);
            this.rdoSalary.TabIndex = 0;
            this.rdoSalary.TabStop = true;
            this.rdoSalary.Text = "Weekly";
            this.rdoSalary.UseVisualStyleBackColor = true;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(241, 328);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // lblPay
            // 
            this.lblPay.Location = new System.Drawing.Point(241, 287);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(100, 23);
            this.lblPay.TabIndex = 12;
            this.lblPay.Text = "Wages";
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 465);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.grpSalary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.txtNewLastName);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblNewLastName);
            this.Controls.Add(this.lblNewName);
            this.Name = "frmNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Employee";
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.grpSalary.ResumeLayout(false);
            this.grpSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewLastName;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rdoManagerNo;
        private System.Windows.Forms.RadioButton rdoManagerYes;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.RadioButton rdoTimeNo;
        private System.Windows.Forms.RadioButton rdoTimeYes;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.RadioButton rdoSalesNo;
        private System.Windows.Forms.RadioButton rdoSalesYes;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpSalary;
        private System.Windows.Forms.RadioButton rdoHourly;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblPay;
    }
}
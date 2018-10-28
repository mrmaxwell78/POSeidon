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
            this.nudWage = new System.Windows.Forms.NumericUpDown();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAddEmp = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.grpStatus.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.grpSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewName
            // 
            this.lblNewName.BackColor = System.Drawing.Color.Transparent;
            this.lblNewName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewName.ForeColor = System.Drawing.Color.White;
            this.lblNewName.Location = new System.Drawing.Point(25, 77);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(78, 23);
            this.lblNewName.TabIndex = 0;
            this.lblNewName.Text = "First Name:";
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblNewLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLastName.ForeColor = System.Drawing.Color.White;
            this.lblNewLastName.Location = new System.Drawing.Point(27, 123);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(75, 23);
            this.lblNewLastName.TabIndex = 1;
            this.lblNewLastName.Text = "Last Name:";
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewName.Location = new System.Drawing.Point(73, 75);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 25);
            this.txtNewName.TabIndex = 2;
            this.txtNewName.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewName_Validating);
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewLastName.Location = new System.Drawing.Point(73, 121);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(100, 25);
            this.txtNewLastName.TabIndex = 3;
            this.txtNewLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewLastName_Validating);
            // 
            // grpStatus
            // 
            this.grpStatus.BackColor = System.Drawing.Color.Transparent;
            this.grpStatus.Controls.Add(this.rdoManagerNo);
            this.grpStatus.Controls.Add(this.rdoManagerYes);
            this.grpStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.ForeColor = System.Drawing.Color.White;
            this.grpStatus.Location = new System.Drawing.Point(32, 171);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(180, 44);
            this.grpStatus.TabIndex = 5;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Manager?";
            // 
            // rdoManagerNo
            // 
            this.rdoManagerNo.AutoSize = true;
            this.rdoManagerNo.Location = new System.Drawing.Point(95, 20);
            this.rdoManagerNo.Name = "rdoManagerNo";
            this.rdoManagerNo.Size = new System.Drawing.Size(46, 22);
            this.rdoManagerNo.TabIndex = 1;
            this.rdoManagerNo.TabStop = true;
            this.rdoManagerNo.Text = "No";
            this.rdoManagerNo.UseVisualStyleBackColor = true;
            // 
            // rdoManagerYes
            // 
            this.rdoManagerYes.AutoSize = true;
            this.rdoManagerYes.Location = new System.Drawing.Point(7, 19);
            this.rdoManagerYes.Name = "rdoManagerYes";
            this.rdoManagerYes.Size = new System.Drawing.Size(52, 22);
            this.rdoManagerYes.TabIndex = 0;
            this.rdoManagerYes.TabStop = true;
            this.rdoManagerYes.Text = "Yes";
            this.rdoManagerYes.UseVisualStyleBackColor = true;
            // 
            // grpTime
            // 
            this.grpTime.BackColor = System.Drawing.Color.Transparent;
            this.grpTime.Controls.Add(this.rdoTimeNo);
            this.grpTime.Controls.Add(this.rdoTimeYes);
            this.grpTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTime.ForeColor = System.Drawing.Color.White;
            this.grpTime.Location = new System.Drawing.Point(32, 249);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(180, 44);
            this.grpTime.TabIndex = 6;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Full Time?";
            // 
            // rdoTimeNo
            // 
            this.rdoTimeNo.AutoSize = true;
            this.rdoTimeNo.Location = new System.Drawing.Point(95, 22);
            this.rdoTimeNo.Name = "rdoTimeNo";
            this.rdoTimeNo.Size = new System.Drawing.Size(46, 22);
            this.rdoTimeNo.TabIndex = 1;
            this.rdoTimeNo.TabStop = true;
            this.rdoTimeNo.Text = "No";
            this.rdoTimeNo.UseVisualStyleBackColor = true;
            // 
            // rdoTimeYes
            // 
            this.rdoTimeYes.AutoSize = true;
            this.rdoTimeYes.Location = new System.Drawing.Point(7, 22);
            this.rdoTimeYes.Name = "rdoTimeYes";
            this.rdoTimeYes.Size = new System.Drawing.Size(52, 22);
            this.rdoTimeYes.TabIndex = 0;
            this.rdoTimeYes.TabStop = true;
            this.rdoTimeYes.Text = "Yes";
            this.rdoTimeYes.UseVisualStyleBackColor = true;
            // 
            // grpSales
            // 
            this.grpSales.BackColor = System.Drawing.Color.Transparent;
            this.grpSales.Controls.Add(this.rdoSalesNo);
            this.grpSales.Controls.Add(this.rdoSalesYes);
            this.grpSales.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.ForeColor = System.Drawing.Color.White;
            this.grpSales.Location = new System.Drawing.Point(32, 319);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(180, 44);
            this.grpSales.TabIndex = 7;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales Team?";
            // 
            // rdoSalesNo
            // 
            this.rdoSalesNo.AutoSize = true;
            this.rdoSalesNo.Location = new System.Drawing.Point(95, 21);
            this.rdoSalesNo.Name = "rdoSalesNo";
            this.rdoSalesNo.Size = new System.Drawing.Size(46, 22);
            this.rdoSalesNo.TabIndex = 1;
            this.rdoSalesNo.TabStop = true;
            this.rdoSalesNo.Text = "No";
            this.rdoSalesNo.UseVisualStyleBackColor = true;
            // 
            // rdoSalesYes
            // 
            this.rdoSalesYes.AutoSize = true;
            this.rdoSalesYes.Location = new System.Drawing.Point(25, 73);
            this.rdoSalesYes.Name = "rdoSalesYes";
            this.rdoSalesYes.Size = new System.Drawing.Size(52, 22);
            this.rdoSalesYes.TabIndex = 0;
            this.rdoSalesYes.TabStop = true;
            this.rdoSalesYes.Text = "Yes";
            this.rdoSalesYes.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(343, 335);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(343, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpSalary
            // 
            this.grpSalary.BackColor = System.Drawing.Color.Transparent;
            this.grpSalary.Controls.Add(this.rdoHourly);
            this.grpSalary.Controls.Add(this.rdoSalary);
            this.grpSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalary.ForeColor = System.Drawing.Color.White;
            this.grpSalary.Location = new System.Drawing.Point(32, 385);
            this.grpSalary.Name = "grpSalary";
            this.grpSalary.Size = new System.Drawing.Size(180, 44);
            this.grpSalary.TabIndex = 10;
            this.grpSalary.TabStop = false;
            this.grpSalary.Text = "Payment Option?";
            // 
            // rdoHourly
            // 
            this.rdoHourly.AutoSize = true;
            this.rdoHourly.Location = new System.Drawing.Point(95, 21);
            this.rdoHourly.Name = "rdoHourly";
            this.rdoHourly.Size = new System.Drawing.Size(78, 23);
            this.rdoHourly.TabIndex = 1;
            this.rdoHourly.TabStop = true;
            this.rdoHourly.Text = "Hourly";
            this.rdoHourly.UseVisualStyleBackColor = true;
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.BackColor = System.Drawing.Color.Transparent;
            this.rdoSalary.ForeColor = System.Drawing.Color.White;
            this.rdoSalary.Location = new System.Drawing.Point(7, 21);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(82, 23);
            this.rdoSalary.TabIndex = 0;
            this.rdoSalary.TabStop = true;
            this.rdoSalary.Text = "Weekly";
            this.rdoSalary.UseVisualStyleBackColor = false;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // nudWage
            // 
            this.nudWage.DecimalPlaces = 2;
            this.nudWage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(116)))), ((int)(((byte)(145)))));
            this.nudWage.Location = new System.Drawing.Point(344, 181);
            this.nudWage.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudWage.Name = "nudWage";
            this.nudWage.Size = new System.Drawing.Size(101, 26);
            this.nudWage.TabIndex = 11;
            this.nudWage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWage.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblPay
            // 
            this.lblPay.BackColor = System.Drawing.Color.Transparent;
            this.lblPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.White;
            this.lblPay.Location = new System.Drawing.Point(276, 183);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(60, 23);
            this.lblPay.TabIndex = 12;
            this.lblPay.Text = "Wages";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(345, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 25);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(202, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(137, 19);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Enter Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(345, 75);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 25);
            this.txtUserName.TabIndex = 18;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(201, 77);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(138, 19);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "Enter Username:";
            // 
            // lblAddEmp
            // 
            this.lblAddEmp.AutoSize = true;
            this.lblAddEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEmp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblAddEmp.Location = new System.Drawing.Point(22, 24);
            this.lblAddEmp.Name = "lblAddEmp";
            this.lblAddEmp.Size = new System.Drawing.Size(68, 32);
            this.lblAddEmp.TabIndex = 21;
            this.lblAddEmp.Text = "Add";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployee.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(82, 24);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(146, 32);
            this.lblEmployee.TabIndex = 22;
            this.lblEmployee.Text = "Employee";
            // 
            // frmNewEmployee
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POSeidon.Properties.Resources.water2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 465);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblAddEmp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.nudWage);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudWage)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudWage;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAddEmp;
        private System.Windows.Forms.Label lblEmployee;
    }
}
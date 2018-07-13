namespace POSeidon
{
    partial class frmPOS
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.col1FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3Adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.chkEmp3Time = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoEmp3Manager = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoEmp3Sales = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFullTime = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmp1 = new System.Windows.Forms.Label();
            this.chkEmp1Time = new System.Windows.Forms.CheckBox();
            this.pnlEmp1Man = new System.Windows.Forms.Panel();
            this.rdoEmp1Manager = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoEmp1Sales = new System.Windows.Forms.RadioButton();
            this.lblEmp2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoEmp2Sales = new System.Windows.Forms.RadioButton();
            this.chkEmp2Time = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoEmp2Manager = new System.Windows.Forms.RadioButton();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tlpEmployee.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlEmp1Man.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(776, 540);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Make A Sale";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvCustomer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Customer List";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1FirstName,
            this.col2LastName,
            this.col3Adr,
            this.col4Phone,
            this.col5Email,
            this.col6});
            this.dgvCustomer.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCustomer.Location = new System.Drawing.Point(6, 6);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(763, 447);
            this.dgvCustomer.TabIndex = 0;
            // 
            // col1FirstName
            // 
            this.col1FirstName.HeaderText = "First Name";
            this.col1FirstName.Name = "col1FirstName";
            // 
            // col2LastName
            // 
            this.col2LastName.HeaderText = "Last Name";
            this.col2LastName.Name = "col2LastName";
            // 
            // col3Adr
            // 
            this.col3Adr.HeaderText = "Address";
            this.col3Adr.Name = "col3Adr";
            // 
            // col4Phone
            // 
            this.col4Phone.HeaderText = "Phone";
            this.col4Phone.Name = "col4Phone";
            // 
            // col5Email
            // 
            this.col5Email.HeaderText = "Email";
            this.col5Email.Name = "col5Email";
            // 
            // col6
            // 
            this.col6.HeaderText = "Loyalty Member";
            this.col6.Name = "col6";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventory List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tlpEmployee);
            this.tabPage2.Controls.Add(this.btnNewEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpEmployee
            // 
            this.tlpEmployee.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpEmployee.ColumnCount = 4;
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.8672F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.1328F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlpEmployee.Controls.Add(this.chkEmp3Time, 1, 3);
            this.tlpEmployee.Controls.Add(this.panel4, 2, 3);
            this.tlpEmployee.Controls.Add(this.panel5, 3, 3);
            this.tlpEmployee.Controls.Add(this.label1, 0, 3);
            this.tlpEmployee.Controls.Add(this.lblName, 0, 0);
            this.tlpEmployee.Controls.Add(this.lblFullTime, 1, 0);
            this.tlpEmployee.Controls.Add(this.lblManager, 2, 0);
            this.tlpEmployee.Controls.Add(this.label2, 3, 0);
            this.tlpEmployee.Controls.Add(this.lblEmp1, 0, 1);
            this.tlpEmployee.Controls.Add(this.chkEmp1Time, 1, 1);
            this.tlpEmployee.Controls.Add(this.pnlEmp1Man, 2, 1);
            this.tlpEmployee.Controls.Add(this.panel2, 3, 1);
            this.tlpEmployee.Controls.Add(this.lblEmp2, 0, 2);
            this.tlpEmployee.Controls.Add(this.panel3, 3, 2);
            this.tlpEmployee.Controls.Add(this.chkEmp2Time, 1, 2);
            this.tlpEmployee.Controls.Add(this.panel1, 2, 2);
            this.tlpEmployee.Location = new System.Drawing.Point(7, 47);
            this.tlpEmployee.Name = "tlpEmployee";
            this.tlpEmployee.RowCount = 6;
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tlpEmployee.Size = new System.Drawing.Size(763, 446);
            this.tlpEmployee.TabIndex = 3;
            // 
            // chkEmp3Time
            // 
            this.chkEmp3Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkEmp3Time.AutoSize = true;
            this.chkEmp3Time.Location = new System.Drawing.Point(437, 195);
            this.chkEmp3Time.Name = "chkEmp3Time";
            this.chkEmp3Time.Size = new System.Drawing.Size(40, 17);
            this.chkEmp3Time.TabIndex = 16;
            this.chkEmp3Time.Text = "No";
            this.chkEmp3Time.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoEmp3Manager);
            this.panel4.Location = new System.Drawing.Point(518, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 47);
            this.panel4.TabIndex = 17;
            // 
            // rdoEmp3Manager
            // 
            this.rdoEmp3Manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp3Manager.AutoSize = true;
            this.rdoEmp3Manager.Location = new System.Drawing.Point(32, 14);
            this.rdoEmp3Manager.Name = "rdoEmp3Manager";
            this.rdoEmp3Manager.Size = new System.Drawing.Size(43, 17);
            this.rdoEmp3Manager.TabIndex = 8;
            this.rdoEmp3Manager.TabStop = true;
            this.rdoEmp3Manager.Text = "Yes";
            this.rdoEmp3Manager.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdoEmp3Sales);
            this.panel5.Location = new System.Drawing.Point(628, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(111, 47);
            this.panel5.TabIndex = 18;
            // 
            // rdoEmp3Sales
            // 
            this.rdoEmp3Sales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp3Sales.AutoSize = true;
            this.rdoEmp3Sales.Location = new System.Drawing.Point(33, 15);
            this.rdoEmp3Sales.Name = "rdoEmp3Sales";
            this.rdoEmp3Sales.Size = new System.Drawing.Size(51, 17);
            this.rdoEmp3Sales.TabIndex = 5;
            this.rdoEmp3Sales.TabStop = true;
            this.rdoEmp3Sales.Text = "Sales";
            this.rdoEmp3Sales.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(150, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Place Holder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(150, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullTime
            // 
            this.lblFullTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullTime.Location = new System.Drawing.Point(416, 23);
            this.lblFullTime.Name = "lblFullTime";
            this.lblFullTime.Size = new System.Drawing.Size(83, 23);
            this.lblFullTime.TabIndex = 1;
            this.lblFullTime.Text = "Full Time";
            this.lblFullTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManager
            // 
            this.lblManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManager.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.Location = new System.Drawing.Point(519, 23);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(100, 23);
            this.lblManager.TabIndex = 2;
            this.lblManager.Text = "Manager";
            this.lblManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sales Team";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmp1
            // 
            this.lblEmp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmp1.Location = new System.Drawing.Point(150, 84);
            this.lblEmp1.Name = "lblEmp1";
            this.lblEmp1.Size = new System.Drawing.Size(100, 23);
            this.lblEmp1.TabIndex = 4;
            this.lblEmp1.Text = "Place Holder";
            this.lblEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkEmp1Time
            // 
            this.chkEmp1Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkEmp1Time.AutoSize = true;
            this.chkEmp1Time.Location = new System.Drawing.Point(437, 87);
            this.chkEmp1Time.Name = "chkEmp1Time";
            this.chkEmp1Time.Size = new System.Drawing.Size(40, 17);
            this.chkEmp1Time.TabIndex = 7;
            this.chkEmp1Time.Text = "No";
            this.chkEmp1Time.UseVisualStyleBackColor = true;
            this.chkEmp1Time.CheckedChanged += new System.EventHandler(this.chkEmp1Time_CheckedChanged);
            // 
            // pnlEmp1Man
            // 
            this.pnlEmp1Man.Controls.Add(this.rdoEmp1Manager);
            this.pnlEmp1Man.Location = new System.Drawing.Point(518, 72);
            this.pnlEmp1Man.Name = "pnlEmp1Man";
            this.pnlEmp1Man.Size = new System.Drawing.Size(103, 47);
            this.pnlEmp1Man.TabIndex = 9;
            // 
            // rdoEmp1Manager
            // 
            this.rdoEmp1Manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp1Manager.AutoSize = true;
            this.rdoEmp1Manager.Location = new System.Drawing.Point(32, 15);
            this.rdoEmp1Manager.Name = "rdoEmp1Manager";
            this.rdoEmp1Manager.Size = new System.Drawing.Size(43, 17);
            this.rdoEmp1Manager.TabIndex = 8;
            this.rdoEmp1Manager.TabStop = true;
            this.rdoEmp1Manager.Text = "Yes";
            this.rdoEmp1Manager.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoEmp1Sales);
            this.panel2.Location = new System.Drawing.Point(628, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 47);
            this.panel2.TabIndex = 10;
            // 
            // rdoEmp1Sales
            // 
            this.rdoEmp1Sales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp1Sales.AutoSize = true;
            this.rdoEmp1Sales.Location = new System.Drawing.Point(33, 15);
            this.rdoEmp1Sales.Name = "rdoEmp1Sales";
            this.rdoEmp1Sales.Size = new System.Drawing.Size(51, 17);
            this.rdoEmp1Sales.TabIndex = 5;
            this.rdoEmp1Sales.TabStop = true;
            this.rdoEmp1Sales.Text = "Sales";
            this.rdoEmp1Sales.UseVisualStyleBackColor = true;
            // 
            // lblEmp2
            // 
            this.lblEmp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmp2.Location = new System.Drawing.Point(150, 138);
            this.lblEmp2.Name = "lblEmp2";
            this.lblEmp2.Size = new System.Drawing.Size(100, 23);
            this.lblEmp2.TabIndex = 11;
            this.lblEmp2.Text = "Place Holder";
            this.lblEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoEmp2Sales);
            this.panel3.Location = new System.Drawing.Point(628, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 47);
            this.panel3.TabIndex = 14;
            // 
            // rdoEmp2Sales
            // 
            this.rdoEmp2Sales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp2Sales.AutoSize = true;
            this.rdoEmp2Sales.Location = new System.Drawing.Point(33, 15);
            this.rdoEmp2Sales.Name = "rdoEmp2Sales";
            this.rdoEmp2Sales.Size = new System.Drawing.Size(51, 17);
            this.rdoEmp2Sales.TabIndex = 5;
            this.rdoEmp2Sales.TabStop = true;
            this.rdoEmp2Sales.Text = "Sales";
            this.rdoEmp2Sales.UseVisualStyleBackColor = true;
            // 
            // chkEmp2Time
            // 
            this.chkEmp2Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkEmp2Time.AutoSize = true;
            this.chkEmp2Time.Location = new System.Drawing.Point(437, 141);
            this.chkEmp2Time.Name = "chkEmp2Time";
            this.chkEmp2Time.Size = new System.Drawing.Size(40, 17);
            this.chkEmp2Time.TabIndex = 12;
            this.chkEmp2Time.Text = "No";
            this.chkEmp2Time.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoEmp2Manager);
            this.panel1.Location = new System.Drawing.Point(518, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 47);
            this.panel1.TabIndex = 13;
            // 
            // rdoEmp2Manager
            // 
            this.rdoEmp2Manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp2Manager.AutoSize = true;
            this.rdoEmp2Manager.Location = new System.Drawing.Point(32, 14);
            this.rdoEmp2Manager.Name = "rdoEmp2Manager";
            this.rdoEmp2Manager.Size = new System.Drawing.Size(43, 17);
            this.rdoEmp2Manager.TabIndex = 8;
            this.rdoEmp2Manager.TabStop = true;
            this.rdoEmp2Manager.Text = "Yes";
            this.rdoEmp2Manager.UseVisualStyleBackColor = true;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(300, 492);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(153, 41);
            this.btnNewEmployee.TabIndex = 1;
            this.btnNewEmployee.Text = "Create New Employee?";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabPage5);
            this.tabPanel.Controls.Add(this.tabPage1);
            this.tabPanel.Controls.Add(this.tabPage2);
            this.tabPanel.Controls.Add(this.tabPage3);
            this.tabPanel.Controls.Add(this.tabPage4);
            this.tabPanel.Location = new System.Drawing.Point(3, 35);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(784, 566);
            this.tabPanel.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabPanel.TabIndex = 0;
            this.tabPanel.SelectedIndexChanged += new System.EventHandler(this.tabPanel_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 602);
            this.Controls.Add(this.tabPanel);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSeidon Point Of Sale";
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tlpEmployee.ResumeLayout(false);
            this.tlpEmployee.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlEmp1Man.ResumeLayout(false);
            this.pnlEmp1Man.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.TableLayoutPanel tlpEmployee;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFullTime;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmp1;
        private System.Windows.Forms.CheckBox chkEmp1Time;
        private System.Windows.Forms.Panel pnlEmp1Man;
        private System.Windows.Forms.RadioButton rdoEmp1Manager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoEmp1Sales;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3Adr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5Email;
        private System.Windows.Forms.CheckBox chkEmp3Time;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdoEmp3Manager;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdoEmp3Sales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmp2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoEmp2Sales;
        private System.Windows.Forms.CheckBox chkEmp2Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoEmp2Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
    }
}


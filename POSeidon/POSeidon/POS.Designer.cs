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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tabPage2.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlEmp1Man.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(776, 540);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Loyalty Program";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Customer List";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.btnNewEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee List";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPanel.Controls.Add(this.tabPage1);
            this.tabPanel.Controls.Add(this.tabPage2);
            this.tabPanel.Controls.Add(this.tabPage3);
            this.tabPanel.Controls.Add(this.tabPage4);
            this.tabPanel.Controls.Add(this.tabPage5);
            this.tabPanel.Location = new System.Drawing.Point(3, 35);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(784, 566);
            this.tabPanel.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabPanel.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.8672F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.1328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFullTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblManager, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmp1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkEmp1Time, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlEmp1Man, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 446);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(156, 19);
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
            this.lblFullTime.Location = new System.Drawing.Point(430, 19);
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
            this.lblManager.Location = new System.Drawing.Point(535, 19);
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
            this.label2.Location = new System.Drawing.Point(651, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sales Team";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmp1
            // 
            this.lblEmp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmp1.Location = new System.Drawing.Point(156, 77);
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
            this.chkEmp1Time.Location = new System.Drawing.Point(451, 80);
            this.chkEmp1Time.Name = "chkEmp1Time";
            this.chkEmp1Time.Size = new System.Drawing.Size(40, 17);
            this.chkEmp1Time.TabIndex = 7;
            this.chkEmp1Time.Text = "No";
            this.chkEmp1Time.UseVisualStyleBackColor = true;
            // 
            // pnlEmp1Man
            // 
            this.pnlEmp1Man.Controls.Add(this.rdoEmp1Manager);
            this.pnlEmp1Man.Location = new System.Drawing.Point(534, 64);
            this.pnlEmp1Man.Name = "pnlEmp1Man";
            this.pnlEmp1Man.Size = new System.Drawing.Size(103, 49);
            this.pnlEmp1Man.TabIndex = 9;
            // 
            // rdoEmp1Manager
            // 
            this.rdoEmp1Manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp1Manager.AutoSize = true;
            this.rdoEmp1Manager.Location = new System.Drawing.Point(32, 16);
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
            this.panel2.Location = new System.Drawing.Point(644, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 49);
            this.panel2.TabIndex = 10;
            // 
            // rdoEmp1Sales
            // 
            this.rdoEmp1Sales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoEmp1Sales.AutoSize = true;
            this.rdoEmp1Sales.Location = new System.Drawing.Point(33, 16);
            this.rdoEmp1Sales.Name = "rdoEmp1Sales";
            this.rdoEmp1Sales.Size = new System.Drawing.Size(51, 17);
            this.rdoEmp1Sales.TabIndex = 5;
            this.rdoEmp1Sales.TabStop = true;
            this.rdoEmp1Sales.Text = "Sales";
            this.rdoEmp1Sales.UseVisualStyleBackColor = true;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlEmp1Man.ResumeLayout(false);
            this.pnlEmp1Man.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}


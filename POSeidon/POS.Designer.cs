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
            this.btnSale = new System.Windows.Forms.Button();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.lstSale = new System.Windows.Forms.ListBox();
            this.InventoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnLoyalty = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReloadInventory = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSalesHistory = new System.Windows.Forms.DataGridView();
            this.salesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTableTableAdapter2 = new POSeidon.POSeidonDataSetTableAdapters.CustomerTableTableAdapter();
            this.pOSeidonDataSet1 = new POSeidon.POSeidonDataSet();
            this.customerTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTableBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSeidonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnSale);
            this.tabPage5.Controls.Add(this.txtSales);
            this.tabPage5.Controls.Add(this.lstSale);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(776, 548);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Make A Sale";
            this.tabPage5.ToolTipText = "Make A Sale";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(278, 462);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(135, 50);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "Make A Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(90, 43);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(587, 20);
            this.txtSales.TabIndex = 2;
            this.txtSales.TextChanged += new System.EventHandler(this.txtSales_TextChanged);
            // 
            // lstSale
            // 
            this.lstSale.FormattingEnabled = true;
            this.lstSale.Location = new System.Drawing.Point(90, 216);
            this.lstSale.Name = "lstSale";
            this.lstSale.Size = new System.Drawing.Size(587, 186);
            this.lstSale.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnNewCustomer);
            this.tabPage4.Controls.Add(this.btnCustomer);
            this.tabPage4.Controls.Add(this.btnRemoveCustomer);
            this.tabPage4.Controls.Add(this.btnLoyalty);
            this.tabPage4.Controls.Add(this.dgvCustomer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 548);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Customer List";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(360, 479);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(145, 54);
            this.btnNewCustomer.TabIndex = 4;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(43, 479);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(137, 54);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Refresh Table";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(209, 479);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(131, 54);
            this.btnRemoveCustomer.TabIndex = 2;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnLoyalty
            // 
            this.btnLoyalty.Location = new System.Drawing.Point(528, 480);
            this.btnLoyalty.Name = "btnLoyalty";
            this.btnLoyalty.Size = new System.Drawing.Size(131, 54);
            this.btnLoyalty.TabIndex = 1;
            this.btnLoyalty.Text = "Loyalty Information";
            this.btnLoyalty.UseVisualStyleBackColor = true;
            this.btnLoyalty.Click += new System.EventHandler(this.btnLoyalty_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.dgvCustomer.DataSource = this.customerTableBindingSource1;
            this.dgvCustomer.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCustomer.Location = new System.Drawing.Point(6, 6);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(763, 447);
            this.dgvCustomer.TabIndex = 0;
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.AllowNew = true;
            this.customerTableBindingSource.DataMember = "CustomerTable";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReloadInventory);
            this.tabPage3.Controls.Add(this.btnAddItem);
            this.tabPage3.Controls.Add(this.dgvInventory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 548);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventory List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnReloadInventory
            // 
            this.btnReloadInventory.Location = new System.Drawing.Point(404, 495);
            this.btnReloadInventory.Name = "btnReloadInventory";
            this.btnReloadInventory.Size = new System.Drawing.Size(128, 38);
            this.btnReloadInventory.TabIndex = 2;
            this.btnReloadInventory.Text = "Reload Table";
            this.btnReloadInventory.UseVisualStyleBackColor = true;
            this.btnReloadInventory.Click += new System.EventHandler(this.btnReloadInventory_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(166, 495);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(121, 38);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add To Inventory";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(776, 474);
            this.dgvInventory.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEmployee);
            this.tabPage2.Controls.Add(this.btnNewEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee List";
            this.tabPage2.ToolTipText = "List of Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(100, 55);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(580, 372);
            this.dgvEmployee.TabIndex = 2;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(288, 492);
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
            this.tabPanel.Location = new System.Drawing.Point(3, 27);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(784, 574);
            this.tabPanel.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabPanel.TabIndex = 0;
            this.tabPanel.SelectedIndexChanged += new System.EventHandler(this.tabPanel_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSalesHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales History";
            this.tabPage1.ToolTipText = "Previous Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSalesHistory
            // 
            this.dgvSalesHistory.AutoGenerateColumns = false;
            this.dgvSalesHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesHistory.DataSource = this.salesHistoryBindingSource;
            this.dgvSalesHistory.Location = new System.Drawing.Point(1, 3);
            this.dgvSalesHistory.Name = "dgvSalesHistory";
            this.dgvSalesHistory.Size = new System.Drawing.Size(774, 463);
            this.dgvSalesHistory.TabIndex = 0;
            // 
            // salesHistoryBindingSource
            // 
            this.salesHistoryBindingSource.DataMember = "SalesHistory";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customerTableTableAdapter2
            // 
            this.customerTableTableAdapter2.ClearBeforeFill = true;
            // 
            // pOSeidonDataSet1
            // 
            this.pOSeidonDataSet1.DataSetName = "POSeidonDataSet";
            this.pOSeidonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableBindingSource1
            // 
            this.customerTableBindingSource1.DataMember = "CustomerTable";
            this.customerTableBindingSource1.DataSource = this.pOSeidonDataSet1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Loyalty";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Loyalty";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 602);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSeidon Point Of Sale";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTableBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSeidonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnLoyalty;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridView dgvInventory;
        private POSeidonDataSet pOSeidonDataSet;
        private System.Windows.Forms.DataGridView dgvSalesHistory;
        private System.Windows.Forms.BindingSource salesHistoryBindingSource;
        //private POSeidonDataSetTableAdapters.Sales_HistoryTableAdapter sales_HistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private System.Windows.Forms.Button btnNewCustomer;
        private POSeidonDataSetTableAdapters.SalesHistoryTableAdapter salesHistoryTableAdapter;
        private POSeidonDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter1;
        private POSeidonDataSetTableAdapters.EmployeeTableTableAdapter employeeTableTableAdapter1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnReloadInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn loyaltyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource InventoryTableBindingSource;
        private POSeidonDataSetTableAdapters.InventoryTableTableAdapter inventoryTableTableAdapter1;
        private System.Windows.Forms.ListBox lstSale;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource customerTableBindingSource1;
        private POSeidonDataSet pOSeidonDataSet1;
        private POSeidonDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter2;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace POSeidon
{
    public partial class frmPOS : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        //Employee EmpList = new Employee();
        List<Employee> myEmpList = new List<Employee>();
        Customer myCustomer = new Customer();

        public frmPOS()
        {
            frmLog frmlogin = new frmLog();
            frmlogin.Show();
            this.Opacity = 0;//to hide the POS
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\POSeidon.accdb;Persist Security Info=True";
        }


        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmNewEmployee newEmp = new frmNewEmployee();
            newEmp.Show();

        }


        private void tabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPanel.SelectedTab == tabPage4)
            {//this is probably unneeded once Databases are working
                LoadCustomers();
            }

            if (tabPanel.SelectedTab == tabPage2)
            {
                loadEmployees();

            }

            if(tabPanel.SelectedTab == tabPage1)
            {
                loadSalesHistory();
            }

            if(tabPanel.SelectedTab == tabPage3)
            {
                loadInventory();
            }
        }

        private void LoadCustomers()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * from CustomerTable";
                command.CommandText = query;

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCustomer.DataSource = dataTable;

                connection.Close();
            }

            catch (Exception ex) { }

        }

        private void SaveCustomers()
        {
            //this is probably unneeded once Databases are working
        }

        private void btnLoyalty_Click(object sender, EventArgs e)
        {//Anything else related to loyalty can go here in the information
            MessageBox.Show("Loyalty Information:\n" + "Free shipping\n" + "10% Off\n" + "Exclusive offers in store\n");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void loadEmployees()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select FirstName, LastName, ManagerStatus, FullTimeStatus, SalesTeam from EmployeeTable";
                command.CommandText = query;

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                dgvEmployee.DataSource = dataTable;
                
               
                connection.Close();
            }
            catch (Exception) { }
        }

        private void loadSalesHistory()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select * from SalesHistory";
                command.CommandText = query;

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                dgvSalesHistory.DataSource = dataTable;
               
                connection.Close();
            }
            catch (Exception) { }
        }

        private void loadInventory()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * from InventoryTable";
                command.CommandText = query;

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                dgvInventory.DataSource = dataTable;
                
                connection.Close();
            }
            catch (Exception) { }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
            }*/
        } //this is eventually for changes in the datagridview 

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {/* This ended up deleting everything from the customer table :(
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                DataGridViewRow delrow = dgvCustomer.Rows[i];
                if(delrow.Selected == true)
                {
                    dgvCustomer.Rows.RemoveAt(i);
                }
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM CustomerTable WHERE ID=" + i + "";
                   
                    command.ExecuteNonQuery();
                    
                }
                catch(Exception expt) { }
            }

            foreach(DataGridViewRow row in dgvCustomer.Rows)
            {
                if (row.Selected)
                {
                    dgvCustomer.Rows.RemoveAt(row.Index);
                    break;
                }
            }
            connection.Close();
        }*/
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer customer = new frmNewCustomer();
            customer.Show();
            
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
         
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmInventory item = new frmInventory();
            item.Show();
        }

        private void btnReloadInventory_Click(object sender, EventArgs e)
        {
            loadInventory();
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSales.Text;

            if(searchText != String.Empty)
            {
                try
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    command.CommandText = @"SELECT Item FROM InventoryTable WHERE id = Item LIKE '@searchText%'";
                    command.Parameters.Add("@searchText", OleDbType.VarChar, 50).Value = searchText;

                    command.ExecuteNonQuery();

                    lstSale.DataSource = inventoryTableTableAdapter1;
                    lstSale.DisplayMember = "Item" + "Price";
                    connection.Close();
                }

                catch (Exception) { }
            }
            
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
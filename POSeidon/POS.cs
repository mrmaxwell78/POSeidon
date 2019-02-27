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
        DataTable dataTable;
        private bool btnSaleClicked = false;
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
                DataTable dataTableS = new DataTable();
                oleDbDataAdapter.Fill(dataTableS);
                dgvSalesHistory.DataSource = dataTableS;
               
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

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer customer = new frmNewCustomer();
            customer.Show();
            
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


        private void btnSale_Click(object sender, EventArgs e)
        {
            string tempSKU = string.Empty;
            string tempItem, tempQuant, tempPrice = "";

            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("Item LIKE '%{0}%'", txtSales.Text); //OR SKU LIKE '%{0}%'

            tempSKU = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
            tempItem = dgvSales.SelectedRows[0].Cells[1].Value.ToString();
            tempQuant = dgvSales.SelectedRows[0].Cells[2].Value.ToString();
            tempPrice = dgvSales.SelectedRows[0].Cells[3].Value.ToString();
            int quantity = Int32.Parse(tempQuant);
           
         

            try {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
               
                string cmdTxt = "INSERT INTO SalesHistory (Item, Price, SKU, Quantity) VALUES (@Item, @Price, @SKU, @Quantity) ";
                command.CommandText = cmdTxt;

                command.Parameters.Add("@Item", OleDbType.VarChar, 15).Value = tempItem;
                command.Parameters.Add("@Price", OleDbType.Decimal, 1000).Value = Double.Parse(tempPrice);
                command.Parameters.Add("@SKU", OleDbType.VarChar, 6).Value = tempSKU;
                command.Parameters.Add("@Quantity", OleDbType.Integer, 32).Value = tempQuant;

                command.ExecuteNonQuery();

                /*string cmdTxt2 = "UPDATE Quantity in InvetoryTable WHERE Item = tempItem VALUES (@Quantity -1)";
                command.CommandText = cmdTxt2;
                command.ExecuteNonQuery(); */

                connection.Close();
            }
           catch(Exception ex) { }
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("Item LIKE '%{0}%'", txtSales.Text); //OR SKU LIKE '%{0}%'
            dgvSales.DataSource = dv;
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT SKU, Item, Quantity, Price from InventoryTable";
                command.CommandText = query;

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(command);
                dataTable = new DataTable();
                oleDbDataAdapter.Fill(dataTable);
                dgvSales.DataSource = dataTable;

                connection.Close();

            }

            catch (Exception ex) { }
        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
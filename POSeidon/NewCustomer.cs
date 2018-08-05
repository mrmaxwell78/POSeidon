using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class frmNewCustomer : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private DataAccess data = new DataAccess();

        public frmNewCustomer()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\POSeidon.accdb;Persist Security Info=True";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool loyal = loyaltyStatus();

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command.CommandText = "INSERT into CustomerTable (First Name, Last Name, Address, Phone, Email, Loyalty) VALUES (@First Name, @Last Name, @Address, @Phone, @Email, @Loyalty)";
            command.Parameters.Add("@First Name", OleDbType.VarChar, 15).Value = txtNewCustomerFirst.Text;
            command.Parameters.Add("@Last Name", OleDbType.VarChar, 15).Value = txtNewCustomerLast.Text;
            command.Parameters.Add("@Address", OleDbType.VarChar, 50).Value = txtNewCustomerAddress.Text;
            command.Parameters.Add("@Phone", OleDbType.VarChar, 10).Value = txtNewCustomerPhone.Text;
            command.Parameters.Add("@Email", OleDbType.VarChar, 25).Value = txtNewCustomerEmail.Text;
            command.Parameters.Add("@Loyalty", OleDbType.Boolean).Value = loyal;

            command.ExecuteNonQuery();

            data.tempCust.FirstName = txtNewCustomerFirst.Text;
            data.tempCust.LastName = txtNewCustomerLast.Text;
            data.tempCust.Address1 = txtNewCustomerAddress.Text;
            data.tempCust.Phone1 = txtNewCustomerPhone.Text;
            data.tempCust.Email1 = txtNewCustomerEmail.Text;
            data.tempCust.Loyal = loyal;

            data.cusList.Add(data.tempCust);

            command.Connection.Close();
            connection.Close();
        }

        private bool loyaltyStatus()
        {
            if (chkCustomerLoyalty.Checked)
                return true;
            else
                return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

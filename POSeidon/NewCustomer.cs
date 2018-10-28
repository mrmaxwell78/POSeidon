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
            bool loyal = loyaltyStatus(); //convert to boolean status
            try//try to add to the database
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "INSERT into CustomerTable ([First_Name], [Last_Name], Address, Phone, Email, Loyalty) VALUES (@First_Name, @Last_Name, @Address, @Phone, @Email, @Loyalty)";
                command.Parameters.Add("@First_Name", OleDbType.VarChar, 15).Value = txtNewCustomerFirst.Text;
                command.Parameters.Add("@Last_Name", OleDbType.VarChar, 15).Value = txtNewCustomerLast.Text;
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

                data.cusList.Add(data.tempCust);//add to customerList in data class

                connection.Close();

                MessageBox.Show("Added");

                this.Close();
            }
            catch (Exception) { }
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

        private void txtNewCustomerFirst_Validating(object sender, CancelEventArgs e)
        {//Check name for digits and if the textbox is empty
            if (txtNewCustomerFirst.Text == string.Empty)//check to see if the textbox is empty
            {
                MessageBox.Show("Please enter a first name.");
                e.Cancel = true;
            }

            if (txtNewCustomerFirst.Text != string.Empty)//check to see if the textbox is not empty
            {
                char.ToUpper(txtNewCustomerFirst.Text[0]);//if not empty, upper case the first char

                for (int i = 0; i < txtNewCustomerFirst.Text.Length; i++)//itterate through the string and determine the chars are all letters
                {
                    if (char.IsDigit(txtNewCustomerFirst.Text[i]))//if char is a digit, show message
                    {
                        MessageBox.Show("Please no digits.");
                        e.Cancel = true;
                    }

                }
            }
        }

        private void txtNewCustomerLast_Validating(object sender, CancelEventArgs e)
        {//Check name for digits and if the textbox is empty
            if (txtNewCustomerLast.Text == string.Empty)//check to see if the textbox is empty
            {
                MessageBox.Show("Please enter a first name.");
                e.Cancel = true;
            }

            if (txtNewCustomerLast.Text != string.Empty)//check to see if the textbox is not empty
            {
                char.ToUpper(txtNewCustomerLast.Text[0]);//if not empty, upper case the first char

                for (int i = 0; i < txtNewCustomerLast.Text.Length; i++)//itterate through the string and determine the chars are all letters
                {
                    if (char.IsDigit(txtNewCustomerLast.Text[i]))//if char is a digit, show message
                    {
                        MessageBox.Show("Please no digits.");
                        e.Cancel = true;
                    }

                }
            }
        }
    }
}

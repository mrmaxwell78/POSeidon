using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace POSeidon
{
    public partial class frmNewEmployee : Form
    {
        //Access DB connection
        private OleDbConnection connection = new OleDbConnection();

        DataAccess data = new DataAccess();


        public frmNewEmployee()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Matt\Desktop\POSeidon\POSeidon.accdb;Persist Security Info=True";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {//This needs to be fixed!
           // frmPOS.LoadEmployees(empList);
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool manager, time, sales, payment = false;
            if (isValidEntry())
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    manager = ManagerStatus();
                    time = TimeStatus();
                    sales = SalesStatus();
                    payment = PaymentStatus();

                    command.CommandText = "INSERT into EmployeeTable (FirstName, LastName, ManagerStatus, FullTimeStatus, SalesTeam, PaymentOption, Wages, Username, [Password]) VALUES (@FirstName, @LastName, @ManagerStatus, @FullTimeStatus, @SalesTeam, @PaymentOption, @Wages, @Username, @Password)";


                    command.Parameters.Add("@FirstName", OleDbType.VarChar, 15).Value = txtNewName.Text;
                    command.Parameters.Add("@LastName", OleDbType.VarChar, 15).Value = txtNewLastName.Text;
                    command.Parameters.Add("@ManagerStatus", OleDbType.Boolean).Value = manager;
                    command.Parameters.Add("@FullTimeStatus", OleDbType.Boolean).Value = time;
                    command.Parameters.Add("@SalesTeam", OleDbType.Boolean).Value = sales;
                    command.Parameters.Add("@PaymentOption", OleDbType.Boolean).Value = payment;
                    command.Parameters.Add("@Wages", OleDbType.Currency).Value = nudWage.Value;
                    command.Parameters.Add("@Username", OleDbType.VarChar).Value = txtUserName.Text;
                    command.Parameters.Add("@Password", OleDbType.VarChar).Value = txtPassword.Text;

                    command.ExecuteNonQuery();

                    /*
                    //FileStream to output to a text file
                    FileStream outfile = new FileStream("Employees.txt", FileMode.Append);
                    //StreamWriter is the one that actually writes to the file
                    StreamWriter fileWriter = new StreamWriter(outfile);
                    //get data from form
                    data.tempEmp.FirstName = txtNewName.Text;
                    data.tempEmp.LastName = txtNewLastName.Text;
                    data.tempEmp.EmpManager = ManagerStatus();
                    data.tempEmp.EmpFullTime = TimeStatus();
                    data.tempEmp.EmpSales = SalesStatus();
                    data.tempEmp.EmpPay = PaymentStatus();
                    data.tempEmp.Wages = Convert.ToDouble(nudWage.Value);
                    data.tempEmp.UserName = txtUserName.Text;
                    data.tempEmp.Password = txtPassword.Text;

                    fileWriter.WriteLine(data.tempEmp.FirstName + ", " + data.tempEmp.LastName + ", "
                        + data.tempEmp.EmpManager + ", " + data.tempEmp.EmpFullTime + ", " + data.tempEmp.EmpSales +
                        ", " + data.tempEmp.EmpPay + ", " + data.tempEmp.Wages + ", " + data.tempEmp.UserName + ", " + data.tempEmp.Password);
                        */
                    MessageBox.Show("Saved");

                    data.empList.Add(data.tempEmp);
                    connection.Close();
                    //fileWriter.Close();
                    //outfile.Close();
                }

                catch (Exception exp) { }

            }

            this.Close();
        }

        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {//check to see which radio button is clicked and update the label accordingly
            if (rdoSalary.Checked == true)
            {
                lblPay.Text = "Weekly Salary";
            }
            else
            {
                lblPay.Text = "Hourly Rate";
            }
        }

        private bool isValidEntry()//method to determine if all of the user input is valid
        {
            if (txtNewName.Text == string.Empty)//check to see if the textbox is empty
            {
                MessageBox.Show("Please enter a first name.");
                return false;
            }

            if (txtNewName.Text != string.Empty)//check to see if the textbox is not empty
            {
                char.ToUpper(txtNewName.Text[0]);//if not empty, upper case the first char

                for (int i = 0; i < txtNewName.Text.Length; i++)//itterate through the string and determine the chars are all letters
                {
                    if (char.IsDigit(txtNewName.Text[i]))//if char is a digit, show message
                    {
                        MessageBox.Show("Please no digits.");
                        return false;
                    }

                }
            }

            if (txtNewLastName.Text == string.Empty)//check to see if the textbox is empty
            {
                MessageBox.Show("Please enter a last name.");
                return false;
            }

            if (txtNewLastName.Text != string.Empty)
            { //itterate through the string and determine the chars are all letters
                for (int i = 0; i < txtNewLastName.Text.Length; i++)
                {
                    if (char.IsDigit(txtNewLastName.Text[i]))//if char is a digit show message
                    {
                        MessageBox.Show("Please no digits.");
                        return false;
                    }
                }
            }

            if (!rdoManagerYes.Checked && !rdoManagerNo.Checked)//check that one radio buttons is checked
            {
                MessageBox.Show("Please select if the new Employee is a manager or not.");
                return false;
            }

            if (!rdoTimeYes.Checked && !rdoTimeNo.Checked)//check that one radio button is checked
            {
                MessageBox.Show("Please indicate if they are full time or not.");
                return false;
            }

            if (!rdoSalesYes.Checked && !rdoSalesNo.Checked)//check that one radio button is checked
            {
                MessageBox.Show("Please indicate if they are a sales team member or not.");
                return false;
            }

            if (!rdoSalary.Checked && !rdoHourly.Checked)//check that one radio button is checked
            {
                MessageBox.Show("Please indicate if this person is paid hourly or a weekly salary.");
                return false;
            }

            else//if this all passes, return true and proceed
                return true;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (nudWage.Value.ToString().Length >= 4)
            {
                MessageBox.Show("Please input in this format: XX.XX");
            }
        }

        private bool ManagerStatus()
        {
            if (rdoManagerYes.Checked)
                return true;
            else
                return false;
        }

        private bool TimeStatus()
        {
            if (rdoTimeYes.Checked)
                return true;
            else
                return false;
        }

        private bool SalesStatus()
        {
            if (rdoSalesYes.Checked)
                return true;
            else
                return false;
        }

        private bool PaymentStatus()
        {
            if (rdoSalary.Checked)
                return true;
            else
                return false;
        }
    }
}

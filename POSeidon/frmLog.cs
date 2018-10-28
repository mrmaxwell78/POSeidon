using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class frmLog : Form
    {   //Access DB connection
        private OleDbConnection connection = new OleDbConnection();

        public frmLog()
        {
            InitializeComponent();
       
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\POSeidon.accdb;Persist Security Info=True";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = false;

            //Open the connection
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;//Set command to the connection string
            command.CommandText = "select Username, [Password] from EmployeeTable where Username='" + txtUsername.Text + "' and [Password]='" + txtPassword.Text + "'";
            //Look for login info from the table^
            OleDbDataReader reader = command.ExecuteReader(); //Execute the command statement
            int count = 0; 
            while (reader.Read())
            {//Read from the database and look for matching
                count++;
            }
            if(count == 1)//One Match
            {
                //MessageBox.Show("Username and password is correct.");
                login = true;
            }
            else if(count > 1)//More than one match
            {
                MessageBox.Show("Duplicate Username and password.");
            }
            else//No match
            {
                MessageBox.Show("Incorrect Login info");
            }

            command.Connection.Close();
            connection.Close();


            if (login == true)
            {

                this.Close(); //close the frmlog
                frmPOS.ActiveForm.Opacity = 100; // show the form

            }
           
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPOS.ActiveForm.Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}

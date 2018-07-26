using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class frmLog : Form
    {
        private Employee tempEmp = new Employee();

        public frmLog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = false;

            //try login here
            try
            {
                FileStream inFile = new FileStream("Employees.txt", FileMode.Open);

                StreamReader sReader = new StreamReader(inFile);

                Employee tempEmp = new Employee();

                string line;
                //priming read
                line = sReader.ReadLine();

                string[] fields = new string[9];
                char[] sep = new char[1];
                sep[0] = ',';

                while (line != null)
                {
                    tempEmp = new Employee();

                    fields = line.Split(sep);
                    tempEmp.FirstName = fields[0];
                    tempEmp.LastName = fields[1];
                    tempEmp.EmpManager = Convert.ToBoolean(fields[2]);
                    tempEmp.EmpFullTime = Convert.ToBoolean(fields[3]);
                    tempEmp.EmpSales = Convert.ToBoolean(fields[4]);
                    tempEmp.EmpSales = Convert.ToBoolean(fields[5]);
                    tempEmp.Wages = Convert.ToDouble(fields[6]);
                    tempEmp.UserName = fields[7];
                    tempEmp.Password = fields[8];


                    line = sReader.ReadLine();
                }

                sReader.Close();
                inFile.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File not found!");
            }

            //try login here
            if (txtUsername.Text == tempEmp.UserName)
                if (txtPassword.Text == tempEmp.Password)
                    login = true;
            //and then when it success update login variable as true

            if (login == true)
            {

                this.Close(); //close the frmlog
                frmPOS.ActiveForm.Opacity = 100; // show the form

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPOS.ActiveForm.Close();
        }
    }
}

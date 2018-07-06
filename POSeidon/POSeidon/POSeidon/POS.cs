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

namespace POSeidon
{
    public partial class frmPOS : Form
    {
        //Employee EmpList = new Employee();
        List<Employee> myEmpList = new List<Employee>();

        public frmPOS()
        {
            InitializeComponent();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmNewEmployee newEmp = new frmNewEmployee();
            newEmp.Show();

            try
            {
                FileStream inFile = new FileStream("Employees.txt", FileMode.Open);

                StreamReader sReader = new StreamReader(inFile);

                Employee tempEmp = new Employee();

                string line;
                //priming read
                line = sReader.ReadLine();

                string[] fields = new string[7];
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

                    myEmpList.Add(tempEmp);

                    line = sReader.ReadLine();
                }
                sReader.Close();
                inFile.Close();

            }
            catch (FileNotFoundException) { }
        }



        private void chkEmp1Time_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmp1Time.Checked)
                chkEmp1Time.Text = "Yes";
            else
                chkEmp1Time.Text = "No";
        }
    }
}
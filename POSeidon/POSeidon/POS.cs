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
        Customer myCustomer = new Customer();

        public frmPOS()
        {
            //frmLogin frmlog = new frmLogin();
            //frmlog.Show();
            //this.Opacity = 0;//to hide the POS
            InitializeComponent();
        }

        /*This is for frmlog
         * private void btlogin_Click(object sender, EventArgs e)
            {
                bool login = false;

                //try your login here 
               //and then when it success update login variable as true

        if(login == true){

            this.Close(); //close the frmlog
            frmPOS.ActiveForm.Opacity = 100; // show the form

        }else{
              //inform user about failed login
        }
}
         */

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmNewEmployee newEmp = new frmNewEmployee();
            newEmp.Show();
            
            /*
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
            catch (FileNotFoundException) { } */ //this was experimenting to see if reading would work
        }


        public void LoadEmployees(List<Employee> employees)//I'm not sure if this will work, testing to see if it will
        {//This is probably also unneeded once databases are working
            myEmpList = employees.ToList();
            foreach (Employee tempEmp in myEmpList)
            {/*Need to figure out a way to update lbls via a foreach loop
                lblEmp1.Text = myEmpList[0].FirstName;
                chkEmp1Time.Checked = Convert.ToBoolean(myEmpList[0].EmpFullTime);
                rdoEmp1Manager.Checked = Convert.ToBoolean(myEmpList[0].EmpManager);
                rdoEmp1Sales.Checked = Convert.ToBoolean(myEmpList[0].EmpSales);*/
            }
        }
      

        private void chkEmp1Time_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmp1Time.Checked)
                chkEmp1Time.Text = "Yes";
            else
                chkEmp1Time.Text = "No";
        }

        private void tabPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPanel.SelectedTab == tabPage4)
            {//this is probably unneeded once Databases are working
                LoadCustomers();
                SaveCustomers();
            }
        }

        private void LoadCustomers()
        {
            //this is probably unneeded once Databases are working
        }

        private void SaveCustomers()
        {
            //this is probably unneeded once Databases are working
        }

        private void btnLoyalty_Click(object sender, EventArgs e)
        {//Anything else related to loyalty can go here in the information
            MessageBox.Show("Loyalty Information:\n" + "Free shipping\n" + "10% Off\n" + "Exclusive offers in store\n");
        }
    }
}
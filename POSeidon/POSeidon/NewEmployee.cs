using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class frmNewEmployee : Form
    {
        public frmNewEmployee()
        {
            InitializeComponent();
        }

 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtNewName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }

            if(txtNewLastName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a last name.");
                return;
            }

            if(!rdoManagerYes.Checked && !rdoManagerNo.Checked)
            {
                MessageBox.Show("Please select if the new Employee is a manager or not.");
                return;
            }

            if(!rdoTimeYes.Checked && !rdoTimeNo.Checked)
            {
                MessageBox.Show("Please indicate if they are full time or not.");
                return;
            }

            if(!rdoSalesYes.Checked && !rdoSalesNo.Checked)
            {
                MessageBox.Show("Please indicate if they are a sales team member or not.");
                return;
            }

            if(!rdoSalary.Checked && !rdoHourly.Checked)
            {
                MessageBox.Show("Please indicate if this person is paid hourly or a weekly salary.");
                return;
            }
        }

        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoSalary.Checked == true)
            {
                lblPay.Text = "Weekly Salary";
            }
            else
            {
                lblPay.Text = "Hourly Rate";
            }
        }
    }
}

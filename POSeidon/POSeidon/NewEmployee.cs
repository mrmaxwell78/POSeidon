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
            if (isValidEntry())
            {
                MessageBox.Show("Data is saved.");
                //insert database commands here  
            }
 
            this.Close();
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

         private bool isValidEntry()
        {
                if (txtNewName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a first name.");
                    return false;
                }
                
                if(txtNewName.Text != string.Empty)
                {
                    char.ToUpper(txtNewName.Text[0]);

                    for(int i = 0; i < txtNewName.Text.Length; i++)
                    {
                    if (char.IsDigit(txtNewName.Text[i]))
                        {
                            MessageBox.Show("Please no digits.");
                            return false;
                        }
                        
                    }
                }

                if (txtNewLastName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a last name.");
                    return false;
                }

                if(txtNewLastName.Text != string.Empty)
                {
                    for(int i = 0; i < txtNewLastName.Text.Length; i++)
                    {
                    if (char.IsDigit(txtNewLastName.Text[i]))
                        {
                            MessageBox.Show("Please no digits.");
                            return false;
                        }
                    }
                }

                if (!rdoManagerYes.Checked && !rdoManagerNo.Checked)
                {
                    MessageBox.Show("Please select if the new Employee is a manager or not.");
                    return false;
                }

                if (!rdoTimeYes.Checked && !rdoTimeNo.Checked)
                {
                    MessageBox.Show("Please indicate if they are full time or not.");
                    return false;
                }

                if (!rdoSalesYes.Checked && !rdoSalesNo.Checked)
                {
                    MessageBox.Show("Please indicate if they are a sales team member or not.");
                    return false;
                }

                if (!rdoSalary.Checked && !rdoHourly.Checked)
                {
                    MessageBox.Show("Please indicate if this person is paid hourly or a weekly salary.");
                    return false;
                }

                else
                    return true;
                  
            }
        }
    }

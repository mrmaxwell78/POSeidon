﻿using System;
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
                //insert database commands here to load data to the database.
            }
 
            this.Close();
        }

        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {//check to see which radio button is clicked and update the label accordingly
            if(rdoSalary.Checked == true)
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
                
                if(txtNewName.Text != string.Empty)//check to see if the textbox is not empty
                {
                    char.ToUpper(txtNewName.Text[0]);//if not empty, upper case the first char

                    for(int i = 0; i < txtNewName.Text.Length; i++)//itterate through the string and determine the chars are all letters
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

                if(txtNewLastName.Text != string.Empty)
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
            if (numericUpDown1.Value.ToString().Length >= 4)
            {
                MessageBox.Show("Please input in this format: XX.XX");
            }
        }
    }
    }

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
    public partial class frmLog : Form
    {   //these probably aren't needed
        private string userName;
        private string password;

        public frmLog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = false;

            //try login here
            if (txtUsername.Text == "maxw" || txtUsername.Text == "dwil" || txtUsername.Text == "mker")
                if (txtPassword.Text == "password" || txtPassword.Text == "login")
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

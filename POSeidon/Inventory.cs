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
    public partial class frmInventory : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public frmInventory()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\POSeidon.accdb;Persist Security Info=True";
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            { //go through and add to the table
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "INSERT into InventoryTable (Item, Price, SKU, Description, Quantity) VALUES (@Item, @Price, @SKU, @Description, @Quantity)";
                command.Parameters.Add("@Item", OleDbType.VarChar, 25).Value = txtItemName.Text;
                command.Parameters.Add("@Price", OleDbType.Currency).Value = Convert.ToDouble(txtPrice.Text);
                command.Parameters.Add("@SKU", OleDbType.VarChar, 10).Value = txtSKU.Text;
                command.Parameters.Add("@Description", OleDbType.VarChar, 100).Value = txtItemDescription.Text;
                command.Parameters.Add("@Quantity", OleDbType.Integer).Value = txtQuantity.Text;

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Added");

                this.Close();
            }
            catch(Exception) { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtItemName_Validating(object sender, CancelEventArgs e)
        {//if empty cancel
            if (txtItemName.Text == string.Empty)
                e.Cancel = true;
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {//if empty cancel
            if (txtPrice.Text == string.Empty)
                e.Cancel = true;
        }

        private void txtSKU_Validating(object sender, CancelEventArgs e)
        {//if empty cancel
            if (txtSKU.Text == string.Empty)
                e.Cancel = true;
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {//if empty cancel
            if (txtQuantity.Text == string.Empty)
                e.Cancel = true;
        }
    }
}

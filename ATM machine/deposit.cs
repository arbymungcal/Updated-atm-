using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_machine
{
    public partial class deposit : Form
    {
        private string selectedBillType;
        public deposit()
        {
            InitializeComponent();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void deposit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            double amount;
            // Parse the text to double
            double.TryParse(amountTextBox.Text, out amount);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double amount;
            // Check if the text in amountTextBox is convertible to double
            if (double.TryParse(amountTextBox.Text, out amount))
            {
                // Optionally, you can update the cheque and savings variables here if needed
                Pub.cheque += amount;
                Pub.savings += amount;

                balance showreceipt = new balance(selectedBillType, amount);
                this.Hide();
                showreceipt.Show();
            }
            else
            {
                // Display an error message or take appropriate action if the input is not a valid double
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

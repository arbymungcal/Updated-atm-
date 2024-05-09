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
    public partial class withdraw : Form
    {
        private string selectedBillType;
        public withdraw()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            double inputValue;
            if (double.TryParse(textBox1.Text, out inputValue))
            {
                double amount;
                // Parsing successful, inputValue now holds the parsed double value
                double.TryParse(textBox1.Text, out amount);
                // You can use inputValue as needed
            }
            else
            {
                // Parsing failed, handle invalid input if needed
                // For example, display an error message
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(textBox1.Text, out amount))
            {
                // Check if the amount is greater than savings
                if (amount > Pub.savings)
                {
                    // Display a message indicating insufficient funds
                    MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                // Subtract the amount from both cheque and savings
                Pub.cheque -= amount;
                Pub.savings -= amount;

                balance balanceForm = new balance(selectedBillType, amount);
                this.Hide();
                balanceForm.Show();
            }
            else
            {
                // Display an error message if the input is not a valid double
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

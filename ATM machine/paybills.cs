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
    
    public partial class paybills : Form
    {
        private string selectedBillType;
        private double amount;
        public paybills()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedItem != null)
            {
                selectedBillType = guna2ComboBox1.SelectedItem.ToString();

                switch (selectedBillType)
                {
                    case "WaterBill":
                    case "ElectricityBill":
                    case "CreditCardBill":
                        balance billreceipt = new balance(selectedBillType, amount);
                        break;
                    default:
                        MessageBox.Show("Ivalid Choice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            else
            {
                MessageBox.Show("Please select bill to pay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(textBox1.Text, out amount))
            {
                // Subtract the amount from both cheque and savings
                Pub.cheque -= amount;
                Pub.savings -= amount;

                balance balance = new balance(selectedBillType, amount);
                this.Hide();
                balance.Show();
            }
            else
            {
                // Display an error message if the input is not a valid double
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paybills_Load(object sender, EventArgs e)
        {

        }
    }
}

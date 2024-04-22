using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P05_Melvin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //METHods
        private bool ValidateInput(string Input)
        {
            if (string.IsNullOrEmpty(Input))
            {
                MessageBox.Show("Enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.IsNullOrEmpty(Input))
            {
                //Convert to decimal
                if (double.TryParse(Input, out double doubleValue))
                {
                    if (doubleValue >= 0) //positive val
                    {
                        return true; //valid
                    }
                }
            }

            MessageBox.Show("Enter a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private bool ValidateAllData()
        {
            if (!ValidateInput(txtBorrowed.Text))
            {
                return false;
            }
            if (!ValidateInput(txtInterest.Text))
            {
                return false;
            }
            if (!ValidateInput(txtMonthlyPayment.Text))
            {
                return false;
            }
            if (!ValidateInput(txtMonthsRepay.Text))
            {
                return false;
            }
            if (!ValidateInput(txtPaid.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private double ReturnValues()
        {
            double Borrowed;
            double Interest;
            double monthlyPayment;
            double monthsRepay;
            double Paid;

            Borrowed = double.Parse(txtBorrowed.Text);
            Interest = double.Parse(txtInterest.Text);
            monthlyPayment = double.Parse(txtMonthlyPayment.Text);
            monthsRepay = double.Parse(txtMonthsRepay.Text);
            Paid = double.Parse(txtPaid.Text);
        }

        //BTN

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateAllData();


                // textBoxResults.Text = $"Total Amount Paid: {totalAmountPaid:C}\r\nNumber of Months Left: {numberOfMonthsLeft}";

            }
            catch 
            {
                MessageBox.Show("Invlauid data entered");
            }
        }

    }
}

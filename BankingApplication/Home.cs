using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Home : Form
    {
        public decimal currentBalance = 0;
        decimal interest = .05M;
        public Home()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (currentBalance > 0)
            {
                decimal withdrawAmount = Convert.ToDecimal(txtWithdraw.Text);

                if (withdrawAmount <= currentBalance && withdrawAmount > 0)
                {
                    lbxBalance.Items.Add("Withdrew: $" + withdrawAmount);
                    currentBalance = currentBalance - withdrawAmount;
                    lbxBalance.Items.Add("Current Balace: $" + Math.Round(currentBalance, 2));
                    lblBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                    lblOutput.Text = "";
                }
                else
                {
                    lblOutput.Text = "Amount withdrawn must be greater than 0, but less than the amount in your balance.";
                }
            }
            else
            {
                lblOutput.Text = "I'm sorry, you do not have sufficient funds for that request.";
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal depositedAmount = Convert.ToDecimal(txtDeposit.Text);

                if (depositedAmount > 0)
                {
                    lbxBalance.Items.Add("Deposited: $" + depositedAmount);
                    currentBalance = currentBalance + depositedAmount;
                    lbxBalance.Items.Add("Current Balace: $" + Math.Round(currentBalance, 2));
                    lblBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                    lblOutput.Text = "";
                }
                else
                {
                    lblOutput.Text = "Please deposit an amount.";
                }
            }
            catch (Exception)
            {
                lblOutput.Text = "ERROR: You must enter a number";
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            currentBalance = currentBalance + (currentBalance * interest);
            lbxBalance.Items.Add("Interest Added: " + Convert.ToString(Math.Round(interest * 100, 0) + "%"));
            lbxBalance.Items.Add("Current Balace: $" + Math.Round(currentBalance, 2));
            lblBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
        }

        private void btnBull_Click(object sender, EventArgs e)
        {
            interest = .10M;
        }

        private void btnBear_Click(object sender, EventArgs e)
        {
            interest = .02M;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxBalance.Items.Clear();
            lblBalance.Text = "";
            lblOutput.Text = "";
            txtDeposit.Clear();
            txtWithdraw.Clear();
            interest = .05M;
            currentBalance = 0;
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            Stocks s1 = new Stocks();         
            s1.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}

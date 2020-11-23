using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
1 --> -10%
2 --> -5%
3 --> -1%
4 --> 1%
5 --> 5%
6 --> 7%
7 --> 10%
8 --> 14%
9 --> 18%
10 --> 25%
 */

namespace BankingApplication
{
    public partial class Stocks : Form
    {
        public static decimal[] percents = { -.10M, -.05M, -.01M, .01M, .05M, .07M, .10M, .14M, .18M, .25M };
        public static Random random = new Random();
        decimal currentBalance = Home.currentBalance;
        public Stocks()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            txtInvest.Clear();
            cbxAcer.Checked = false;
            cbxApple.Checked = false;
            cbxFacebook.Checked = false;
            cbxIntel.Checked = false;
            cbxMicrosoft.Checked = false;
            cbxRyzen.Checked = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            lblCurrentBalance.Text = "$" + Convert.ToString(currentBalance);
        }

        private void btnInvest_Click(object sender, EventArgs e)
        {
            decimal acer = percents[random.Next(percents.Length)];
            decimal apple = percents[random.Next(percents.Length)];
            decimal facebook = percents[random.Next(percents.Length)];
            decimal intel = percents[random.Next(percents.Length)];
            decimal microsoft = percents[random.Next(percents.Length)];
            decimal ryzen = percents[random.Next(percents.Length)];

            if (currentBalance > 0)
            {
                try
                {
                    decimal investedAmount = Convert.ToDecimal(txtInvest.Text);
                    if (investedAmount < currentBalance && investedAmount > 0)
                    {
                        lblOutput.Text = "";

                        if (cbxAcer.Checked)
                        {
                            if (cbxApple.Checked)
                            {
                                if (cbxFacebook.Checked)
                                {
                                    if (cbxIntel.Checked)
                                    {
                                        if (cbxMicrosoft.Checked)
                                        {
                                            if (cbxRyzen.Checked)
                                            {
                                                MessageBox.Show("Your Return: " + Convert.ToString(Math.Round((((acer + apple + facebook + intel + microsoft + ryzen) / 6) * 100), 2) + "%"));
                                                lbxOutput.Items.Add("You purchased: Acer, Apple, Facebook, Intel, Microsoft, and Ryzen Stock.");
                                                currentBalance = currentBalance + (((acer + apple + facebook + intel + microsoft + ryzen) / 6) * investedAmount);
                                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                            }
                                            else
                                            {
                                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel + microsoft) / 5) * 100) + "%");
                                                lbxOutput.Items.Add("You purchased: Acer, Apple, Facebook, Intel, and Microsoft Stock.");
                                                currentBalance = currentBalance + (((acer + apple + facebook + intel + microsoft) / 5) * investedAmount);
                                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                            }
                                        }
                                        else if (cbxRyzen.Checked)
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel + ryzen) / 5) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Apple, Facebook, Intel, and Ryzen Stock.");
                                            currentBalance = currentBalance + (((acer + apple + facebook + intel + ryzen) / 5) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel) / 4) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Apple, Facebook, and Intel Stock.");
                                            currentBalance = currentBalance + (((acer + apple + facebook + intel) / 4) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                    }
                                    else if (cbxMicrosoft.Checked)
                                    {
                                        if (cbxRyzen.Checked)
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + microsoft + ryzen) / 5) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Apple, Facebook, Microsoft, and Ryzen Stock.");
                                            currentBalance = currentBalance + (((acer + apple + facebook + microsoft + ryzen) / 5) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + microsoft) / 4) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Apple, Facebook, and Microsoft Stock.");
                                            currentBalance = currentBalance + (((acer + apple + facebook + microsoft) / 4) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                    }
                                    else if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Apple, Facebook, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((acer + apple + facebook + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Apple, and Facebook Stock.");
                                        currentBalance = currentBalance + (((acer + apple + facebook) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxIntel.Checked)
                                {
                                    if (cbxMicrosoft.Checked)
                                    {
                                        if (cbxRyzen.Checked)
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel + microsoft + ryzen) / 5) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Apple, Intel, Microsoft, and Ryzen Stock.");
                                            currentBalance = currentBalance + (((acer + apple + intel + microsoft + ryzen) / 5) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel + microsoft) / 4) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Apple, Intel, and Microsoft Stock.");
                                            currentBalance = currentBalance + (((acer + apple + intel + microsoft) / 4) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                    }
                                    else if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Apple, Intel, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((acer + apple + intel + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Apple, and Intel Stock.");
                                        currentBalance = currentBalance + (((acer + apple + intel) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxMicrosoft.Checked)
                                {
                                    if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + microsoft + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Apple, Microsoft, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((acer + apple + microsoft + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + microsoft) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Apple,, and Microsoft Stock.");
                                        currentBalance = currentBalance + (((acer + apple + microsoft) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer, Apple, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((acer + apple + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer, and Apple Stock.");
                                    currentBalance = currentBalance + (((acer + apple) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxFacebook.Checked)
                            {
                                if (cbxIntel.Checked)
                                {
                                    if (cbxMicrosoft.Checked)
                                    {
                                        if (cbxRyzen.Checked)
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + intel + microsoft + ryzen) / 5) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Facebook, Intel, Microsoft, and Ryzen Stock.");
                                            currentBalance = currentBalance + (((acer + facebook + intel + microsoft + ryzen) / 5) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + intel + microsoft) / 4) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Acer, Facebook, Intel, and Microsoft Stock.");
                                            currentBalance = currentBalance + (((acer + facebook + intel + microsoft) / 4) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                    }
                                    else if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + intel + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Facebook, Intel, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((acer + facebook + intel + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + intel) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Facebook, and Intel Stock.");
                                        currentBalance = currentBalance + (((acer + facebook + intel) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxMicrosoft.Checked)
                                {
                                    if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + microsoft + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Facebook, Microsoft, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((acer + facebook + microsoft + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + microsoft) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Facebook, and Microsoft Stock.");
                                        currentBalance = currentBalance + (((acer + facebook + microsoft) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer, Facebook, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((acer + facebook + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer and Facebook Stock.");
                                    currentBalance = currentBalance + (((acer + facebook) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxIntel.Checked)
                            {
                                if (cbxMicrosoft.Checked)
                                {
                                    if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + intel + microsoft + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Intel, Microsoft, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((acer + intel + microsoft + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + intel + microsoft) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Acer, Intel, and Microsoft Stock.");
                                        currentBalance = currentBalance + (((acer + intel + microsoft) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + intel + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer, Intel, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((acer + intel + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + intel) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer and Intel Stock.");
                                    currentBalance = currentBalance + (((acer + intel) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxMicrosoft.Checked)
                            {
                                if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + microsoft + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer, Microsoft, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((acer + microsoft + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + microsoft) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Acer and Microsoft Stock.");
                                    currentBalance = currentBalance + (((acer + microsoft) / 6) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + ryzen) / 2) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Acer and Ryzen Stock.");
                                currentBalance = currentBalance + (((acer + ryzen) / 2) * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString((acer * 100) + "%"));
                                lbxOutput.Items.Add("You purchased: Acer Stock.");
                                currentBalance = currentBalance + (acer * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                        }
                        else if (cbxApple.Checked)
                        {
                            if (cbxFacebook.Checked)
                            {
                                if (cbxIntel.Checked)
                                {
                                    if (cbxMicrosoft.Checked)
                                    {
                                        if (cbxRyzen.Checked)
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook + intel + microsoft + ryzen) / 5) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Apple, Facebook, Intel, Microsoft, and Ryzen Stock.");
                                            currentBalance = currentBalance + (((apple + facebook + intel + microsoft + ryzen) / 5) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook + intel + microsoft) / 4) * 100) + "%");
                                            lbxOutput.Items.Add("You purchased: Apple, Facebook, Intel, and Microsoft Stock.");
                                            currentBalance = currentBalance + (((apple + facebook + intel + microsoft) / 4) * investedAmount);
                                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                        }
                                    }
                                    else if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook + intel + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Apple, Facebook, Intel, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((apple + facebook + intel + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook + intel) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Apple, Facebook, and Intel Stock.");
                                        currentBalance = currentBalance + (((apple + facebook + intel) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxMicrosoft.Checked)
                                {
                                    if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook + microsoft + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased:Apple, Facebook, Microsoft, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((apple + facebook + microsoft + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook + microsoft) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased:Apple, Facebook, and Microsoft Stock.");
                                        currentBalance = currentBalance + (((apple + facebook + microsoft) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased:Apple, Facebook, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((apple + facebook + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((apple + facebook) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Apple, and Facebook Stock.");
                                    currentBalance = currentBalance + (((apple + facebook) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxIntel.Checked)
                            {
                                if (cbxMicrosoft.Checked)
                                {
                                    if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((apple + intel + microsoft + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Apple, Intel, Microsoft, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((apple + intel + microsoft + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((apple + intel + microsoft) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Apple, Intel, and Microsoft Stock.");
                                        currentBalance = currentBalance + (((apple + intel + microsoft) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((apple + intel + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Apple, Intel, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((apple + intel + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((apple + intel) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Apple, and Intel Stock.");
                                    currentBalance = currentBalance + (((apple + intel) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxMicrosoft.Checked)
                            {
                                if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((apple + microsoft + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Apple, Microsoft, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((apple + microsoft + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((apple + microsoft) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Apple and Microsoft Stock.");
                                    currentBalance = currentBalance + (((apple + microsoft) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((apple + ryzen) / 2) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Apple, and Ryzen Stock.");
                                currentBalance = currentBalance + (((apple + ryzen) / 2) * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString((apple) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Apple Stock.");
                                currentBalance = currentBalance + (apple * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                        }
                        else if (cbxFacebook.Checked)
                        {
                            if (cbxIntel.Checked)
                            {
                                if (cbxMicrosoft.Checked)
                                {
                                    if (cbxRyzen.Checked)
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((facebook + intel + microsoft + ryzen) / 4) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Facebook, Intel, Microsoft, and Ryzen Stock.");
                                        currentBalance = currentBalance + (((facebook + intel + microsoft + ryzen) / 4) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Return: " + Convert.ToString(((facebook + intel + microsoft) / 3) * 100) + "%");
                                        lbxOutput.Items.Add("You purchased: Facebook, Intel, and Microsoft Stock.");
                                        currentBalance = currentBalance + (((facebook + intel + microsoft) / 3) * investedAmount);
                                        lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                        lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                    }
                                }
                                else if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((facebook + intel + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Facebook, Intel, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((facebook + intel + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((facebook + intel) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Facebook and Intel Stock.");
                                    currentBalance = currentBalance + (((facebook + intel) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxMicrosoft.Checked)
                            {
                                if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((facebook + microsoft + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Facebook, Microsoft, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((facebook + microsoft + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((facebook + microsoft) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Facebook and Microsoft Stock.");
                                    currentBalance = currentBalance + (((facebook + microsoft) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((facebook + ryzen) / 2) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Facebook and Ryzen Stock.");
                                currentBalance = currentBalance + (((facebook + ryzen) / 2) * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString((facebook) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Facebook Stock.");
                                currentBalance = currentBalance + (facebook * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                        }
                        else if (cbxIntel.Checked)
                        {
                            if (cbxMicrosoft.Checked)
                            {
                                if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((intel + microsoft + ryzen) / 3) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Intel, Microsoft, and Ryzen Stock.");
                                    currentBalance = currentBalance + (((intel + microsoft + ryzen) / 3) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((intel + microsoft) / 2) * 100) + "%");
                                    lbxOutput.Items.Add("You purchased: Intel, and Microsoft Stock.");
                                    currentBalance = currentBalance + (((intel + microsoft) / 2) * investedAmount);
                                    lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                    lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                                }
                            }
                            else if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((intel + ryzen) / 2) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Intel, and Ryzen Stock.");
                                currentBalance = currentBalance + (((intel + ryzen) / 2) * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((intel)) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Intel Stock.");
                                currentBalance = currentBalance + (intel * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                        }
                        else if (cbxMicrosoft.Checked)
                        {
                            if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((microsoft + ryzen) / 2) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Microsoft and Ryzen Stock.");
                                currentBalance = currentBalance + (((microsoft + ryzen) / 2) * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString((microsoft) * 100) + "%");
                                lbxOutput.Items.Add("You purchased: Microsoft Stock.");
                                currentBalance = currentBalance + (microsoft * investedAmount);
                                lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                                lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                            }
                        }
                        else if (cbxRyzen.Checked)
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString((ryzen) * 100) + "%");
                            lbxOutput.Items.Add("You purchased: Ryzen Stock.");
                            currentBalance = currentBalance + (ryzen * investedAmount);
                            lblCurrentBalance.Text = "$" + Convert.ToString(Math.Round(currentBalance, 2));
                            lbxOutput.Items.Add("Your new balance: " + "$" + Convert.ToString(Math.Round(currentBalance, 2)));
                        }
                        else
                        {
                            MessageBox.Show("Please select a stock");
                            lbxOutput.Items.Add("You did not purchase any stock.");
                        }

                        random = new Random();

                    }
                    else
                    {
                        lblOutput.Text = "You must invest less than your current balance and greater than 0";
                    }
                }
                catch (Exception)
                {
                    lblOutput.Text = "You must invest some amount";
                }
            }
            else
            {
                lblOutput.Text = "You do not have enough money to invest.";
            }
        }
    }
}

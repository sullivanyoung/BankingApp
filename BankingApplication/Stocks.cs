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
        public static double[] percents = { -.10, -.05, -.01, .01, .05, .07, .10, .14, .18, .25 };
        public static Random random = new Random();
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
            lblCurrentBalance.Text = "$" + Convert.ToString(Home.currentBalance);
        }

        private void btnInvest_Click(object sender, EventArgs e)
        {
            double acer = percents[random.Next(percents.Length)];
            double apple = percents[random.Next(percents.Length)];
            double facebook = percents[random.Next(percents.Length)];
            double intel = percents[random.Next(percents.Length)];
            double microsoft = percents[random.Next(percents.Length)];
            double ryzen = percents[random.Next(percents.Length)];

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
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel + microsoft + ryzen) / 6) * 100) + "%");
                                    lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, Intel, Microsoft, and Ryzen Stock.");
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel + microsoft) / 5) * 100) + "%");
                                    lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, Intel, and Microsoft Stock.");
                                }
                            }
                            else if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel + ryzen) / 5) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, Intel, and Ryzen Stock.");
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel) / 4) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, and Intel Stock.");
                            }
                        }
                        else if (cbxMicrosoft.Checked)
                        {
                            if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + microsoft + ryzen) / 5) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, Microsoft, and Ryzen Stock.");
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + microsoft) / 4) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, and Microsoft Stock.");
                            }
                        }
                        else if (cbxRyzen.Checked)
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + ryzen) / 4) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, and Ryzen Stock.");
                        }
                        else
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook) / 3) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Apple, and Facebook Stock.");
                        }
                    }
                    else if (cbxIntel.Checked)
                    {
                        if (cbxMicrosoft.Checked)
                        {
                            if (cbxRyzen.Checked)
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel + microsoft + ryzen) / 5) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Apple, Intel, Microsoft, and Ryzen Stock.");
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel + microsoft) / 4) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Apple, Intel, and Microsoft Stock.");
                            }
                        }
                        else if (cbxRyzen.Checked)
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel + ryzen) / 4) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Apple, Intel, and Ryzen Stock.");
                        }
                        else
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + intel) / 3) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Apple, and Intel Stock.");
                        }
                    }
                    else if (cbxMicrosoft.Checked)
                    {
                        if (cbxRyzen.Checked)
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + microsoft + ryzen) / 4) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Apple, Microsoft, and Ryzen Stock.");
                        }
                        else
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + microsoft) / 3) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Apple,, and Microsoft Stock.");
                        }
                    }
                    else if (cbxRyzen.Checked)
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + ryzen) / 3) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer, Apple, and Ryzen Stock.");
                    }
                    else
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple) / 2) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer, and Apple Stock.");
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
                                lbxOutput.Items.Add($"You purchased: Acer, Facebook, Intel, Microsoft, and Ryzen Stock.");
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + intel + microsoft) / 4) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Facebook, Intel, and Microsoft Stock.");
                            }
                        }
                        else if (cbxRyzen.Checked)
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + intel + ryzen) / 4) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Facebook, Intel, and Ryzen Stock.");
                        }
                        else
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + intel) / 3) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Facebook, and Intel Stock.");
                        }
                    }
                    else if (cbxMicrosoft.Checked)
                    {
                        if (cbxRyzen.Checked)
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + microsoft + ryzen) / 4) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Facebook, Microsoft, and Ryzen Stock.");
                        }
                        else
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + microsoft) / 3) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Facebook, and Microsoft Stock.");
                        }
                    }
                    else if (cbxRyzen.Checked)
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook + ryzen) / 3) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer, Facebook, and Ryzen Stock.");
                    }
                    else
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + facebook) / 2) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer and Facebook Stock.");
                    }
                }
                else if (cbxIntel.Checked)
                {
                    if (cbxMicrosoft.Checked)
                    {
                        if (cbxRyzen.Checked)
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + intel + microsoft + ryzen) / 4) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Intel, Microsoft, and Ryzen Stock.");
                        }
                        else
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer+ intel + microsoft) / 3) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Intel, and Microsoft Stock.");
                        }
                    }
                    else if (cbxRyzen.Checked)
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + intel + ryzen) / 3) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer, Intel, and Ryzen Stock.");
                    }
                    else
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + intel) / 2) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer and Intel Stock.");
                    }
                }
                else if (cbxMicrosoft.Checked)
                {
                    if (cbxRyzen.Checked)
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + microsoft + ryzen) / 3) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer, Microsoft, and Ryzen Stock.");
                    }
                    else
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + microsoft) / 2) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer, and Microsoft Stock.");
                    }
                }
                else if (cbxRyzen.Checked)
                {
                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + ryzen) / 2) * 100) + "%");
                    lbxOutput.Items.Add($"You purchased: Acer and Ryzen Stock.");
                }
                else
                {
                    MessageBox.Show("Please select a stock");
                    lbxOutput.Items.Add($"You did not purchase any stock.");
                }

            }
            random = new Random();
        }
    }
}

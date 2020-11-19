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
        public static double[] percents = { -.10, -.05, -.01, .01, .05, .07, .10, .14, .18, .25};
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
            lblCurrentBalance.Text = "$" +  Convert.ToString(Home.currentBalance);
        }

        private void btnInvest_Click(object sender, EventArgs e)
        {
            double acer = percents[random.Next(percents.Length)];
            double apple = percents[random.Next(percents.Length)];
            double facebook = percents[random.Next(percents.Length)];
            double intel = percents[random.Next(percents.Length)];
            double microsoft = percents[random.Next(percents.Length)];
            double ryzen = percents[random.Next(percents.Length)];

            if(cbxAcer.Checked)
            {
                if(cbxApple.Checked)
                {
                    if (cbxFacebook.Checked)
                    {
                        if (cbxIntel.Checked)
                        {
                            if (cbxMicrosoft.Checked)
                            {
                                if (cbxRyzen.Checked)
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel + microsoft + ryzen)/6) * 100) + "%");
                                    lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, Intel, Microsoft, and Ryzen Stock.");
                                }
                                else
                                {
                                    MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel + microsoft)/5) * 100) + "%");
                                    lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, Intel, and Microsoft Stock.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook + intel)/4) * 100) + "%");
                                lbxOutput.Items.Add($"You purchased: Acer, Apple, Facebook, and Intel Stock.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple + facebook)/3) * 100) + "%");
                            lbxOutput.Items.Add($"You purchased: Acer, Apple, and Facebook Stock.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Return: " + Convert.ToString(((acer + apple)/2) * 100) + "%");
                        lbxOutput.Items.Add($"You purchased: Acer and Apple Stock.");
                    }
                }
                else
                {
                    MessageBox.Show("Acer Stock: " + Convert.ToString(acer * 100) + "%");
                    lbxOutput.Items.Add($"You purchased: Acer Stock.");
                }
            }
            else if (cbxApple.Checked)
            {
                MessageBox.Show("Apple Stock: " + Convert.ToString(apple * 100) + "%");
            }
            else if (cbxFacebook.Checked)
            {
                MessageBox.Show("Facebook Stock: " + Convert.ToString(facebook * 100) + "%");
            }
            else if (cbxIntel.Checked)
            {
                MessageBox.Show("Intel Stock: " + Convert.ToString(intel * 100) + "%");
            }
            else if (cbxMicrosoft.Checked)
            {
                MessageBox.Show("Microsoft Stock: " + Convert.ToString(microsoft * 100) + "%");
            }
            else if (cbxRyzen.Checked)
            {
                MessageBox.Show("Ryzen Stock: " + Convert.ToString(ryzen * 100) + "%");
            }
            else
            {
                MessageBox.Show("No selected stock.");
            }

            random = new Random();
        }
    }
}

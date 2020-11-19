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
    }
}

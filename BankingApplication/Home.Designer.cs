
namespace BankingApplication
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lbxBalance = new System.Windows.Forms.ListBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBull = new System.Windows.Forms.Button();
            this.btnBear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(326, 378);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(115, 30);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(562, 378);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(115, 30);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Location = new System.Drawing.Point(86, 87);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(86, 13);
            this.lblBalanceAmount.TabIndex = 2;
            this.lblBalanceAmount.Text = "Current Balance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Withdraw Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deposit Amount:";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(326, 217);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(100, 20);
            this.txtWithdraw.TabIndex = 5;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(562, 217);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtDeposit.TabIndex = 6;
            // 
            // lbxBalance
            // 
            this.lbxBalance.FormattingEnabled = true;
            this.lbxBalance.Location = new System.Drawing.Point(45, 112);
            this.lbxBalance.Name = "lbxBalance";
            this.lbxBalance.Size = new System.Drawing.Size(248, 342);
            this.lbxBalance.TabIndex = 8;
            this.lbxBalance.SelectedIndexChanged += new System.EventHandler(this.lbxBalance_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(173, 87);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 9;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(99, 488);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(115, 30);
            this.btnForward.TabIndex = 10;
            this.btnForward.Text = "Fast Forward 1 Year";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBull
            // 
            this.btnBull.Location = new System.Drawing.Point(637, 488);
            this.btnBull.Name = "btnBull";
            this.btnBull.Size = new System.Drawing.Size(115, 30);
            this.btnBull.TabIndex = 11;
            this.btnBull.Text = "Create Bull Market";
            this.btnBull.UseVisualStyleBackColor = true;
            this.btnBull.Click += new System.EventHandler(this.btnBull_Click);
            // 
            // btnBear
            // 
            this.btnBear.Location = new System.Drawing.Point(443, 488);
            this.btnBear.Name = "btnBear";
            this.btnBear.Size = new System.Drawing.Size(115, 30);
            this.btnBear.TabIndex = 12;
            this.btnBear.Text = "Create Bear Market";
            this.btnBear.UseVisualStyleBackColor = true;
            this.btnBear.Click += new System.EventHandler(this.btnBear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Edit Market for the Year:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 33);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "2% Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "10% Interest";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(245, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "5% Interest without Market Selection";
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(712, 13);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(79, 33);
            this.btnStocks.TabIndex = 19;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(712, 579);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 42);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close Program";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 633);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStocks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBear);
            this.Controls.Add(this.btnBull);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lbxBalance);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.ListBox lbxBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBull;
        private System.Windows.Forms.Button btnBear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnClose;
    }
}



namespace BankingApplication
{
    partial class Stocks
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.txtInvest = new System.Windows.Forms.TextBox();
            this.btnInvest = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.gpbCompanies = new System.Windows.Forms.GroupBox();
            this.rdnIntel = new System.Windows.Forms.RadioButton();
            this.rdnRyzen = new System.Windows.Forms.RadioButton();
            this.rdnAcer = new System.Windows.Forms.RadioButton();
            this.rdnMicrosoft = new System.Windows.Forms.RadioButton();
            this.rdnFacebook = new System.Windows.Forms.RadioButton();
            this.rdnApple = new System.Windows.Forms.RadioButton();
            this.gpbCompanies.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(761, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(79, 33);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 33);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(319, 22);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(89, 13);
            this.lblBalance.TabIndex = 23;
            this.lblBalance.Text = "Current Balance: ";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(428, 22);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentBalance.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(761, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 42);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close Program";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(481, 86);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(170, 290);
            this.lbxOutput.TabIndex = 31;
            // 
            // txtInvest
            // 
            this.txtInvest.Location = new System.Drawing.Point(308, 220);
            this.txtInvest.Name = "txtInvest";
            this.txtInvest.Size = new System.Drawing.Size(100, 20);
            this.txtInvest.TabIndex = 32;
            // 
            // btnInvest
            // 
            this.btnInvest.Location = new System.Drawing.Point(322, 302);
            this.btnInvest.Name = "btnInvest";
            this.btnInvest.Size = new System.Drawing.Size(75, 23);
            this.btnInvest.TabIndex = 33;
            this.btnInvest.Text = "Invest";
            this.btnInvest.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(322, 446);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(100, 37);
            this.btnMonth.TabIndex = 34;
            this.btnMonth.Text = "1 Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(508, 446);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(100, 37);
            this.btnYear.TabIndex = 35;
            this.btnYear.Text = "1 Year";
            this.btnYear.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(135, 446);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(100, 37);
            this.btnWeek.TabIndex = 36;
            this.btnWeek.Text = "1 Week";
            this.btnWeek.UseVisualStyleBackColor = true;
            // 
            // gpbCompanies
            // 
            this.gpbCompanies.Controls.Add(this.rdnIntel);
            this.gpbCompanies.Controls.Add(this.rdnRyzen);
            this.gpbCompanies.Controls.Add(this.rdnAcer);
            this.gpbCompanies.Controls.Add(this.rdnMicrosoft);
            this.gpbCompanies.Controls.Add(this.rdnFacebook);
            this.gpbCompanies.Controls.Add(this.rdnApple);
            this.gpbCompanies.Location = new System.Drawing.Point(135, 133);
            this.gpbCompanies.Name = "gpbCompanies";
            this.gpbCompanies.Size = new System.Drawing.Size(82, 192);
            this.gpbCompanies.TabIndex = 37;
            this.gpbCompanies.TabStop = false;
            this.gpbCompanies.Text = "Companies";
            // 
            // rdnIntel
            // 
            this.rdnIntel.AutoSize = true;
            this.rdnIntel.Location = new System.Drawing.Point(7, 135);
            this.rdnIntel.Name = "rdnIntel";
            this.rdnIntel.Size = new System.Drawing.Size(45, 17);
            this.rdnIntel.TabIndex = 5;
            this.rdnIntel.TabStop = true;
            this.rdnIntel.Text = "Intel";
            this.rdnIntel.UseVisualStyleBackColor = true;
            // 
            // rdnRyzen
            // 
            this.rdnRyzen.AutoSize = true;
            this.rdnRyzen.Location = new System.Drawing.Point(6, 112);
            this.rdnRyzen.Name = "rdnRyzen";
            this.rdnRyzen.Size = new System.Drawing.Size(55, 17);
            this.rdnRyzen.TabIndex = 4;
            this.rdnRyzen.TabStop = true;
            this.rdnRyzen.Text = "Ryzen";
            this.rdnRyzen.UseVisualStyleBackColor = true;
            // 
            // rdnAcer
            // 
            this.rdnAcer.AutoSize = true;
            this.rdnAcer.Location = new System.Drawing.Point(7, 89);
            this.rdnAcer.Name = "rdnAcer";
            this.rdnAcer.Size = new System.Drawing.Size(47, 17);
            this.rdnAcer.TabIndex = 3;
            this.rdnAcer.TabStop = true;
            this.rdnAcer.Text = "Acer";
            this.rdnAcer.UseVisualStyleBackColor = true;
            // 
            // rdnMicrosoft
            // 
            this.rdnMicrosoft.AutoSize = true;
            this.rdnMicrosoft.Location = new System.Drawing.Point(7, 66);
            this.rdnMicrosoft.Name = "rdnMicrosoft";
            this.rdnMicrosoft.Size = new System.Drawing.Size(68, 17);
            this.rdnMicrosoft.TabIndex = 2;
            this.rdnMicrosoft.TabStop = true;
            this.rdnMicrosoft.Text = "Microsoft";
            this.rdnMicrosoft.UseVisualStyleBackColor = true;
            // 
            // rdnFacebook
            // 
            this.rdnFacebook.AutoSize = true;
            this.rdnFacebook.Location = new System.Drawing.Point(6, 42);
            this.rdnFacebook.Name = "rdnFacebook";
            this.rdnFacebook.Size = new System.Drawing.Size(73, 17);
            this.rdnFacebook.TabIndex = 1;
            this.rdnFacebook.TabStop = true;
            this.rdnFacebook.Text = "Facebook";
            this.rdnFacebook.UseVisualStyleBackColor = true;
            // 
            // rdnApple
            // 
            this.rdnApple.AutoSize = true;
            this.rdnApple.Location = new System.Drawing.Point(6, 19);
            this.rdnApple.Name = "rdnApple";
            this.rdnApple.Size = new System.Drawing.Size(52, 17);
            this.rdnApple.TabIndex = 0;
            this.rdnApple.TabStop = true;
            this.rdnApple.Text = "Apple";
            this.rdnApple.UseVisualStyleBackColor = true;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 560);
            this.Controls.Add(this.gpbCompanies);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnInvest);
            this.Controls.Add(this.txtInvest);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClear);
            this.Name = "Stocks";
            this.Text = "Form2";
            this.gpbCompanies.ResumeLayout(false);
            this.gpbCompanies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.TextBox txtInvest;
        private System.Windows.Forms.Button btnInvest;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.GroupBox gpbCompanies;
        private System.Windows.Forms.RadioButton rdnRyzen;
        private System.Windows.Forms.RadioButton rdnAcer;
        private System.Windows.Forms.RadioButton rdnMicrosoft;
        private System.Windows.Forms.RadioButton rdnFacebook;
        private System.Windows.Forms.RadioButton rdnApple;
        private System.Windows.Forms.RadioButton rdnIntel;
    }
}
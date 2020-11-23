
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
            this.btnYear = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.gpbCompanies = new System.Windows.Forms.GroupBox();
            this.cbxRyzen = new System.Windows.Forms.CheckBox();
            this.cbxMicrosoft = new System.Windows.Forms.CheckBox();
            this.cbxIntel = new System.Windows.Forms.CheckBox();
            this.cbxFacebook = new System.Windows.Forms.CheckBox();
            this.cbxApple = new System.Windows.Forms.CheckBox();
            this.cbxAcer = new System.Windows.Forms.CheckBox();
            this.btnMonth = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
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
            this.lbxOutput.Size = new System.Drawing.Size(342, 251);
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
            this.btnInvest.Location = new System.Drawing.Point(308, 302);
            this.btnInvest.Name = "btnInvest";
            this.btnInvest.Size = new System.Drawing.Size(100, 32);
            this.btnInvest.TabIndex = 33;
            this.btnInvest.Text = "Invest";
            this.btnInvest.UseVisualStyleBackColor = true;
            this.btnInvest.Click += new System.EventHandler(this.btnInvest_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(508, 446);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(100, 37);
            this.btnYear.TabIndex = 35;
            this.btnYear.Text = "1 Year";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(135, 446);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(100, 37);
            this.btnWeek.TabIndex = 36;
            this.btnWeek.Text = "1 Week";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // gpbCompanies
            // 
            this.gpbCompanies.Controls.Add(this.cbxRyzen);
            this.gpbCompanies.Controls.Add(this.cbxMicrosoft);
            this.gpbCompanies.Controls.Add(this.cbxIntel);
            this.gpbCompanies.Controls.Add(this.cbxFacebook);
            this.gpbCompanies.Controls.Add(this.cbxApple);
            this.gpbCompanies.Controls.Add(this.cbxAcer);
            this.gpbCompanies.Location = new System.Drawing.Point(135, 133);
            this.gpbCompanies.Name = "gpbCompanies";
            this.gpbCompanies.Size = new System.Drawing.Size(82, 160);
            this.gpbCompanies.TabIndex = 37;
            this.gpbCompanies.TabStop = false;
            this.gpbCompanies.Text = "Companies";
            // 
            // cbxRyzen
            // 
            this.cbxRyzen.AutoSize = true;
            this.cbxRyzen.Location = new System.Drawing.Point(7, 140);
            this.cbxRyzen.Name = "cbxRyzen";
            this.cbxRyzen.Size = new System.Drawing.Size(56, 17);
            this.cbxRyzen.TabIndex = 5;
            this.cbxRyzen.Text = "Ryzen";
            this.cbxRyzen.UseVisualStyleBackColor = true;
            // 
            // cbxMicrosoft
            // 
            this.cbxMicrosoft.AutoSize = true;
            this.cbxMicrosoft.Location = new System.Drawing.Point(7, 116);
            this.cbxMicrosoft.Name = "cbxMicrosoft";
            this.cbxMicrosoft.Size = new System.Drawing.Size(69, 17);
            this.cbxMicrosoft.TabIndex = 4;
            this.cbxMicrosoft.Text = "Microsoft";
            this.cbxMicrosoft.UseVisualStyleBackColor = true;
            // 
            // cbxIntel
            // 
            this.cbxIntel.AutoSize = true;
            this.cbxIntel.Location = new System.Drawing.Point(7, 92);
            this.cbxIntel.Name = "cbxIntel";
            this.cbxIntel.Size = new System.Drawing.Size(46, 17);
            this.cbxIntel.TabIndex = 3;
            this.cbxIntel.Text = "Intel";
            this.cbxIntel.UseVisualStyleBackColor = true;
            // 
            // cbxFacebook
            // 
            this.cbxFacebook.AutoSize = true;
            this.cbxFacebook.Location = new System.Drawing.Point(7, 68);
            this.cbxFacebook.Name = "cbxFacebook";
            this.cbxFacebook.Size = new System.Drawing.Size(74, 17);
            this.cbxFacebook.TabIndex = 2;
            this.cbxFacebook.Text = "Facebook";
            this.cbxFacebook.UseVisualStyleBackColor = true;
            // 
            // cbxApple
            // 
            this.cbxApple.AutoSize = true;
            this.cbxApple.Location = new System.Drawing.Point(7, 44);
            this.cbxApple.Name = "cbxApple";
            this.cbxApple.Size = new System.Drawing.Size(53, 17);
            this.cbxApple.TabIndex = 1;
            this.cbxApple.Text = "Apple";
            this.cbxApple.UseVisualStyleBackColor = true;
            // 
            // cbxAcer
            // 
            this.cbxAcer.AutoSize = true;
            this.cbxAcer.Location = new System.Drawing.Point(7, 20);
            this.cbxAcer.Name = "cbxAcer";
            this.cbxAcer.Size = new System.Drawing.Size(48, 17);
            this.cbxAcer.TabIndex = 0;
            this.cbxAcer.Text = "Acer";
            this.cbxAcer.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(322, 446);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(100, 37);
            this.btnMonth.TabIndex = 38;
            this.btnMonth.Text = "1 Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(478, 363);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 39;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 560);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.gpbCompanies);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnYear);
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
            this.Load += new System.EventHandler(this.Stocks_Load);
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
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.GroupBox gpbCompanies;
        private System.Windows.Forms.CheckBox cbxRyzen;
        private System.Windows.Forms.CheckBox cbxMicrosoft;
        private System.Windows.Forms.CheckBox cbxIntel;
        private System.Windows.Forms.CheckBox cbxFacebook;
        private System.Windows.Forms.CheckBox cbxApple;
        private System.Windows.Forms.CheckBox cbxAcer;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Label lblOutput;
    }
}
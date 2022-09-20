namespace Homework2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_B_ID = new System.Windows.Forms.TextBox();
            this.textBox_B_PWD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_B_Open = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_A_ID = new System.Windows.Forms.TextBox();
            this.textBox_A_PWD = new System.Windows.Forms.TextBox();
            this.button_Signin = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Deposit = new System.Windows.Forms.Button();
            this.button_Withdraw = new System.Windows.Forms.Button();
            this.checkBox_Credit = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_credit = new System.Windows.Forms.Label();
            this.checkBox_A_credit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "银行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATM";
            // 
            // textBox_B_ID
            // 
            this.textBox_B_ID.Location = new System.Drawing.Point(57, 50);
            this.textBox_B_ID.Name = "textBox_B_ID";
            this.textBox_B_ID.Size = new System.Drawing.Size(260, 27);
            this.textBox_B_ID.TabIndex = 2;
            // 
            // textBox_B_PWD
            // 
            this.textBox_B_PWD.Location = new System.Drawing.Point(57, 83);
            this.textBox_B_PWD.Name = "textBox_B_PWD";
            this.textBox_B_PWD.Size = new System.Drawing.Size(260, 27);
            this.textBox_B_PWD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "账号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "密码";
            // 
            // button_B_Open
            // 
            this.button_B_Open.Location = new System.Drawing.Point(12, 146);
            this.button_B_Open.Name = "button_B_Open";
            this.button_B_Open.Size = new System.Drawing.Size(305, 29);
            this.button_B_Open.TabIndex = 6;
            this.button_B_Open.Text = "开户";
            this.button_B_Open.UseVisualStyleBackColor = true;
            this.button_B_Open.Click += new System.EventHandler(this.button_B_Open_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "账号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "密码";
            // 
            // textBox_A_ID
            // 
            this.textBox_A_ID.Location = new System.Drawing.Point(386, 50);
            this.textBox_A_ID.Name = "textBox_A_ID";
            this.textBox_A_ID.Size = new System.Drawing.Size(290, 27);
            this.textBox_A_ID.TabIndex = 9;
            // 
            // textBox_A_PWD
            // 
            this.textBox_A_PWD.Location = new System.Drawing.Point(386, 83);
            this.textBox_A_PWD.Name = "textBox_A_PWD";
            this.textBox_A_PWD.Size = new System.Drawing.Size(290, 27);
            this.textBox_A_PWD.TabIndex = 10;
            // 
            // button_Signin
            // 
            this.button_Signin.Location = new System.Drawing.Point(682, 53);
            this.button_Signin.Name = "button_Signin";
            this.button_Signin.Size = new System.Drawing.Size(94, 57);
            this.button_Signin.TabIndex = 11;
            this.button_Signin.Text = "登录";
            this.button_Signin.UseVisualStyleBackColor = true;
            this.button_Signin.Click += new System.EventHandler(this.button_Signin_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(416, 171);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(360, 27);
            this.textBox_amount.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "交易金额";
            // 
            // button_Deposit
            // 
            this.button_Deposit.Location = new System.Drawing.Point(341, 204);
            this.button_Deposit.Name = "button_Deposit";
            this.button_Deposit.Size = new System.Drawing.Size(216, 29);
            this.button_Deposit.TabIndex = 14;
            this.button_Deposit.Text = "存钱";
            this.button_Deposit.UseVisualStyleBackColor = true;
            this.button_Deposit.Click += new System.EventHandler(this.button_Deposit_Click);
            // 
            // button_Withdraw
            // 
            this.button_Withdraw.Location = new System.Drawing.Point(563, 204);
            this.button_Withdraw.Name = "button_Withdraw";
            this.button_Withdraw.Size = new System.Drawing.Size(213, 29);
            this.button_Withdraw.TabIndex = 15;
            this.button_Withdraw.Text = "取钱";
            this.button_Withdraw.UseVisualStyleBackColor = true;
            this.button_Withdraw.Click += new System.EventHandler(this.button_Withdraw_Click);
            // 
            // checkBox_Credit
            // 
            this.checkBox_Credit.AutoSize = true;
            this.checkBox_Credit.Location = new System.Drawing.Point(241, 116);
            this.checkBox_Credit.Name = "checkBox_Credit";
            this.checkBox_Credit.Size = new System.Drawing.Size(76, 24);
            this.checkBox_Credit.TabIndex = 16;
            this.checkBox_Credit.Text = "信用卡";
            this.checkBox_Credit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "账户余额";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(416, 137);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(18, 20);
            this.label_amount.TabIndex = 18;
            this.label_amount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "信用额度";
            // 
            // label_credit
            // 
            this.label_credit.AutoSize = true;
            this.label_credit.Location = new System.Drawing.Point(638, 137);
            this.label_credit.Name = "label_credit";
            this.label_credit.Size = new System.Drawing.Size(18, 20);
            this.label_credit.TabIndex = 20;
            this.label_credit.Text = "0";
            // 
            // checkBox_A_credit
            // 
            this.checkBox_A_credit.AutoSize = true;
            this.checkBox_A_credit.Location = new System.Drawing.Point(682, 116);
            this.checkBox_A_credit.Name = "checkBox_A_credit";
            this.checkBox_A_credit.Size = new System.Drawing.Size(76, 24);
            this.checkBox_A_credit.TabIndex = 21;
            this.checkBox_A_credit.Text = "信用卡";
            this.checkBox_A_credit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 384);
            this.Controls.Add(this.checkBox_A_credit);
            this.Controls.Add(this.label_credit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_Credit);
            this.Controls.Add(this.button_Withdraw);
            this.Controls.Add(this.button_Deposit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.button_Signin);
            this.Controls.Add(this.textBox_A_PWD);
            this.Controls.Add(this.textBox_A_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_B_Open);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_B_PWD);
            this.Controls.Add(this.textBox_B_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_B_ID;
        private TextBox textBox_B_PWD;
        private Label label3;
        private Label label4;
        private Button button_B_Open;
        private Label label5;
        private Label label6;
        private TextBox textBox_A_ID;
        private TextBox textBox_A_PWD;
        private Button button_Signin;
        private TextBox textBox_amount;
        private Label label7;
        private Button button_Deposit;
        private Button button_Withdraw;
        private CheckBox checkBox_Credit;
        private Label label8;
        private Label label_amount;
        private Label label9;
        private Label label_credit;
        private CheckBox checkBox_A_credit;
    }
}
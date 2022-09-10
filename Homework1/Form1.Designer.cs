namespace Homework1
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
            this.button_hello = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_prime = new System.Windows.Forms.TextBox();
            this.button_prime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_formula = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_ticks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task 1";
            // 
            // button_hello
            // 
            this.button_hello.Location = new System.Drawing.Point(12, 29);
            this.button_hello.Name = "button_hello";
            this.button_hello.Size = new System.Drawing.Size(130, 23);
            this.button_hello.TabIndex = 1;
            this.button_hello.Text = "Hello World!";
            this.button_hello.UseVisualStyleBackColor = true;
            this.button_hello.Click += new System.EventHandler(this.button_hello_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task 2";
            // 
            // textBox_prime
            // 
            this.textBox_prime.Location = new System.Drawing.Point(12, 108);
            this.textBox_prime.Name = "textBox_prime";
            this.textBox_prime.Size = new System.Drawing.Size(130, 23);
            this.textBox_prime.TabIndex = 3;
            // 
            // button_prime
            // 
            this.button_prime.Location = new System.Drawing.Point(12, 137);
            this.button_prime.Name = "button_prime";
            this.button_prime.Size = new System.Drawing.Size(130, 23);
            this.button_prime.TabIndex = 4;
            this.button_prime.Text = "Prime Number";
            this.button_prime.UseVisualStyleBackColor = true;
            this.button_prime.Click += new System.EventHandler(this.button_prime_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task 3";
            // 
            // label_formula
            // 
            this.label_formula.AutoSize = true;
            this.label_formula.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_formula.Location = new System.Drawing.Point(163, 31);
            this.label_formula.Name = "label_formula";
            this.label_formula.Size = new System.Drawing.Size(73, 21);
            this.label_formula.TabIndex = 6;
            this.label_formula.Text = "Formula";
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(163, 55);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(100, 23);
            this.textBox_answer.TabIndex = 7;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(163, 85);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(100, 23);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(163, 137);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 23);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(163, 166);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 23);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "结束";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_ticks
            // 
            this.label_ticks.AutoSize = true;
            this.label_ticks.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ticks.Location = new System.Drawing.Point(327, 38);
            this.label_ticks.Name = "label_ticks";
            this.label_ticks.Size = new System.Drawing.Size(93, 41);
            this.label_ticks.TabIndex = 11;
            this.label_ticks.Text = "Ticks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "得分:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(368, 91);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(40, 17);
            this.label_score.TabIndex = 13;
            this.label_score.Text = "score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ticks);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_formula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_prime);
            this.Controls.Add(this.textBox_prime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_hello);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_hello;
        private Label label2;
        private TextBox textBox_prime;
        private Button button_prime;
        private Label label3;
        private Label label_formula;
        private TextBox textBox_answer;
        private Button button_submit;
        private Button button_start;
        private Button button_exit;
        private Label label_ticks;
        private Label label4;
        private Label label_score;
    }
}
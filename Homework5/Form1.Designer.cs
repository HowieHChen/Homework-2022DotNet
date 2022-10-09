namespace Homework5
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
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBaidu = new System.Windows.Forms.CheckBox();
            this.checkBoxBing = new System.Windows.Forms.CheckBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(9, 57);
            this.textBoxKeyword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(340, 23);
            this.textBoxKeyword.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(353, 57);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(73, 25);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Go";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // checkBoxBaidu
            // 
            this.checkBoxBaidu.AutoSize = true;
            this.checkBoxBaidu.Checked = true;
            this.checkBoxBaidu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBaidu.Location = new System.Drawing.Point(131, 31);
            this.checkBoxBaidu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxBaidu.Name = "checkBoxBaidu";
            this.checkBoxBaidu.Size = new System.Drawing.Size(60, 21);
            this.checkBoxBaidu.TabIndex = 3;
            this.checkBoxBaidu.Text = "Baidu";
            this.checkBoxBaidu.UseVisualStyleBackColor = true;
            // 
            // checkBoxBing
            // 
            this.checkBoxBing.AutoSize = true;
            this.checkBoxBing.Checked = true;
            this.checkBoxBing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBing.Location = new System.Drawing.Point(191, 31);
            this.checkBoxBing.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxBing.Name = "checkBoxBing";
            this.checkBoxBing.Size = new System.Drawing.Size(53, 21);
            this.checkBoxBing.TabIndex = 4;
            this.checkBoxBing.Text = "Bing";
            this.checkBoxBing.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(9, 87);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(418, 363);
            this.richTextBoxOutput.TabIndex = 5;
            this.richTextBoxOutput.Text = "";
            // 
            // listViewResult
            // 
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewResult.Location = new System.Drawing.Point(431, 10);
            this.listViewResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(480, 439);
            this.listViewResult.TabIndex = 6;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "手机号";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 400;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(353, 27);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(73, 23);
            this.textBoxCount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "号码个数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.checkBoxBing);
            this.Controls.Add(this.checkBoxBaidu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxKeyword);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKeyword;
        private Button buttonSearch;
        private Label label1;
        private CheckBox checkBoxBaidu;
        private CheckBox checkBoxBing;
        private RichTextBox richTextBoxOutput;
        private ListView listViewResult;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox textBoxCount;
        private Label label2;
    }
}
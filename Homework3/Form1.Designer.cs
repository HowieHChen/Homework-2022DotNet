namespace Homework3
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
            this.button_PickFile = new System.Windows.Forms.Button();
            this.label_FileName = new System.Windows.Forms.Label();
            this.button_Count = new System.Windows.Forms.Button();
            this.button_CountFormat = new System.Windows.Forms.Button();
            this.label_FilePath = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Word = new System.Windows.Forms.ColumnHeader();
            this.Count = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button_PickFile
            // 
            this.button_PickFile.Location = new System.Drawing.Point(12, 12);
            this.button_PickFile.Name = "button_PickFile";
            this.button_PickFile.Size = new System.Drawing.Size(94, 29);
            this.button_PickFile.TabIndex = 0;
            this.button_PickFile.Text = "选择文件";
            this.button_PickFile.UseVisualStyleBackColor = true;
            this.button_PickFile.Click += new System.EventHandler(this.button_PickFile_Click);
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FileName.Location = new System.Drawing.Point(12, 44);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(72, 27);
            this.label_FileName.TabIndex = 1;
            this.label_FileName.Text = "文件名";
            // 
            // button_Count
            // 
            this.button_Count.Location = new System.Drawing.Point(12, 177);
            this.button_Count.Name = "button_Count";
            this.button_Count.Size = new System.Drawing.Size(180, 29);
            this.button_Count.TabIndex = 3;
            this.button_Count.Text = "统计（原文件）";
            this.button_Count.UseVisualStyleBackColor = true;
            this.button_Count.Click += new System.EventHandler(this.button_Count_Click);
            // 
            // button_CountFormat
            // 
            this.button_CountFormat.Location = new System.Drawing.Point(12, 212);
            this.button_CountFormat.Name = "button_CountFormat";
            this.button_CountFormat.Size = new System.Drawing.Size(180, 29);
            this.button_CountFormat.TabIndex = 4;
            this.button_CountFormat.Text = "格式化代码并统计";
            this.button_CountFormat.UseVisualStyleBackColor = true;
            this.button_CountFormat.Click += new System.EventHandler(this.button_CountFormat_Click);
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Location = new System.Drawing.Point(12, 71);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(69, 20);
            this.label_FilePath.TabIndex = 5;
            this.label_FilePath.Text = "完整路径";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Count});
            this.listView1.Location = new System.Drawing.Point(428, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 426);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            this.Word.Width = 240;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_FilePath);
            this.Controls.Add(this.button_CountFormat);
            this.Controls.Add(this.button_Count);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.button_PickFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_PickFile;
        private Label label_FileName;
        private Button button_Count;
        private Button button_CountFormat;
        private Label label_FilePath;
        private ListView listView1;
        private ColumnHeader Word;
        private ColumnHeader Count;
    }
}
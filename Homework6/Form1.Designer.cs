namespace Homework6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCollege = new System.Windows.Forms.TabPage();
            this.buttonCollegeAdd = new System.Windows.Forms.Button();
            this.buttonCollegeDel = new System.Windows.Forms.Button();
            this.buttonCollegeSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCollegeStuCount = new System.Windows.Forms.TextBox();
            this.textBoxCollegeClassCount = new System.Windows.Forms.TextBox();
            this.textBoxCollegeName = new System.Windows.Forms.TextBox();
            this.textBoxCollegeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageClass = new System.Windows.Forms.TabPage();
            this.buttonClassAdd = new System.Windows.Forms.Button();
            this.buttonClassDel = new System.Windows.Forms.Button();
            this.buttonClassSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxClassStuCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.textBoxClassId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClassCollege = new System.Windows.Forms.ComboBox();
            this.tabPageStu = new System.Windows.Forms.TabPage();
            this.buttonStuAdd = new System.Windows.Forms.Button();
            this.buttonStuDel = new System.Windows.Forms.Button();
            this.buttonStuSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStuId = new System.Windows.Forms.TextBox();
            this.comboBoxStuSex = new System.Windows.Forms.ComboBox();
            this.textBoxStuName = new System.Windows.Forms.TextBox();
            this.comboBoxStuClass = new System.Windows.Forms.ComboBox();
            this.comboBoxStuCollege = new System.Windows.Forms.ComboBox();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.buttonLogRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCollege.SuspendLayout();
            this.tabPageClass.SuspendLayout();
            this.tabPageStu.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(759, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCollege);
            this.tabControl1.Controls.Add(this.tabPageClass);
            this.tabControl1.Controls.Add(this.tabPageStu);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 224);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageCollege
            // 
            this.tabPageCollege.Controls.Add(this.buttonCollegeAdd);
            this.tabPageCollege.Controls.Add(this.buttonCollegeDel);
            this.tabPageCollege.Controls.Add(this.buttonCollegeSave);
            this.tabPageCollege.Controls.Add(this.label12);
            this.tabPageCollege.Controls.Add(this.label11);
            this.tabPageCollege.Controls.Add(this.label10);
            this.tabPageCollege.Controls.Add(this.textBoxCollegeStuCount);
            this.tabPageCollege.Controls.Add(this.textBoxCollegeClassCount);
            this.tabPageCollege.Controls.Add(this.textBoxCollegeName);
            this.tabPageCollege.Controls.Add(this.textBoxCollegeId);
            this.tabPageCollege.Controls.Add(this.label2);
            this.tabPageCollege.Location = new System.Drawing.Point(4, 29);
            this.tabPageCollege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageCollege.Name = "tabPageCollege";
            this.tabPageCollege.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageCollege.Size = new System.Drawing.Size(493, 191);
            this.tabPageCollege.TabIndex = 0;
            this.tabPageCollege.Text = "学校";
            this.tabPageCollege.UseVisualStyleBackColor = true;
            // 
            // buttonCollegeAdd
            // 
            this.buttonCollegeAdd.Location = new System.Drawing.Point(393, 86);
            this.buttonCollegeAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCollegeAdd.Name = "buttonCollegeAdd";
            this.buttonCollegeAdd.Size = new System.Drawing.Size(91, 27);
            this.buttonCollegeAdd.TabIndex = 10;
            this.buttonCollegeAdd.Text = "新增";
            this.buttonCollegeAdd.UseVisualStyleBackColor = true;
            this.buttonCollegeAdd.Click += new System.EventHandler(this.buttonCollegeAdd_Click);
            // 
            // buttonCollegeDel
            // 
            this.buttonCollegeDel.Location = new System.Drawing.Point(393, 120);
            this.buttonCollegeDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCollegeDel.Name = "buttonCollegeDel";
            this.buttonCollegeDel.Size = new System.Drawing.Size(94, 29);
            this.buttonCollegeDel.TabIndex = 9;
            this.buttonCollegeDel.Text = "删除";
            this.buttonCollegeDel.UseVisualStyleBackColor = true;
            this.buttonCollegeDel.Click += new System.EventHandler(this.buttonCollegeDel_Click);
            // 
            // buttonCollegeSave
            // 
            this.buttonCollegeSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonCollegeSave.Location = new System.Drawing.Point(393, 155);
            this.buttonCollegeSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCollegeSave.Name = "buttonCollegeSave";
            this.buttonCollegeSave.Size = new System.Drawing.Size(94, 29);
            this.buttonCollegeSave.TabIndex = 8;
            this.buttonCollegeSave.Text = "保存";
            this.buttonCollegeSave.UseVisualStyleBackColor = false;
            this.buttonCollegeSave.Click += new System.EventHandler(this.buttonCollegeSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "学生数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "班级数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "学校名称";
            // 
            // textBoxCollegeStuCount
            // 
            this.textBoxCollegeStuCount.Location = new System.Drawing.Point(90, 105);
            this.textBoxCollegeStuCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCollegeStuCount.Name = "textBoxCollegeStuCount";
            this.textBoxCollegeStuCount.ReadOnly = true;
            this.textBoxCollegeStuCount.Size = new System.Drawing.Size(199, 27);
            this.textBoxCollegeStuCount.TabIndex = 4;
            // 
            // textBoxCollegeClassCount
            // 
            this.textBoxCollegeClassCount.Location = new System.Drawing.Point(90, 72);
            this.textBoxCollegeClassCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCollegeClassCount.Name = "textBoxCollegeClassCount";
            this.textBoxCollegeClassCount.ReadOnly = true;
            this.textBoxCollegeClassCount.Size = new System.Drawing.Size(199, 27);
            this.textBoxCollegeClassCount.TabIndex = 3;
            // 
            // textBoxCollegeName
            // 
            this.textBoxCollegeName.Location = new System.Drawing.Point(90, 39);
            this.textBoxCollegeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCollegeName.Name = "textBoxCollegeName";
            this.textBoxCollegeName.Size = new System.Drawing.Size(199, 27);
            this.textBoxCollegeName.TabIndex = 2;
            // 
            // textBoxCollegeId
            // 
            this.textBoxCollegeId.Location = new System.Drawing.Point(90, 6);
            this.textBoxCollegeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCollegeId.Name = "textBoxCollegeId";
            this.textBoxCollegeId.ReadOnly = true;
            this.textBoxCollegeId.Size = new System.Drawing.Size(199, 27);
            this.textBoxCollegeId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "学校ID";
            // 
            // tabPageClass
            // 
            this.tabPageClass.Controls.Add(this.buttonClassAdd);
            this.tabPageClass.Controls.Add(this.buttonClassDel);
            this.tabPageClass.Controls.Add(this.buttonClassSave);
            this.tabPageClass.Controls.Add(this.label13);
            this.tabPageClass.Controls.Add(this.textBoxClassStuCount);
            this.tabPageClass.Controls.Add(this.label9);
            this.tabPageClass.Controls.Add(this.textBoxClassName);
            this.tabPageClass.Controls.Add(this.textBoxClassId);
            this.tabPageClass.Controls.Add(this.label3);
            this.tabPageClass.Controls.Add(this.label1);
            this.tabPageClass.Controls.Add(this.comboBoxClassCollege);
            this.tabPageClass.Location = new System.Drawing.Point(4, 29);
            this.tabPageClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageClass.Name = "tabPageClass";
            this.tabPageClass.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageClass.Size = new System.Drawing.Size(493, 191);
            this.tabPageClass.TabIndex = 1;
            this.tabPageClass.Text = "班级";
            this.tabPageClass.UseVisualStyleBackColor = true;
            // 
            // buttonClassAdd
            // 
            this.buttonClassAdd.Location = new System.Drawing.Point(393, 86);
            this.buttonClassAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClassAdd.Name = "buttonClassAdd";
            this.buttonClassAdd.Size = new System.Drawing.Size(91, 27);
            this.buttonClassAdd.TabIndex = 10;
            this.buttonClassAdd.Text = "新增";
            this.buttonClassAdd.UseVisualStyleBackColor = true;
            this.buttonClassAdd.Click += new System.EventHandler(this.buttonClassAdd_Click);
            // 
            // buttonClassDel
            // 
            this.buttonClassDel.Location = new System.Drawing.Point(393, 120);
            this.buttonClassDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClassDel.Name = "buttonClassDel";
            this.buttonClassDel.Size = new System.Drawing.Size(94, 29);
            this.buttonClassDel.TabIndex = 9;
            this.buttonClassDel.Text = "删除";
            this.buttonClassDel.UseVisualStyleBackColor = true;
            this.buttonClassDel.Click += new System.EventHandler(this.buttonClassDel_Click);
            // 
            // buttonClassSave
            // 
            this.buttonClassSave.Location = new System.Drawing.Point(393, 155);
            this.buttonClassSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClassSave.Name = "buttonClassSave";
            this.buttonClassSave.Size = new System.Drawing.Size(94, 29);
            this.buttonClassSave.TabIndex = 8;
            this.buttonClassSave.Text = "保存";
            this.buttonClassSave.UseVisualStyleBackColor = true;
            this.buttonClassSave.Click += new System.EventHandler(this.buttonClassSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "班级名称";
            // 
            // textBoxClassStuCount
            // 
            this.textBoxClassStuCount.Location = new System.Drawing.Point(90, 105);
            this.textBoxClassStuCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClassStuCount.Name = "textBoxClassStuCount";
            this.textBoxClassStuCount.ReadOnly = true;
            this.textBoxClassStuCount.Size = new System.Drawing.Size(199, 27);
            this.textBoxClassStuCount.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "学生人数";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(90, 72);
            this.textBoxClassName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(199, 27);
            this.textBoxClassName.TabIndex = 4;
            // 
            // textBoxClassId
            // 
            this.textBoxClassId.Location = new System.Drawing.Point(90, 39);
            this.textBoxClassId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClassId.Name = "textBoxClassId";
            this.textBoxClassId.ReadOnly = true;
            this.textBoxClassId.Size = new System.Drawing.Size(199, 27);
            this.textBoxClassId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "学校";
            // 
            // comboBoxClassCollege
            // 
            this.comboBoxClassCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassCollege.FormattingEnabled = true;
            this.comboBoxClassCollege.Location = new System.Drawing.Point(90, 5);
            this.comboBoxClassCollege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxClassCollege.Name = "comboBoxClassCollege";
            this.comboBoxClassCollege.Size = new System.Drawing.Size(199, 28);
            this.comboBoxClassCollege.TabIndex = 0;
            // 
            // tabPageStu
            // 
            this.tabPageStu.Controls.Add(this.buttonStuAdd);
            this.tabPageStu.Controls.Add(this.buttonStuDel);
            this.tabPageStu.Controls.Add(this.buttonStuSave);
            this.tabPageStu.Controls.Add(this.label8);
            this.tabPageStu.Controls.Add(this.label7);
            this.tabPageStu.Controls.Add(this.label6);
            this.tabPageStu.Controls.Add(this.label5);
            this.tabPageStu.Controls.Add(this.label4);
            this.tabPageStu.Controls.Add(this.textBoxStuId);
            this.tabPageStu.Controls.Add(this.comboBoxStuSex);
            this.tabPageStu.Controls.Add(this.textBoxStuName);
            this.tabPageStu.Controls.Add(this.comboBoxStuClass);
            this.tabPageStu.Controls.Add(this.comboBoxStuCollege);
            this.tabPageStu.Location = new System.Drawing.Point(4, 29);
            this.tabPageStu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageStu.Name = "tabPageStu";
            this.tabPageStu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageStu.Size = new System.Drawing.Size(493, 191);
            this.tabPageStu.TabIndex = 2;
            this.tabPageStu.Text = "学生";
            this.tabPageStu.UseVisualStyleBackColor = true;
            // 
            // buttonStuAdd
            // 
            this.buttonStuAdd.Location = new System.Drawing.Point(393, 86);
            this.buttonStuAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStuAdd.Name = "buttonStuAdd";
            this.buttonStuAdd.Size = new System.Drawing.Size(94, 27);
            this.buttonStuAdd.TabIndex = 12;
            this.buttonStuAdd.Text = "新增";
            this.buttonStuAdd.UseVisualStyleBackColor = true;
            this.buttonStuAdd.Click += new System.EventHandler(this.buttonStuAdd_Click);
            // 
            // buttonStuDel
            // 
            this.buttonStuDel.Location = new System.Drawing.Point(393, 120);
            this.buttonStuDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStuDel.Name = "buttonStuDel";
            this.buttonStuDel.Size = new System.Drawing.Size(94, 29);
            this.buttonStuDel.TabIndex = 11;
            this.buttonStuDel.Text = "删除";
            this.buttonStuDel.UseVisualStyleBackColor = true;
            this.buttonStuDel.Click += new System.EventHandler(this.buttonStuDel_Click);
            // 
            // buttonStuSave
            // 
            this.buttonStuSave.Location = new System.Drawing.Point(393, 155);
            this.buttonStuSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStuSave.Name = "buttonStuSave";
            this.buttonStuSave.Size = new System.Drawing.Size(94, 29);
            this.buttonStuSave.TabIndex = 10;
            this.buttonStuSave.Text = "保存";
            this.buttonStuSave.UseVisualStyleBackColor = true;
            this.buttonStuSave.Click += new System.EventHandler(this.buttonStuSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "学号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "班级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "学校";
            // 
            // textBoxStuId
            // 
            this.textBoxStuId.Location = new System.Drawing.Point(90, 138);
            this.textBoxStuId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStuId.Name = "textBoxStuId";
            this.textBoxStuId.ReadOnly = true;
            this.textBoxStuId.Size = new System.Drawing.Size(199, 27);
            this.textBoxStuId.TabIndex = 4;
            // 
            // comboBoxStuSex
            // 
            this.comboBoxStuSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStuSex.FormattingEnabled = true;
            this.comboBoxStuSex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxStuSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxStuSex.Location = new System.Drawing.Point(90, 104);
            this.comboBoxStuSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStuSex.Name = "comboBoxStuSex";
            this.comboBoxStuSex.Size = new System.Drawing.Size(199, 28);
            this.comboBoxStuSex.TabIndex = 3;
            // 
            // textBoxStuName
            // 
            this.textBoxStuName.Location = new System.Drawing.Point(90, 72);
            this.textBoxStuName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStuName.Name = "textBoxStuName";
            this.textBoxStuName.Size = new System.Drawing.Size(199, 27);
            this.textBoxStuName.TabIndex = 2;
            // 
            // comboBoxStuClass
            // 
            this.comboBoxStuClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStuClass.FormattingEnabled = true;
            this.comboBoxStuClass.Location = new System.Drawing.Point(90, 38);
            this.comboBoxStuClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStuClass.Name = "comboBoxStuClass";
            this.comboBoxStuClass.Size = new System.Drawing.Size(199, 28);
            this.comboBoxStuClass.TabIndex = 1;
            // 
            // comboBoxStuCollege
            // 
            this.comboBoxStuCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStuCollege.FormattingEnabled = true;
            this.comboBoxStuCollege.Location = new System.Drawing.Point(90, 5);
            this.comboBoxStuCollege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStuCollege.Name = "comboBoxStuCollege";
            this.comboBoxStuCollege.Size = new System.Drawing.Size(199, 28);
            this.comboBoxStuCollege.TabIndex = 0;
            this.comboBoxStuCollege.SelectedIndexChanged += new System.EventHandler(this.comboBoxStuCollege_SelectedIndexChanged);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.buttonLogRefresh);
            this.tabPageLog.Location = new System.Drawing.Point(4, 29);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(493, 191);
            this.tabPageLog.TabIndex = 3;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // buttonLogRefresh
            // 
            this.buttonLogRefresh.Location = new System.Drawing.Point(168, 80);
            this.buttonLogRefresh.Name = "buttonLogRefresh";
            this.buttonLogRefresh.Size = new System.Drawing.Size(94, 29);
            this.buttonLogRefresh.TabIndex = 0;
            this.buttonLogRefresh.Text = "刷新";
            this.buttonLogRefresh.UseVisualStyleBackColor = true;
            this.buttonLogRefresh.Click += new System.EventHandler(this.buttonLogRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCollege.ResumeLayout(false);
            this.tabPageCollege.PerformLayout();
            this.tabPageClass.ResumeLayout(false);
            this.tabPageClass.PerformLayout();
            this.tabPageStu.ResumeLayout(false);
            this.tabPageStu.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPageCollege;
        private TextBox textBoxCollegeId;
        private Label label2;
        private TabPage tabPageClass;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxClassCollege;
        private TabPage tabPageStu;
        private Button buttonCollegeDel;
        private Button buttonCollegeSave;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBoxCollegeStuCount;
        private TextBox textBoxCollegeClassCount;
        private TextBox textBoxCollegeName;
        private Label label13;
        private TextBox textBoxClassStuCount;
        private Label label9;
        private TextBox textBoxClassName;
        private TextBox textBoxClassId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxStuId;
        private ComboBox comboBoxStuSex;
        private TextBox textBoxStuName;
        private ComboBox comboBoxStuClass;
        private ComboBox comboBoxStuCollege;
        private Button buttonClassDel;
        private Button buttonClassSave;
        private Button buttonStuDel;
        private Button buttonStuSave;
        private Button buttonCollegeAdd;
        private Button buttonClassAdd;
        private Button buttonStuAdd;
        private TabPage tabPageLog;
        private Button buttonLogRefresh;
    }
}
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Homework6
{
    public partial class Form1 : Form
    {
        private DataTable collegeTable;
        private DataTable classTable;
        private DataTable stuTable;
        private DataTable logTable;

        public Form1()
        {
            InitializeComponent();            
            SQLiteHelper.SetConnection("edu.db");            
            SqlManager.LoadFromSql(out collegeTable, out classTable, out stuTable, out logTable);
            tabControl1_SelectedIndexChanged(tabControl1, new EventArgs());
        }

        private void buttonCollegeDel_Click(object sender, EventArgs e)
        {
            if (!checkInfos(CtrlTargetSql.College))
            {
                MessageBox.Show("信息不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(textBoxCollegeId.Text.ToString(), out int collegeId))
            {
                MessageBox.Show("ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string[] param = { collegeId.ToString()};
                if(!SqlManager.DelInfo(CtrlTargetSql.College, param))
                {
                    MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK);
                }
                else
                {
                    DataRow dataRow = (dataGridView1.CurrentRow.DataBoundItem as DataRowView).Row;
                    collegeTable.Rows.Remove(dataRow);
                    MessageBox.Show("已删除", "提示", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            
        }

        private void buttonCollegeSave_Click(object sender, EventArgs e)
        {
            if (!checkInfos(CtrlTargetSql.College))
            {
                MessageBox.Show("信息不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if(!int.TryParse(textBoxCollegeId.Text.ToString(), out int collegeId))
            {
                MessageBox.Show("ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string[] param = { collegeId.ToString(),textBoxCollegeName.Text };
                if (!SqlManager.AddInfo(CtrlTargetSql.College,param))
                {
                    MessageBox.Show("保存失败", "错误", MessageBoxButtons.OK);
                }
                else
                {
                    DataRow[] rows = collegeTable.Select($"CollegeId={textBoxCollegeId.Text}");
                    if (rows.Count() > 0)
                    {
                        rows[0][0] = collegeId.ToString();
                        rows[0][1] = textBoxCollegeName.Text;
                    }
                    else
                    {
                        DataRow newRow = collegeTable.NewRow();
                        newRow[0] = collegeId.ToString();
                        newRow[1] = textBoxCollegeName.Text;
                        collegeTable.Rows.Add(newRow);
                    }
                    MessageBox.Show("已保存", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }

        private bool checkInfos(CtrlTargetSql sourceType)
        {
            bool result = false;
            switch (sourceType)
            {
                case CtrlTargetSql.College:
                    result = !string.IsNullOrEmpty(textBoxCollegeId.Text.ToString()) && !string.IsNullOrEmpty(textBoxCollegeName.Text.ToString());
                    break;
                case CtrlTargetSql.Class:
                    result = !string.IsNullOrEmpty(textBoxClassId.Text.ToString()) && !string.IsNullOrEmpty(textBoxClassName.Text.ToString()) && !string.IsNullOrEmpty(comboBoxClassCollege.Text.ToString());
                    break;
                case CtrlTargetSql.Student:
                    result = !string.IsNullOrEmpty(textBoxStuId.Text.ToString()) && !string.IsNullOrEmpty(textBoxStuName.Text.ToString()) && !string.IsNullOrEmpty(comboBoxStuClass.Text.ToString()) && !string.IsNullOrEmpty(comboBoxStuCollege.Text.ToString()) && !string.IsNullOrEmpty(comboBoxStuSex.Text.ToString());
                    break;
                default:
                    break;
            }
            return result;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataTable.Rows.Count <= 0) return;
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow == null) return;
            int collegeId;
            int classId;
            int studentId;
            
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    if(selectedRow.Cells.Count != 2) return;
                    textBoxCollegeId.ReadOnly = true;
                    buttonCollegeDel.Enabled = true;
                    collegeId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    textBoxCollegeId.Text = selectedRow.Cells[0].Value.ToString();
                    textBoxCollegeName.Text = selectedRow.Cells[1].Value.ToString();
                    textBoxCollegeClassCount.Text = classTable.Select($"CollegeId={collegeId}").Count().ToString();
                    textBoxCollegeStuCount.Text = stuTable.Select($"CollegeId={collegeId}").Count().ToString();
                    break;
                case 1:
                    if (selectedRow.Cells.Count != 3) return;
                    textBoxClassId.ReadOnly = true;
                    buttonClassDel.Enabled = true;
                    comboBoxClassCollege.Enabled = false;
                    classId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    collegeId = Convert.ToInt32(selectedRow.Cells[2].Value);
                    textBoxClassId.Text = selectedRow.Cells[0].Value.ToString();
                    textBoxClassName.Text = selectedRow.Cells[1].Value.ToString();
                    textBoxClassStuCount.Text = stuTable.Select($"CollegeId={collegeId} and ClassId={classId}").Count().ToString();
                    comboBoxClassCollege.Items.Clear();
                    foreach(DataRow data in collegeTable.Select())
                    {
                        comboBoxClassCollege.Items.Add($"{data[0]},{data[1]}");
                    }
                    DataRow[] rows = collegeTable.Select($"CollegeId='{collegeId}'");
                    string collegeName = string.Empty;
                    if (rows != null && rows.Count() > 0) collegeName = rows[0]["Name"].ToString();
                    comboBoxClassCollege.SelectedItem = $"{collegeId},{collegeName}";
                    break;
                case 2:
                    if (selectedRow.Cells.Count != 5) return;
                    textBoxStuId.ReadOnly = true;
                    buttonClassDel.Enabled = true;
                    studentId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    classId = Convert.ToInt32(selectedRow.Cells[3].Value);
                    collegeId = Convert.ToInt32(selectedRow.Cells[2].Value);
                    textBoxStuId.Text = selectedRow.Cells[0].Value.ToString();
                    textBoxStuName.Text = selectedRow.Cells[1].Value.ToString();
                    comboBoxStuSex.SelectedIndex = selectedRow.Cells[4].Value.ToString() == "0" ? 0 : 1;
                    comboBoxStuCollege.Items.Clear();
                    foreach (DataRow data in collegeTable.Select())
                    {
                        comboBoxStuCollege.Items.Add($"{data[0]},{data[1]}");
                    }
                    rows = collegeTable.Select($"CollegeId={collegeId}");
                    collegeName = string.Empty;
                    if (rows != null && rows.Count() > 0) collegeName = rows[0]["Name"].ToString();
                    comboBoxStuCollege.SelectedItem = $"{collegeId},{collegeName}";
                    break;
                case 3:

                    break;
                default:
                    break;
            }
        }

        private void buttonCollegeAdd_Click(object sender, EventArgs e)
        {
            textBoxCollegeId.ReadOnly = false;
            buttonCollegeDel.Enabled = false;
            textBoxCollegeId.Clear();
            textBoxCollegeName.Clear();
            textBoxCollegeClassCount.Clear();
            textBoxCollegeStuCount.Clear();
        }

        private void buttonClassAdd_Click(object sender, EventArgs e)
        {
            textBoxClassId.ReadOnly = false;
            buttonClassDel.Enabled = false;
            comboBoxClassCollege.Enabled = true;
            textBoxClassId.Clear();
            textBoxClassName.Clear();
            textBoxClassStuCount.Clear();
            comboBoxClassCollege.Items.Clear();
            comboBoxStuClass.Items.Clear();
            foreach (DataRow data in collegeTable.Select())
            {
                comboBoxClassCollege.Items.Add($"{data[0]},{data[1]}");
            }
        }

        private void buttonStuAdd_Click(object sender, EventArgs e)
        {
            textBoxStuId.ReadOnly = false;
            buttonClassDel.Enabled = false;
            textBoxStuId.Clear();
            textBoxStuName.Clear();
            comboBoxStuCollege.Items.Clear();
            foreach(DataRow data in collegeTable.Select())
            {
                comboBoxStuCollege.Items.Add($"{data[0]},{data[1]}");
            }
        }

        private void buttonClassSave_Click(object sender, EventArgs e)
        {
            if (!checkInfos(CtrlTargetSql.Class))
            {
                MessageBox.Show("信息不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(textBoxClassId.Text.ToString(), out int classId))
            {
                MessageBox.Show("班级ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(comboBoxClassCollege.Text.ToString().Split(',')[0], out int collegeId))
            {
                MessageBox.Show("学校ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string[] param = { classId.ToString(), textBoxClassName.Text, collegeId.ToString() };
                if (!SqlManager.AddInfo(CtrlTargetSql.Class, param))
                {
                    MessageBox.Show("保存失败", "错误", MessageBoxButtons.OK);
                }
                else
                {
                    DataRow[] rows = classTable.Select($"ClassId={classId}");
                    if (rows.Count() > 0)
                    {
                        rows[0][0] = classId.ToString();
                        rows[0][1] = textBoxCollegeName.Text;
                        rows[0][2] = collegeId.ToString();
                    }
                    else
                    {
                        DataRow newRow = classTable.NewRow();
                        newRow[0] = classId.ToString();
                        newRow[1] = textBoxClassName.Text;
                        newRow[2] = collegeId.ToString();
                        classTable.Rows.Add(newRow);
                    }
                    MessageBox.Show("已保存", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void buttonClassDel_Click(object sender, EventArgs e)
        {
            if (!checkInfos(CtrlTargetSql.Class))
            {
                MessageBox.Show("信息不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(textBoxClassId.Text.ToString(), out int classId))
            {
                MessageBox.Show("班级ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(comboBoxClassCollege.Text.ToString().Split(',')[0], out int collegeId))
            {
                MessageBox.Show("学校ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string[] param = { classId.ToString(),collegeId.ToString() };
                if (!SqlManager.DelInfo(CtrlTargetSql.Class, param))
                {
                    MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK);
                }
                else
                {
                    DataRow dataRow = (dataGridView1.CurrentRow.DataBoundItem as DataRowView).Row;
                    classTable.Rows.Remove(dataRow);
                    MessageBox.Show("已删除", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = collegeTable;
                    break;
                case 1:
                    dataGridView1.DataSource = classTable;
                    break;
                case 2:
                    dataGridView1.DataSource = stuTable;
                    break;
                case 3:
                    dataGridView1.DataSource = logTable;
                    break;
                default:
                    break;
            }
        }

        private void comboBoxStuCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStuCollege.Text.Count() == 0) return;
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if(selectedRow == null || selectedRow.Cells.Count == 0)
            {
                string[] college = comboBoxStuCollege.SelectedItem.ToString().Split(',');
                comboBoxStuClass.Items.Clear();
                foreach (DataRow data in classTable.Select($"CollegeId={college[0]}"))
                {
                    comboBoxStuClass.Items.Add($"{data[0]},{data[1]}");
                }
            }
            else
            {
                int classId = Convert.ToInt32(selectedRow.Cells[3].Value);
                int collegeId = Convert.ToInt32(selectedRow.Cells[2].Value);
                if (comboBoxStuCollege.SelectedItem == null) return;
                string[] college = comboBoxStuCollege.SelectedItem.ToString().Split(',');
                DataRow[] rows = classTable.Select($"CollegeId={collegeId}");
                string className = string.Empty;
                if (rows != null && rows.Count() > 0) className = rows[0]["Name"].ToString();

                comboBoxStuClass.Items.Clear();
                foreach (DataRow data in classTable.Select($"CollegeId={college[0]}"))
                {
                    comboBoxStuClass.Items.Add($"{data[0]},{data[1]}");
                }
                if (collegeId.ToString() == college[0])
                {
                    comboBoxStuClass.SelectedItem = $"{classId},{className}";
                }
            }                          
        }

        private void buttonStuDel_Click(object sender, EventArgs e)
        {
            if (!checkInfos(CtrlTargetSql.Student))
            {
                MessageBox.Show("信息不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(comboBoxStuClass.Text.ToString().Split(',')[0], out int classId))
            {
                MessageBox.Show("班级ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(comboBoxStuCollege.Text.ToString().Split(',')[0], out int collegeId))
            {
                MessageBox.Show("学校ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(textBoxStuId.Text.ToString(), out int studentId))
            {
                MessageBox.Show("学号有误", "提示", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string[] param = { studentId.ToString(), collegeId.ToString(), classId.ToString() };
                if (!SqlManager.DelInfo(CtrlTargetSql.Student, param))
                {
                    MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK);
                }
                else
                {
                    DataRow dataRow = (dataGridView1.CurrentRow.DataBoundItem as DataRowView).Row;
                    stuTable.Rows.Remove(dataRow);
                    MessageBox.Show("已删除", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void buttonStuSave_Click(object sender, EventArgs e)
        {
            if (!checkInfos(CtrlTargetSql.Student))
            {
                MessageBox.Show("信息不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(comboBoxStuClass.Text.ToString().Split(',')[0], out int classId))
            {
                MessageBox.Show("班级ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(comboBoxStuCollege.Text.ToString().Split(',')[0], out int collegeId))
            {
                MessageBox.Show("学校ID有误", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(textBoxStuId.Text.ToString(), out int studentId))
            {
                MessageBox.Show("学号有误", "提示", MessageBoxButtons.OK);
                return;
            }
            int sex = comboBoxStuSex.Text.ToString() == "男" ? 0 : 1;
            try
            {
                string[] param = { studentId.ToString(), textBoxStuName.Text, collegeId.ToString(), classId.ToString(), sex.ToString()};
                if (!SqlManager.AddInfo(CtrlTargetSql.Student, param))
                {
                    MessageBox.Show("保存失败", "错误", MessageBoxButtons.OK);
                }
                else
                {
                    DataRow[] rows = stuTable.Select($"ClassId={classId}");
                    if (rows.Count() > 0)
                    {
                        rows[0][0] = studentId.ToString();
                        rows[0][1] = textBoxStuName.Text;
                        rows[0][2] = collegeId.ToString();
                        rows[0][3] = classId.ToString();
                        rows[0][4] = sex.ToString();
                    }
                    else
                    {
                        DataRow newRow = stuTable.NewRow();
                        newRow[0] = studentId.ToString();
                        newRow[1] = textBoxStuName.Text;
                        newRow[2] = collegeId.ToString();
                        newRow[3] = classId.ToString();
                        newRow[4] = sex.ToString();
                        stuTable.Rows.Add(newRow);
                    }
                    MessageBox.Show("已保存", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void buttonLogRefresh_Click(object sender, EventArgs e)
        {
            logTable.Clear();
            foreach (DataRow row in SqlManager.RefreshLog())
            {
                DataRow dataRow = logTable.NewRow();
                dataRow[0] = row[0].ToString();
                dataRow[1] = row[1].ToString();
                logTable.Rows.Add(dataRow);
            }
        }
    }
}
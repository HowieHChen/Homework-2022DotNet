using System.Collections;
using System.Data;

namespace Homework3
{
    public partial class Form1 : Form
    {
        private string nowFilePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_PickFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "C# 源文件|*.cs|所有文件|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                string fileName = dialog.SafeFileName;
                label_FileName.Text = fileName;
                label_FilePath.Text = filePath;
                nowFilePath = filePath;
            }
        }

        private void button_Count_Click(object sender, EventArgs e)
        {
            FuncUtils.BaseCount(nowFilePath, out int wordCount, out int lineCount);
            MessageBox.Show("词数：" + wordCount.ToString() + "\n行数：" + lineCount.ToString());
        }

        private void button_CountFormat_Click(object sender, EventArgs e)
        {
            Hashtable hashtable = FuncUtils.AdvancedCount(
                FuncUtils.FormatText(nowFilePath),
                out int wordCount,
                out int lineCount);
            ArrayList akeys = new ArrayList(hashtable.Keys);
            akeys.Sort();
            listView1.Items.Clear();
            foreach (string key in akeys)
            {
                ListViewItem item = new ListViewItem(key);
                item.SubItems.Add(hashtable[key].ToString());
                listView1.Items.Add(item);
            }
            MessageBox.Show("词数：" + wordCount.ToString() + "\n行数：" + lineCount.ToString());
        }


    }
}
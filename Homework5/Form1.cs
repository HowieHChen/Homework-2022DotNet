using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Homework5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listViewResult.Items.Clear();
            richTextBoxOutput.Clear();
            if (textBoxKeyword.Text == string.Empty || textBoxKeyword.Text == string.Empty) return;
            string keyword = textBoxKeyword.Text;
            bool isBaidu = checkBoxBaidu.Checked;
            bool isBing = checkBoxBing.Checked;
            if (!int.TryParse(textBoxCount.Text, out int targetCount)) targetCount = 100;
            Crawler crawler = new Crawler(keyword, isBaidu, isBing, targetCount);
            crawler.PrintLogDelegate += new Crawler.PrintLog(PrintLog);
            crawler.OutputPhoneDelegate += new Crawler.OutputPhone(PrintPhone);
            crawler.AccessControlDelegate += new Crawler.AccessControl(AccessControl);
            new Thread(crawler.Start).Start();
        }

        public void PrintPhone(string phone, string url)
        {
            this.Invoke(new Action(() =>
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    phone, url
                });
                listViewResult.Items.Add(item);
                listViewResult.Items[listViewResult.Items.Count - 1].EnsureVisible();
            }));            
        }

        public void PrintLog(string log)
        {
            string time = DateTime.Now.ToString();
            this.Invoke(new Action(() =>
            {
                richTextBoxOutput.AppendText(time + " " + log);
                richTextBoxOutput.AppendText(System.Environment.NewLine);
            }));
        }

        public void AccessControl(bool enabled)
        {
            this.Invoke(new Action(() =>
            {
                checkBoxBaidu.Enabled = checkBoxBing.Enabled = 
                textBoxKeyword.Enabled = textBoxCount.Enabled = 
                buttonSearch.Enabled = enabled;
            }));
        }
    }
}
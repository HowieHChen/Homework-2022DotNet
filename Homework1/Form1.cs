namespace Homework1
{
    public partial class Form1 : Form
    {
        private int answer = 0;
        private bool state = false;
        private int score = 0;
        private int ticks = 15;
        private System.Timers.Timer timer;
        const int interval = 1000;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer()
            {
                Interval = interval,
                Enabled = false
            };
            timer.Elapsed += (s, e) =>
            {
                ticks--;
                if (ticks <= 0)
                {
                    ticks = 15;
                    UpdateQuestion();
                }
                UpdateTicks();
            };
        }

        private void button_hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Task 1");
        }

        private void button_prime_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_prime.Text.ToString(), out int result) || result < 0)
            {
                MessageBox.Show("请输入一个正整数！", "错误");
                textBox_prime.Text = String.Empty;
                return;
            }
            else
            {
                string answer = GetPrimeFactors(result);
                MessageBox.Show(answer, "结果");
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                MessageBox.Show("请先开始！", "提示");
                return;
            }
            if (!int.TryParse(textBox_answer.Text.ToString(), out int myResult))
            {
                MessageBox.Show("请输入一个整数！", "错误");
                return;
            }
            if (myResult == answer)
            {
                UpdateQuestion();
                ticks = 15;
                label_ticks.Text = "15";
                score++;
                label_score.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("答案错误！", "错误");
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (state)
            {
                MessageBox.Show("已经开始了！", "提示");
                return;
            }
            UpdateQuestion();
            label_score.Text = "0";
            label_ticks.Text = "15";
            score = 0;
            state = true;
            timer.Start();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                MessageBox.Show("请先开始！", "提示");
                return;
            }
            string tips = "您的得分是" + score.ToString();
            answer = 0;
            score = 0;
            state = false;
            label_formula.Text = "请先开始";
            label_ticks.Text = "0";
            label_score.Text = "0";
            timer.Stop();
            MessageBox.Show(tips, "您的成绩");
        }

        private string GetPrimeFactors(int target)
        {
            string result = target.ToString() + ": ";
            while (target % 2 == 0)
            {
                result += "2 ";
                target /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(target); i += 2)
            {
                while (target % i == 0)
                {
                    result += (i + " ");
                    target /= i;
                }
            }
            if (target > 2)
            {
                result += target;
            }
            return result;
        }

        private delegate void UpdateTicksDelegate();
        private void UpdateTicks()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateTicksDelegate(UpdateTicks));
            }
            else
            {
                label_ticks.Text = ticks.ToString();
            }
        }


        private delegate void UpdateQuestionDelegate();
        private void UpdateQuestion()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateQuestionDelegate(UpdateQuestion));
            }
            else
            {
                string question = string.Empty;
                answer = GetQuestion(ref question);
                label_formula.Text = question;
            }
        }

        private int GetQuestion(ref string question)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            int count = random.Next(1, 3);  //几个符号
            int result = random.Next(50);   //第一个数字
            question = result.ToString();
            for (int i = 0; i < count; i++)
            {
                int num = random.Next(50);
                if (random.Next(2) % 2 == 0) //加号
                {
                    result += num;
                    question += "+";
                }
                else //减号
                {
                    result -= num;
                    question += "-";
                }
                question += num.ToString();
            }
            return result;
        }
    }
}
namespace Homework_2022DotNet
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
                if(ticks <= 0)
                {
                    ticks = 15;
                    UpdateQuestion();
                }
                UpdateTicks();
            };
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
                label_Ticks.Text = ticks.ToString();
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
                label_Question.Text = question;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!","Task 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text.ToString(),out int result) || result < 0)
            {
                MessageBox.Show("请输入一个正整数！", "Warning");
                textBox1.Text = String.Empty;
                return;
            }
            else
            {
                string answer = GetPrimeFactors(result);
                MessageBox.Show(answer, "Result");
            }
        }

        private string GetPrimeFactors(int target)
        {
            string result = target.ToString() + ": ";
            while(target % 2 == 0)
            {
                result += "2 ";
                target /= 2;
            }
            for(int i = 3; i <= Math.Sqrt(target); i += 2)
            {
                while(target % i == 0)
                {
                    result += (i + " ");
                    target /= i;
                }
            }
            if(target > 2)
            {
                result += target;
            }
            return result;
        }

        private void label_Score_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (state)
            {
                MessageBox.Show("已经开始了！", "提示");
                return;
            }
            UpdateQuestion();
            score = 0;
            state = true;
            timer.Start();
        }

        private int GetQuestion(ref string question)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            int count = random.Next(1,3);  //几个符号
            int result = random.Next(50);   //第一个数字
            question = result.ToString();    
            for(int i = 0; i < count; i++)
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                label_Question.Text = "请点击开始";
                return;
            }
            string tips = "您的得分是" + score.ToString();
            answer = 0;
            score = 0;
            state = false;
            label_Question.Text = "请先开始";
            label_Ticks.Text = "0";
            label_Score.Text = "0";
            timer.Stop();
            MessageBox.Show(tips, "Result");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                MessageBox.Show("请先开始！", "Warning");
                return;
            }
            if(!int.TryParse(textBox2.Text.ToString(), out int myResult))
            {
                MessageBox.Show("请输入一个整数！", "Warning");
                return;
            }
            if(myResult == answer)
            {
                UpdateQuestion();
                ticks = 15;
                score++;
                label_Score.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("答案错误！", "Warning");
            }
        }
    }
}
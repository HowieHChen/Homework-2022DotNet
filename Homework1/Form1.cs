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
                MessageBox.Show("������һ����������", "����");
                textBox_prime.Text = String.Empty;
                return;
            }
            else
            {
                string answer = GetPrimeFactors(result);
                MessageBox.Show(answer, "���");
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                MessageBox.Show("���ȿ�ʼ��", "��ʾ");
                return;
            }
            if (!int.TryParse(textBox_answer.Text.ToString(), out int myResult))
            {
                MessageBox.Show("������һ��������", "����");
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
                MessageBox.Show("�𰸴���", "����");
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (state)
            {
                MessageBox.Show("�Ѿ���ʼ�ˣ�", "��ʾ");
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
                MessageBox.Show("���ȿ�ʼ��", "��ʾ");
                return;
            }
            string tips = "���ĵ÷���" + score.ToString();
            answer = 0;
            score = 0;
            state = false;
            label_formula.Text = "���ȿ�ʼ";
            label_ticks.Text = "0";
            label_score.Text = "0";
            timer.Stop();
            MessageBox.Show(tips, "���ĳɼ�");
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
            int count = random.Next(1, 3);  //��������
            int result = random.Next(50);   //��һ������
            question = result.ToString();
            for (int i = 0; i < count; i++)
            {
                int num = random.Next(50);
                if (random.Next(2) % 2 == 0) //�Ӻ�
                {
                    result += num;
                    question += "+";
                }
                else //����
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
using System.Runtime.CompilerServices;

namespace Homework2
{
    public partial class Form1 : Form
    {
        ATM atm;
        bool isLogin = false;

        public Form1()
        {
            BigMoneyFetched += BigMoneyAlert;
            InitializeComponent();
            atm = new ATM();
        }

        public event BigMoneyFetchedEventHandler BigMoneyFetched;

        public void BigMoneyAlert(object sender, BigMoneyArgs args)
        {
            string tips = "�˺�" + args.account.AccountID + "����ȡ��" + args.amount + "Ԫ��";
            MessageBox.Show(tips, "ATM");
        }

        private void button_B_Open_Click(object sender, EventArgs e)
        {
            string cardID = textBox_B_ID.Text;
            string password = textBox_B_PWD.Text;
            int isCredit = checkBox_Credit.Checked ? 1 : 0;
            if(cardID == string.Empty || password == string.Empty)
            {
                MessageBox.Show("�˺ź����벻��Ϊ��", "Bank");
                return;
            }
            atm.GetBank.SignUp(isCredit, cardID, password);
        }

        private void button_Signin_Click(object sender, EventArgs e)
        {
            string cardID = textBox_A_ID.Text;
            string password = textBox_A_PWD.Text;
            int isCredit = checkBox_A_credit.Checked ? 1 : 0;
            if(atm.SignIn(isCredit, cardID, password))
            {
                isLogin = true;
                UpdateAmount();
                label_credit.Visible = label9.Visible = atm.IsCredit ? true : false;
                MessageBox.Show("��½�ɹ�", "ATM");
            }
            else
            {
                isLogin = false;
                label_credit.Visible = label9.Visible = true;
                label_amount.Text = label_credit.Text = "0";
                MessageBox.Show("��½ʧ�ܣ��˺Ų����ڻ��������", "ATM");
            }
        }

        private void button_Deposit_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("��δ��¼", "ATM");
                return;
            }
            if(double.TryParse(textBox_amount.Text, out double result) && atm.DepositMoney(result))
            {
                UpdateAmount();
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�������", "ATM");
            }
        }

        private void button_Withdraw_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("��δ��¼", "ATM");
                return;
            }
            if (double.TryParse(textBox_amount.Text, out double result))
            {
                try
                {
                    switch (atm.WithdrawMoney(result))
                    {
                        case 0:
                            MessageBox.Show("����ʧ�ܣ������������ö��", "ATM");
                            break;
                        case 1:
                            UpdateAmount();
                            break;
                        case 2:
                            MessageBox.Show("�˻����㣬��ʹ�����ö��", "ATM");
                            UpdateAmount();
                            break;
                        default:
                            MessageBox.Show("����ʧ�ܣ������������ö��", "ATM");
                            break;
                    }
                }
                catch(BadCashException ex)
                {
                    MessageBox.Show(ex.Message, "ATM");
                }
                if(result > 10000)
                {
                    BigMoneyArgs args = new BigMoneyArgs();
                    args.amount = result;
                    args.account = atm.GetAccount();
                    BigMoneyFetched(this, args);
                }
            }
            else
            {
                MessageBox.Show("����ʧ�ܣ�������", "ATM");
            }
        }

        private void UpdateAmount()
        {
            label_amount.Text = atm.GetAmount().ToString();
            label_credit.Text = atm.GetCreditAmount().ToString();
        }
    }
}
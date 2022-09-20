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
            string tips = "ÕËºÅ" + args.account.AccountID + "³¢ÊÔÈ¡¿î" + args.amount + "Ôª£¡";
            MessageBox.Show(tips, "ATM");
        }

        private void button_B_Open_Click(object sender, EventArgs e)
        {
            string cardID = textBox_B_ID.Text;
            string password = textBox_B_PWD.Text;
            int isCredit = checkBox_Credit.Checked ? 1 : 0;
            if(cardID == string.Empty || password == string.Empty)
            {
                MessageBox.Show("ÕËºÅºÍÃÜÂë²»ÄÜÎª¿Õ", "Bank");
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
                MessageBox.Show("µÇÂ½³É¹¦", "ATM");
            }
            else
            {
                isLogin = false;
                label_credit.Visible = label9.Visible = true;
                label_amount.Text = label_credit.Text = "0";
                MessageBox.Show("µÇÂ½Ê§°Ü£¬ÕËºÅ²»´æÔÚ»òÃÜÂë´íÎó", "ATM");
            }
        }

        private void button_Deposit_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("ÄúÎ´µÇÂ¼", "ATM");
                return;
            }
            if(double.TryParse(textBox_amount.Text, out double result) && atm.DepositMoney(result))
            {
                UpdateAmount();
            }
            else
            {
                MessageBox.Show("²Ù×÷Ê§°Ü£¬Çë¼ì²é½ð¶î", "ATM");
            }
        }

        private void button_Withdraw_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("ÄúÎ´µÇÂ¼", "ATM");
                return;
            }
            if (double.TryParse(textBox_amount.Text, out double result))
            {
                try
                {
                    switch (atm.WithdrawMoney(result))
                    {
                        case 0:
                            MessageBox.Show("²Ù×÷Ê§°Ü£¬Çë¼ì²éÓà¶î»òÐÅÓÃ¶î¶È", "ATM");
                            break;
                        case 1:
                            UpdateAmount();
                            break;
                        case 2:
                            MessageBox.Show("ÕË»§Óà¶î²»×ã£¬ÒÑÊ¹ÓÃÐÅÓÃ¶î¶È", "ATM");
                            UpdateAmount();
                            break;
                        default:
                            MessageBox.Show("²Ù×÷Ê§°Ü£¬Çë¼ì²éÓà¶î»òÐÅÓÃ¶î¶È", "ATM");
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
                MessageBox.Show("²Ù×÷Ê§°Ü£¬Çë¼ì²é½ð¶î", "ATM");
            }
        }

        private void UpdateAmount()
        {
            label_amount.Text = atm.GetAmount().ToString();
            label_credit.Text = atm.GetCreditAmount().ToString();
        }
    }
}
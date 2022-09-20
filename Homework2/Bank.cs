using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Account
    {
        private string accountID;
        private string password;
        private double totalAmount;

        public Account()
        {

        }
        public Account(string id, string pwd)
        {
            accountID = id;
            password = pwd;
            totalAmount = 0;
        }

        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public string AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool DepositMoney(double amount)
        {
            if (amount < 0) return false;
            totalAmount += amount;
            return true;
        }

        public int WithdrawMoney(double amount)
        {
            Random random = new Random(DateTime.Now.Second);
            if (random.Next(0, 10) < 3) throw new BadCashException("出钞错误");
            // if (amount < 0) return 0;
            if (0 < amount && amount <= totalAmount)
            {
                totalAmount -= amount;
                return 1;
            }
            return 0;
        }

    }
    public class CreditAccount : Account
    {
        private double creditAmount;

        public double CreditAmount { get { return creditAmount; } }
        public CreditAccount(string id, string pwd): base( id, pwd)
        {
            creditAmount = 5000;
        }

        public new int WithdrawMoney(double amount)
        {
            Random random = new Random(DateTime.Now.Second);
            if (random.Next(0, 10) < 3) throw new BadCashException("出钞错误");
            if (amount < 0) return 0;
            if (amount <= TotalAmount)
            {
                TotalAmount -= amount;
                return 1;
            }
            else if(amount <= TotalAmount + creditAmount)
            {
                creditAmount -= (amount - TotalAmount);
                TotalAmount = 0;                
                return 2;
            }
            return 0;
        }

    }
    public class Bank
    {
        List<Account> accounts = new List<Account>();
        List<CreditAccount> creditAccounts = new List<CreditAccount>();

        public void SignUp(int type, string id, string pwd)
        {
            if(type == 0) accounts.Add(new Account(id, pwd));
            else if(type == 1) creditAccounts.Add(new CreditAccount(id,pwd));
        }

        public List<Account> Accounts { get { return accounts; } }
        public List<CreditAccount> CreditAccounts { get { return creditAccounts; } }

    }
    public class ATM
    {
        Bank bank = new Bank();
        Account nowAccount;
        CreditAccount nowCreditAccount;
        bool isCredit;

        public Bank GetBank { get { return bank; } }
        public bool IsCredit { get { return isCredit; } }

        public bool SignIn(int type, string id, string pwd)
        {
            if(type == 0)
                foreach (Account account in bank.Accounts)
                {
                    if (account.AccountID == id && account.Password == pwd) { nowAccount = account; isCredit = false; return true; }
                }
            else if(type == 1)
                foreach (CreditAccount account in bank.CreditAccounts)
                {
                    if (account.AccountID == id && account.Password == pwd) { nowCreditAccount = account; isCredit = true; return true; }
                }
            return false;
        }

        public Account GetAccount()
        {
            return isCredit ? nowCreditAccount : nowAccount;
        }

        public double GetAmount()
        {
            return isCredit ? nowCreditAccount.TotalAmount : nowAccount.TotalAmount;
        }

        public double GetCreditAmount()
        {
            return isCredit ? nowCreditAccount.CreditAmount : 0;
        }

        public bool DepositMoney(double amount)
        {
            return isCredit ? nowCreditAccount.DepositMoney(amount) : nowAccount.DepositMoney(amount);
        }

        public int WithdrawMoney(double amount)
        {
            return isCredit ? nowCreditAccount.WithdrawMoney(amount) : nowAccount.WithdrawMoney(amount);
        }
    }
}

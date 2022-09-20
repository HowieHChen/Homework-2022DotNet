using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class BigMoneyArgs : EventArgs
    {
        public Account account;
        public double amount;
    }

    public delegate void BigMoneyFetchedEventHandler(object sender, BigMoneyArgs args);

    public class BadCashException : ApplicationException
    {
        public BadCashException(string message) : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Account
    {
        public string AccountOwner { get; }
        public string AccountNumber { get;  }

        public double Amount { get; protected set; }

        

        public Account(string accountOwner, string accountNumber)
        {
            AccountOwner = accountOwner;
            AccountNumber = accountNumber;
        }

        public double Deposit(double amountToDeposit)
        {
            Amount += amountToDeposit;

            return Amount;
        }

        public virtual double Withdraw(double amountToWithdraw)
        {
            if (amountToWithdraw > Amount)
            {
                return 0;
            }
            else
            {
                Amount -= amountToWithdraw;
            }

            return Amount;
        }
    }
}

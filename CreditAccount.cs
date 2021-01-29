using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class CreditAccount : Account
    {
        public double CreditLimit { get; set; }
        public CreditAccount(string accountOwner, string accountNumber, double creditLimit) 
            : base(accountOwner, accountNumber)
        {
            CreditLimit = creditLimit;
        }

        public override double Withdraw(double amountToWithdraw)
        {
            if (amountToWithdraw > Amount + CreditLimit)
            {
                return Amount;
            }
            else
            {
                Amount -= amountToWithdraw;
            }

            return Amount;
        }
    }
}

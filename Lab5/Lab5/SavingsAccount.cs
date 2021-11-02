using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class SavingsAccount : Account
    {
        private decimal InterestRate { get; }
        public SavingsAccount(decimal initialBalance, decimal interestRate)
        {
            if (interestRate< (Decimal)0.00)
            {
                Console.WriteLine("Not a valid interest rate");
                throw new Exception("Not a valid interest rate.");
            }
            else
            {
                base.balance = initialBalance;
                this.InterestRate = interestRate;
            }
        }
        public decimal calculateInterest(decimal initialBalance)
        {
            return InterestRate * initialBalance;
        }

        public override decimal Credit(decimal creditAmount, out string transactionMessage)
        {
            return base.Credit(creditAmount, out transactionMessage);
        }

        public override decimal Debit(decimal debitAmount, out string transactionMessage)
        {
            return base.Debit(debitAmount, out transactionMessage);
        }
    }
}

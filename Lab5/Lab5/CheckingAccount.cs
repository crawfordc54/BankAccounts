using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class CheckingAccount : Account
    {
        private decimal feePerTransaction;
        public CheckingAccount(decimal initialBalance, decimal feePerTransaction)
        {
            if(feePerTransaction < 0)
            {
                throw new Exception("Fee must be greater than zero.");
            }
            else
            {
                base.balance = initialBalance;
                this.feePerTransaction = feePerTransaction;
            }
        }

        public override decimal Credit(decimal creditAmount, out string transactionMessage)
        {
            if(creditAmount < feePerTransaction)
            {
                transactionMessage = "Debit amount must exceed the $" + feePerTransaction + " transaction fee.";
                    return 0;
            }
            if(creditAmount < 0)
            {

                transactionMessage = "Incoming Credit amount is less than 0.00";
                return 0;
            }
            balance = creditAmount + balance;
            transactionMessage = "Amount of $" + creditAmount + " deposited.";
            return creditAmount - feePerTransaction;
        }

        public override decimal Debit(decimal debitAmount, out string transactionMessage)
        {
            if (debitAmount + feePerTransaction > base.balance)
            {
                transactionMessage = "Debt amount plus the $" + feePerTransaction + " transaction fee exceeded the account balance";
                return 0;
            }
            else
            {
                balance = debitAmount - balance;
                transactionMessage = "A $" + feePerTransaction + " transaction fee was charged";
                return debitAmount + feePerTransaction;
            }
        }

    }
}

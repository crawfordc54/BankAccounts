namespace Lab5
{
    class Account
    {
        public decimal balance;
        public Account()
        {

        }
        public Account(decimal initialBalance, decimal feePerTransaction)
        {
            this.balance = initialBalance;
        } 

        public virtual decimal Credit(decimal creditAmount, out string transactionMessage)
        {
            if (creditAmount < 0)
            {
                transactionMessage = "Incoming Credit amount is less than 0.00.";
                return (decimal)0.00;
            } else
            {
                transactionMessage = "$" + creditAmount + " deposited.";
                balance += creditAmount;
                return (decimal)balance;
            }
        }


        public virtual decimal Debit(decimal debitAmount, out string transactionMessage)
        {
            if (debitAmount > balance) { 
                transactionMessage = "Debit transaction amount exceeds balance";
                return (decimal)0.00;
            } else
            {
                transactionMessage = "$" + debitAmount + " withdrawn.";
                balance -= debitAmount;
                return (decimal)balance;
            }
        }
    }
}

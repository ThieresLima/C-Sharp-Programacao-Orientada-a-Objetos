﻿namespace Course.Entities
{
    class BusinessAccount : Account  // É UM. BusinessAccount é um Account.
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)  // aproveitando o construtor da classe Account (SuperClasse)
        {                                                     
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
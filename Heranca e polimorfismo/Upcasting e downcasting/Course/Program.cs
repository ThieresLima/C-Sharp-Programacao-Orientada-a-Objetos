﻿using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING = SubClasse para SuperClasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 00.1);

            // DOWNCASTING = SuperClasse para subclasse

            BusinessAccount acc4 = (BusinessAccount)acc2; // casting.
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3; // erro n é uma extensao do BusinessAccount.

            if (acc3 is BusinessAccount) // is = é uma instancia de ...
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // as = casting.
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
             
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpDateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}

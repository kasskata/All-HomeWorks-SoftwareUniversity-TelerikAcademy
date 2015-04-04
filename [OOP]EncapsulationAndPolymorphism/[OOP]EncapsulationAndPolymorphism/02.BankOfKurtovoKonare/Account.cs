using System;

namespace _02.BankOfKurtovoKonare
{
    public abstract class Account
    {
        public Account(string customer, decimal balance, decimal interestRate, TypeAcc type)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.TypeAcc = type;

        }

        TypeAcc TypeAcc { get; set; }
        string Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

        public virtual decimal InterestOnPeriod(int months)
        {
            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}

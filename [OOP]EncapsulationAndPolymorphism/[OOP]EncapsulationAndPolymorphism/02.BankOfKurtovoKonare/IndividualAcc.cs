﻿namespace _02.BankOfKurtovoKonare
{
    using System;

    public class IndividualAcc : Account
    {
        public IndividualAcc(string customer, decimal balance, decimal interestRate, TypeAcc type)
            : base(customer, balance, interestRate, type)
        {
        }

        public TypeAcc Type { get; set; }

        public string Customer { get; set; }

        public decimal Balance{ get; set; }

        public decimal InterestRate { get; set; }

        public override decimal InterestOnPeriod(int months)
        {
            switch (this.Type)
            {
                case TypeAcc.Loan:
                    return base.InterestOnPeriod(months - 3);
                case TypeAcc.Deposit:
                    if (this.Balance >= 1000)
                    {
                        return 0;
                    }
                    else
                    {
                        return base.InterestOnPeriod(months);
                    }
                case TypeAcc.Mortgage:
                    if (months <= 6)
                    {
                        return base.InterestOnPeriod(months) / 2;
                    }
                    else
                    {
                        var interestFirstYear = base.InterestOnPeriod(6) / 2;
                        return base.InterestOnPeriod(months - 6) + interestFirstYear;
                    }
            }
            throw new ArgumentException("Can't have account without type of the account");
        }
    }
}

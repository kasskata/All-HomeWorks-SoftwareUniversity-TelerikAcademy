namespace BankManagment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LoanAcc : Account
    {
        public decimal NewDeposit(decimal amount)
        {
            return amount + this.Balance;
        }
        public override decimal InterestRate(byte months)
        {
            if (this.isEnterprice == false)
            {
                return (months - 3) * this.InterestRatePerMoth;
            }
            else
            {
                return (months - 2) * this.InterestRatePerMoth;
            }
        }
    }
}

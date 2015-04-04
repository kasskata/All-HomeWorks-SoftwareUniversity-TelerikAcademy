namespace BankManagment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MortgageAcc : Account
    {
        public decimal NewDeposit(decimal amount)
        {
            return amount + this.Balance;
        }
        public override decimal InterestRate(byte months)
        {
            if (months <= 12 && this.isEnterprice == true)
            {
                return base.InterestRate(months)/2;
            }
            else if (months <= 6 && isEnterprice == false)
            {
                return 0;
            }
            else
            {
                return base.InterestRate(months);
            }
        }
    }
}

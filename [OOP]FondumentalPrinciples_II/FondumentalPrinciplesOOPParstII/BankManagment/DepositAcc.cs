namespace BankManagment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DepositAcc : Account
    {
        public override decimal InterestRate(byte months)
        {
            if (this.Balance >= 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else return base.InterestRate(months);
        }
       
        public decimal NewDeposit(decimal amount)
        {
            return amount + this.Balance;
        }
        
        public decimal WithDraw(decimal amount)
        {
            return this.Balance - amount;
        }
    }
}

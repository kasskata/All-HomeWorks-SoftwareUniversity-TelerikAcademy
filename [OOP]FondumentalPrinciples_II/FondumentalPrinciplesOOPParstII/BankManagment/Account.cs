namespace BankManagment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Account
    {
        protected bool isEnterprice ;

        public string CustomerName { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRatePerMoth { get; set; }
        // public bool IsEnterprice { get { return this.isEnterprice; } protected set { value = true; } }

        public virtual decimal InterestRate(byte months)
        {
            return months * this.InterestRatePerMoth;
        }
    }
}

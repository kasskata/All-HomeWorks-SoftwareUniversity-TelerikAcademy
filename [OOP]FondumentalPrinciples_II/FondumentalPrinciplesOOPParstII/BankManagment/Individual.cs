namespace BankManagment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Individual : Account
    {
        public Individual()
        {
            this.isEnterprice = false;
        }
        public List<Account> allAcconCostumer { get;set; }
    }
}

namespace _01.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Payment
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}",this.ProductName,this.Price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{

    public class Sale
    {
        private double price;
        private string productName;
        public Sale(string product, DateTime date, double price)
        {
            this.ProductName = product;
            this.Date = date;
            this.Price = price;
        }
        public string ProductName
        {
            get
            {
                if (string.IsNullOrEmpty(this.productName))
                {
                    throw new ArgumentNullException("ProductName cant be null");
                }
                return this.productName;
            }
            private set
            {
            }
        }

        public DateTime Date { get; set; }

        public double Price
        {
            get
            {
                if (this.price == 0)
                {
                    throw new ArgumentNullException("Price cant be null");
                }
                return this.price;
            }
            set
            {
            }
        }
    }
}

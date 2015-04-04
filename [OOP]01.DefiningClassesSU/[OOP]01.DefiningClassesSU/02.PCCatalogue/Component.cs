using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.PCCatalogue
{
    public class Component
    {
        private string name;
        private decimal price;
        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
        public string Name
        {
            get
            {
                if (this.name == "")
                {
                    throw new ArgumentNullException("Invalid value for NAME");
                }
                else return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public string Details { get; set; }

        public decimal Price
        {
            get
            {
                if (this.price == 0 )
                {
                    throw new ArgumentNullException("Invalid value for PRICE");
                }
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }
        public override string ToString()
        {
            return "Component: " + "========================================" + "\n" + " Name: " + this.Name + " Details: "+(this.Details == "" ? "None" : this.Details) + " Price: " + this.Price;
        }
    }
}

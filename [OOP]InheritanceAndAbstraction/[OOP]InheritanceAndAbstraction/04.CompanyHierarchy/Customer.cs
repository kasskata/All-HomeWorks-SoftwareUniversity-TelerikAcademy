using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{
    public class Customer : IPerson
    {
        private decimal spend;
        private string firstName;
        private string lastName;
        public Customer(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.Spend = 0;
        }
        public decimal Spend
        {
            get
            {
                return this.spend;
            }
            set
            {
                if ((this.spend + value) < this.spend)
                {
                    throw new ArgumentNullException("Cant devide or do nothing on spend");
                }
            }
        }

        public string FirstName
        {
            get
            {
                if (string.IsNullOrEmpty(this.firstName))
                {
                    throw new ArgumentNullException("The name cant be null!");
                }
                return this.firstName;
            }
            private set
            {
            }
        }

        public string ID { get; private set; }

        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(this.lastName))
                {
                    throw new ArgumentNullException("The name cant be null!");

                }
                return this.lastName;
            }
            private set
            {
            }
        }
    }
}

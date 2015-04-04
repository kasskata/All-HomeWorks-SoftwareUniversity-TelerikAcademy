using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.CompanyHierarchy
{
    public abstract class Employee : IPerson
    {
        private decimal salary;
        private string id;
        private string lastName;
        private string firstName;
        public Employee(string name, string lastName, string id)
        {
            this.firstName = name;
            this.lastName = lastName;
            this.id = id;
        }
        public decimal Salary
        {
            get
            {
                if (this.salary == 0)
                {
                    throw new ArgumentNullException("Salary cant be null");
                }
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public Department Department { get; set; }
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

        public string ID
        {
            get
            {
                if (string.IsNullOrEmpty(this.id) || this.id.Length < 10 || Regex.IsMatch(this.id, @"\W"))
                {
                    throw new ArgumentNullException("The name cant be null!");
                }
                return this.id;
            }
            private set
            {
            }
        }

        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(this.lastName))
                {
                    throw new ArgumentNullException("The Last Name can not be null!");
                }
                return this.lastName;
            }
            private set
            {
            }
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.ID;
        }
    }
}

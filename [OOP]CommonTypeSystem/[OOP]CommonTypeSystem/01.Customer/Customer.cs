namespace _01.Customer
{
    using System;
    using System.Collections.Generic;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private Customer()
        {

        }

        public Customer(string firstName, string middleName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string PermanentAdress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public List<Payment> Payments { get; set; }
        public CustomerType Type { get; set; }

        public override bool equals(object obj)
        {
            customer other = obj as customer;
            return this.firstname == other.firstname &&
                this.middlename == other.middlename &&
                this.lastname == other.lastname &&
                this.id == other.id &&
                this.permanentadress == other.permanentadress &&
                this.mobilephone == other.mobilephone &&
                this.email == other.email &&
                this.type == other.type;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.ID.GetHashCode() ^
                this.PermanentAdress.GetHashCode() ^
                this.MobilePhone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Type.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Customer {0} {1} {2} {3} {4} {5} {6} {7} {8}",
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.ID,
                this.PermanentAdress,
                this.MobilePhone,
                this.Email,
                this.Payments,
                this.Type);
        }
        public static bool operator ==(Customer a, Customer b)
        {
            return Customer.Equals(a, b);
        }
        public static bool operator !=(Customer a, Customer b)
        {
            return !(Customer.Equals(a, b));
        }

        public Customer Clone()
        {
            Customer cloning = new Customer();
            cloning.FirstName = this.FirstName;
            cloning.MiddleName = this.MiddleName;
            cloning.LastName = LastName;
            cloning.ID = this.ID;
            cloning.PermanentAdress = this.PermanentAdress;
            cloning.MobilePhone = cloning.MobilePhone;
            cloning.Email = this.Email;
            cloning.Payments = new List<Payment>();
            cloning.Payments = this.Payments;
            cloning.Type = this.Type;

            return cloning;
        }

        object ICloneable.Clone()
        {
            Customer cloning = new Customer()
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                ID = this.LastName,
                PermanentAdress = this.PermanentAdress,
                MobilePhone = this.MobilePhone,
                Email = this.Email,
                Type = this.Type,
                Payments = new List<Payment>()
            };
            foreach (var item in this.Payments)
            {
                cloning.Payments.Add(new Payment()
                {
                    ProductName = item.ProductName,
                    Price = item.Price
                });
            }
            return cloning;
        }

        public int CompareTo(Customer other)
        {
            int result = 
                (this.FirstName + "" + this.MiddleName + "" + this.LastName).CompareTo(other.FirstName + "" + other.MiddleName + "" + other.LastName);
            if (result == 0)
            {
                result = this.ID.CompareTo(other.ID);
            }
            return result;
        }
    }
}

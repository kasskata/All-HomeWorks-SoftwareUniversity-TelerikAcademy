namespace _01.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var st1 = new Customer("Pesho", "Peshov", "Peshov", "9087654323");
            var st3 = new Customer("Kolio", "Peshov", "Peshov", "9087654323");
            var st2 = (Customer)st3.Clone();
            st2.FirstName = "Typanar";
            var st4 = st2.Clone();
            st4.ID = "098872356354";

            var p = new Payment();

            Console.WriteLine(st1.Equals(st1));

            var customers = new List<Customer>(){
                st1,st2,st3,st4
            };
            customers.Sort();

            customers.ForEach(x=>Console.WriteLine(x));
        }
    }
}

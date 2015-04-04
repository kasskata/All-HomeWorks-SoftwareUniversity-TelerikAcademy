using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Project cars = new Project("Cars",DateTime.Parse("12.12.2002"),"nema");
            Sale SaleReadyCars = new Sale("Cars",DateTime.Parse("12.12.2002"),1245.99);
            Console.WriteLine(cars.State);
            cars.CloseProject();
            Console.WriteLine(cars.State);
            Employee stancho = new Developer("Stancho","IT","2135561234",cars);
            Employee pancho = new SalesEmployee("Pancho", "Vladigerov", "213213234", SaleReadyCars);
            Employee pesho = new Manager("Pesho","Managera","90873462321",stancho);
            Employee mariika = new SalesEmployee("Mariika", "Stankova", "89675456789", SaleReadyCars);
            Employee kosio = new Developer("Kosio", "eshov", "32151255", cars);

            Customer stamat = new Customer("Stamat","Kostov");
            Customer kosta = new Customer("Kosta", "Kostov");


            IPerson[] personsCollection = {
            stancho,pancho,pesho,mariika,kosio,stamat,kosta
            };
            foreach (var person in personsCollection)
            {
                Console.WriteLine(person);
            }
        }
    }
}

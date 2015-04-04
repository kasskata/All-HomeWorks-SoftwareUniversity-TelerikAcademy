using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PCCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer asus = new Computer("Asus",new Component("inel7","cpu",123.5M),23.5M);
            Computer asus1 = new Computer("Asus", new Component("inel8", "", 1123.5M), 23.5M);
            asus1.SeveralComponents.Add(new Component("inel7", "cpu", 123.5M));
            Computer asus2 = new Computer("Asus", new Component("inel9", "cpu", 1129.5M), 23.5M);


            List<Computer> computers = new List<Computer>();
            computers.Add(asus);
            computers.Add(asus1);
            computers.Add(asus2);

            var result = computers.OrderBy(x => x.Price);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Core
    {
        static void Main(string[] args)
        {
            var pesho = new Person("Pesho",23);
            var stamat = new Person("Stamcho", 54, "kajiPi4@abv.bg");
            var joro = new Person("Joro Picha",14,"mahniGoToq.com");

            Console.WriteLine(pesho);
            Console.WriteLine(stamat);
            Console.WriteLine(joro);
        }
    }
}

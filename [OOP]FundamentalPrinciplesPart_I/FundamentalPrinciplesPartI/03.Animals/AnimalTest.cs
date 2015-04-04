namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class AnimalTest
    {
        internal static void Main()
        {
            List<Animals> kaspichanskiqLess = new List<Animals>();

            kaspichanskiqLess.Add(new Dog("Sharo", 13, Animals.Sex.Male));
            kaspichanskiqLess.Add(new Frog("katq", 2, Animals.Sex.Female));
            kaspichanskiqLess.Add(new Kitten("Maca", 4));
            kaspichanskiqLess.Add(new Kitten("Biba", 8));
            kaspichanskiqLess.Add(new Tomcat("Macho", 10));
            kaspichanskiqLess.Add(new Tomcat("Djaro", 7));
            kaspichanskiqLess.Add(new Frog("Daro", 2, Animals.Sex.Male));
            kaspichanskiqLess.Add(new Tomcat("Poro", 8));
            kaspichanskiqLess.Add(new Dog("Zoro", 7, Animals.Sex.Male));
            kaspichanskiqLess.Add(new Kitten("Presious", 3));

            Console.WriteLine("<< Kaspichanian Less Animals >>");
            foreach (var animal in kaspichanskiqLess)
            {
                Console.WriteLine(animal);
            }

            var averageAge = kaspichanskiqLess.Average(a => a.Age);
            Console.WriteLine("\n Average age of all Kaspichanian Less'Animals:" + averageAge);
        }
    }
}

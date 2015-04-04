namespace NumbersAndLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class NumbersAndLINQ
    {
        static void Main()
        {
            List<int> array = new List<int>();

            for (int i = 1; i <= 9912; i++)
            {
                array.Add(i);
            }

            Console.WriteLine("_______________________DEVIDE BY 3 AND 7 ____________________________________");
            var newArrDevideBy3And7 = new List<int>(array.Where(x => (((x % 7) % 3) == 0)));
            for (int i = 0; i < newArrDevideBy3And7.Count; i++)
            {
                Console.Write(newArrDevideBy3And7[i] + "**");
            }
            Console.WriteLine();

            var newArrPrimes = new List<int>(array.Where(x => x % 2 != 0).Where(x => (((x % 7) % 5) % 3) != 0).Where(x => x / x == 1));
            Console.WriteLine("_____________________________PRIME NUMBERS __________________________________");
            for (int i = 1; i < newArrPrimes.Count; i++)
            {
                Console.Write(newArrPrimes[i] + "**");
                if (newArrPrimes[i] % 100 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
           
        }
    }
}

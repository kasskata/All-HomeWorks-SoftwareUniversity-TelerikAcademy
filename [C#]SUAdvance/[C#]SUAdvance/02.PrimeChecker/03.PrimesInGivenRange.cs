using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    public class PrimesInGivenRange
    {
        internal static void Main()
        {
            Console.WriteLine("Start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Finish:");

            int finish = int.Parse(Console.ReadLine());
            PrimeNumberInRange(start,finish);
        }

        private static void PrimeNumberInRange(int start, int finish)
        {
            StringBuilder primeNumbers = new StringBuilder();
            
            if (start >= finish)
            {
                throw new ArgumentException("Start value is bigger than Finish value");
            }
            for (int i = start; i < finish; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 !=0)
                {
                    primeNumbers.Append(i).Append(',');
                }
            }
            Console.WriteLine(primeNumbers.ToString().TrimEnd(','));
        }
    }
}

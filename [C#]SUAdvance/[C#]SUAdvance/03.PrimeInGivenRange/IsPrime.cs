namespace _02.PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    internal class PrimeChecker
    {
        internal static void Main()
        {
            ulong number;

            Console.WriteLine("number:");

            number = ulong.Parse(Console.ReadLine());
            
            GTPrime(number);
        }
        internal static void GTPrime(ulong nmbr)
        {

            if (nmbr == 0 || nmbr == 1)
            {
                throw new ArgumentException("invalid number()");
            }
            else
            {
                 nmbr / 2;
                for (ulong a = 2; a <= nmbr / 2; a++)
                {
                    if (nmbr % a == 0)
                    {
                        Console.WriteLine(false);
                        return;
                    }

                }
                Console.WriteLine(true);
            }
        }
    }
}

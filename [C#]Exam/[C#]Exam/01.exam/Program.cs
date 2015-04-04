using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.exam
{
    class Program
    {
        static void Main()
        {
            int sumN = 0;
            int sumNDouble = 0;
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                sumN += int.Parse(Console.ReadLine());
                sumNDouble += int.Parse(Console.ReadLine());
            }

            if (sumN == sumNDouble)
            {
                Console.WriteLine("Yes, sum=" + sumN);
            }
            else
            {
                if (sumN > sumNDouble)
                {
                    int exchange = sumN;
                    sumN = sumNDouble;
                    sumNDouble = exchange;
                }
                Console.WriteLine("No, diff=" + (sumNDouble - sumN));
            }
        }
    }
}

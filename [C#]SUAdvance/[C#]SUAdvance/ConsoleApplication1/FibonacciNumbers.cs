namespace ConsoleApplication1
{
    //Define a method Fib(n) that calculates the nth Fibonacci number.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class FibonacciNumbers
    {
        internal static int CalFibNumbers(int number)
        {
            int a = 0, b = 1, c;
            
            for (int counter = 1; counter <= number; counter++)
            {
                c = b + a;
                a = b;
                b = c;
            }

            return b;
        }

        internal static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            //Print the result from the method int b;
            Console.WriteLine(CalFibNumbers(number));
        }
    }
}

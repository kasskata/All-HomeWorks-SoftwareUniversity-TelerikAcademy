using System;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).


class CalculateFactorialsWithoutN
{
    static void Main()
    {
        Console.WriteLine("N= ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.WriteLine("K= ");
        decimal k = decimal.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factorialK = 1;
        decimal factorialKN = 1;

        if (1 < n && 1 < k && n < k)
        {
            for (int counter = 1; counter <= n; counter++)
            {
                factorialN *= counter;
            }
            Console.WriteLine("Factorial n = "+ factorialN);

            for (int counter = 1; counter <= k; counter++)
            {
                factorialK *= counter;
            }
            Console.WriteLine("Factorial k = "+ factorialK);

            for (decimal counter = 1; counter <= (k - n); counter++)
            {
                factorialKN *= counter;
            }
            Console.WriteLine("Factorial k-n = "+factorialKN);
            Console.WriteLine();
            Console.WriteLine("N! * K! / (K-N)! = " + (factorialN * factorialK) / factorialKN);
        }
        else
        {
            Console.WriteLine("not a valid value");
        }
    }
}
using System;
using System.Numerics;

//Write a program that calculates N!/K! for given N and K (1<K<N).

class KPlusOneEqualN
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        if (k < n && k > 1 && n > 1)
        {
            for (int counter = 1; counter <= n; counter++)
            {
                factorialN *= counter;
            }
            Console.WriteLine("FactorialN = " + factorialN);

            for (int counter = 1; counter <= k; counter++)
            {
                factorialK *= counter;
            }
            Console.WriteLine("factorialK= " + factorialK);

            Console.WriteLine("N!/K! = " + (factorialN/factorialK));
        }
        else
        {
            Console.WriteLine("N or K or both dont answer on requare values");
        }
    }
}
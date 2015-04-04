using System;

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/X^N

class FactorialPowerAndSum
{
    static void Main()
    {
        Console.Write("N= ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.Write("X= ");
        decimal x = decimal.Parse(Console.ReadLine());
        decimal factorialN = 1m;
        decimal powerResult = 1m;
        decimal sum = 1m;

        for (int k = 1, i = 0; k <= n; k++, i++)
        {
            powerResult *= x;
            factorialN *= k;
            sum += (factorialN / powerResult);

            Console.WriteLine("TESTfactorial = " + factorialN);
            Console.WriteLine("TESTpower = " + powerResult);
            Console.WriteLine("TESTSum = " + sum);
        }

        Console.WriteLine("__________________________");
        Console.WriteLine("factorial = " + factorialN);
        Console.WriteLine("power = " + powerResult);
        Console.WriteLine("S = " + sum);
    }
}


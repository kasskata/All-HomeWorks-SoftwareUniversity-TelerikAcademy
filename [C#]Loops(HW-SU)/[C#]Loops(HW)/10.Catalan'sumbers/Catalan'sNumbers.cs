using System;
using System.Numerics;

//Write a program to calculate the Nth Catalan number by given N.
//Catalan's formula: Cn=(2*n!)/(n+1)!*n! for n>=0

class CatalansNumbers
{
    static void Main()
    {
        Console.WriteLine("enter one number and will be calculate whit Catalan's formula");
        Console.Write("number : ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial2N = 1;
        BigInteger factorialNPlus1 = 1;
        BigInteger factorialN = 1;
        for (int counter = 1; counter <= 2 * n; counter++)
        {
            factorial2N *= counter;
        }
        for (int counter = 1; counter <= 1 + n; counter++)
        {
            factorialNPlus1 *= counter;
        }
        for (int counter = 1; counter <= n; counter++)
        {
            factorialN = counter;
        }
        Console.WriteLine(factorial2N);
        Console.WriteLine("Devide by");
        Console.WriteLine(factorialNPlus1);
        Console.WriteLine("*");
        Console.WriteLine(factorialN);
        Console.WriteLine("Catalan number : " + factorial2N / (factorialNPlus1 * factorialN));
    }
}
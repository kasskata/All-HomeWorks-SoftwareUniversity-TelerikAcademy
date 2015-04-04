using System;

//Write a program that reads a number N and calculates the sum of the first N members of the 
//sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class SumNFromFibonaccisequence
{
    static void Main()
    {
        Console.Write("How much numbers from \"Fibonacci's sequence\" u want to calculate: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int sumA = 0;
        int sumB = 0;
        Console.Write("The sequence is: 0,1,");
        for (int counter = 1; counter < n; counter++)
        {
            a = b + a;
            b = b + a;
            sumA = a + sumA;
            sumB = b + sumB;
            Console.Write(a);
            Console.Write(",");
            Console.Write(b);
            Console.Write(",");
        }
        Console.WriteLine();
        Console.WriteLine("*********************");
        Console.WriteLine("the sum from first {0} number of \"Fibonacci's sequence\" = {1}", n, +(sumA + sumB + 1));
    }
}
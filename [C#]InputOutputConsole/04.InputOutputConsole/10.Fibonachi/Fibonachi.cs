using System;
using System.Collections.Generic;
using System.Text;
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci 
//sequence (at a single line, separated by spaces) :
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops.
class Program
{
    static void Main()
    {
        Console.WriteLine("How many Fibonacci numbers u want: ");
        uint count = uint.Parse(Console.ReadLine());
        ulong fNumber = 1;
        ulong oldNumber = 1;
        StringBuilder fibonacciSeqence = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            if (i != 0 || i != 0)
            {
                fNumber = oldNumber + fNumber;
                fibonacciSeqence.Append(fNumber+" ");
                oldNumber = fNumber - oldNumber;
            }
            else
            {
                fibonacciSeqence.Append(" 1 1 ");
            }
        }
        Console.WriteLine(fibonacciSeqence.ToString());
    }
}
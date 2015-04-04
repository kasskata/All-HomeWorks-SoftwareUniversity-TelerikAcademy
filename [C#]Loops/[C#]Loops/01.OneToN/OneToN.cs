using System;
//Write a program that prints all the numbers from 1 to N.

class OneToN
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.Write("{0},",counter);
            counter++;
        }
    }
}
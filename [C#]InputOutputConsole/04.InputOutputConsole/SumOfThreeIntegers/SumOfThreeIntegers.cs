using System;

class SumOfThreeIntegers
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter 3 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('_', 10));
            Console.WriteLine("Sum = " + (a + b + c));
        }
        catch(FormatException)
        {
            Console.WriteLine("Cant Enter another symbols,only numbers!");
        }
    }
}
using System;
//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this WITHOUT if statements. 
class NumberComparer
{
    static void Main()
    {
        try
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Greater: {0}", a > b ? a : b);
        }
        catch (FormatException)
        {
            Console.WriteLine("Cant Enter another symbols,only numbers!");
        }
    }
}
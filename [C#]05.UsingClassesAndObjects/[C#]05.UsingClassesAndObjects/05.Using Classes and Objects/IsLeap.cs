using System;


//1.Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


class IsLeap
{
    static void Main()
    {
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Is " + year + " is leap year? >> " + DateTime.IsLeapYear(year) + "\n");
    }
}
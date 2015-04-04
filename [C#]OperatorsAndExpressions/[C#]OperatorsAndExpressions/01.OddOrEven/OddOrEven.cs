using System;

//Write an expression that checks if given integer is odd or even.

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter one integer number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(a % 2 == 0 ? "even" : "odd");
    }
}
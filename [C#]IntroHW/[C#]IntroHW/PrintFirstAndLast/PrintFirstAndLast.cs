using System;

class PrintFirstAndLast
{
    static void Main()
    {
        Console.Write("Enter First name:");
        string name = Console.ReadLine();
        Console.Write("Enter Last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Hello, " + name +" \n"+lastName);
    }
}

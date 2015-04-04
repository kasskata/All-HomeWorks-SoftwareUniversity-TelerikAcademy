using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter some number:");
        string number = "1231789";//Console.ReadLine();

        if (number[number.Length-2] % 7 == 0)
        {
            Console.WriteLine("is");
        }
        else
        {
            Console.WriteLine("isn't");
        }
    }
}

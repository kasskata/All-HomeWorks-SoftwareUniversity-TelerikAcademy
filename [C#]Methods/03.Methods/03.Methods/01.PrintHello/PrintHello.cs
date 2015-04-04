using System;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.

    class PrintHello
    {
        static void NamePlusHello(string name)
        { 
            Console.WriteLine("Halo, " + name + "!");
        }
        static void Main()
        {
            NamePlusHello(Console.ReadLine());
        }
    }

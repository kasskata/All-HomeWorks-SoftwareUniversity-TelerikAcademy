using System;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomClass
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Random a = new Random();
            Console.WriteLine(string.Join(",",a.Next(100, 200)));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

class ReplaceMethod
{
    static void Main()
    {
        string text = "developer is stupid";
        if (text.Length < 20)
        {
            Console.WriteLine(text.PadRight(20, '*'));
            Console.WriteLine("12345678901234567890");
        }
        else
        {
            Console.WriteLine(text);
            Console.WriteLine("12345678901234567890");
        }
    }
}

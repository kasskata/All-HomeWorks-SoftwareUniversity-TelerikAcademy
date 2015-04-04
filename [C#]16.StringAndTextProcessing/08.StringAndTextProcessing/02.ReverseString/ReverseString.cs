using System;
using System.Collections.Generic;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

class ReverseString
{
    static void Main()
    {
        Console.Write("enter some letter u want to reverse: ");
        string letter = Console.ReadLine();
        StringBuilder reverse = new StringBuilder();
        for (int i = letter.Length-1; i >=0; i--)
        {
            reverse.Append(letter[i]);
        }
        Console.WriteLine(string.Concat("/",reverse,"\\"));
    }
}

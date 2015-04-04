using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
//      "We are living in an yellow submarine. We don't have anything else. 
//      Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.");


class SubstringCount
{
    static void Main()
    {
        Console.Write("enter some Sybstring u want");
        string str = Console.ReadLine();
        Console.WriteLine("Enter the text:");
        string text = @" We are living in an yellow submarine. We don't have anything else
Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int count = 0;         
        for (int i = 0; i < text.Length-1; i++)
        {
         if ((text.Substring(i, 2).ToLower()) == str)
            {
                count++;
            }
        }
        Console.WriteLine( count);
    }
}

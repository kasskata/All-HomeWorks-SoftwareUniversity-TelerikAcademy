using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks. 
class ForbidenWords
{
    static void Main(string[] args)
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] array = (text.Trim('.',' ')).Split(' ','.');
        StringBuilder update = new StringBuilder();
        update.Append(text);
        for (int i = 0; i < array.Length; i++)
        {
                if (array[i] == null)
                {
                    continue;
                }
                else if (array[i].Equals("CLR"))
                {
                    array[i] = "***";
                }
                else if (array[i].Equals("PHP"))
                {
                    array[i] = "***";
                }
                else if (array[i].Equals("Microsoft"))
                {
                    array[i] = "*********";
                }
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();
    }
}

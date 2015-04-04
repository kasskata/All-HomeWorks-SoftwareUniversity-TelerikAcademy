using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that extracts from a given text all sentences containing given words
//Consider that the sentences are separated by "." and the words – by non-letter symbols.
class ExtractingLetters
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        text.ToLower();
        string[] array = text.Split(' ', '.');
        StringBuilder update = new StringBuilder();
        for (int i = 0; i < array.Length;  i++)
        {
            if (array[i].IndexOf("in") < 0)
            {
                update.Append(array[i]+" ");
            }
        }
        Console.WriteLine(update);
    }
}
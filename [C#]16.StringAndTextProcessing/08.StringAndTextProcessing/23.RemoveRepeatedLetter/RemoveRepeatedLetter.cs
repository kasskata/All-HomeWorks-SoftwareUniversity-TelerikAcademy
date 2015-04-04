using System;
using System.Text;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class RemoveRepeatedLetters
{
    static void Main()
    {
        string text = "Example: AaAaAaaAaAAaAANnnnnnnNNNNnnnnNNNNNNnnAAaaAAAaaAAACCcccCCooOOonnnnndddDDdddaaaaa\"".ToLower();
        StringBuilder str = new StringBuilder(text);

        for (int i = 0; i < str.Length -1; i++)
        {
            if (str[i] == str[i + 1])
            {
                str.Remove(i, 1);
                i--;
            }
        }
        Console.WriteLine("New fixed Text : \n " + "\""+str+"\"");
    }
}
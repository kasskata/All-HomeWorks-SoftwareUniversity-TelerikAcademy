using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

class ProParseDictionarygram
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary.Add(".NET", "- platform for applications from Microsoft");
        dictionary.Add("CLR", "- managed execution environment for .NET");
        dictionary.Add("namespace", "– hierarchical organization of classes");

        try
        {
            Console.WriteLine("enter keyword from the Dictionary class");
            Console.WriteLine("or not ");
            string ask = Console.ReadLine();
            Console.WriteLine(dictionary[ask]);
        }
        catch (Exception)
        {
            Console.WriteLine("We don have that word in library");
        }
        
    }
}

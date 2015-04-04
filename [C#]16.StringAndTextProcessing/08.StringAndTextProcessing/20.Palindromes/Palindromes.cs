using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class Palindromes
{
    static void Main(string[] args)
    {
        string text = "Write a program that extracts from a given coffeffoc texttxet allla palindromes, e.g. \"ABBA\", \"lamal\", \"exe\".";
        string[] update = text.Split(new char[] { ' ', ',', ':', '?', '!', '-', '_', '(', ')', '.', '"' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string robin in update)
        {
            bool batman = true;
            for (int j = 0; j < (robin.Length / 2); j++)
            {
                if (robin[j] != robin[robin.Length - 1 - j])
                {
                    batman = false;
                    break;
                }
            }
            if (batman && robin.Length > 1)
            {
                Console.WriteLine("Found new Word:" + robin.PadLeft(20,'_'));
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


class Alphabetical
{
    static void Main()
    {
        string[] text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order"
            .Split(new char[] {' ','.',',','!','?','1','2','3','4','5','6','7','8','9','0','\n','\r','\t','-','_'},StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(text);
        Console.WriteLine("--==All Words Alphabetical order==--");
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length!=1)
            {
                Console.WriteLine("{0,20}: " + text[i] + " ", (i + 1));
            }
        }
        Console.WriteLine();
    }
}

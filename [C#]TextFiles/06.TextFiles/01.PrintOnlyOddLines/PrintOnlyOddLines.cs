using System;
using System.IO;
//Write a program that reads a text file and prints on the console its odd lines.

class PrintOnlyOddLines
{
    static void Main()
    {
        string Text = @"OddLines.txt";
        StreamReader Print = new StreamReader(Text,System.Text.Encoding.Unicode);
        int count = 0;
        string line = Print.ReadLine();
        using (Print)
        {
            while (line != null)
            {
                line = Print.ReadLine();
                if (count % 2 == 1)
                {
                    Console.WriteLine(count +" LINE:  "+ line);
                }
                count++;
            }
        }
    }
}

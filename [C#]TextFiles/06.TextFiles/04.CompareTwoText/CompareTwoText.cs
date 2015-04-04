using System;
using System.IO;
using System.Text;

//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different. Assume the files have equal number of lines.

class CompareTwoText
{
    static void Main()
    {
        StreamReader cSharp = new StreamReader(@"C#.txt");
        StreamReader hTML = new StreamReader(@"HTML.txt");
        string cline = "";
        string hline = "";
        int count = 1;
        Console.WriteLine("Number of lines on Documents: ");
        int numberOfLines = int.Parse(Console.ReadLine());
        using (cSharp)
        {
            while (hline != null)
            {
                if ((cline = cSharp.ReadLine()) == (hline = hTML.ReadLine()))
                {
                    Console.WriteLine("same on " + count + " Lines: \n" + cline + "\n" + hline);
                }
                else
                {
                    Console.WriteLine("not the same on " + count + " line: ");
                }
                count++;
                if (count > numberOfLines)
                {
                    break;
                }
            }
        }
    }
}    

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

class InsertingObjectsInText
{
    static void Main()
    {
        StreamReader text = new StreamReader(@"OddLines.txt");
        string line = "";
        int count = 0;
        StreamWriter newText = new StreamWriter(@"newOddLines.txt");
        using (newText)
        {
            while (line != null)
            {
                newText.WriteLine("1111111111122222222222233333333333344444444444555555555666666667777777");
                newText.WriteLine((count++) + " Line :" + line);
                line = text.ReadLine();
            }
            Console.WriteLine("Done!");
        }
    }
}
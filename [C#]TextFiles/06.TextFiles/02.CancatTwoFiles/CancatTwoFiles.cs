using System;
using System.IO;
using System.Text;

//Write a program that concatenates two text files into another text file.

class CancatTwoFiles
{
    static void Main()
    {
        string sFirstFile = @"OddLines.txt";
        string sSecondFile = @"PrimalLines.txt";

        StreamReader firstFile = new StreamReader(sFirstFile);
        StreamReader secondFile = new StreamReader(sSecondFile);
        string holefirst = firstFile.ReadToEnd();
        string holesecond = secondFile.ReadToEnd();

        StringBuilder Concatfiles = new StringBuilder();
        Concatfiles.Append(String.Concat(holefirst, holesecond));

        Console.WriteLine(Concatfiles);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> Games</instrest>
//<interest>C#</instrest><interest> Java</instrest></interests></student>

class Program
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"Text.txt");
        StreamWriter Output = new StreamWriter(@"CleanText.txt", false);

        string line = input.ReadLine();

        while (line != null)
        {
            CleanXMLText(line, Output);
            line = input.ReadLine();
        }
        Output.Close();
        input.Close();
    }

    private static void CleanXMLText(string line, StreamWriter writer)
    {
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '<')
            {
                while ((i + 1 < line.Length) && (line[i] != '>'))
                {
                    i++;
                }
            }
            else
            {
                writer.Write(line[i]);
            }
        }
        writer.WriteLine();
        Console.WriteLine("Job Done");
    }
}

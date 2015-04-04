using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).

class ReplaceStringsInFiles
{
    static void Main()
    {
        StreamReader input = new StreamReader("C#.txt");
        StreamWriter bigFile = new StreamWriter("bigFile.txt");
        string text = input.ReadToEnd();
        int count = 0;
        using (bigFile)
        {
            while (count != 96)
            //This is Madness !!
            {
                bigFile.WriteLine("{0}", text);
                count++;
            }
        }
        input.Close();


        StreamReader inputfinal = new StreamReader("bigFile.txt");
        StreamWriter output = new StreamWriter("bigFileStart.txt");

        for (string line; (line = inputfinal.ReadLine()) != null;)
        {
            output.WriteLine(line.Replace("start", "finish")); 
        }
    }
}

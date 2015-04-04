using System;
using System.IO;
using System.Text;

class SortingNames
{
    static void Main()
    {
        StreamReader inputnames = new StreamReader(@"Names.txt");
        string[] names = inputnames.ReadToEnd().Split('\n');
        Array.Sort(names);
        StreamWriter output = new StreamWriter(@"NewNames.txt");
        using (output)
        {
            for (int i = 0; i < names.Length; i++)
            {
                output.WriteLine(names[i].ToString());
            }
        }
        Console.WriteLine("Job Done!");
    }
}

using System;
using System.Collections.Generic;
using System.Text;
class ASCI_Table
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode; 

        List<char> allChars = new List<char>();
        for (int i = 0; i < 256 ; i++)
        {
            allChars.Add((char)i);
        }

        StringBuilder charss = new StringBuilder();
        foreach (var charr in allChars)
        {
            charss.Append(charr + " ");
        }
        Console.WriteLine(charss.ToString());
        Console.WriteLine("ASCI Table MaxValue: "+(int)char.MaxValue);
    }
}

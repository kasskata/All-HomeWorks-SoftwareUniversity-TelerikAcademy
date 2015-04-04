using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class UnicodeChars
{
    static void Main()
    {
        string input = "Hi!";
        StringBuilder encoded = new StringBuilder();
        foreach (var item in input)
        {
            Console.WriteLine(encoded.AppendFormat("\\u{0:X4}", (ushort)item));
        } 
    }
}

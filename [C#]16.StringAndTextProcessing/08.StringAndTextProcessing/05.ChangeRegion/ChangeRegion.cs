using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//You are given a text. Write a program that changes the text in all regions surrounded 
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:

class ChangeRegion
{
    static void Main()
    {
        Console.WriteLine("Please input the string");
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else";
        Console.WriteLine();
        int opentag = 0;
        int closetag = 0;
        string update = text;

        while (opentag != -1)
        {
            opentag = text.IndexOf("<upcase>", closetag);
            if (opentag != -1)
            {
                closetag = text.IndexOf("</upcase>", opentag);
                string work = text.Substring(opentag + 8, closetag - opentag - 8);
                string upper = work.ToUpper();

                update = update.Replace("<upcase>" + work + "</upcase>", upper);
            }
        }
        Console.WriteLine(update);
    }
}
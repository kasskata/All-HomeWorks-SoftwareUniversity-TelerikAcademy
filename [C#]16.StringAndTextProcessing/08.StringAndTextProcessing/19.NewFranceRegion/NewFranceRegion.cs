using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
//
class NewFranceRegion
{
    static void Main()
    {
        string text = @"I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 
I graduated my high school. The law says (see section 7.3.12) 
that we are allowed to do this (section 7.4.2.9).".Trim(new char[] { ' ', ',', ':', '?', '!', '-', '_','(',')'});
        string[] update = text.Split(new char[] { ' ', ',', ':', '?', '!', '-', '_', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        List<DateTime> batman = new List<DateTime>();
        for (int i = 0; i < update.Length; i++)
        {
            try
            {
                string word = update[i];
                if (update[i][update[i].Length - 1] == '.')
                {
                    word = update[i].Substring(0, update[i].Length - 1);
                }
                DateTime date = DateTime.ParseExact(word,"d.m.yyyy",CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString("dd.mm.yyyy",CultureInfo.CreateSpecificCulture("en-CA")));
            }
            catch
            {
                continue;
            }   
        }
        foreach (var date in batman)
        {
            Console.WriteLine(date);
        }
    }
}

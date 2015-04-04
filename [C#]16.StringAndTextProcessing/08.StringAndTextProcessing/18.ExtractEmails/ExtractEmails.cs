using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class ExtractEmails
{
    static void Main()
    {
        string text = @"Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. 
This is not email: test@test. This also: @telerik.com. Neither this: a@a.b. ".Trim(' ', ',');
        string[] update = text.Split(new char[] { ' ', ',', ':', '?', '!', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
        StreamWriter PrintForU = new StreamWriter("Emails.txt");
        for (int i = 0; i < update.Length; i++)
        {
            //сигурен съм,че ешението няма да ви хареса,но ще обесня
            //сигурен съм че може да се използва библиотека за всички националности(".com,.net,.uk,.ru") и после да се сравнят всички с една проверка.това не знам как да го създам.
            //"@" за имейл се използва винги след някакъв Username затова ЗДЪЛЖИТЕЛНО проверяваме дали "@" не е първия индекс
            //Ако няма "@" е е имейл(до колкото знам)
            //името "Provider" na email сайта не ни инетересува защото всеки може да си направи сайт за пощи и няма начин да се проверяват
            //ако имате плакване пишете в форума постнал съм програмата
            if (
                update[i].IndexOf("@") != -1 &&
                update[i].IndexOf("@") != 0 &&
                update[i].IndexOf(".com") != -1 ||
                update[i].IndexOf(".uk") != -1 ||
                update[i].IndexOf(".bg") != -1)
            {
                using (PrintForU)
                {
                    Console.WriteLine("The email: \"{0}\" Printed to the \"Emails.txt\"", update[i]);
                    PrintForU.WriteLine(update[i]);
                }
            }
        }
    }
}

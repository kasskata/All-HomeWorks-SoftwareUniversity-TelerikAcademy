using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a string from the console and lists all different words in the string along
//with information how many times each word is found.

class WordsMaching
{
    static void Main(string[] args)
    {
        string[] text = (@"Write a program that reads reads reads reads reads reads reads a string from from from from from жfrom from from from 
the console and lists all differentall differentall differentall differentall differentall differentall differentall differentall differentall 
words in the string along with information how many times each word is found.with information how many 
times each word is found.found.found.found.found.found.found.found.found.found.found.found.".ToLower()).Split(new char[] {
                              ' ','.',',','!','?','1','2','3','4','5','6','7','8','9','0','\n','\r','\t','-','_'
                                                        },StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> Counter = new Dictionary<string, int>();

        foreach (var word in text)
        {
            if (word.Length != 1)
            {
                if (Counter.ContainsKey(word))
                {
                    Counter[word] = Counter[word] + 1;
                }
                else
                {
                    Counter.Add(word, 1);
                }
            }

        }
        foreach (var word in Counter)
        {
            Console.WriteLine("{0} {1} times", word.Key.PadRight(15,'_'), word.Value);
        }
    }
}

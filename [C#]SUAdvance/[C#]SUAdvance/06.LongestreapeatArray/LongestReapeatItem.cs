namespace _06.LongestreapeatArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    //Write a program to find the longest area of equal elements in array of strings. You first should read an integer 
    //n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length
    //, then its elements). If multiple sequences have the same maximal length, print the leftmost of them.
    class LongestReapeatItem
    {
        static void Main()
        {
            Console.WriteLine("i upload one document which is in the project ");
            StreamReader inputnames = new StreamReader(@"text.txt");
            string[] batman = inputnames.ReadToEnd().Split(new char[]{' ','.',',','!','?','1','2','3','4','5',
                                                      '6','7','8','9','0','\n','\r','\t','-','_'},StringSplitOptions.RemoveEmptyEntries);
            foreach (var letters in batman)
            {
                Console.WriteLine(letters);
            }
            Array.Sort(batman);
            int count = 1;
            int max = 0;
            string letter = "";

            for (int i = 0; i < batman.Length-1; i++)
            {
                if (batman[i] == batman[i+1])
                {
                    count++;
                    
                    if (max < count)
                    {
                        max = count;
                        letter = batman[i]; 
                    }
                }
                if (batman[i] != batman[i + 1])
                {
                    count = 0;
                }
                if (i == batman.Length-2)
                {
                    if (letter == batman[i+1])
                    {
                        count++;
                        max = count;
                    }
                }
            }
            Console.WriteLine("In the text repeat most is \" {0} \":{1} times",letter,max);
            Console.WriteLine();
        }
    }
}

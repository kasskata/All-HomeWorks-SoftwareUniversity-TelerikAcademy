using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

class OnlyWordTestDelete
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"C#.txt");
        StreamWriter output = new StreamWriter(@"DeleteTestFile.txt");

        using (input)
        {
            using (output)
            {
                string TextAll = input.ReadToEnd();
                string[] text = TextAll.Split();
                string newText = "";
                string test = "test";

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains(test))
                    {
                        string currentWord = text[i];
                        if (currentWord.Substring(0, 4).Equals(test))
                        {
                            text[i] = "";
                        }
                    }
                }

                newText = String.Join(" ", text);
                char[] whiteSpace = new char[] { ' ' };
                text = newText.Split(whiteSpace, StringSplitOptions.RemoveEmptyEntries);
                newText = String.Join(" ", text);

                output.WriteLine(newText);
            }
        }
    }
}

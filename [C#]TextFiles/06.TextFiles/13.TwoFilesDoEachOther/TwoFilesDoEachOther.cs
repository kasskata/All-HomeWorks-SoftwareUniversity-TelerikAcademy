using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.

class TwoFilesDoEachOther
{
    static void Main()
    {
        List<string> listOfWords = new List<string>();
        StreamReader reader = new StreamReader("words.txt");
        using (reader)
        {
            string currentRow = reader.ReadLine();
            while (currentRow != null)
            {
                listOfWords.Add(currentRow);
                currentRow = reader.ReadLine();
            }
        }

        StreamReader reader2 = new StreamReader("text.txt");
        string allText = " ";
        using (reader2)
        {
            allText += reader2.ReadToEnd();
        }

        int[] array = new int[listOfWords.Count];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Regex.Matches(allText, " " + listOfWords[i] + " ").Count;
        }
        string[] array2 = listOfWords.ToArray();
        Array.Sort(array, array2);

        StreamWriter writer = new StreamWriter("answer.txt");
        using (writer)
        {
            for (int i = array2.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    writer.WriteLine(array2[i]);
                }
            }
        }
    }
}

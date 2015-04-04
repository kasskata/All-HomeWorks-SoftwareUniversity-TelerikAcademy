using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.

class Exceptions
{
    static void Main()
    {
        StringBuilder result = new StringBuilder("\\b");
        using (StreamReader wordsToDel = new StreamReader("WordsToDelete.txt"))
        {                                         
            string word = wordsToDel.ReadLine(); 
                                                 
            while (word != null)                 
            {                                    
                word = word.Trim();              
                result.Append(String.Join("", word, "\\b|\\b"));
                word = wordsToDel.ReadLine();
            }
        }
       
        string searchPattern = result.Remove(result.Length - 3, 3).ToString();
        result.Clear(); 

        using (StreamReader inputText = new StreamReader("Text.txt"))
        {
            string textLine = inputText.ReadLine();
            while (textLine != null)
            {  
                textLine = Regex.Replace(textLine, searchPattern, "", RegexOptions.IgnoreCase);
                result.AppendLine(textLine);
                textLine = inputText.ReadLine();
            }
        }
        using (StreamWriter writer = new StreamWriter("Text.txt"))
        {
            writer.Write(result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a string from the console and prints all different letters in the string along with 
//information how many times each letter is found. 

class CountTheLetters
{
    static void Main()
    {
        string[] Text = (@"Write a program that reads a string from the console and prints all different letters in the string along 
with information how many times each letter is found".ToLower())
                                                     .Split(new char[] 
                                                     {' ','.',',','!','?','1','2','3','4','5',
                                                      '6','7','8','9','0','\n','\r','\t','-','_'},StringSplitOptions.RemoveEmptyEntries);
        //естествено в масива трябва да допълним още знаци ако има други
        //и сме готови 
        //.toLower дефакто съкращава само писането и на главни,ав задачата ни се търси букви а не главни или малки 
        int[]counter = new int[26];
        for (int i = 0; i < Text.Length; i++)
        {
            for (int j = 0; j < Text[i].Length; j++)
            {
                counter[((int)(Text[i][j]))-97]++;
                //Зложна работа!Изчисляваме на коя позиция да се запише count
                //като използваме свойството на char от ASCII таблицата
                //примерно 'а'=97 => char - 97 = 0 и записваме на нулева позиция
                //ако помня добре имахме подобна задача
            }
        }
        //и изпечатваме САМО буквите които се срещат
        for (int i = 0; i < counter.Length; i++)
        {
            if (counter[i] != 0)
            {
                Console.WriteLine("{0} counted {1} times", (char)(i + 65), counter[i]);
            }
            else
            {
                continue;
            }
        }
    }
}

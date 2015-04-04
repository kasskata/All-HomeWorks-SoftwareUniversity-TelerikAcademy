using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!" => "Delphi not and PHP, not C++ not is C#!".

    class ReverseStrings
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] batman = text.Split(new char[]{' ','.','!','?',',','-','_','/','\\','|'},StringSplitOptions.RemoveEmptyEntries);
            string[] robin = text.Split(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')', '(',
                                                '*', '/', '=', '~', '`' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder joker = new StringBuilder();
            for (int i = batman.Length-1,j=0; i >= 0; i--,j++)
            {
               joker.Append(batman[i]);
               joker.Append(robin[j]);
            }
            Console.WriteLine(joker);
        }
    }

using System;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class Sumof5Numbers
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Try the program with what u want!Everithing! :P\n2 Exception wich isn't hanled");
            //advance hazzard!
            string[] text = Console.ReadLine().Split(new char[] {
                              ' ','.',',','!','?','@','#','$','%','^','&','*','(',')','_','\n','\r','\t','-','_'
                                                        }, StringSplitOptions.RemoveEmptyEntries);
            //Why batman? becouse he will kick their asses and will be ints :P(because Its more easy to me - array => super hero)
            int sum = new Int32();
            for (int i = 0; i < text.Length; i++)
            {
                sum += int.Parse(text[i]);
            }
            Console.WriteLine("Sum =  " + sum);
        }
        catch (FormatException)
        {
            Console.WriteLine("Cant Enter another symbols,only numbers!");
        }
        //MY test :
        //124 12 32 54 2315 252 523 5 235 2 523523 5 235 235 5 25 25 235 23 5 2  5  52 5 2
        //35  235 235  2 5  2         235  235  523 5 235 235 235 23 5 235  2      235 325
        //235 235 235 235 23 5 325 235  235 23 523 5 235 23 523 52 35 235 2 52 525 2 5 23
        //5 25 5 235 235
        //Try and this:
        //123 123  & 213 & 213 & 123125 123 12 (123) *!@# 1243
        //Save that Project, it will be usefull in C# part 2!
    }
}
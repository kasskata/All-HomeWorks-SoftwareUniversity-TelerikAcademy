using System;
using System.Text;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.


class CopyrightSymbol
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int copy = 169;
        Console.WriteLine(@"
                         {0}     
                        {0}{0}{0}
                       {0}{0}{0}{0}{0}
         ", (char)copy);
    }
}
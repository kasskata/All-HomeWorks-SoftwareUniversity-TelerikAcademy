using System;
//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and
//prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a 
//should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, 
//then the number b should be printed with 2 digits after the decimal
//point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned

class FormattingNumbers
{
    static void Main()
    {
        try
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if ((a <= 0 || a >= 500) || (b <= 0 || b >= 500) || (c <= 0 || c >= 500))
            {
                Console.WriteLine("can't continue,your number is not inavalid");
            }
            else
            {
                Console.WriteLine("|{0,10}|{1,10}|{2,10}|{3,10}|", "A in Hex", "A Binary", "B-2digits", "C-3digits");
                Console.WriteLine("|{0,-10:X}|{1,10:P10}|{2,10:0.00}|{3,-10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
                //                right align|doesntmatter|RightAlign|LeftAlign
                //                 HEX         Binary       2-Digits   3-digits
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Cant Enter another symbols,only numbers!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number,
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

class FormatingString
{
    static void Main()
    {
        int number = 9999;
        double duoNumber = number / 100;
        StringBuilder formats = new StringBuilder();

        string hexNumber = number.ToString("x").PadLeft(15, '_');
        string deciNumber = number.ToString("D").PadLeft(15, '_');
        string percentNumber = duoNumber.ToString("P").PadLeft(15, '_');
        string scienceNumber = number.ToString("E").PadLeft(15, '_');

        formats.Append(
            number + " in decimal" + deciNumber + "\n" +
            number + " in heximal" + hexNumber + "\n" +
            number + " in percent" + percentNumber + "\n" +
            number + " in Scinece" + scienceNumber
            );

        Console.WriteLine(formats);
    }
}

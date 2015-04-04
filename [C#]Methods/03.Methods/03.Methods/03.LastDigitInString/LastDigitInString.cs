using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LastDigitInString
{
    static void LastDigit(string number)
    {
        char lastDigit = number[number.Length-1];
        switch (lastDigit)
        {
            case '1':
                Console.WriteLine("One");
                break;
            case '2':
                Console.WriteLine("Two");
                break;
            case '3':
                Console.WriteLine("Three");
                break;
            case '4':
                Console.WriteLine("Four");
                break;
            case '5':
                Console.WriteLine("Five");
                break;
            case '6':
                Console.WriteLine("Six");
                break;
            case '7':
                Console.WriteLine("Seven");
                break;
            case '8':
                Console.WriteLine("Eight");
                break;
            case '9':
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Zero");
                break;
        };
    }
    static void Main()
    {
        Console.Write("Enter Number:");
        LastDigit(Console.ReadLine());
    }
}
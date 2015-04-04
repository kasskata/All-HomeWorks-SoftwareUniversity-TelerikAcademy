using System;
//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//0 > "Zero"
//273 > "Two hundred seventy three"
//400 > "Four hundred"
//501 > "Five hundred and one"
//711 > "Seven hundred and eleven"

class NumbersToText
{
    static void Main()
    {
        Console.Write("Enter number (0 to 999): ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0 && number < 999)
        {
            int digit = number % 10;
            number = number / 10;
            int tenth = number % 10;
            number /= 10;
            int hundred = number % 10;

            switch (hundred)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
                default:
                    break;
            }

            switch (tenth)
            {
                case 1:
                    if (hundred == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("and ");
                    }
                    break;
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("forty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
                case 0:
                    if (hundred == 0)
                    {
                        break;
                    }
                    else if (digit == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("and ");
                    }
                    break;
            }
            switch (digit)
            {
                case 1:
                    if (tenth == 1)
                    {
                        Console.Write("eleven");
                    }
                    else
                    {
                        Console.Write("one");
                    }
                    break;
                case 2:
                    if (tenth == 1)
                    {
                        Console.Write("twelve");
                    }
                    else
                    {
                        Console.Write("two");
                    }
                    break;
                case 3:
                    if (tenth == 1)
                    {
                        Console.Write("thirteen");
                    }
                    else
                    {
                        Console.Write("three");
                    }
                    break;
                case 4:
                    if (tenth == 1)
                    {
                        Console.Write("fourteen");
                    }
                    else
                    {
                        Console.Write("four");
                    }
                    break;
                case 5:
                    if (tenth == 1)
                    {
                        Console.Write("fifteen");
                    }
                    else
                    {
                        Console.Write("five");
                    }
                    break;
                case 6:
                    if (tenth == 1)
                    {
                        Console.Write("sixteen");
                    }
                    else
                    {
                        Console.Write("six");
                    }
                    break;
                case 7:
                    if (tenth == 1)
                    {
                        Console.Write("seventeen");
                    }
                    else
                    {
                        Console.Write("seven");
                    }
                    break;
                case 8:
                    if (tenth == 1)
                    {
                        Console.Write("eighteen");
                    }
                    else
                    {
                        Console.Write("eight");
                    }
                    break;
                case 9:
                    if (tenth == 1)
                    {
                        Console.Write("nineteen");
                    }
                    else
                    {
                        Console.Write("nine");
                    }
                    break;
            }

        }
        Console.WriteLine("");
    }
}
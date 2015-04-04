using System;
//Write program that asks for a digit and depending on the input shows the name 
//of that digit (in English) using a switch statement.

class NamesToDigits
{
    static void Main()
    {
        for (int count = 0; count <= 20; count++)
        {
            Console.Write("Enter ONE digit number:");
            string digit1 = Console.ReadLine();
            int digit = int.Parse(digit1);
            Console.WriteLine(" ");


            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("not a digit!");
                    break;
            }
            Console.WriteLine("Continue...\r\n");

        }
    }
}
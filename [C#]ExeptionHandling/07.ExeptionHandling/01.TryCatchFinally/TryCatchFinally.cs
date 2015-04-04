using System;

//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class Program
{
    static void Main()
    {
        Console.Write("Number: ");
        string snumber = Console.ReadLine();
        try
        {
            double number = int.Parse(snumber);
            int root = (int)Math.Sqrt(number);
            if (number < 0)
            {
                Console.WriteLine("Negative number");
                throw new ArithmeticException("invalid negative number");
            }
            Console.WriteLine(root);
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is to big");
        }
        catch (FormatException)
        {
            Console.WriteLine("The number contain and other charecter");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
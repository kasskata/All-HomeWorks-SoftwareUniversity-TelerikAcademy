using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 

//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class MyFirstException
{
    static int IsNumberRight(int start,int end)
    {
        int number=new Int32();
        try
        {
            number = int.Parse(Console.ReadLine());
            if (start >= number)
            {
                throw new ArgumentException("Bad number");
            }
            if (end <= number)
            {
                throw new ArgumentException("Bad number");
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("enter real integer number");
        }
        catch (FormatException)
        {
            Console.WriteLine("enter real integer number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Too big number. The number must be in range {0} & {1}", start, end);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Too small number need to be between {0} & {1}", start, end);
        }
        return number;
    }
    static void Main()
    {
        int start = 10;
        int end = 100;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("enter number:");
            int Number = IsNumberRight(start, end);
            if (Number > start)
            {
                start = Number;
            }
        }
    }
}

using System;

class DevideByZero
{
    static void Main()
    {
        int number = 35;

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("its Devideble");
        }
        else
        {
            Console.WriteLine("Its NOT devideble");
        }
    }
}
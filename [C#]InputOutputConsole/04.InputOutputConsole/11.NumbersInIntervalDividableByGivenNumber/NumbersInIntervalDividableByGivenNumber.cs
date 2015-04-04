using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers: ");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondnumber = int.Parse(Console.ReadLine());
        
        if (firstNumber > secondnumber)
        {
            int exchange = firstNumber;
            firstNumber = secondnumber;
            secondnumber = exchange;
        }
        else if (firstNumber == secondnumber)
        {
            Console.WriteLine("Dont have any numbers");
        }
        else
        {
            for (int i = firstNumber; i <= secondnumber; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
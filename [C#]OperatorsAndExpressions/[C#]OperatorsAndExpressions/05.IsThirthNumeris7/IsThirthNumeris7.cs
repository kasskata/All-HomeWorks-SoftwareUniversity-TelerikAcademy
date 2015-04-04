using System;

//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.


class IsThirthNumeris7
{
    static void Main()
    {
        Console.WriteLine("enter some number: ");
        int randomNumber = int.Parse(Console.ReadLine());
        if (randomNumber % 1000 > 699 && randomNumber % 1000 < 800)
        {
            Console.WriteLine("The thirth number from {0} is 7", randomNumber);
        }
        else
        {
            Console.WriteLine("The thirth number from {0} isn't 7", randomNumber);
        }
    }
}
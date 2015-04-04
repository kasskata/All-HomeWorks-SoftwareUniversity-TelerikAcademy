using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


class PrimalNumbers
{
    static void Main()
    {
        int MaxResultToCheck = 100;
        int x = 35;
        bool IsPrime = (x % 2 > 0) && (x % 3 > 0) && (x % 5 > 0) && (x % 7 > 0);
        bool IsTrue = (x == 2) || (x == 3) || (x == 5) && (x == 7);
        Console.WriteLine(IsPrime || IsTrue);
    }
}
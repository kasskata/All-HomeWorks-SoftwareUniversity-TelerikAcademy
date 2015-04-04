using System;

//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int frst = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int scnd = int.Parse(Console.ReadLine());
        int bigger = 0;

        if (scnd > frst)
        {
            int exchange = frst;
            frst = scnd;
            scnd = exchange;
        }
        if (frst != 0 && scnd != 0 && frst != scnd)
        {
            while (frst != 0 && scnd != 0)
            {
                if (frst > scnd)
                {
                    frst -= scnd;
                }
                else
                {
                    scnd -= frst;
                }
                if (frst > scnd)
                {
                    bigger = frst;
                }
                else
                {
                    bigger = scnd;
                }
            }
            Console.WriteLine("bigger GCD is " + bigger);
        }
        Console.WriteLine("invalid input");
    }
}

using System;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following.

class TheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 20 && n > 0)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int column = row; column <=row+n-1; column++)
                {
                    Console.Write(column+n-1 + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Can't create the Matrix (enter positive intiger number between 0 & 21)!");
        }
    }
}
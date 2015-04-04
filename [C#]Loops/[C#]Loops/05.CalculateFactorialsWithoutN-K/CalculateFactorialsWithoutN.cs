using System;

// In combinatorics, the number of ways to choose k different members out of a group of n different elements 
// (also known as the number of combinations) is calculated by the following formula:
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. Examples:


class CalculateFactorialsWithoutN
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong k = ulong.Parse(Console.ReadLine());
            ulong sum = 1;

            if (1 < k && k < n && n < 100)
            {
                for (uint i = 0; i < k; i++)
                {
                    sum *= (n - i);
                    sum /= (i + 1);
                }
                Console.WriteLine(sum);
            }
        }
    }
}
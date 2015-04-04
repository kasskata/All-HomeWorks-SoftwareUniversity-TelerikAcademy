using System;
using System.Collections.Generic;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

class SieveOfEratosthenes
{
    static void Main()
    {
        List<int> Primes = new List<int>();

        for (int i = 0; i <= 10000000; i++)
        {
            if (i % 2 != 0 && 
                i % 3 != 0 &&
                i % 5 != 0 &&
                i % 7 != 0)
            {
                Primes.Add(i);
            }
        }
        Console.WriteLine("Print all Primes between 1 and 10 000 000 in array ({0} prime numbers):",Primes.Count);
        for (int i = 0; i < Primes.Count; i++)
        {
           Console.WriteLine(Primes[i]);         
        }
        Console.WriteLine("Print all Primes between 1 and 10 000 000 in array ({0} prime numbers):", Primes.Count);
    }
}

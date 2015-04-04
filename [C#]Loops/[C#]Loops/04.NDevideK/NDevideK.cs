using System;

//Write a program that calculates N!/K! for given N and K (1<K<N).


class NDevideK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        for (int counter = 1; counter <= n; counter++)
        {
            counter *= counter;
            Console.WriteLine(counter);
        }
    }
}
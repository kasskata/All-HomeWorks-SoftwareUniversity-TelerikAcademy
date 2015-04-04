using System;

//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8 => 1+1-2=0.


class SubsetWithSumZero
{
    static void Main()
    {
        int[] array = new int[5];
        int sumTargets = 0;

        for (int counter = 0; counter < 5; counter++)
        {
            array[counter] = int.Parse(Console.ReadLine());
        }

        for (int counter = 1; counter < 32; counter++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                sum += ((counter >> j) & 1) * array[j];
            }
            if (sum == 0)
            {
                sumTargets++;
            }
        }
        Console.WriteLine("how many subset is equal to 0 : " + sumTargets);
    }
}
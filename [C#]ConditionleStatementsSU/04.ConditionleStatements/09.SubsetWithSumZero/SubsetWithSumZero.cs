using System;

//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8 => 1+1-2=0.


class SubsetWithSumZero
{
    static void Main()
    {
        int[] array = new int[5];
        int sumTargets = 0;
        int count = 0;

        for (int counter = 0; counter < 5; counter++)
        {
            array[counter] = int.Parse(Console.ReadLine());
        }

        for (int counter = 0; counter < array.Length; counter++)
        {
            sumTargets += counter;
            if (sumTargets == 0)
            {
                count++;
            }
        }
        Console.WriteLine("{0} {1} {2} {3} {4}? : {5}",array[0],array[1],array[2],array[3],array[4], sumTargets!=0 ? "have "+count+" subsets" : "Dont have any subsets");
    }
}
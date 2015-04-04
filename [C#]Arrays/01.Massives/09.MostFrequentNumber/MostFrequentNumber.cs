using System;
using System.Collections.Generic;

//Write a program that finds the most frequent number in an array. Example:
	//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} => 4 (5 times)


class MostFrequentNumber
{
    static void Main()
    {
        //initializating and SORTING the array
        int[] array = new int[9];
        for (int i = 0;i<array.Length;i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int Length = 1;
        int start = 0;
        int maxLength = 1;
        int maxStart = 0;
        // other stuff is from 04."TheBiggerSequence" problem.
        List<int> maxSequense = new List<int>(); 
        for (int index = 0; index < array.Length - 1; index++)
        {
            if (array[index] == array[index + 1])
            {
                start = array[index];
                Length++;
            }
            if (array[index] != array[index + 1])
            {
                Length = 1;
            }
            if (Length > maxLength)
            {
                maxStart = start;
                maxLength = Length;
            }
        }
        for (int i = 0; i < maxLength; i++)
        {
            maxSequense.Add(maxStart);
        }

        Console.Write("maxfrequence number is " + maxSequense[0]);
        Console.Write(" times " + maxSequense.Count);
        Console.WriteLine();
    }
}
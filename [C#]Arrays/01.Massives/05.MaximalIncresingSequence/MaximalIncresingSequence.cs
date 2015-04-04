using System;
using System.Collections.Generic;

//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} => {2, 3, 4}.


class MaximalIncresingSequence
{
    static void Main()
    {
        int[] array = new int[7] { -342423523, -123435423, 3, 4, 2, 2, 4 };
        int firstItem = 0;
        int maxLength = 1;
        

        for (int i = 0; i < array.Length-1; i++)
        {
            int currentLength = 1;
            int previous = array[i];
            int j = i + 1;
            for (; j < array.Length; j++)
            {
                if (previous < array[j])
                {
                    previous = array[j];
                }
                else
                {
                    break;
                }
            }
            currentLength = j - i;
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                firstItem = i;
            }
        }
        for (int i = firstItem; i < firstItem + maxLength; i++)
        {
            Console.Write(" " +array[i]);
        }
        Console.WriteLine();
    }
}

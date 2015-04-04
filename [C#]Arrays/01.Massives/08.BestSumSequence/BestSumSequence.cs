using System;
using System.Collections.Generic;

//Write a program that finds the sequence of maximal sum in given array. Example:
	//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} => {2, -1, 6, 4}
	//Can you do it with only one loop (with single scan through the elements of the array)?
class BestSumSequence
{
    static void Main()
    {
        int[] sequence = {32,65,13,-32,32,65,12,-5,5};
        int maxLength = 0;
        int maxTemp = 0;
        int bestBegin = 0; // find this and use it for print the sequence
        int begin = 0; 
        int end = 0; // know when we stop the sequence
        //Kadane's algrithm
        for (int i = 0; i < sequence.Length; i++)
        {
            if (maxTemp < 0)
            {
                maxTemp = sequence[i];
                begin = i;
            }
            else
            {
                maxTemp += sequence[i];
            }
            if (maxTemp >= maxLength)
            {
                maxLength = maxTemp;
                bestBegin = begin;
                end = i;
            }
        }
        for (int i = bestBegin; i < end -1; i++) // dont know but work with this "-1" :P 
        {
            Console.WriteLine(sequence[i]); 
        } 
    }
}
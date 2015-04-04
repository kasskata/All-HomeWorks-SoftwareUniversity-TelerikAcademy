using System;
using System.Collections.Generic;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.
//

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter Array's length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        List<int> theNumbers = new List<int>();
        Console.Write("Enter Array's length: ");
        int k = int.Parse(Console.ReadLine());
        //initialize help variable

        int maxNumber = 0;

        //initialize the array
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int counter = 0; counter < k; counter++)
        {
            maxNumber = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];

                    if (i == array.Length)
                    {
                        theNumbers.Add(maxNumber);
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (maxNumber == array[i])
                {
                    array[i] = int.MinValue;
                    break;
                }
            }
            Console.WriteLine("max number is " + maxNumber);
        }
    }
}
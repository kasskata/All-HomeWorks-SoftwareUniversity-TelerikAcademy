using System;
using System.Collections.Generic;

//Write a program that finds the maximal sequence of equal elements in an array.
	//	Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} > {2, 2, 2}.

class TheBiggerSequence
{
    static void Main()
    {
        //Initilize the array
        int[] sequenceArray = { 1, 1, 3, 3, 3, 2, 2, 2, 2, 1, };
        List<int> maxSequense = new List<int>();
        int Length = 1;
        int start = 0;
        int maxLength = 1;
        int maxStart = 0;
        

        for (int index = 0; index < sequenceArray.Length-1; index++)
        {
            if (sequenceArray[index] == sequenceArray[index + 1])
            {
                start = sequenceArray[index];
                Length++;
            }
            if (sequenceArray[index] != sequenceArray[index + 1])
            {
                Length = 1;
            }
            if (Length > maxLength)
            {
                maxStart = start;
                maxLength = Length;
            }
        }

        Console.Write("{");
        for (int i = 0; i < maxLength; i++)
        {
            maxSequense.Add(maxStart);
            Console.Write(maxSequense[i] + ",");
        }
        Console.WriteLine("}");
    }
}

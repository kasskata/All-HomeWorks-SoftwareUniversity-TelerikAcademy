namespace _03.LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using TakeInput;

    // Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>.
    // If several sequences has the same longest length, return the leftmost of them. Write a program to test whether
    // the method works correctly.

    class LongestSubsequence
    {
        static void Main()
        {
            List<int> listNumbers = TakeInput.ListIntPrepare();

            int counter = 1;
            int maxSequence = 0;
            int numberFromSeq = new int();
            for (int i = 1; i < listNumbers.Count; i++)
            {
                if (listNumbers[i] == listNumbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (maxSequence < counter)
                {
                    maxSequence = counter;
                    numberFromSeq = listNumbers[i];
                }
            }

            Console.WriteLine();
        }
    }
}

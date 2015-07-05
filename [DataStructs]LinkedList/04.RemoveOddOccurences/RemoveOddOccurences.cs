namespace _04.RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TakeInput;

    // Write a program that removes from given sequence all numbers that occur odd number of times.
    class RemoveOddOccurences
    {
        static void Main()
        {
            List<int> listNumbers = TakeInput.ListIntPrepare();

            var groupSequence = listNumbers
                .GroupBy(x => x)
                .Where(x => x.Count()%2 == 0)
                .OrderBy(x => x.Count())
                .ToList();

            if (groupSequence.Any())
            {
                foreach (var seq in groupSequence)
                {
                    foreach (var i in seq)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Don't have any Even Occurrences");
            }
        }
    }
}

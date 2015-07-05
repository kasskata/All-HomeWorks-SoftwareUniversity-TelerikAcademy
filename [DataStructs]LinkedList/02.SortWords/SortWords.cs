namespace _02.SortWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TakeInput;

    // Write a program that reads from the console a sequence of words (strings on a single line, separated by a space). 
    // Sort them alphabetically. Keep the sequence in List<string>.
    class SortWords
    {
        static void Main()
        {
            List<string> sequence = TakeInput.ListStringPrepare();

            var orderedSequence = sequence.OrderBy(x => x);
            Console.WriteLine(string.Join(", ",orderedSequence));
        }
    }
}

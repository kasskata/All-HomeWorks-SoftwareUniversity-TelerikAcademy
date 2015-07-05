namespace _01.SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TakeInput;

    // Write a program that reads from the console a sequence of integer numbers (on a single line, separated by a space). 
    // Calculate and print the sum and average of the elements of the sequence. Keep the sequence in List<int>.
    class SumAndAverage
    {
        static void Main()
        {
            List<int> listNumbers = TakeInput.ListIntPrepare();

            Console.WriteLine("Your sequence: [{0}]", string.Join(", ", listNumbers));
            Console.WriteLine("Sum: {0}", listNumbers.Sum());
            Console.WriteLine("Average: {0}", listNumbers.Average());
        }
    }
}

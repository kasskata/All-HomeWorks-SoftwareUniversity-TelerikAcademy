namespace _01.ReverseNumbersWithAStack
{
    using System;
    using System.Collections.Generic;
    using TakeInput;

    // Write a program that reads N integers from the console and reverses them using a stack. 
    // Use the Stack<int> class from .NET Framework. Just put the input numbers in the stack and pop them

    class ReverseNumbersWithAStack
    {
        static void Main()
        {
            List<int> numbers = TakeInput.ListIntPrepare();
            Stack<int> stackOfNumbers = new Stack<int>();

            foreach (int number in numbers)
            {
                stackOfNumbers.Push(number);
            }

            int count = stackOfNumbers.Count;

            while (count != 0)
            {
                Console.WriteLine(stackOfNumbers.Pop());
                count--;
            }
        }
    }
}

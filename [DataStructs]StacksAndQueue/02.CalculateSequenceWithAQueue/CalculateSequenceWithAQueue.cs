namespace _02.CalculateSequenceWithAQueue
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    //    We are given the following sequence of numbers:
    //S1 = N
    //S2 = S1 + 1
    //S3 = 2*S1 + 1
    //S4 = S1 + 2
    //S5 = S2 + 1
    //S6 = 2*S2 + 1
    //S7 = S2 + 2
    //…
    //Using the Queue<T> class, write a program to print its first 50 members for given N
    class CalculateSequenceWithAQueue
    {
        private static Queue<int> q = new Queue<int>();

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            q = new Queue<int>();

            DequeueAndPrint(n);

            int count = 50;
            while (count > 0)
            {
                var number = q.Dequeue();
                DequeueAndPrint(number + 1);
                DequeueAndPrint((number * 2) + 1);
                DequeueAndPrint(number + 2);
                count -= 3;
            }
        }

        private static void DequeueAndPrint(int number)
        {
            Console.Write("{0}, ", number);
            q.Enqueue(number);
        }
    }
}

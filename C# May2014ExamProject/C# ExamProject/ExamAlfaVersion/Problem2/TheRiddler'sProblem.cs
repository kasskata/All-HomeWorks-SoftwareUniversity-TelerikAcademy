namespace Problems2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TheRiddlersProblem
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            int oddNumberSkip = int.Parse(Console.ReadLine());
            int evenNumberSkip = int.Parse(Console.ReadLine());
            int sumOddPositions = 0;
            int sumEvenPositions = 0;
            int evenCounter = 0;
            int oddCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddCounter++;
                    if (oddCounter % oddNumberSkip == 0)
                    {
                        sumOddPositions = input[i] * sumOddPositions;
                    }
                    else
                    {
                        sumOddPositions += input[i];
                    }
                }

                if (i % 2 != 0)
                {
                    evenCounter++;
                    if (evenCounter % evenNumberSkip == 0)
                    {
                        sumEvenPositions = input[i] * sumEvenPositions;
                    }
                    else
                    {
                        if (i != 0)
                        {
                            sumEvenPositions += input[i];
                        }
                    }
                }
            }

            string oddSum = sumOddPositions.ToString("X");
            string evenSum = sumEvenPositions.ToString("X");
            Console.WriteLine("Odd: " + oddSum);
            Console.WriteLine("Even: " + evenSum);
        }
    }
}

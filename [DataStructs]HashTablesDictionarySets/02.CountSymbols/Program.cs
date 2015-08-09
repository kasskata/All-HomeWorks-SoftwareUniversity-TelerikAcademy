namespace _02.CountSymbols
{
    using System;
    using System.Collections.Generic;

    class CountSymbols
    {
        static void Main()
        {
            Console.WriteLine("Gimme in put: ");
            string input = Console.ReadLine();
            SortedDictionary<char, int> counterDictionary = new SortedDictionary<char, int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (!counterDictionary.ContainsKey(input[i]))
                {
                    counterDictionary.Add(input[i], 1);
                    continue;
                }
                counterDictionary[input[i]] += 1;
            }

            foreach (var i in counterDictionary)
            {
                Console.WriteLine("{0}: {1} time{2}", i.Key, i.Value, i.Value > 1 ? "s" : "");
            }
        }
    }
}

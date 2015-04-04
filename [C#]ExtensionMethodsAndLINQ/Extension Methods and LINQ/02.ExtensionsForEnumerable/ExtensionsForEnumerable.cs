namespace ExtensionsForEnumerable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
    // sum, product, min, max, average.


    public static class ExtensionsForEnumerable
    {
        public static decimal Sum<T>(this IEnumerable<T> list)
        {
            decimal result = new decimal();
            foreach (var index in list)
            {
                result += Convert.ToDecimal(index);
            }
            return result;
        }

        public static decimal Product<T>(this IEnumerable<T> list)
        {
            decimal result = new decimal(1);
            foreach (var index in list)
            {
                result *= Convert.ToDecimal(index);
            }
            return result;
        }
        public static decimal Min<T>(this IEnumerable<T> list)
        {
            decimal temp = decimal.MaxValue;
            foreach (var index in list)
            {
                if (Convert.ToDecimal(index) < temp)
                {
                    temp = Convert.ToDecimal(index);
                }
            }
            return temp;
        }

        public static decimal Max<T>(this IEnumerable<T> list)
        {
            decimal temp = decimal.MinValue;
            foreach (var index in list)
            {
                if (Convert.ToDecimal(index) > temp)
                {
                    temp = Convert.ToDecimal(index);
                }
            }
            return temp;
        }

        public static decimal Average<T>(this List<T> list)
        {
            return list.Sum<T>() / list.Count();
        }

        static void Main()
        {
            List<int> joker = new List<int>();
            joker.Add(10);
            joker.Add(5);
            joker.Add(12);
            joker.Add(59);
            joker.Add(15);
            joker.Add(51);
            IEnumerable<int> batman = new List<int>(joker);

            Console.WriteLine(batman.Sum());
            Console.WriteLine(batman.Product());
            Console.WriteLine(batman.Min());
            Console.WriteLine(batman.Max());
            Console.WriteLine(batman.Average());
            Console.WriteLine();
        }
    }
}

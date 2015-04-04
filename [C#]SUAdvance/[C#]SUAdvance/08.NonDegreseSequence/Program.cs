using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NonDegreseSequence
{
    class Program
    {
        static int[] numbers = { 11 ,12, 13, 3 ,14, 4, 15, 5, 6 ,7, 8, 7, 16, 9, 8 };
        static int count = 0;
        static List<int> sortedSubset = new List<int>();

        static void Main()
        {
            Queue<List<int>> subsetsQueue = new Queue<List<int>>();
            List<int> emptySet = new List<int>();
            subsetsQueue.Enqueue(emptySet);
            while (subsetsQueue.Count > 0)
            {
                List<int> subset = subsetsQueue.Dequeue();

                CountSorted(subset);

                int start = -1;
                if (subset.Count > 0)
                {
                    start = subset[subset.Count - 1];
                }
                for (int i = start + 1; i < numbers.Length; i++)
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(i);
                    subsetsQueue.Enqueue(newSubset);
                }
            }
            //Console.WriteLine(count);
            Print(sortedSubset);
        }

        static void Print(List<int> subset)
        {
            Console.Write("{");
            for (int i = 0; i < subset.Count; i++)
            {
                if (i != subset.Count - 1)
                {
                    Console.Write("{0}, ", subset[i]);
                }
                else
                {
                    Console.Write("{0}", subset[i]);
                }
            }
            Console.WriteLine("}");
        }

        static void CountSorted(List<int> subset)
        {
            List<int> tmpList = new List<int>();
            int tmpCount = 0;

            if (subset.Count > 1)
            {
                for (int i = 0; i < subset.Count; i++)
                {
                    int index = subset[i];
                    tmpList.Add(numbers[index]);
                    tmpCount++;
                }
                //Check if subset is sorted and whether it has most elements.
                if (IsSorted(tmpList) && count < tmpCount)
                {
                    count = tmpCount;
                    sortedSubset.RemoveRange(0, sortedSubset.Count);
                    sortedSubset.AddRange(tmpList);
                }
            }
        }
        public static bool IsSorted(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] > list[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

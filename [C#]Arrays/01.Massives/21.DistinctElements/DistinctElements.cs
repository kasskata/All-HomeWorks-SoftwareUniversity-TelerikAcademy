using System;
using System.Collections.Generic;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


class DistinctElements
{
    static void Main()
    {
        int n;
        int k;
        InputNAndK(out n, out k);

        List<int> list = new List<int>(n);
        InitializeList(list, n);

        int[] combination = new int[k];
        InitializeArray(combination);

        bool nextCombinationExists = true;
        do
        {
            PrintCombination(combination);
            nextCombinationExists = NextIndexCombination(list.Count, k, combination);

        } while (nextCombinationExists);
    }

    private static void InputNAndK(out int n, out int k)
    {
        Console.Write("Enter n: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        k = int.Parse(Console.ReadLine());
    }

    private static void InitializeList(List<int> list, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            list.Add(i);
        }
    }

    private static void PrintCombination(int[] comb)
    {
        for (int i = 0; i < comb.Length; i++)
        {
            Console.Write((comb[i] + 1) + " ");
        }
        Console.WriteLine();
    }
    static bool NextIndexCombination(int elementsCount, int kClass, int[] arrayOfIndexes)
    {
        int maxIndex = elementsCount - 1;
        

        int itemIndex = kClass;
        for (int currentIndex = arrayOfIndexes.Length - 1; currentIndex >= 0; currentIndex--)
        {
            if (arrayOfIndexes[currentIndex] < maxIndex - (kClass - 1 - currentIndex))
            {
                itemIndex = currentIndex;
                break;
            }
        }
        if (itemIndex == kClass)
        {
            return false;
        }
        

        arrayOfIndexes[itemIndex]++;
        for (int i = itemIndex + 1; i < arrayOfIndexes.Length; i++)
        {
            arrayOfIndexes[i] = arrayOfIndexes[i - 1] + 1;
        }

        return true;
    }

    static void InitializeArray(int[] combination)
    {
        for (int i = 0; i < combination.Length; i++)
        {
            combination[i] = i;
        }
    }
}
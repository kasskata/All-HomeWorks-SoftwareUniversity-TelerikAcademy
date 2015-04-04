using System;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 11;

        for (int i = 0; i < arr.Length; i++)
            for (int j = i, sum = 0; j < arr.Length; j++)
                if ((sum += arr[j]) == s)
                    for (int k = 0, l = j - i + 1; k < l; k++) Console.WriteLine(arr[i + k]);
    }
}
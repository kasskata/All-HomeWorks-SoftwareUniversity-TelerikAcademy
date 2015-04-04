using System;
using System.Diagnostics;

class Assertions
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr.Length >= 2);
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1 );
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }
    
    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(startIndex <= endIndex);
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            Debug.Assert(midIndex <= startIndex || midIndex >=endIndex);
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the left half
                endIndex = midIndex - 1;
            }
        }

        throw new ArgumentException("Searched value not found");
        return -1;
    }



    static void Main()
    {
        try
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            bool[] arrBool = new bool[] { false, false, false, false, true, true, false, true };
            SelectionSort(arrBool);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arrBool));

            string[] arrString = new string[] { "sd", "as", "ba", "rt", "fd", "ads", "12", "ac" };
            SelectionSort(arrString);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arrString));

            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }
        catch(ArgumentException e){
            Console.WriteLine(e.Message);
        }
    }
    
}

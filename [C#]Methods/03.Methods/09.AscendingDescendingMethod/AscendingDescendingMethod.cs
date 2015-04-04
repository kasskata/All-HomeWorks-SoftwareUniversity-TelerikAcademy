using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
//Нямам време да си донапиша задачата за това правя бързо решение.
class AscendingDescendingMethod
{
    static int FindMax(int position,int[]array)
    {
        int max = array[position];
        for (int i = position; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }
    static void AscendingOrder(int max,int[] array)
    {
        for (int i = 0; i <= array.Length-1; i++)
        {
            for (int j = 0; j <= array.Length-1; j++)
            {
                if (array[i] < array[j]) // swap items
                {
                    int exchange = array[i];
                    array[i] = array[j];
                    array[j] = exchange;
                }
            }
        }
        Console.WriteLine("Acsending: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("  "+array[i]);
        }
        Console.WriteLine();
    }

    static void DescendingOrder(int max,int[]array)
    {
       for (int i = 0; i <= array.Length-1; i++)
        {
            for (int j = 0; j <= array.Length-1; j++)
            {
                if (array[i] > array[j]) // swap items
                {
                    int exchange = array[i];
                    array[i] = array[j];
                    array[j] = exchange;
                }   
            } 
        }
        Console.WriteLine("Descending: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("  " + array[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Fill the Array ({0} elemnt/s left) : ", array.Length - i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int[] cloneArray = (int[])array.Clone();

        Console.WriteLine("Enter position u want: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Max Number: " + FindMax(position, array));

        int max = FindMax(position, array);
        AscendingOrder(max, array);
        DescendingOrder(max, cloneArray);
    }
}
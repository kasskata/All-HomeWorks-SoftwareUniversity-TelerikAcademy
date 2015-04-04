using System;

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class SelectionSorting
{
    static void Main()
    {
        Console.WriteLine("Enter some Length for our Array");
        int[] array = new int[int.Parse(Console.ReadLine())];
        //initializating Array
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        //The algorithm
        for (int index = 0; index < array.Length - 1; index++)
        {
            for (int j = index + 1; j < array.Length; j++)
            {
                if (array[index] > array[j]) // swap items
                {
                    int exchange = array[index];
                    array[index] = array[j];
                    array[j] = exchange;
                }
            }
        }
        for (int i = 0; i < array.Length; i++) // print sorted array
        {
            Console.Write(array[i] + " ");
        }
    }
}

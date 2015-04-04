using System;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

class Program
{
    static string CheckNeigbour(int position, params int[] array)
    {
        //i messed up the method and do it for surely like this with 10000 if statements sorry about this
        position -= 1;
        string test = "";
        if (0 < position && position < array.Length - 1)
        {
            if (array[position - 1] < array[position] && array[position] > array[position + 1])
            {
                test = "is bigger";
            }
            else
            {
                test = "is not bigger";
            }
        }
        else if (0 == position)
        {
            if (array[position] > array[position + 1])
            {
                test = "is bigger";
            }
            else
            {
                test = "is not bigger";
            }
        }
        else if (position == array.Length-1)
        {
            if (array[position] > array[position - 1])
            {
                test = "is bigger";
            }
            else
            {
                test = "is not bigger";
            }
        }
        else
        {
            test = "is not bigger";
        }
        return test;
    }
    //but work properly in the problem
    static void Main()
    {
        Console.Write("Position (1 to 10): ");
        int position = int.Parse(Console.ReadLine());
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Fill the Array ({0} elemnt/s left) : ", array.Length - i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("the number on position {0} {1} than his neighbours. ",position ,CheckNeigbour(position, array));
    }
}

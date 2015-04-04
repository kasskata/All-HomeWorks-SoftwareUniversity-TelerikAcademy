using System;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

class ReturnANumber1
{
    static int FirstBiggerThanHisNeigbour(params int[] array)
    {
        int position = -2;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (i > 0 && i < array.Length)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    position = i;
                    break;
                }
            }
            else if (i == 0)
            {
                if (array[0] > array[1])
                {
                    position = i;
                    break;
                }
            }
            else if (i == array.Length)
            {
                if (array[i] > array[i - 1])
                {
                    position =  i;
                    break;
                }
            }
            else
            {
                position = -1;
            }
        }
        return position;
    }
    static void Main()
    {
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Fill the Array ({0} elemnt/s left) : ", array.Length - i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int position = FirstBiggerThanHisNeigbour(array)+1;
        Console.WriteLine("first position: " + position);
    }
}

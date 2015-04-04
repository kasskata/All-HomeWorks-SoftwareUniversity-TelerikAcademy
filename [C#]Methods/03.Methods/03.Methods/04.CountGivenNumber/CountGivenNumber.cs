using System;

//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.


class CountGivenNumber
{
    static int Count(int number ,params int[]array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return (count);
    }
    static void Main()
    {
        Console.Write("Enter the number which u want to trace: ");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Fill the Array: {0} elemnt/s left",array.Length-i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("the number {0} appear {1} time/times",number, Count(number, array));
    }
}

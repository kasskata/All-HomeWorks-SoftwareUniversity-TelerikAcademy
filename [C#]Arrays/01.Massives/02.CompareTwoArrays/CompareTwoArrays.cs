using System;

//Write a program that reads two arrays from the console and compares them element by element.

class Program
{
    static void Main()
    {
        Console.Write("Enter Original Array's length: ");
        int[] originalArr = new int[int.Parse(Console.ReadLine())];
        Console.Write("Enter Compare Array's length: ");
        int[] compareArr = new int[int.Parse(Console.ReadLine())];
        bool isEqual = true;


        if (originalArr.Length != compareArr.Length)
        {
            Console.WriteLine("The arrays have different lenght");
        }
        else
        {
            //now initilizing first loop to take the literals from console
            for (int index = 0; index < originalArr.Length; index++)
            {
                Console.Write("OriginalArr enter some number ({0}left):", originalArr.Length - index - 1);//I design this cool stuff(left counter) alone :P 
                originalArr[index] = int.Parse(Console.ReadLine());
                Console.Write("CompareArr: enter some number({0}left):", compareArr.Length - index - 1);//I design this cool stuff(left counter) alone :P 
                compareArr[index] = int.Parse(Console.ReadLine());
            }

            // loop for comparing and print to the console
            for (int index = 0; index < originalArr.Length; index++)
            {
                if (originalArr.Length != compareArr.Length)
                {
                    isEqual = false;
                    break;
                }
                else
                {
                    Console.WriteLine("{0} - {1}", originalArr[index], compareArr[index]);
                }
            }
            Console.WriteLine("Both Arrays is identity -->{0}", isEqual);
        }
    }
}

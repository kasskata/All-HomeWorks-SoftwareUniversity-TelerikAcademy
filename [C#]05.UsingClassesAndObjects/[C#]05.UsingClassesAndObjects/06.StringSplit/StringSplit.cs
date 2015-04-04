using System;

//5.You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//  string = "43 68 9 23 318" ; result = 461

class StringSplit
{
    static void Main()
    {
        string sequence = " 125 6578 436 9999,152346 318 ".Trim();
        string[] array = sequence.Split(' ');
        double sum = new Int32();
        for (int i = 0; i  < array.Length; i++)
        {
            sum += double.Parse(array[i]);
            Console.WriteLine(sum);
        }
        Console.WriteLine("sum= " + sum);
    }
}

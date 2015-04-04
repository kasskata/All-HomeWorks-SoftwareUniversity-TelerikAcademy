using System;
using System.Collections.Generic;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point)
//. The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
//The output is like in the examples below. Examples:

class MinimalAndMaximal
{
    static void Main()
    {
        List<int> batman = new List<int>();
        Console.WriteLine("Enter numbers(When u want to Stop type \"Stop\")");
        int maximal = 0;
        int minimal = 0;
        int sum = 0;
        double avarage = 0;

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "stop" || input == "Stop")
            {
                break;
            }
            else
            {
                batman.Add(int.Parse(input));
            }
        }
        batman.Sort();
        minimal = batman[0];
        maximal = batman[batman.Count-1];
        foreach (var number in batman)
        {
            sum += number;
        }
        avarage = sum / batman.Count-1;

        Console.WriteLine("Min: "+ minimal);
        Console.WriteLine("Max: " + maximal);
        Console.WriteLine("Sum: "+ sum);
        Console.WriteLine("Average: " + avarage);
    }
}
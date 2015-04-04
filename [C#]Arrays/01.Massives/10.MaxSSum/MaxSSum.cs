using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 => {4, 2, 5}	


class MaxSSum
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 11;

        //sum += array[counter]) == s => the counter of array and the current sum is equal to S (i like the design from "JasonPet" user)
        for (int index = 0; index < array.Length; index++) // first scan all arrays elements 
        {
            for (int counter = index, sum = 0; counter < array.Length; counter++) //with all array's elements begin to counter (first loop)
            {
                if ((sum += array[counter]) == s)  // when we have equals with sum 
                {
                    for (int k = 0, l = counter - index + 1; k < l; k++) //Print the sequence begin from (counter - index + 1) to K
                    {
                        Console.WriteLine(array[index + k]); 
                    }
                }
            }
        }
    }
}
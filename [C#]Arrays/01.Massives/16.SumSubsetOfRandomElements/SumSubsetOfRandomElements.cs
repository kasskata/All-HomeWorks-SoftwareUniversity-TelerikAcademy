using System;
using System.Collections.Generic;

// * We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S. 
// Example:
// arr={
//2,
//1 , 
//2 ,
//4 ,
//3 ,
//5 ,
//2 ,
//6  }, S=14 => yes (1+2+5+6)


class SumSubsetOfRandomElements
{
    static void Main()
    {
        int[] array = {2,1,2,4,3,5,2,6};
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int s = 14;
        bool[] Sums = new bool[s + 1];
        string[] Index = new string[s + 1];
        int Sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Sum = array[i];
            if (Sum < Sums.Length)
            {
                Sums[Sum] = true;
                Index[Sum] = i.ToString();
            }

            for (int j = Sums.Length - 1; j > 0; j--)
            {
                if (Sums[j] == true && j != array[i])
                {
                    if (Sum + j < Sums.Length)
                    {
                        Sums[Sum + j] = true;
                        if (Index[j] != i.ToString())
                        {
                            Index[Sum + j] = Index[j];
                        }
                        Index[Sum + j] = Index[Sum + j] + ";" + i.ToString();
                    }
                }
            }

            if (Sums[s] == true)
            {
                break;
            }
        }
        if (Sums[s] == true)
        {
            Console.Write("Yes (");
            string str = "";
            for (int i = 0; i < Index[s].Length; i++)
            {
                if (Index[s].Substring(i, 1) != ";")
                {
                    str = Index[s].Substring(i, 1);
                }
                else
                {
                    Console.Write("{0}+", array[Convert.ToInt32(str)]);
                    str = "";
                }
            }
            if (str != "")
            {
                Console.Write("{0}", array[Convert.ToInt32(str)]);
            }
            Console.WriteLine(")");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
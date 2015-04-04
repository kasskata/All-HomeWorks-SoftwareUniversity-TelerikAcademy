using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] multiArr = new int[n, n];
            for (int i = 0; i < multiArr.GetLength(1); i++)
            {
                for (int j = 0; j < multiArr.GetLength(0); j++)
                {
                    multiArr[i, j] = j;
                    Console.Write(j + "  ");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with
//a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N
//numbers separated by space. The output should be a single number in a separate text file. Example:

class BestPlatformFromText
{

          static void Main()
    {
        StreamReader Inputmatrix = new StreamReader(@"Matrix.txt");
        int[,] Matrix = new int [4,4];
            using (Inputmatrix)
            {
                for (int y = 0; y < Matrix.GetLength(1); y++)
                {
                    string[] array = ((Inputmatrix.ReadLine()).Split(' '));
                    for (int x = 0; x < Matrix.GetLength(1); x++)
                    {
                        Matrix[y, x] = int.Parse(array[x]);
                    }
                }
            }
        int bestCol = 0;
        int bestRow = 0;
        int bestSum = int.MinValue;
        for (int row = 0; row < Matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < Matrix.GetLength(1) - 1; col++)
            {
                int sum = Matrix[row, col] + Matrix[row, col + 1]
                   + Matrix[row + 1, col] + Matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        //Print Best 3x3 platform
        Console.WriteLine(new string('_', 40));
        Console.WriteLine("The best platform is");
        Console.WriteLine("{0} , {1}", Matrix[bestRow, bestCol], Matrix[bestRow, bestCol + 1]);
        Console.WriteLine("{0} , {1}", Matrix[bestRow + 1, bestCol], Matrix[bestRow + 1, bestCol + 1]);;
        Console.WriteLine("and maximal sum is: "+ bestSum);
        Console.WriteLine(new string('_', 40));
    }
}
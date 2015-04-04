using System;
/*
Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
  0 2 4 0  > направих си труда за теб направо да вкарваш числата
  7 1 3 3  > с отделните цифри на цял ред като го направи Жоро в лекцията.
  1 3 9 8  > Смени цифрите и ги копирай в конзолата.
  4 6 7 9  > ЗАдължително да са минимум 3 колони(columns)!!!
*/
class MaximalSumMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter small numbers,later you will initialize the matrix");
        Console.Write("Enter how many rows u want: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter how many columns u want: ");
        int m = int.Parse(Console.ReadLine());

        //initialize the matrix
        int[,] multiarray = new int[n, m];
        for (int row = 0; row < multiarray.GetLength(0); row++)
        {
            string currentRow = Console.ReadLine();
            string[] numberAsString = currentRow.Split(' ');
            for (int col = 0; col < multiarray.GetLength(1); col++)
            {
                multiarray[row, col] = int.Parse(numberAsString[col]);
            }
        }
        //calculations
        int bestCol = 0;
        int bestRow = 0;
        int bestSum = int.MinValue;
        for (int row = 0; row < multiarray.GetLength(0)-2; row++)
        {
            for (int col = 0; col < multiarray.GetLength(1)-2; col++)
            {
                int sum = multiarray[row, col] + multiarray[row, col + 1] + multiarray[row, col+2]
                   + multiarray[row + 1, col] + multiarray[row + 1, col + 1] + multiarray[row + 1, col+2]
                   + multiarray[row + 2, col] + multiarray[row + 2, col + 1] + multiarray[row + 2, col +2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        //Print Best 3x3 platform
        Console.WriteLine(new string('_',40));
        Console.WriteLine("The best platform is");
        Console.WriteLine("{0} , {1} , {2}",multiarray[bestRow,bestCol],multiarray[bestRow,bestCol+1],multiarray[bestRow,bestCol+2]);
        Console.WriteLine("{0} , {1} , {2}",multiarray[bestRow+1,bestCol],multiarray[bestRow+1,bestCol+1],multiarray[bestRow+1,bestCol+2]);
        Console.WriteLine("{0} , {1} , {2}",multiarray[bestRow+2,bestCol],multiarray[bestRow+2,bestCol+1],multiarray[bestRow+2,bestCol+2]);
        Console.WriteLine("and maximal sum is: "+ bestSum);
    }
}

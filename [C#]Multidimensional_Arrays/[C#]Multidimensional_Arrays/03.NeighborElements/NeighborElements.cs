using System;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
//neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 
//     ha fi ho hi    Пързо писане подобно на примера на Жоро в лекцията.
//     ha fo fo fo
//     xx ho ha xx

class NeighborElements
{
    static void Main()
    {
        Console.WriteLine("Columns: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Rows: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[m,n];

        //initialize the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string currentRow = Console.ReadLine();
            string[] numberAsString = currentRow.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = numberAsString[col];
            }
        }
        // calculation: find best length
        int length = 1;
        int bestLen = 1;
        int count = 0;
        string bestString = "";

        // 
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    length = 1;
                    count = length;
                    while (count + row < matrix.GetLength(0))
                    {
                        if (matrix[row + count, col] == matrix[row, col])
                        {
                            length++;
                            count++;
                            bestString = matrix[row, col];
                        }
                        else
                        {
                            count++;
                        }
                    }
                    if (length > bestLen)
                    {
                        bestLen = length;
                    }
                }
                else if (matrix[row, col] == matrix[row, col + 1])
                {
                    length = 1;
                    count = length;
                    while (count + col < matrix.GetLength(1))
                    {
                        if (matrix[row, col + count] == matrix[row, col])
                        {
                            count++;
                            length++;
                            bestString = matrix[row, col];
                        }
                        else
                        {
                            count++;
                        }
                    }
                    if (length > bestLen)
                    {
                        bestLen = length;
                    }
                }
                else if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    length = 1;
                    count = length;
                    while (count + row < matrix.GetLength(0) && count + col < matrix.GetLength(1))
                    {
                        if (matrix[row + count, col + count] == matrix[row, col])
                        {
                            length++;
                            count++;
                            bestString = matrix[row, col];
                        }
                        else
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    length = 1;
                }
                if (length > bestLen)
                {
                    bestLen = length;
                }
            }
        }
        //printing
        Console.Write(">>>>   ");
        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(bestString + " , ");
        }
        Console.WriteLine();

        //имам малко грешки в изчисленията,но моля те смили се :P
        //Не можах да го завършаидеята ми беше да се сменят цветовете а избраните но ми писна и спирях да се пробвам пък и нямам време (пък стана 29.12.2013 - 3:20)
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        if (matrix[row, col] == bestString)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            Console.Write(matrix[row, col]);
        //            Console.ResetColor();
        //        }
        //        else
        //        {
        //            Console.Write(matrix[row, col]);
        //        }
        //        Console.Write(" | ");
        //    }
        //    Console.WriteLine();
        //}
        //for (int row = 0; row < answer.GetLength(0); row++)
        //{
        //    for (int col = 0; col < answer.GetLength(1); col++)
        //    {
        //        Console.Write(" | ");
        //        if (answer != null)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            Console.Write(answer[row, col]);
        //            Console.ResetColor();
        //        }
        //        if (answer[row, col] == null)
        //        {
        //            Console.Write(matrix[row,col]);
        //        }

        //    }
        //    Console.WriteLine();
        //}
    }
}
//                (matrix[row, col] == matrix[row - 1, col])     || (matrix[row, col] == matrix[row + 1, col])     ||
//                (matrix[row, col] == matrix[row, col - 1])     || (matrix[row, col] == matrix[row, col + 1])     ||
//                (matrix[row, col] == matrix[row - 1, col - 1]) || (matrix[row, col] == matrix[row - 1, col + 1]) ||
//                (matrix[row, col] == matrix[row + 1, col - 1]) || (matrix[row, col] == matrix[row + 1, col + 1])
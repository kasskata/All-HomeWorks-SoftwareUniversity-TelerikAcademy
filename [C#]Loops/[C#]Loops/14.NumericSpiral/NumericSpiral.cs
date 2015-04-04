using System;

//* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers
//1 ... N numbers arranged as a spiral.


class NumericSpiral
{
    static void Main()
    {
        int currentRow = 0;
        int currentColumn = 0;
        int maxRows = 0;
        while (true)
        {
            Console.Write("Input number of rows N,:");
            bool check = int.TryParse(Console.ReadLine(), out maxRows);
            if (check && maxRows > 1 && maxRows <= 20)
            {
                break;
            }
            else
            {
                Console.WriteLine("The data input is incorrect!");
            }
        }
        int maxColumns = maxRows;
        int maxValue = maxRows * maxColumns;
        int counter = 1;
        int[,] elements = new int[maxRows, maxColumns];
        while (counter <= maxValue)
        {


            for (int i = currentRow; i < maxColumns; i++)
            {
                if (counter <= maxValue)
                {
                    elements[currentRow, i] = counter;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            currentRow++;
            for (int i = currentRow; i < maxRows; i++)
            {
                if (counter <= maxValue)
                {
                    elements[i, maxColumns - 1] = counter;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            maxColumns--;
            for (int i = maxColumns; i > currentColumn; i--)
            {
                if (counter <= maxValue)
                {
                    elements[maxRows - 1, i - 1] = counter;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            maxRows--;
            for (int i = maxRows; i > currentRow; i--)
            {
                if (counter <= maxValue)
                {
                    elements[i - 1, currentColumn] = counter;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            currentColumn++;
        }
        Console.WriteLine();
        Console.WriteLine("The output matrix is:");
        Console.WriteLine();
        for (int i = 0; i < Math.Sqrt(maxValue); i++)
        {
            Console.Write("|");
            for (int k = 0; k < Math.Sqrt(maxValue); k++)
            {
                if (elements[i, k] > 9)
                {
                    if (elements[i, k] > 99)
                    {
                        Console.Write(" {0}|", elements[i, k]);
                    }
                    else
                    {
                        Console.Write(" {0}|", elements[i, k]);
                    }
                }
                else
                {
                    Console.Write("  {0}|", elements[i, k]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
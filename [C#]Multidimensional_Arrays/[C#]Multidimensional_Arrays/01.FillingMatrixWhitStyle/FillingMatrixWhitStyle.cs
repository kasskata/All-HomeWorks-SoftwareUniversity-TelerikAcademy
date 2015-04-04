using System;
using System.Collections.Generic;


//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)


class FillingArrays
{
    static void Main()
    {
        int sum = 1;
        int n = 4;// int.Parse(Console.ReadLine());
        int[,] multiArr = new int[n, n];


        // Filling A) style
        for (int i = 0; i < multiArr.GetLength(1); i++)
        {
            for (int j = 0; j < multiArr.GetLength(0); j++)
            {
                multiArr[j, i] = sum;
                sum++;
            }
        }
        sum = 1;
        for (int row = 0; row < multiArr.GetLength(1); row++)
        {
            for (int col = 0; col < multiArr.GetLength(0); col++)
            {
                Console.Write(multiArr[row, col] + "  ");
                multiArr[row, col] = 0;                           // CLEAN the numbers and prepare for next fill
            }
            Console.WriteLine();
        }
        Console.WriteLine("A)");
        Console.WriteLine(new string('_',40));
        
        
        //Filling B) Style
        for (int col = 0; col < multiArr.GetLength(0); col++)
        {
            if (col % 2 == 0 || col == 0)
            {
                for (int row = 0; row < multiArr.GetLength(1); row++)
                {
                    multiArr[row,col] = sum;
                    sum++;
                }
            }
            else
            {
                for (int row = multiArr.GetLength(1)-1; row >= 0; row--)
                {
                    multiArr[row,col] = sum;
                    sum++;
                }
            }
        }
        for (int row = 0; row < multiArr.GetLength(1); row++)
        {
            for (int col = 0; col < multiArr.GetLength(0); col++)
            {
                Console.Write(multiArr[row, col] + "  ");
                multiArr[row, col] = 0;                           // CLEAN the numbers and prepare for next fill
            }
            Console.WriteLine();
        }

        Console.WriteLine("B)");
        Console.WriteLine(new string('_', 40));
        // Filling C) Style
         string part = "bottom";
        int counter = 0;

        int vertical = 0;
        int horizon = n - 1;
        int startRow = n - 1;
        int startTopCol = 1;
        while (counter < n*n)
        {
            if (part == "bottom")
            {
                counter++;
                multiArr[horizon, vertical] = counter;
                horizon++;
                vertical++;
                if (horizon > n - 1)
                {
                    startRow--;
                    horizon = startRow;
                    vertical = 0;
                }
                if (startRow < 0)
                {
                    startRow = 0;
                    horizon = 0;
                    vertical = 1;
                    part = "top";
                }
            }

            if (part == "top")
            {
                counter++;
                multiArr[horizon,vertical] = counter;
                horizon++;
                vertical++;
                if (vertical > n - 1)
                {
                    startTopCol++;
                    vertical = startTopCol;
                    horizon = 0;
                }
            }
        }
        for (int row = 0; row < multiArr.GetLength(1); row++)
        {
            for (int col = 0; col < multiArr.GetLength(0); col++)
            {
                Console.Write(multiArr[row, col] + "  ");
                multiArr[row, col] = 0;                           // CLEAN the numbers and prepare for next fill
            }
            Console.WriteLine();
        }

        Console.WriteLine("C)");
        Console.WriteLine(new string('_', 40));
        // fill D) style 
    }
}
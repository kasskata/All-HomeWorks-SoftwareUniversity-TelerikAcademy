using System;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2 => {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


class FirstMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[,] variables = new int[n, k];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < k; col++)
            {
                Console.WriteLine("{0},{1}",row,col);
            }

        }
    }
}

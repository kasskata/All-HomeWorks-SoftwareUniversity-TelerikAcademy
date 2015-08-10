namespace _03.TheWhiteHorse
{
    using System;
    using System.Collections.Generic;

    public static class HorseRiding
    {
        private static readonly int[] Positions = { 1, 2, -1, 2, 1, -2, -1, -2, 2, 1, -2, 1, 2, -1, -2, -1 };

        private class Node
        {
            public int Row { get; private set; }
            public int Col { get; private set; }
            public int Value { get; private set; }

            public Node(int row, int col, int value = 1)
            {
                this.Row = row;
                this.Col = col;
                this.Value = value;
            }
        }

        public static void Ride()
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var startRow = int.Parse(Console.ReadLine());
            var startCol = int.Parse(Console.ReadLine());
            var matrix = new int[rows, cols];

            matrix = FillMatrixWithValues(startRow, startCol, matrix);
            PrintResult(matrix.GetLength(1) / 2, matrix);
        }

        public static int[,] FillMatrixWithValues(int startRow, int startCol, int[,] matrix)
        {
            var queue = new Queue<Node>(new[] { new Node(startRow, startCol) });

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                matrix[currentNode.Row, currentNode.Col] = currentNode.Value;

                for (var i = 0; i < Positions.Length; i += 2)
                {
                    if (IsValidPosition(currentNode.Row + Positions[i],
                        currentNode.Col + Positions[i + 1], matrix))
                    {
                        queue.Enqueue(new Node(
                            currentNode.Row + Positions[i],
                            currentNode.Col + Positions[i + 1],
                            currentNode.Value + 1));
                    }
                }
            }
            return matrix;
        }

        public static void PrintResult(int col, int[,] matrix)
        {
            Console.WriteLine();
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, col]);
            }
        }

        private static bool IsValidPosition(int currRow, int currCol, int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            if (currRow < rows && currRow >= 0 &&
                currCol < cols && currCol >= 0 &&
                matrix[currRow, currCol] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
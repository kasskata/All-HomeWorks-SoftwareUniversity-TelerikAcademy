namespace Problem5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string[] inputFirstLine = Console.ReadLine().Split(',');
            string[] inputSecondtLine = Console.ReadLine().Split(',');
            int[,] grid = new int[8, 4];

            int positionFirstComLine = int.Parse(inputFirstLine[0]);
            int positionSecondComLine = int.Parse(inputSecondtLine[0]);

            for (int i = 0; i < grid.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.WriteLine(grid[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < grid.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (j == positionFirstComLine)
                    {
                        grid[i, j] = grid[i, j] == 0 ? 1 : 0;
                        positionFirstComLine += int.Parse(inputFirstLine[i + 1]);
                        break;
                    }
                }
            }

            for (int i = 0; i < grid.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (j == positionSecondComLine)
                    {
                        grid[i, j] = grid[i, j] == 0 ? 1 : 0;
                        positionSecondComLine += int.Parse(inputSecondtLine[i + 1]);
                        break;
                    }
                }
            }

            

            grid[grid.GetLength(0) - 1, positionFirstComLine] = grid[grid.GetLength(0) - 1, positionFirstComLine] == 0 ? 1 : 0;
            grid[grid.GetLength(0) - 1, positionSecondComLine] = grid[grid.GetLength(0) - 1, positionSecondComLine] == 0 ? 1 : 0;

            int sum = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                int tempDecNumber = Convert.ToInt32(grid[i, 0] + string.Empty + grid[i, 1] + string.Empty + grid[i, 2] + string.Empty + grid[i, 3], 2);
                sum += tempDecNumber;
            }

            Console.WriteLine(Convert.ToString(sum, 2));
            Console.WriteLine(sum.ToString("X"));
        }
    }
}
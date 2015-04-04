namespace MatrixSpinNumbers
{
    using System;

    public class MatrixSpin
    {
        internal static int[,] matrix;
        internal static int currentNumber = 1;
        internal static int directionX = 1;
        internal static int directionY = 1;
        internal static int i = 0;
        internal static int j = 0;
        internal static int size;

        private static void Change()
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int cd = 0;
            for (int i = 0; i < 8; i++)
                if (dirX[i] == directionX && dirY[i] == directionY)
                {
                    cd = i; break;
                }

            if (cd == 7)
            {
                directionX = dirX[0];
                directionY = dirY[0];
                return;
            }

            directionX = dirX[cd + 1];
            directionY = dirY[cd + 1];
        }

        private static bool Check(int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= matrix.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= matrix.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }

            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static void FindCell(out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)

                for (int j = 0; j < matrix.GetLength(0); j++)
                    if (matrix[i, j] == 0) { x = i; y = j; return; }

        }

        public static void Main()
        {
            size = ReadInput();
            matrix = new int[size, size];
            int step = size;

            RotateNumbersOnClockAngle();

            FindCell(out i, out j);
            currentNumber++;

            if (i != 0 && j != 0)
            {
                directionX = 1;
                directionY = 1;

                RotateNumbersOnClockAngle();
            }
            PrintMatrix();
        }

        private static int ReadInput()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }
            return n;
        }

        private static void RotateNumbersOnClockAngle()
        {
            while (true)
            {
                matrix[i, j] = currentNumber;

                if (!Check(i, j))
                {
                    break;
                }

                // stop if fill the cells
                if (i + directionX >= size || i + directionX < 0 || j + directionY >= size || j + directionY < 0 || matrix[i + directionX, j + directionY] != 0)

                    while ((i + directionX >= size || i + directionX < 0 || j + directionY >= size || j + directionY < 0 || matrix[i + directionX, j + directionY] != 0))
                    {
                        Change();
                    }
                i += directionX;
                j += directionY;
                currentNumber++;
            }
        }

        public static void PrintMatrix()
        {
            for (int pp = 0; pp < size; pp++)
            {
                for (int qq = 0; qq < size; qq++)
                {
                    Console.Write("{0,4}", matrix[pp, qq]);
                }

                Console.WriteLine();
            }
        }
    }
}
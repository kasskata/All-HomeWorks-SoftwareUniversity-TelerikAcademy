using System;
using System.Collections.Generic;

namespace Qix_Game
{
    class DrawEngine
    {
        public struct PrintItem
        {
            public string value;
            public int x;
            public int y;
            public ConsoleColor color;
            public bool isEmpty;

            public PrintItem(string value, int x, int y, ConsoleColor color, bool isEmpty = false)
            {
                this.value = value;
                this.x = x;
                this.y = y;
                this.color = color;
                this.isEmpty = isEmpty;
            }
        }

        static Queue<PrintItem> stuffToPrint = new Queue<PrintItem>();

        public static void PrintField(GameField field, bool isRedraw, bool fillTrail)
        {
            for (int col = 0; col < field.gameField.GetLength(1); col++)
            {
                for (int row = 0; row < field.gameField.GetLength(0); row++)
                {
                    if (!isRedraw && field.gameField[row, col] == CellStatus.Filled)
                    {
                        PrintOnPosition(row, col, CellColor(CellStatus.Filled));
                    }
                    else if (field.gameField[row, col] == CellStatus.Head)
                    {
                        PrintStringOnPosition(row, col, ((char)2).ToString(), CellColor(CellStatus.Head));
                    }
                    else if (!fillTrail && field.gameField[row, col] == CellStatus.Trail)
                    {
                        PrintStringOnPosition(row, col, ((char)46).ToString(), CellColor(CellStatus.Trail));
                        //PrintOnPosition(row, col, CellColor(CellStatus.Trail));
                    }
                    else if (fillTrail && field.gameField[row, col] == CellStatus.Trail)
                    {
                        //PrintStringOnPosition(row, col, ((char)46).ToString(), CellColor(CellStatus.Filled));
                        //field.gameField[row, col] = CellStatus.Filled;
                    }
                    else if (field.gameField[row, col] == CellStatus.Ball)
                    {

                    }
                }
            }
        }

        //Must go to the Draw Engine
        public static void PrintOnPosition(int row, int col, ConsoleColor color = ConsoleColor.DarkGray)
        {
            PrintItem toPrint = new PrintItem(" ", col, row, color, true);
            stuffToPrint.Enqueue(toPrint);
        }

        public static void PrintStringOnPosition(int row, int col, string phrase, ConsoleColor color = ConsoleColor.White)
        {
            PrintItem toPrint = new PrintItem(phrase, col, row, color);
            stuffToPrint.Enqueue(toPrint);
        }

        public static void Print()
        {
            while (stuffToPrint.Count > 0)
            {
                PrintItem item = stuffToPrint.Dequeue();
                Console.SetCursorPosition(item.x, item.y);
                if (item.isEmpty)
                {
                    Console.BackgroundColor = item.color;
                    Console.Write(item.value);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = item.color;
                    Console.Write(item.value);
                }
            }
        }

        //The ToColor method from GameField
        public static ConsoleColor CellColor(CellStatus status)
        {
            if (status.Equals(CellStatus.Empty))
            {
                return ConsoleColor.Black;
            }
            else if (status.Equals(CellStatus.Filled))
            {
                return ConsoleColor.Cyan;
            }
            else if (status.Equals(CellStatus.Head))
            {
                return ConsoleColor.White;
            }
            else if (status.Equals(CellStatus.Trail))
            {
                return ConsoleColor.Cyan;
            }
            else if (status.Equals(CellStatus.Ball))
            {
                //return ConsoleColor.; <--- Ball color
            }
            return ConsoleColor.Gray;
        }

        public static void FillNew(GameField theField)
        {
            List<List<int>> newValues = theField.tmpList;
            foreach (List<int> val in newValues)
            {
                PrintOnPosition(val[0], val[1], CellColor(CellStatus.Filled));
            }
            theField.tmpList = new List<List<int>>();
        }

        internal static void PrintPartOfField(GameField field, int startCol, int startRow)
        {
            List<List<int>> toRedraw = new List<List<int>>();

            int endCol = startCol + 4;
            int endRow = startRow + 4;
            if (endCol >= field.gameField.GetLength(1))
            {
                endCol = field.gameField.GetLength(1);
            }
            if (endRow >= field.gameField.GetLength(0))
            {
                endRow = field.gameField.GetLength(0);
            }

            for (int col = startCol; col < endCol; col++)
            {
                for (int row = startRow; row < endRow; row++)
                {
                    if (field.gameField[row, col] == CellStatus.Filled)
                    {
                        PrintOnPosition(row, col, CellColor(CellStatus.Filled));
                    }
                    else if (field.gameField[row, col] == CellStatus.Head)
                    {
                        PrintStringOnPosition(row, col, ((char)2).ToString(), CellColor(CellStatus.Head));
                    }
                    else if (field.gameField[row, col] == CellStatus.Trail)
                    {
                        PrintStringOnPosition(row, col, ((char)46).ToString(), CellColor(CellStatus.Trail));
                    }
                }
            }
        }

        internal static void ClearField(GameField field)
        {
            for (int col = 0; col < field.gameField.GetLength(1); col++)
            {
                for (int row = 0; row < field.gameField.GetLength(0); row++)
                {
                    if (field.gameField[row, col] == CellStatus.Head ||
                        field.gameField[row, col] == CellStatus.Trail)
                    {
                        field.gameField[row, col] = CellStatus.Empty;
                        PrintStringOnPosition(row, col, ((char)2).ToString(), CellColor(CellStatus.Empty));
                    }
                }
            }
        }
    }
}

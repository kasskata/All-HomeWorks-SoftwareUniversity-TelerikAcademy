using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {
        public class HiScore
        {
            private string player;

            private int points;

            public HiScore()
            {
            }

            public HiScore(string name, int points)
            {
                this.Player = name;
                this.Points = points;
            }
            public string Player
            {
                get
                {
                    return player;
                }

                set
                {
                    player = value;
                }
            }

            public int Points
            {
                get
                {
                    return points;
                }

                set
                {
                    points = value;
                }
            }
        }

        private static void Main(string[] args)
        {
            string startCoord = string.Empty;
            char[,] field = CreateField();
            char[,] bombs = PlaceBombs();
            int count = 0;
            bool isBombTrigered = false;
            List<HiScore> bestScores = new List<HiScore>(6);
            int row = 0;
            int col = 0;
            const int Max = 35;
            bool start = true;
            bool finish = false;

            do
            {
                if (start)
                {
                    Console.WriteLine(
                        "Wellcome! Let's play “Minesweeper”. Test your luck and continue to the end."
                        + "Enter 'top' for \"HiScores\", \n'restart': Restart the game , \n'exit': Exit from game.");
                    Dump(field);
                    start = false;
                }

                Console.Write("Enter row & column or choise: ");
                startCoord = Console.ReadLine().Trim();
                if (startCoord.Length >= 3)
                {
                    if (int.TryParse(startCoord[0].ToString(), out row) && int.TryParse(startCoord[2].ToString(), out col)
                        && row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        startCoord = "turn";
                    }
                }

                switch (startCoord)
                {
                    case "top":
                        Scores(bestScores);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = PlaceTheBombs();
                        Dump(field);
                        isBombTrigered = false;
                        start = false;
                        break;
                    case "exit":
                        Console.WriteLine("GoodBye");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                YourTurn(field, bombs, row, col);
                                count++;
                            }

                            if (Max == count)
                            {
                                finish = true;
                            }
                            else
                            {
                                Dump(field);
                            }
                        }
                        else
                        {
                            isBombTrigered = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\n You entered invalid command. Please enter again.\n");
                        break;
                }

                if (isBombTrigered)
                {
                    Dump(bombs);
                    Console.Write("\n Bomb Trigered and die with {0} points. " + "Nickname: ", count);
                    string nickname = Console.ReadLine();
                    HiScore t = new HiScore(nickname, count);
                    if (bestScores.Count < 5)
                    {
                        bestScores.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < bestScores.Count; i++)
                        {
                            if (bestScores[i].Points < t.Points)
                            {
                                bestScores.Insert(i, t);
                                bestScores.RemoveAt(bestScores.Count - 1);
                                break;
                            }
                        }
                    }

                    bestScores.Sort((HiScore score1, HiScore score2) => score2.Player.CompareTo(score1.Player));
                    bestScores.Sort((HiScore score1, HiScore score2) => score2.Points.CompareTo(score1.Points));
                    Scores(bestScores);

                    field = CreateGameField();
                    bombs = PlaceTheBombs();
                    count = 0;
                    isBombTrigered = false;
                    start = true;
                }

                if (finish)
                {
                    Console.WriteLine("\n Well done!");
                    Dump(bombs);
                    Console.WriteLine("Nickname: ");
                    string nickName = Console.ReadLine();
                    HiScore points = new HiScore(nickName, count);
                    bestScores.Add(points);
                    Scores(bestScores);
                    field = CreateGameField();
                    bombs = PlaceTheBombs();
                    count = 0;
                    finish = false;
                    start = true;
                }
            }
            while (startCoord != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("Goodbye!");
            Console.Read();
        }

        private static char[,] PlaceBombs()
        {
            throw new NotImplementedException();
        }

        private static char[,] CreateField()
        {
            throw new NotImplementedException();
        }

        private static void Scores(List<HiScore> points)
        {
            Console.WriteLine("\nPoints: ");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Player, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty list. \n");
            }
        }

        private static void YourTurn(char[,] field, char[,] bombs, int turn, int column)
        {
            char howManyBombs = CalculateHowManyBombs(bombs, turn, column);
            bombs[turn, column] = howManyBombs;
            field[turn, column] = howManyBombs;
        }

        private static void Dump(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceTheBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> randomPlaceList = new List<int>();
            while (randomPlaceList.Count < 15)
            {
                Random random = new Random();
                int randomPlace = random.Next(50);
                if (!randomPlaceList.Contains(randomPlace))
                {
                    randomPlaceList.Add(randomPlace);
                }
            }

            foreach (int index in randomPlaceList)
            {
                int col = index / columns;
                int row = index % columns;
                if (row == 0 && index != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void smetki(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char score = CalculateHowManyBombs(field, i, j);
                        field[i, j] = score;
                    }
                }
            }
        }

        private static char CalculateHowManyBombs(char[,] coord, int col, int row)
        {
            int counter = 0;
            int rows = coord.GetLength(0);
            int cols = coord.GetLength(1);

            if (col - 1 >= 0)
            {
                if (coord[col - 1, rows] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < rows)
            {
                if (coord[col + 1, rows] == '*')
                {
                    counter++;
                }
            }

            if (rows - 1 >= 0)
            {
                if (coord[col, rows - 1] == '*')
                {
                    counter++;
                }
            }

            if (rows + 1 < cols)
            {
                if (coord[col, rows + 1] == '*')
                {
                    counter++;
                }
            }

            if ((col - 1 >= 0) && (rows - 1 >= 0))
            {
                if (coord[col - 1, rows - 1] == '*')
                {
                    counter++;
                }
            }

            if ((col - 1 >= 0) && (rows + 1 < cols))
            {
                if (coord[col - 1, rows + 1] == '*')
                {
                    counter++;
                }
            }

            if ((col + 1 < rows) && (rows - 1 >= 0))
            {
                if (coord[col + 1, rows - 1] == '*')
                {
                    counter++;
                }
            }

            if ((col + 1 < rows) && (rows + 1 < cols))
            {
                if (coord[col + 1, rows + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}
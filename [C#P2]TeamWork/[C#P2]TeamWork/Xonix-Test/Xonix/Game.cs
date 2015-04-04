using System;
using System.Threading;

namespace Xonix
{
    class Game
    {
        enum Position { Empty = 0, Full = 1, Trace = 2, Undefined = 3 };

        static int playerX = 0;
        static int playerY = 0;

        static byte[,] playground = new byte[33, 80];

        static void Main()
        {
            Console.BufferWidth = Console.WindowWidth = 80;
            Console.BufferHeight = Console.WindowHeight = 40;

            //Print the menu
            PrintTheMenu();

            //For testing...

            //byte[,] playground = new byte[,]
            //    {
            //        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            //        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},

            //    };

            //Initialize the playfield (only the walls)

            int initX = 0; // for cols
            int initY = 0; // for rows

            while (true)
            {
                playground[initY, initX] = 1;
                if ((initX < 79) && (initY == 0))
                {
                    initX++;
                }
                else if ((initX == 79) && (initY < 32))
                {
                    initY++;
                }
                else if ((initX > 0) && (initY == 32))
                {
                    initX--;
                }
                else if ((initX == 0) && (initY > 0))
                {
                    initY--;

                    if (initY == 0)
                    {
                        break;
                    }
                }
            }

            //Print initilized playfield

            for (int i = 0; i < 33; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    if (playground[i, j] == 1)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write((char)35);
                    }

                }
            }

            //Print the start position of the player

            Console.SetCursorPosition(playerX, playerY);
            Console.Write((char)2);

            //Player position

            Position currentPosition = Position.Full;

            //Directions

            int left = 0;
            int right = 1;
            int up = 2;
            int down = 3;
            int stopped = 4;

            int direction = stopped;

            //The movement of the player

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        currentPosition = GetCurrentPosition(playerX - 1, playerY);

                        if (currentPosition == Position.Empty)
                        {
                            direction = left;
                        }

                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)46);
                        playground[playerY, playerX] = 2;
                        playerX--;
                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)2);
                        currentPosition = GetCurrentPosition(playerX, playerY);
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        currentPosition = GetCurrentPosition(playerX + 1, playerY);

                        if (currentPosition == Position.Empty)
                        {

                            direction = right;
                        }

                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)46);
                        playground[playerY, playerX] = 2;
                        playerX++;
                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)2);
                        currentPosition = GetCurrentPosition(playerX, playerY);
                    }
                    else if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        currentPosition = GetCurrentPosition(playerX, playerY - 1);

                        if (currentPosition == Position.Empty)
                        {
                            direction = up;
                        }

                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)46);
                        playground[playerY, playerX] = 2;
                        playerY--;
                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)2);
                        currentPosition = GetCurrentPosition(playerX, playerY);
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        currentPosition = GetCurrentPosition(playerX, playerY + 1);

                        if (currentPosition == Position.Empty)
                        {
                            direction = down;
                        }

                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)46);
                        playground[playerY, playerX] = 2;
                        playerY++;
                        Console.SetCursorPosition(playerX, playerY);
                        Console.Write((char)2);
                        currentPosition = GetCurrentPosition(playerX, playerY);
                    }
                    else if (pressedKey.Key == ConsoleKey.E)
                    {
                        break;
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case 0: //left
                            {
                                currentPosition = GetCurrentPosition(playerX, playerY);

                                if (currentPosition == Position.Empty)
                                {
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)46);
                                    playground[playerY, playerX] = 2;
                                    playerX--;
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)2);
                                }
                                else if (currentPosition == Position.Trace)
                                {
                                    GameOver();
                                }
                            }; break;

                        case 1: //right
                            {
                                currentPosition = GetCurrentPosition(playerX, playerY);

                                if (currentPosition == Position.Empty)
                                {
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)46);
                                    playground[playerY, playerX] = 2;
                                    playerX++;
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)2);
                                }
                                else if (currentPosition == Position.Trace)
                                {
                                    GameOver();
                                }
                            }; break;

                        case 2: //up
                            {
                                currentPosition = GetCurrentPosition(playerX, playerY);

                                if (currentPosition == Position.Empty)
                                {
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)46);
                                    playground[playerY, playerX] = 2;
                                    playerY--;
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)2);
                                }
                                else if (currentPosition == Position.Trace)
                                {
                                    GameOver();
                                }
                            }; break;

                        case 3: //down
                            {
                                currentPosition = GetCurrentPosition(playerX, playerY);

                                if (currentPosition == Position.Empty)
                                {
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)46);
                                    playground[playerY, playerX] = 2;
                                    playerY++;
                                    Console.SetCursorPosition(playerX, playerY);
                                    Console.Write((char)2);
                                }
                                else if (currentPosition == Position.Trace)
                                {
                                    GameOver();
                                }
                            }; break;
                        //case 4:
                        //    {
                        //        //Just wait for direction
                        //    }; break;
                    }
                }
                Thread.Sleep(80);
            }

            //Clear the console, pause 1sec. and then print everything, if there is a trail - make it wall...

            Console.Clear();
            Thread.Sleep(1000);

            for (int i = 0; i < 33; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (playground[i, j] == 1)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write((char)35);
                    }
                    else if (playground[i, j] == 2)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write((char)35);
                    }

                }
            }

        }

        private static void PrintTheMenu()
        {
            string[] options = { "New Game", "High Scores", "Map selection", "BlaBla", "BlaBla2", "BlaBla3", "Exit" };
            int selection = 0;
            while (true)
            {
                Console.Clear();
                //TODO move it to a file
                Console.WriteLine(@"##################################
#____  ___            .__        #
#\   \/  /____   ____ |__|__  ___#
# \     //  _ \ /    \|  \  \/  /#
# /     (  <_> )   |  \  |>    < #
#/___/\  \____/|___|  /__/__/\_ \#
#      \_/          \/         \/#
##################################");
                Console.SetCursorPosition(0, 9);
                for (int i = 0; i < options.Length; i++)
                {
                    int padding = ((35 - options[i].Length) / 2) + options[i].Length;
                    if (i == selection)
                    {
                        Console.Write(new String(' ', padding - options[i].Length));
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(options[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(options[i].PadLeft(padding));
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    selection++;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    selection--;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    //TODO check the selection
                    Console.Clear();
                    break;
                }

                if (selection >= options.Length)
                {
                    selection = 0;
                }
                else if (selection < 0)
                {
                    selection = options.Length - 1;
                }
            }
        }

        private static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over!");
        }

        static Position GetCurrentPosition(int playerX, int playerY)
        {
            if (playground[playerY, playerX] == 0)
            {
                return Position.Empty;
            }
            else if (playground[playerY, playerX] == 1)
            {
                return Position.Full;
            }
            else if (playground[playerY, playerX] == 2)
            {
                return Position.Trace;
            }
            else
            {
                return Position.Undefined;
            }
        }
    }
}

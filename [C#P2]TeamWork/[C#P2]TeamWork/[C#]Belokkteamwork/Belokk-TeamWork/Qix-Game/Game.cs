using System;
using System.Collections.Generic;
using System.Threading;

namespace Qix_Game
{
    public class Game
    {
        private static List<Ball> balls = new List<Ball>();
        private static Player player = new Player(0, 0);
        private static GameField theField = null;
        private static Sidebar sideBar = null;
        private static Settings settings = null;

        static void Main()
        {
            settings = new Settings();

            Console.Title = "Xonix Game";
            Console.CursorVisible = false;
            theField = new GameField(settings.fieldHeight, settings.fieldWidth);
            theField.Initialization();
            FSIOInterface scores = new FSIOInterface();

            StartingMenu menu = new StartingMenu(theField, ref settings);

            theField = menu.LetsGetStarted();
            theField.Initialization();

            DrawEngine.PrintField(theField, false, false);

            theField.gameField[player.CurrentPositionY, player.CurrentPositionX] = player.currentPosition;

            //Create the sidebar
            sideBar = new Sidebar(theField, settings);

            CreateBalls();

            DrawEngine.PrintField(theField, false, false);
            while (!sideBar.isGameOver)
            {
                DrawEngine.Print();
                //Only redraw a submatrix 3x3 arround the player
                int startX = player.LastPositionX - 2;
                int startY = player.LastPositionY - 2;
                if (startX < 0)
                {
                    startX = 0;
                }
                if (startY < 0)
                {
                    startY = 0;
                }
                DrawEngine.PrintPartOfField(theField, startX, startY);
                DrawEngine.PrintField(theField, true, false);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable == true)
                    {
                        Console.ReadKey(true);
                    }

                    player.Move(pressedKey, theField);
                }
                else
                {
                    player.MoveOnDirection(theField);
                }

                for (int i = 0; i < balls.Count; i++)
                {
                    balls[i].MoveBall(theField);
                }

                if (theField.isForFilling)
                {
                    int filled = theField.FillTheField(balls);
                    int percent = scores.CurrentScorePercent(filled, settings.fieldWidth * settings.fieldHeight);
                    sideBar.PrintFilled(percent);
                    int score = scores.CurrentScorePoints(filled, settings.fieldWidth * settings.fieldHeight); 
                    sideBar.PrintScore(score);
                    DrawEngine.FillNew(theField);
                    DrawEngine.PrintField(theField, true, true);
                }
                Thread.Sleep(60);
            }

            sideBar.PrintGameOver();
            DrawEngine.Print();
            Console.WriteLine();
        }

        private static void CreateBalls()
        {
            Random random = new Random();
            for (int i = 0; i < settings.difficulty; i++)
            {
                int startX = random.Next(5, theField.gameField.GetLength(1) - 5);
                int startY = random.Next(5, theField.gameField.GetLength(0) - 5);
                bool left = (startX % 2 == 1);
                bool up = (startY % 2 == 1);
                Ball newBall = new Ball(startX, startY, up, left);
                balls.Add(newBall);
            }
        }

        internal static void Kill(bool isCallFromSidebar = false)
        {
            DrawEngine.ClearField(theField);
            if (player.lastPosition == CellStatus.Filled)
            {
                theField.gameField[player.CurrentPositionY, player.CurrentPositionX] = player.lastPosition;
            }
            player = new Player(0, 0);
            theField.gameField[player.CurrentPositionY, player.CurrentPositionX] = player.currentPosition;
            if (!isCallFromSidebar)
            {
                sideBar.KillOccured();
            }
            DrawEngine.PrintField(theField, false, true);
        }
    }
}

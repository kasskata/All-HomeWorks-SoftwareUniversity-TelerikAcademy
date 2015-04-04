using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;

namespace Qix_Game
{
    class Sidebar
    {
        private GameField field;
        private int width, height, fieldWidth, fieldHeight;
        private int lives = 3;
        private int timeBars = 10, maxBars = 10;
        private Timer timer;
        public bool isGameOver = false;
        private int filled = 0;

        public Sidebar(GameField field, Settings settings)
        {
            this.field = field;
            lives = settings.lives;
            timer = new Timer(settings.levelTime * 100);

            //Set the size
            SetSidebarSize();
            //Print the border
            PrintSidebarBorder();
            //Print the static values
            PrintStaticText();
            //Print lives
            PrintLives();
            //Init and print the timer
            InitTimer();
            timer.Elapsed += new ElapsedEventHandler(Tick);
            timer.Start();
        }

        private void InitTimer()
        {
            string toPrint = new String('|', timeBars);
            DrawEngine.PrintStringOnPosition(5, fieldWidth + 8, toPrint, ConsoleColor.Green);
        }

        private void Tick(object sender, ElapsedEventArgs e)
        {
            timeBars--;
            if (timeBars > 0)
            {
                String toPrint = new String(' ', maxBars - timeBars) + new String('|', timeBars);
                DrawEngine.PrintStringOnPosition(5, fieldWidth + 8, toPrint, ConsoleColor.Green);
            }
            else
            {
                this.KillOccured();
                Game.Kill(true);
            }
        }

        public void KillOccured()
        {
            timer.Stop();
            lives--;
            if (lives >= 0)
            {
                PrintLives();
                timeBars = maxBars;
                InitTimer();
                timer.Start();
            }
            else
            {
                isGameOver = true;
            }
        }

        private void PrintLives()
        {
            DrawEngine.PrintStringOnPosition(2, fieldWidth + 10, lives.ToString(), ConsoleColor.Green);
        }

        public void PrintScore(int score)
        {
            DrawEngine.PrintStringOnPosition(11, fieldWidth + 10, score.ToString(), ConsoleColor.Green);
        }

        public void PrintFilled(int filledPercent)
        {
            //TODO Check if the percent is > the required
            //if so go to next level!
            string percent = String.Format("{0:0.00}%", filledPercent);
            DrawEngine.PrintStringOnPosition(8, fieldWidth + 10, percent, ConsoleColor.Green);
        }

        private void PrintFilled()
        {
            float filledPercent = ((float)filled / (fieldWidth * fieldHeight)) * 100;
            string percent = String.Format("{0:0.00}%", filledPercent);
            DrawEngine.PrintStringOnPosition(8, fieldWidth + 10, percent, ConsoleColor.Green);
        }

        //Static text that will not change while playing
        private void PrintStaticText()
        {
            //Print the lives 
            DrawEngine.PrintStringOnPosition(2, fieldWidth + 2, "Lives: ", ConsoleColor.Magenta);
            //Print the time
            DrawEngine.PrintStringOnPosition(5, fieldWidth + 2, "Time: ", ConsoleColor.Magenta);
            //Print the percentage
            DrawEngine.PrintStringOnPosition(8, fieldWidth + 2, "Filled: ", ConsoleColor.Magenta);
            //Print the score
            DrawEngine.PrintStringOnPosition(11, fieldWidth + 2, "Score: ", ConsoleColor.Magenta);
        }

        private void PrintSidebarBorder()
        {
            //Print the first line
            DrawEngine.PrintStringOnPosition(0, fieldWidth, new String('#', width), ConsoleColor.Red);

            //Draw the side lines
            for (int i = 1; i < height; i++)
            {
                DrawEngine.PrintStringOnPosition(i, fieldWidth, "#", ConsoleColor.Red);
                DrawEngine.PrintStringOnPosition(i, fieldWidth + width - 1, "#", ConsoleColor.Red);
            }

            //Print the last line
            DrawEngine.PrintStringOnPosition(height, fieldWidth, new String('#', width), ConsoleColor.Red);
        }

        //Set the size of the sidebar according to the
        //size of the game field
        private void SetSidebarSize()
        {
            fieldWidth = field.gameField.GetLength(1);
            fieldHeight = field.gameField.GetLength(0);
            width = (fieldWidth / 3) + 3;
            height = field.gameField.GetLength(0) / 2;
        }

        public void AddFilled(int filled)
        {
            this.filled += filled;
            PrintFilled();
        }

        public void PrintGameOver()
        {
            List<string> gameOverText = FSIOInterface.GetGameOverText();
            for (int i = 0; i < gameOverText.Count; i++)
            {
                DrawEngine.PrintStringOnPosition(height + i + 2, fieldWidth, gameOverText[i], ConsoleColor.Red);
            }
        }
    }
}

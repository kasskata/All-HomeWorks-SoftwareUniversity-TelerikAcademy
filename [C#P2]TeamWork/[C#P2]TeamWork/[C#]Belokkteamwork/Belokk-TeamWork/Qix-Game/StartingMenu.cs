using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qix_Game
{
    class StartingMenu
    {
        string offset = new String(' ', (Console.WindowWidth - 34) / 2);
        Settings settings;

        public StartingMenu(GameField theField, ref Settings settings)
        {
            this.settings = settings;
            Console.CursorVisible = false;
        }

        public GameField LetsGetStarted()
        {
            string[] options = GetOptions("main");
            int selection = 0;
            int currentOption = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                PrintLogo();
                Console.SetCursorPosition(0, 9);
                for (int i = 0; i < options.Length; i++)
                {
                    int padding = ((35 - options[i].Length) / 2) + options[i].Length;
                    if (i == selection)
                    {
                        Console.Write(offset + new String(' ', padding - options[i].Length));
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(options[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(offset + options[i].PadLeft(padding));
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    selection++;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    selection--;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    options = GetOptions("main");
                    currentOption = 0;
                    currentOption = 0;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (currentOption == 0 && selection == 0)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (currentOption == 0 && selection == 3)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        ManageSelection(ref options, ref currentOption, ref selection);
                        Console.Clear();
                    }

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
            return new GameField(settings.fieldHeight, settings.fieldWidth);
        }

        private void ManageSelection(ref string[] options, ref int currentOption, ref int selection)
        {
            //Main settings
            //settings option
            if (currentOption == 0 && selection == 1)
            {
                options = GetOptions("settings");
                currentOption = 1;
                selection = 0;
            }
            else if (currentOption == 1 && selection == 3)
            {
                options = GetOptions("main");
                currentOption = 0;
                selection = 0;
            }
            //high score option
            else if (currentOption == 0 && selection == 2)
            {
                if (HighScoreMenu())
                {
                    currentOption = 0;
                    selection = 0;
                }
            }

            //Settings tab
            //Difficulty
            else if (currentOption == 1 && selection == 0)
            {
                options = GetOptions("menu");
                currentOption = 2;
                selection = settings.difficulty - 1;
            }
            else if (currentOption == 2)
            {
                switch (selection)
                {
                    case 1:
                        settings.SetDifficulty(Settings.MEDIUM);
                        break;
                    case 2:
                        settings.SetDifficulty(Settings.HARD);
                        break;
                    default:
                        settings.SetDifficulty(Settings.EASY);
                        break;

                }
                options = GetOptions("settings");
                currentOption = 1;
                selection = 0;
            }
            //Fileds size
            else if (currentOption == 1 && selection == 1)
            {
                options = GetOptions("size");
                currentOption = 3;
                selection = settings.fieldSizeSelected;
            }
            else if (currentOption == 3)
            {
                switch (selection)
                {
                    case 1:
                        settings.SetFieldSize(Settings.MEDIUM);
                        settings.fieldSizeSelected = 1;
                        break;
                    case 2:
                        settings.SetFieldSize(Settings.LARGE);
                        settings.fieldSizeSelected = 2;
                        break;
                    default:
                        settings.SetFieldSize(Settings.SMALL);
                        settings.fieldSizeSelected = 0;
                        break;
                }
                options = GetOptions("settings");
                currentOption = 1;
                selection = 0;
            }
            //Controls
            else if (currentOption == 1 && selection == 2)
            {
                options = GetOptions("controls");
                currentOption = 4;
                selection = 0;
            }
            else if (currentOption == 4 && selection == 4)
            {
                options = GetOptions("settings");
                currentOption = 1;
                selection = 0;
            }
        }

        private string[] GetOptions(string type)
        {
            switch (type)
            {
                case "main":
                    return new string[] { "Start Game", "Settings", "High Scores", "Exit" };
                case "settings":
                    return new string[] { "Difficulty", "Fields size", "Controls", "Back" };
                case "menu":
                    return new string[] { "Easy", "Medium", "Hard", "Back" };
                case "size":
                    return new string[] { "Small", "Medium", "Large", "Back" };
                case "controls":
                    return new string[] { "Left Arrow - Move Left", "Right Arrow - Move Right", "Up Arrow - Move Up", "Down Arrow - Move Down", "Back" };
            }

            return null;
        }

        private void PrintLogo()
        {
            List<string> logo = FSIOInterface.GetMainLogo();
            for (int i = 0; i < logo.Count; i++)
            {
                Console.WriteLine(offset + logo[i]);
            }
        }

        private bool HighScoreMenu()
        {
            Console.Clear();
            PrintLogo();
            List<FSIOInterface.Score> hightScores = FSIOInterface.GetHighScores();
            String toPrint = "Rank Name Level Result";
            DrawEngine.PrintStringOnPosition(9, offset.Length + 7, toPrint, ConsoleColor.Gray);
            for (int i = 0; i < hightScores.Count; i++)
            {
                toPrint = hightScores[i].rank + "   " + hightScores[i].name + "   " + hightScores[i].lvl + "   " + hightScores[i].result;
                DrawEngine.PrintStringOnPosition(11 + i, offset.Length + 7, toPrint, ConsoleColor.Gray);
            }
            DrawEngine.PrintStringOnPosition(settings.fieldHeight - 1, 25, "Press any key to go back...", ConsoleColor.Gray);
            DrawEngine.Print();
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);

            return true;
        }

        //private void ControlsMenu()
        //{
        //    DrawEngine.PrintStringOnPosition(5, 12, "Left Arrow - Move Left", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(7, 12, "Right Arrow - Move Right", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(9, 12, "Up Arrow - Move Up", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(11, 12, "Down Arrow - Move Down", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(17, 12, "Press any key to go back...", ConsoleColor.Gray);
        //    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
        //    ClearMenu();
        //}

        //private void ClearMenu()
        //{
        //    for (int i = 2; i < 29; i++)
        //    {
        //        DrawEngine.PrintStringOnPosition(i, 2, new string(' ', 46));
        //    }

        //}

        //private void SettingsMenu()
        //{
        //    DrawEngine.PrintStringOnPosition(5, 18, "[D]");
        //    DrawEngine.PrintStringOnPosition(5, 21, "ifficulty", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(7, 18, "[F]");
        //    DrawEngine.PrintStringOnPosition(7, 21, "ield size", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(9, 18, "[C]");
        //    DrawEngine.PrintStringOnPosition(9, 21, "ontrols", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(11, 18, "[B]");
        //    DrawEngine.PrintStringOnPosition(11, 21, "ack", ConsoleColor.Gray);
        //    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
        //    bool validEnter = false;
        //    do
        //    {
        //        if (pressedKey.Key == ConsoleKey.D)
        //        {
        //            ClearMenu();
        //            DifficultyMenu();
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.F)
        //        {
        //            ClearMenu();
        //            SizeMenu();
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.C)
        //        {
        //            ClearMenu();
        //            ControlsMenu();
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.B)
        //        {
        //            ClearMenu();
        //            validEnter = true;
        //        }
        //    } while (!validEnter);
        //}

        //private void SizeMenu()
        //{
        //    DrawEngine.PrintStringOnPosition(5, 18, "[S]");
        //    DrawEngine.PrintStringOnPosition(5, 21, "mall - default", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(7, 18, "[M]");
        //    DrawEngine.PrintStringOnPosition(7, 21, "edium", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(9, 18, "[L]");
        //    DrawEngine.PrintStringOnPosition(9, 21, "arge", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(11, 18, "[B]");
        //    DrawEngine.PrintStringOnPosition(11, 21, "ack", ConsoleColor.Gray);
        //    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
        //    bool validEnter = false;
        //    do
        //    {
        //        if (pressedKey.Key == ConsoleKey.S)
        //        {
        //            ClearMenu();
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.M)
        //        {
        //            ClearMenu();
        //            height = 30;
        //            width = 50;
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.L)
        //        {
        //            ClearMenu();
        //            height = 50;
        //            width = 70;
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.B)
        //        {
        //            ClearMenu();
        //            validEnter = true;
        //        }
        //    } while (!validEnter);

        //}

        //private void DifficultyMenu()
        //{
        //    DrawEngine.PrintStringOnPosition(5, 18, "[E]");
        //    DrawEngine.PrintStringOnPosition(5, 21, "asy - default", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(7, 18, "[M]");
        //    DrawEngine.PrintStringOnPosition(7, 21, "edium", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(9, 18, "[H]");
        //    DrawEngine.PrintStringOnPosition(9, 21, "ard", ConsoleColor.Gray);
        //    DrawEngine.PrintStringOnPosition(11, 18, "[B]");
        //    DrawEngine.PrintStringOnPosition(11, 21, "ack", ConsoleColor.Gray);
        //    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
        //    bool validEnter = false;
        //    do
        //    {
        //        if (pressedKey.Key == ConsoleKey.E)
        //        {
        //            ClearMenu();
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.M)
        //        {
        //            ClearMenu();
        //            difficulty = 1;
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.H)
        //        {
        //            ClearMenu();
        //            difficulty = 2;
        //            validEnter = true;
        //        }
        //        else if (pressedKey.Key == ConsoleKey.B)
        //        {
        //            ClearMenu();
        //            validEnter = true;
        //        }
        //    } while (!validEnter);
        //}
    }
}

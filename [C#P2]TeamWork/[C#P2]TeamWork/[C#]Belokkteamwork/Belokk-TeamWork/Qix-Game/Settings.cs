using System;
using System.Collections.Generic;

namespace Qix_Game
{
    class Settings
    {
        public const string FILE_NAME = "../../Settings.ini";
        public const string DIFFICULTY = "[Difficulty]", EASY = "Easy", MEDIUM = "Medium", HARD = "Hard";
        public const string PLAYER = "[Player]", LIVES = "Lives";
        public const string LEVEL_SIZE = "[LevelSize]", SMALL = "Small", LARGE = "Large";
        public const string LEVEL = "[Level", PERCENT = "Percent", TIME = "Time";
        public const string DEFAULT = "Default";
        private Dictionary<string, Dictionary<string, string>> parsedFile = new Dictionary<string, Dictionary<string, string>>();

        //Holds the settings that are red
        public int difficulty { get; set; }
        public int fieldWidth { get; set; }
        public int fieldHeight { get; set; }
        public int fieldSizeSelected { get; set; }
        public int lives { get; set; }
        public int levelPercent { get; set; }
        public int levelTime { get; set; }
        private int currentLevel = 1;

        public Settings()
        {
            //Read the file
            List<string> fileLines = FSIOInterface.ReadFile(FILE_NAME);
            //Parse the file
            ParseFile(fileLines);

            //Set the default values for the variables
            SetDefaults();
        }

        public void SetDifficulty(string DEFAULT)
        {
            difficulty = int.Parse(parsedFile[DIFFICULTY][DEFAULT]);
        }

        public void SetFieldSize(string DEFAULT)
        {
            string[] list = parsedFile[LEVEL_SIZE][DEFAULT].Split('x');
            fieldHeight = int.Parse(list[0]);
            fieldWidth = int.Parse(list[1]);
        }

        public void SetLiveCount()
        {
            lives = int.Parse(parsedFile[PLAYER][LIVES]);
        }

        private void SetLevel()
        {
            levelPercent = int.Parse(parsedFile[LEVEL + currentLevel + "]"][PERCENT]);
            levelTime = int.Parse(parsedFile[LEVEL + currentLevel + "]"][TIME]);
        }

        private void SetDefaults()
        {
            SetDifficulty(DEFAULT);
            SetFieldSize(DEFAULT);
            SetLiveCount();
            SetLevel();
        }

        private void ParseFile(List<string> fileLines)
        {
            string group = DEFAULT;
            Dictionary<string, string> currentDict = new Dictionary<string, string>();
            for (int i = 0; i < fileLines.Count; i++)
            {
                fileLines[i] = fileLines[i].Trim();
                //If the line is a comment
                if (fileLines[i].StartsWith(";"))
                {
                    continue;
                }
                //If the line is the start of a group
                else if (fileLines[i].StartsWith("["))
                {
                    if (currentDict.Count > 0)
                    {
                        parsedFile[group] = currentDict;
                    }
                    group = fileLines[i];
                    currentDict = new Dictionary<string, string>();
                }
                //If it's a regular line
                else
                {
                    string[] split = fileLines[i].Split('=');
                    currentDict[split[0]] = split[1];
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Qix_Game
{
    class FSIOInterface
    {
        //Hold a single score
        public struct Score
        {
            public int result;
            public string name;
            public int rank;
            public int lvl;
        }

        private static string highScoresFile = "../../HighScore.dat";
        private static string mainLogoFile = "../../Logo.dat";
        private static string GameOverFile = "../../GameOver.dat";

        static public List<string> GetGameOverText()
        {
            List<string> returnValue = ReadFileDat(GameOverFile);
            return returnValue;
        }

        static public List<string> GetMainLogo()
        {
            List<string> returnValue = ReadFileDat(mainLogoFile);
            return returnValue;
        }

        static public List<Score> GetHighScores()
        {
            List<string> hiScores = new List<string>(ReadFileDat(highScoresFile));
            List<Score> listScores = new List<Score>();
            Score score;
            foreach (var hiScore in hiScores)
            {
                string[] str = hiScore.Split('.');
                score.rank = Convert.ToInt16(str[0]);
                score.name = str[1];
                score.lvl = Convert.ToInt16(str[2]);
                score.result = Convert.ToInt16(str[3]);
                listScores.Add(score);
            }
            return listScores;
        }

        public static List<string> ReadFile(string fileName)
        {
            List<string> rows = new List<string>();
            StreamReader readerFirstFile = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
            using (readerFirstFile)
            {
                string s;
                Console.WindowHeight = 40;
                while ((s = readerFirstFile.ReadLine()) != null)
                {
                    rows.Add(s);
                }
                return rows;
            }
        }

        private static List<string> ReadFileDat(string fileName)
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    var fileRows = (List<string>)bin.Deserialize(stream);
                    stream.Close();
                    return fileRows;

                }
            }
            catch (IOException)
            {
                List<string> fileRows = new List<string>() { "Read Failed" };
                return fileRows;
            }
        }

        public static bool SaveFileDat(List<string> rows, string fileName)
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, rows);
                    stream.Close();
                    bool isSaved = true;
                    return isSaved;
                }
            }
            catch (IOException)
            {
                bool isSaved = false;
                return isSaved;
            }
        }
        //static List<int> scoreSession = new List<int>();
        int oldPointsForPercent= 0 ;
        public int CurrentScorePercent(int points , int maxPoints)
        {

            int allPoints = oldPointsForPercent + points;
            double percent = ( allPoints / (double)maxPoints) * 100;
            oldPointsForPercent = allPoints;
            return Convert.ToInt16(percent);
        }
        int oldPointsForPoints = 0;
        int oldScorePoints = 0;
        public int CurrentScorePoints(int points,int maxPoints)
        {
            //int resultPoints = points - oldPoints;
            int allPoints = oldPointsForPoints + points;
            double percent = (allPoints / (double)maxPoints) * 100;
            int scorePoints = 0;
            if ( percent <= 30 )
            {
                scorePoints = points * 50;
            }
            else if (percent > 30 && percent <= 50)
            {
                scorePoints = points * 80;
            //    currentsScore = Math.Round(d1, 0, MidpointRounding.AwayFromZero);
            }
            else if (percent > 50 && percent <= 70)
            {
                scorePoints = points * 160;
            //    currentsScore = Math.Round(d1, 0, MidpointRounding.AwayFromZero);
            }
            else if (percent > 70 && percent <= 85)
            {
                scorePoints = points * 250;
            //    currentsScore = Math.Round(d1, 0, MidpointRounding.AwayFromZero);
            }
            oldPointsForPoints = allPoints;
            int allScore = oldScorePoints + scorePoints;
            oldScorePoints = allScore;
            return allScore;
        }
    }
}

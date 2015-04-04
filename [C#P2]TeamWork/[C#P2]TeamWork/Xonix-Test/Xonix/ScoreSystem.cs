using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;


namespace Xonix
{
    class ScoreSystem
    {
        struct scores
        {
            public int result;
            public string name;
            public int rank;
            public int lvl;

        }
        public ScoreSystem()
        {
        }
        public ArrayList GetHiScores()
        {
            List<string> hiScores = new List<string>(ReadFile("../../hiScore.txt"));
            ArrayList listScores = new ArrayList();
            scores score;
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
        public int Score(int[,] matrix)
        {
            int score = 10;
            return score;
        }
        public static void SetHiScore(int score)
        {
        }
        static List<string> ReadFile(string fileName)
        {
            List<string> rows = new List<string>();
            StreamReader readerFirstFile = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
            using (readerFirstFile)    // read file
            {
                string s;
                Console.WindowHeight = 40;
                while ((s = readerFirstFile.ReadLine()) != null)
                {
                    //var result = Regex.Replace(s2,@"\\[Uu]([0-9A-Fa-f]{4})",m => char.ToString((char)ushort.Parse(m.Groups[1].Value,NumberStyles.AllowHexSpecifier)));
                    /*var s2 = new StringBuilder(s)
                                .Replace("'", "")
                                .Replace(",", "")
                                .ToString();*/
                    rows.Add(s);
                }
                return rows;
            }
        }
        static bool SaveFileDat(List<string> rows, string fileName)
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
        static List<string> ReadFileDat(string fileName)
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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static long totalScore = new Int32();//Пазя отвън променивата за да не се променя.Ако имате по-добра идея го направете
        static long currentScore(byte[,] playground)        //return ==> totalScore
        {
            int points = new Int32();
            for (int x = 1; x < playground.GetLength(0) - 1; x++)
            {
                for (int y = 1; y < playground.GetLength(1) - 1; y++)
                {
                    if (playground[x, y] == (int)'.')
                        points++;
                }
            }
            int maxPoints = (playground.GetLength(0) - 2) * (playground.GetLength(1) - 2);//максималния брой точки на игра
            int percent = (points / maxPoints) * 100;
            int currentScore = new Int32();
            if (percent > 10 && percent <= 30)
            {
                currentScore += points * 50;
            }
            if (percent > 30 && percent <= 50)
            {
                currentScore += points * 80;
            }
            if (percent > 50 && percent <= 70)
            {
                currentScore += points * 160;
            }
            if (percent > 70 && percent <= 85)
            {
                currentScore += points * 250;
            }
            totalScore += currentScore;

            return totalScore;//>>>Резултата до подадените данни<<<
        }
    }
}
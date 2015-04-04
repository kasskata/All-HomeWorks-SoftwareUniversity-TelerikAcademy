namespace FallingRocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    internal class FallingRocks
    {
        private static void Play(char[,] playground)
        {
            Random engine = new Random();
            char[] particles = { '!', '@', '#', '$', '%', '^', '&', '*' };
            bool gameOver = false;

            while (gameOver == false)
            {
                Console.WriteLine(new string('_', 61));
                for (int col = 0; col < playground.GetLength(1); col++)
                {
                    playground[0, col] = particles[engine.Next(0, 7)];
                    char temp = playground[0, col];

                    for (int row = 0; row < playground.GetLength(0); row++)
                    {
                        Console.Write(playground[row, col] = ' ');
                    }
                    Console.WriteLine("|");
                }
                AddRandomParticles(particles, playground, engine);

                Console.WriteLine(new string('_', 61));
                Thread.Sleep(150);
                Console.Clear();
            }
        }

        private static void AddRandomParticles(char[] particles, char[,] playground, Random engine)
        {
            for (int i = 0; i < playground.GetLength(1); i++)
            {
                //dont have time!
            }
        }
        static void Main()
        {
            char[,] playground = new char[60, 20];
            string dwarf = "(0)";
            playground[29, playground.GetLength(1) - 1] = dwarf[0];
            playground[30, playground.GetLength(1) - 1] = dwarf[1];
            playground[31, playground.GetLength(1) - 1] = dwarf[2];

            Play(playground);
        }
    }
}
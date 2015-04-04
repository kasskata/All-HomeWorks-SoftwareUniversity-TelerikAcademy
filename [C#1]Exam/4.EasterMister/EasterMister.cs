using System;

class EasterMister
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int hight =  (numberN/2);
        int witdh = 3 * numberN - 1;
        int witdhDrawing = 3 * numberN + 1;
        int topAndBotoom = numberN - 1;

        if (numberN != 2)
        {
            Console.Write(new string('.', numberN + 1));
            Console.Write(new string('*', topAndBotoom));
            Console.WriteLine(new string('.', numberN + 1));
            //top
            for (int i = 0; i <= hight; i++)
            {
                for (int j = 1; j <= witdhDrawing; j++)
                {
                    if (i > hight / 2)
                    {
                        if (j == 2 || j == witdhDrawing - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else
                    {
                        if (j == numberN - (2 * i) || j == ((witdhDrawing + 1 - numberN) + 2 * i))
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }                    
                }
                Console.WriteLine();
            }
            //ribbon
            for (int i = 0; i < 2; i++)
            {
                Console.Write(".*");
                for (int j = 0; j <= (3 * numberN) - 4; j++)
                {
                    if (i == 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('#');

                        }
                        else if (j % 2 == 0)
                        {
                            Console.Write('.');
                        }
                    }
                    else if (i == 1)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('.');
                        }
                        else if (j % 2 == 0)
                        {
                            Console.Write('#');

                        }
                    }
                }
                Console.WriteLine("*.");
            }
            //bottom //
            int counter = 0;
            witdhDrawing = 3 * numberN + 1;
            for (int i = 0; i <=hight; i++)
            {
                for (int j = 1; j <= witdhDrawing; j++)
                {
                    if (i < hight / 2)
                    {
                        if (j == 2 || j == witdhDrawing -1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else
                    {                     
                        if (j == counter|| j == witdh+4-counter)
                        {                        
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                }
                counter += 2;
                Console.WriteLine();
            }

            Console.Write(new string('.', numberN + 1));
            Console.Write(new string('*', topAndBotoom));
            Console.WriteLine(new string('.', numberN + 1));
        }

        else if (numberN==2)
        {
            Console.Write(new string('.', numberN + 1));
            Console.Write(new string('*', topAndBotoom));
            Console.WriteLine(new string('.', numberN + 1));
            for (int i = 0; i < 2; i++)
            {
                Console.Write(".*");
                for (int j = 0; j <= (3 * numberN) - 4; j++)
                {
                    if (i == 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('#');

                        }
                        else if (j % 2 == 0)
                        {
                            Console.Write('.');
                        }
                    }
                    else if (i == 1)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('.');
                        }
                        else if (j % 2 == 0)
                        {
                            Console.Write('#');

                        }
                    }
                }
                Console.WriteLine("*.");
            }
            Console.Write(new string('.', numberN + 1));
            Console.Write(new string('*', topAndBotoom));
            Console.WriteLine(new string('.', numberN + 1));
        }
    }
}

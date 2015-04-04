using System;

class MissCat
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int jurysVote = 0;
        int cat1 = 0;
        int cat2 = 0;
        int cat3 = 0;
        int cat4 = 0;
        int cat5 = 0;
        int cat6 = 0;
        int cat7 = 0;
        int cat8 = 0;
        int cat9 = 0;
        int cat10 = 0;
        for (int i = 0; i < N; i++)
        {
            jurysVote = int.Parse(Console.ReadLine());
            switch (jurysVote)
            {
                case 1:
                    cat1++;
                    break;
                case 2:
                    cat2++;
                    break;
                case 3:
                    cat3++;
                    break;
                case 4:
                    cat4++;
                    break;
                case 5:
                    cat5++;
                    break;
                case 6:
                    cat6++;
                    break;
                case 7:
                    cat7++;
                    break;
                case 8:
                    cat8++;
                    break;
                case 9:
                    cat9++;
                    break;
                case 10:
                    cat10++;
                    break;
            }
        }
        int winner = 0;
        int mostvotes = 0;

        if (cat1 > mostvotes)
        {
            mostvotes = cat1;
            winner = 1;
        }
        if (cat2 > mostvotes)
        {
            mostvotes = cat2;
            winner = 2;
        }
        if (cat3 > mostvotes)
        {
            mostvotes = cat3;
            winner = 3;
        }
        if (cat4 > mostvotes)
        {
            mostvotes = cat4;
            winner = 4;
        }
        if (cat5 > mostvotes)
        {
            mostvotes = cat5;
            winner = 5;
        }
        if (cat6 > mostvotes)
        {
            mostvotes = cat6;
            winner = 6;
        }
        if (cat7 > mostvotes)
        {
            mostvotes = cat7;
            winner = 7;
        }
        if (cat8 > mostvotes)
        {
            mostvotes = cat8;
            winner = 8;
        }
        if (cat9 > mostvotes)
        {
            mostvotes = cat9;
            winner = 9;
        }
        if (cat10 > mostvotes)
        {
            mostvotes = cat10;
            winner = 10;
        }
        Console.WriteLine(winner);
    }
}

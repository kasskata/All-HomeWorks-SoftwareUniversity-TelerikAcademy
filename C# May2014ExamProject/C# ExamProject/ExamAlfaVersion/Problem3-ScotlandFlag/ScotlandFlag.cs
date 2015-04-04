namespace Problem3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ScotlandFlag
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counterLeft = 0;
            int counterMiddle = n - 2;
            int counterRight = 0;
            int letterCounter = 'A';

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', counterLeft));
                counterLeft++;

                Console.Write((char)letterCounter);
                letterCounter++;
                letterCounter = AlphabetReset(letterCounter);
                Console.Write(new string('#', counterMiddle));
                counterMiddle -= 2;
                Console.Write((char)letterCounter);
                letterCounter++;
                letterCounter = AlphabetReset(letterCounter);
                Console.Write(new string(' ', counterRight));
                counterRight++;
                Console.WriteLine();
            }

            Console.Write(new string('-', counterLeft));
            Console.Write((char)letterCounter);
            letterCounter++;
            letterCounter = AlphabetReset(letterCounter);
            Console.Write(new string('-', counterRight));
            Console.WriteLine();

            counterLeft = (n / 2) - 1;
            counterMiddle = 1;
            counterRight = (n / 2) - 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', counterLeft));
                counterLeft--;
                Console.Write((char)letterCounter);
                letterCounter++;
                letterCounter = AlphabetReset(letterCounter);
                Console.Write(new string('#', counterMiddle));
                counterMiddle += 2;
                Console.Write((char)letterCounter);
                letterCounter++;
                letterCounter = AlphabetReset(letterCounter);
                Console.Write(new string(' ', counterRight));
                counterRight--;
                Console.WriteLine();
            }
        }

        public static int AlphabetReset(int letterCounter)
        {
            if (letterCounter > 90)
            {
                letterCounter = 'A';
            }

            return letterCounter;
        }
    }
}

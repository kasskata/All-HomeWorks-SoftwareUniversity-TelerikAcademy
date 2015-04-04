namespace Problem4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StarlinksMath
    {
        public static int SumAllChars(string substring)
        {
            int sum = 0;
            for (int j = 0; j < substring.Length; j++)
            {
                sum += (int)substring[j];
            }

            return sum;
        }

        public static void Main()
        {
            string firstSequence = Console.ReadLine().ToUpper();
            string secondSequence = Console.ReadLine().ToUpper();
            ////int sumOfRightORLeftSides = int.Parse(Console.ReadLine());

            int starlinkerYells = 0;

            for (int i = 1; i < firstSequence.Length; i++)
            {
                string tempFirstSubstringLeftSide = firstSequence.Substring(0, i);
                string tempFirstSubstringRightSide = firstSequence.Substring(i, firstSequence.Length - i);
                int tempFirstSumLeft = SumAllChars(tempFirstSubstringLeftSide);
                int tempFirstSumRight = SumAllChars(tempFirstSubstringRightSide);

                ////  Console.WriteLine(tempFirstSumLeft);
                ////  Console.WriteLine(tempFirstSumRight);

                for (int j = 0; j < secondSequence.Length; j++)
                {
                    string tempSecondSubstringLeftSide = secondSequence.Substring(0, j);
                    string tempSecondSubstringRightSide = secondSequence.Substring(j, secondSequence.Length - j);
                    int tempSecondSumLeft = SumAllChars(tempSecondSubstringLeftSide);
                    int tempSecondSumRight = SumAllChars(tempSecondSubstringRightSide);

                    //// Console.WriteLine(tempSecondSumLeft);
                    //// Console.WriteLine(tempSecondSumRight);

                    if (tempFirstSumLeft == tempSecondSumLeft)
                    {
                        starlinkerYells++;
                        ////Console.WriteLine(tempFirstSumLeft + " " + tempFirstSubstringLeftSide + " = " + tempSecondSubstringLeftSide + " " + tempSecondSumLeft);
                    }

                    if (tempFirstSumRight == tempSecondSumRight)
                    {
                        starlinkerYells++;
                        ////Console.WriteLine(tempFirstSumRight + " " + tempFirstSubstringRightSide + " = " + tempSecondSubstringRightSide + " " + tempSecondSumRight);
                    }
                }
            }

            Console.WriteLine(starlinkerYells);
        }
    }
}

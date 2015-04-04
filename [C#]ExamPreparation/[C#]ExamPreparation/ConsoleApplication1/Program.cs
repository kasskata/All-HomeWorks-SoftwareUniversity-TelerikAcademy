using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Carpets
{
    static void Main(string[] args)
    {
        // For this task the figure is devided into two parts - triangles, with one "for-loop" for each one
        // Each part is an isosceles triangle so each line of of it will be formed from two other strings - left and right,
        //with equal number of chars
        int height = int.Parse(Console.ReadLine());
        int width = height;
        int maxLines = height / 2; //This is the maximal number of lines for each triangle
        int dotsMaxCount = (width - 2) / 2;
        char charLeft;
        char charRight;
        int charDefinitor = 1;
        string leftSide;
        string rightSide;
        int maxCharsInASide = width / 2;

        // Top triangle
        for (int i = 1; i <= maxLines; i++)
        {
            leftSide = new string('.', dotsMaxCount);
            rightSide = leftSide;
            for (int j = dotsMaxCount; j < maxCharsInASide; j++)
            {
                if (charDefinitor == 1)
                {
                    charLeft = '/';
                    charRight = '\u005C';
                    charDefinitor = 0;
                }
                else
                {
                    charLeft = ' ';
                    charRight = ' ';
                    charDefinitor = 1;
                }
                leftSide = leftSide + charLeft;
                rightSide = charRight + rightSide;
            }
            dotsMaxCount--;
            charDefinitor = 1;
            Console.WriteLine(leftSide + rightSide);
        }

        dotsMaxCount = 0;

        //Bottom triangle
        for (int i = 1; i <= maxLines; i++)
        {
            leftSide = new string('.', dotsMaxCount);
            rightSide = leftSide;
            for (int j = dotsMaxCount; j < maxCharsInASide; j++)
            {
                if (charDefinitor == 1)
                {
                    charLeft = '\u005C';
                    charRight = '/';
                    charDefinitor = 0;
                }
                else
                {
                    charLeft = ' ';
                    charRight = ' ';
                    charDefinitor = 1;
                }
                leftSide = leftSide + charLeft;
                rightSide = charRight + rightSide;
            }
            dotsMaxCount++;
            charDefinitor = 1;
            Console.WriteLine(leftSide + rightSide);
        }
    }
}
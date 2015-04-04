using System;
using System.Text;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character 
//encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows 
//the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        Console.WriteLine("Enter some number,which can't devide on 2 and bigger than 3(5,7,9 etc.)");
        int cols = int.Parse(Console.ReadLine());
        //int copyrightToInt = (int)'©';
        char copyright = '©'; 
        int count = 1;
        Console.Write(new string(' ', cols / 2));
        Console.Write(copyright);
        Console.Write(new string(' ', cols / 2));
        Console.WriteLine();
        for (int i = cols / 2; i > 0; i--)
        {
            if (i != 1)
            {
                Console.Write(new string(' ', i - 1));
                Console.Write(copyright);
                Console.Write(new string(' ', count));
                Console.Write(copyright);
                Console.Write(new string(' ', i - 1));
                Console.WriteLine();
                count += 2;
            }
            else if (i == 1)
            {
                for (int y = 0; y < cols; y++)
                {
                    if (y % 2 != 0)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write(copyright);
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Cool Isn't it?");
    }
}

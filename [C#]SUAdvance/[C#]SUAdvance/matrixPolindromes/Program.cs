using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixPolindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int charstart = 97;
            string[,] matrx = new string[row,col];
            int changestart = charstart;
            for (int r = 0; r < matrx.GetLength(0); r++)
            {
                
                for (int c = 0; c < matrx.GetLength(1); c++)
                {
                    matrx[r, c] = ((char)(r+charstart) +""+ (char)(c+changestart) +""+ (char)(r+charstart)).ToString()+" ";
                    Console.Write(matrx[r,c]);
                }
                changestart = r+charstart + 1;
                Console.WriteLine();
            }
        }
    }
}

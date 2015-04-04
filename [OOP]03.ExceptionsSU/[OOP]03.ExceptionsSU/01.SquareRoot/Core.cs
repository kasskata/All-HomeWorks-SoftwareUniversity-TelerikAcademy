namespace _01.SquareRoot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Core
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                double root = Math.Sqrt(number);
                if (number < 0)
                {
                    throw new Exception();
                }
                Console.WriteLine(root);

            }

            catch(Exception)
            {
                Console.WriteLine("Invalid Number!");

            }

            finally
            {
                Console.WriteLine("GoodBye");

            }
        }
    }
}

namespace Problem1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ElectricityProblem
    {
        public static void Main()
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());
            DateTime time = DateTime.Parse(Console.ReadLine());
            int sumWats = 0;

            ////different sum of wats in the days
            decimal noon = (decimal)((2 * 100.53) + (2 * 125.90));
            decimal afternoon = (decimal)((6 * 100.53) + (7 * 125.90));
            decimal midnight = (decimal)((1 * 100.53) + (8 * 125.90));

            ////if noon
            if (time.Hour >= 14 && time.Hour <= 18)
            {
                sumWats = (int)(noon * apartments * floors);

            }

            ////if afternoon
            else if (time.Hour >= 19 && time.Hour <= 23)
            {
                sumWats = (int)(afternoon * apartments * floors);
            }

            ////if midnight
            else if (time.Hour >= 0 && time.Hour <= 8)
            {
                sumWats = (int)(midnight * apartments * floors);
            }

            Console.WriteLine(sumWats + " W");
        }
    }
}

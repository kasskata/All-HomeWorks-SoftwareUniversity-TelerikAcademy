using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            var first = DateTime.ParseExact(Console.ReadLine(),"d.MM.yyyy",CultureInfo.DefaultThreadCurrentCulture);
            var second = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.DefaultThreadCurrentCulture);

            Console.WriteLine(string.Format("{0}",(second - first).Days));
        }
    }
}

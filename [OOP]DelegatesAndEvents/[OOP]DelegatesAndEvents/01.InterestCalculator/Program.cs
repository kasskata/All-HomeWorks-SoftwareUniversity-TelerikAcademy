using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.InterestCalculator
{
    class Program
    {

        public const int TimesPerYear = 12; 
        static void Main(string[] args)
        {
            Func<double, double, int, string> GetSimpleInterest = (sum, interest, years) => 
                (
            string.Format("{0:0.0000}", sum * (1 + (interest/100) * years))
            );
            Func<double, double, int, string> GetCompoundInterest = (sum, interest, years) => (
           string.Format("{0:0.0000}", sum * Math.Pow((1 + (interest/100)/years),years*TimesPerYear))
            );

            string b = GetCompoundInterest.Invoke(500,5.6,10);
            Console.WriteLine(b);
        }
    }
}

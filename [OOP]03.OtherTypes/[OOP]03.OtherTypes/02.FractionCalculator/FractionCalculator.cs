using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        private decimal numerator, denominator;

        public Fraction(decimal n, decimal d)
        {
            numerator = n;
            denominator = d;

        }

        public decimal Numerator
        {
            get
            {
                if (this.numerator == 0)
                {
                    throw new ArgumentNullException("the number cant be Zero or null");
                }
                return this.numerator;
            }
            set { this.numerator = value; }
        }

        public decimal Denominator
        {
            get
            {
                if (this.denominator == 0)
                {
                    throw new ArgumentNullException("the number cant be Zero or null");
                }
                return this.denominator;
            }
            set { this.denominator = value; }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result.denominator = a.denominator * b.denominator;
            result.numerator = (a.numerator * b.denominator) + (b.numerator * a.denominator);

            return result;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result.denominator = a.denominator * b.denominator;
            result.numerator = (a.numerator * b.denominator) - (b.numerator * a.denominator);

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}",this.numerator,this.denominator);
        }
    }
}

using System;

class AmericanPie
{
    static void Main()
    {
        decimal nominatorA = decimal.Parse(Console.ReadLine());
        decimal denominatorA = decimal.Parse(Console.ReadLine());
        decimal nominatorB = decimal.Parse(Console.ReadLine());
        decimal denominatorB = decimal.Parse(Console.ReadLine());
        int wholePies = 0;
        if (denominatorA != denominatorB)
        {
            decimal denominatorAB = denominatorA * denominatorB;
            decimal nominatorAB = (nominatorA * denominatorB) + (nominatorB * denominatorA);
            if (nominatorAB > denominatorAB)
            {
                wholePies =(int)(nominatorAB / denominatorAB);
                Console.WriteLine(wholePies);               
                Console.WriteLine("{0}" + '/' + "{1}", nominatorAB, denominatorAB);
            }
            else if (nominatorAB < denominatorAB)
            {
                decimal pies = nominatorAB / denominatorAB;
                Console.WriteLine("{0:F20}", pies);
                Console.WriteLine("{0}" + '/' + "{1}", nominatorAB, denominatorAB);
            }
            else if (nominatorAB == denominatorAB)
            {
                Console.WriteLine("1");
                Console.WriteLine("{0}" + '/' + "{1}", nominatorAB, denominatorAB);
            }
        }
        else if (denominatorA == denominatorB)
        {
            decimal denominatorAB = denominatorA;
            decimal nominatorAB = nominatorA + nominatorB;
            if (nominatorAB > denominatorAB)
            {
                wholePies = (int)(nominatorAB / denominatorAB);
                Console.WriteLine(wholePies);
                Console.WriteLine("{0}" + '/' + "{1}", nominatorAB, denominatorAB);
            }
            else if (nominatorAB < denominatorAB)
            {
                decimal pies =nominatorAB / denominatorAB;
                Console.WriteLine("{0:F20}", pies);
                Console.WriteLine("{0}" + '/' + "{1}", nominatorAB, denominatorAB);
            }
            else if (nominatorAB == denominatorAB)
            {
                Console.WriteLine("1");
                Console.WriteLine("{0}" + '/' + "{1}", nominatorAB, denominatorAB);
            }
        }
    }
}

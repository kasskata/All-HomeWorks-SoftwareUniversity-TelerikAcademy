using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThreeDPoint;

namespace _01._3DPointStruct
{
    class Program
    {
        static void Main()
        {
            Struct3DPoint point = new Struct3DPoint(2, 1, 5);
            float distance = CalcDistance.Calculate(Struct3DPoint.Basse,point);
            Console.WriteLine(distance);
            List<PathStorage> path = new List<PathStorage>();
            PathStorage firstpath = new PathStorage();
            for (int i = 0; i < 10; i++)
            {
                firstpath.AddPoint(i+0.25f);
            }
        }
    }
}

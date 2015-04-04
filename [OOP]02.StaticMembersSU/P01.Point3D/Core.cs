using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P01.Point3D
{
    public class Core
    {
        static void Main(string[] args)
        {
            Point3D first = new Point3D(-7, -4, 3);
            Console.WriteLine(first);
            Point3D statics = new Point3D(17, 6, 2.5);
            Console.WriteLine("{0:0.000}", DistanceCalculator.DistanceBetween(first, statics));
            Console.WriteLine(first);
            Path a = new Path();
            a.AddPoint(first);
            a.AddPoint(statics);
            Console.WriteLine(a);
            Storage.Save(a);
            Path newPath = Storage.Load(a);
            Console.WriteLine(newPath);
        }
    }
}

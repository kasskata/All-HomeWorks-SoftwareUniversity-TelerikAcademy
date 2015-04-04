namespace P01.Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public static class DistanceCalculator
    {
        public static double DistanceBetween(Point3D a, Point3D b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
        }
    }
    public static class Storage
    {

        internal static void Save(Path a)
        {
            File.WriteAllText("PathOut.txt", a.ToString());
            Console.WriteLine("READED");
        }

        internal static Path Load(Path a)
        {
            string input = File.ReadAllText("PathOut.txt").Trim('[', ']');
            string[] values = new string[3];
            values = input.Split(new char[] { ',', ' ', '\r', '\n', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            Path inputAsPath = new Path();
            Regex splits = new Regex(", ");
            for (int i = 0; i < values.Length; i += 3)
            {
                Point3D temp = new Point3D(double.Parse(values[i]), double.Parse(values[i + 1]), double.Parse(values[i + 2]));
                inputAsPath.AddPoint(temp);
            }

            Console.WriteLine("LOADED");
            return inputAsPath;
        }
    }
}

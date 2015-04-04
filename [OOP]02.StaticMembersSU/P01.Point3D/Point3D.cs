namespace P01.Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartingPoint { get { return Point3D.startingPoint; } }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z));
            return output.ToString();
        }
    }
}

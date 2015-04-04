using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Point3D
{
    public class Path
    {
        private List<Point3D> sequence = new List<Point3D>();

        public void AddPoint(Point3D a)
        {
            this.sequence.Add(a);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            foreach (var i in this.sequence)
            {
                output.AppendLine(i.ToString());
            }
            return output.ToString();
        }
    }
}

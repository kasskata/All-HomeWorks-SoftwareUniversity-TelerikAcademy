namespace _01._3DPointStruct
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ThreeDPoint;

    public class CalcDistance
    {
        public static float Calculate(Struct3DPoint zero , Struct3DPoint point)
        {
            return (float)Math.Sqrt(((zero.X - point.X) * (zero.X - point.X)) + ((zero.Y - point.Y) * (zero.Y - point.Y)) + ((zero.Z - point.Z) * (zero.Z - point.Z)));
        }
    }
}

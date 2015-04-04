using System;

namespace CalcDistance
{
    public class CalculateDistance : ICalcultor
    {
        public float CalcDistance(Point first, Point second)
        {
            float deltaX = first.X - second.X;
            float deltaY = first.Y - second.Y;
            return (float)Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
        }
    }
}

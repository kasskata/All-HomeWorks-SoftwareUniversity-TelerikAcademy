namespace _01Shapes
{
    using System;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double CalculateArea()
        {
            return Math.PI * (this.radius * this.radius);
        }

        public double CalculatePerimeter()
        {
            return 2 * (Math.PI * radius);
        }
    }
}

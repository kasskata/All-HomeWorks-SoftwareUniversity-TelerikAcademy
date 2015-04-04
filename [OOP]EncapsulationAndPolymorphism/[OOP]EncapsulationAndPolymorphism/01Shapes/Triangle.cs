namespace _01Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        private double width;
        private double height;

        public Triangle(double width, double height)
            : base(width, height)
        {
            this.width = width;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return 1 / 2 * width * height;
        }
        public override double CalculatePerimeter()
        {
            return (width * Width + height * height);
        }
        public double CalculateIsoscelesPerimeter(double b, double c)
        {
            return this.width + b + c;
        }
    }
}

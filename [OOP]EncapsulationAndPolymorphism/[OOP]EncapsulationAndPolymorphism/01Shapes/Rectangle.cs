namespace _01Shapes
{
    using System;

    public class Rectangle : BasicShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateArea()
        {
            return width * height;
        
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.width + this.height);

        }
    }
}

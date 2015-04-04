
namespace _01Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}

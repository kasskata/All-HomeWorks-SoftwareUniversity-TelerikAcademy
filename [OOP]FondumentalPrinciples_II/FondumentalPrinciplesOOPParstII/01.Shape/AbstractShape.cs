namespace Shape
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Shape
    {
        public double Width { get; private set; }

        public double Height { get; private set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public abstract double CalculateSurface();
        public override string ToString()
        {
            return base.ToString().PadRight(20,'_') + " " + this.Height +" x "+ this.Width + " = " + this.CalculateSurface();
        }
    }
}
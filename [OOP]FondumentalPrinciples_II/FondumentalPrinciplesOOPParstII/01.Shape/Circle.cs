namespace Shape
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Circle : Shape
    {
        private const double piNumber = Math.PI;

        public Circle(double width)
        :base(width,width)
        {
        }
        public override double CalculateSurface()
        {
            return piNumber * this.Width * this.Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle stupidTriangleAgain = new Triangle(23.12, 23.32);
            Circle stupidCircleAgain = new Circle(123.7634);
            Rectangle stupidRectangleAgain = new Rectangle(23.12, 23.32);

            stupidCircleAgain.CalculateArea();
            stupidCircleAgain.CalculatePerimeter();

            stupidRectangleAgain.CalculateArea();
            stupidRectangleAgain.CalculatePerimeter();

            stupidTriangleAgain.CalculateArea();
            stupidTriangleAgain.CalculatePerimeter();
            stupidTriangleAgain.CalculateIsoscelesPerimeter(321.32,23.5);
        }
    }
}

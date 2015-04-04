namespace Shape
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class ShapeTest
    {
        static void Main()
        {
            Rectangle rect2 = new Rectangle(21.5,10.3);
            Triangle tri2 = new Triangle(12.3, 15.4);
            Circle circ2 = new Circle(4.16);
            Rectangle rect1 = new Rectangle(10.4,5.3);
            Triangle tri1 = new Triangle(7.6,4.6);
            Circle  circ1 = new Circle(1.5);

            List<Shape> shapes = new List<Shape>();

            shapes.Add(rect2);
            shapes.Add(tri2);
            shapes.Add(circ2);
            shapes.Add(rect1);
            shapes.Add(tri1);
            shapes.Add(circ1);

            var orderedByAreas = shapes.OrderBy(s => s.CalculateSurface());

            Print(orderedByAreas);
        }
        static void Print(IEnumerable<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}

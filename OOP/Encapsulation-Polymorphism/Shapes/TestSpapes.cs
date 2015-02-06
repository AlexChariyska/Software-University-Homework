namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestSpapes
    {
        static void Main()
        {
            IShape rect = new Rectangle(5.5, 20);
            IShape triangle = new Triangle(5, 34, 30);
            IShape circle = new Circle(4);

            IList<IShape> shapes = new List<IShape>();
            shapes.Add(rect);
            shapes.Add(triangle);
            shapes.Add(circle);

            foreach (var item in shapes)
            {
                Console.WriteLine("Type: "+ item.GetType());
                Console.WriteLine("Area: "+ item.CalculateArea());
                Console.WriteLine("Perimeter: " + item.CalculatePerimeter());
                Console.WriteLine();
            }

        }
    }
}

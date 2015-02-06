using System;

//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 

namespace Problem7_PointInCircle
{
    class CirclePoint
    {
        static void Main()
        {
            Console.WriteLine("Insert x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert y:");
            double y = double.Parse(Console.ReadLine());
            int radius = 2;
            bool result = (((x * x) + (y * y)) <= (radius * radius));
            Console.WriteLine("The point is from the circle: " + result);
        }
    }
}

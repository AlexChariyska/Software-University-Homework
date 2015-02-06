using System;
using System.Linq;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2)

namespace Problem10_PointsFromCircleAndRectangle
{
    class PointsFromCircleAndRectangle
    {
        static void Main()
        {
            Console.WriteLine("Insert x:");
            double inputX = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert y:");
            double inputY = double.Parse(Console.ReadLine());
            double radius = 1.5;
            int circleX= 1;
            int circleY = 1;
            double pointX;
            double pointY;
            if (inputX > 0)
            {
                pointX = inputX - circleX;
            }
            else
            {
                pointX = inputX + circleX;
            }
            if (inputY > 0)
            {
                pointY = inputY - circleY;
            }
            else
            {
                pointY = inputY + circleY;
            }
            bool isInCircle = (pointX * pointX) + (pointY * pointY) <= radius * radius;
            bool outOfRactangle = inputY > 1;
            if (inputX == 0 || inputY == 0)
            {
                Console.WriteLine("No");
            }
            else if (isInCircle == true && outOfRactangle == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

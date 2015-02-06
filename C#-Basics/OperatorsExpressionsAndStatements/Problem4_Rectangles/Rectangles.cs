using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace Problem4_Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Insert width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert height:");
            double height = double.Parse(Console.ReadLine());
            double rectanglePerimeter = (width + height)*2;
            double rectangleArea = width * height;
            Console.WriteLine("The rectangles perimeter is: {0}.\nThe rectangles area is: {1}",
                rectanglePerimeter, rectangleArea);
        }
    }
}

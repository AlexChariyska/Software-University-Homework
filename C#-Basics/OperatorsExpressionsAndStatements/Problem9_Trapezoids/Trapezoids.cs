using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h

namespace Problem9_Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Insert side a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert side b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert height h:");
            double height = double.Parse(Console.ReadLine());
            double trapezoidArea = (a+b)*height*0.5;
            Console.WriteLine("The trapezoid's area is: {0}", trapezoidArea);
        }
    }
}

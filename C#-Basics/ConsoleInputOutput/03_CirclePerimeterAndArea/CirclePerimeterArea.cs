using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("Insert radius:");
        double radius = double.Parse(Console.ReadLine());
        double perimeterCircle = 2 * Math.PI * radius;
        double areaCircle = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Circle perimeter: {0:0.00}. Circle area: {1:0.00}",
            perimeterCircle, areaCircle);
    }
}


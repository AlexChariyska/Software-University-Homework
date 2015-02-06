using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointInput
{
    static void Main(string[] args)
    {
        Point3D p1 = new Point3D(0, 1, 2);
        Point3D p2 = new Point3D(1.1, 1, 2);
        Point3D p3 = new Point3D(4, 1, 2);
        Console.WriteLine("Starting point {0}", Point3D.StartingPoint.ToString());
        Console.Write("First point: ");
        Console.WriteLine(p1.ToString());
        Console.WriteLine("Distance between p1 and p2: {0}",DistanceCalculator.DistanceCalculator3D(p1, p2));
    }
}


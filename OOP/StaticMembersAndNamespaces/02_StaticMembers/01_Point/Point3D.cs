using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point3D
{
    private double x;
    private double y;
    private double z;
    private static readonly Point3D startingPoint;

    static Point3D()
    {
        startingPoint = new Point3D(0, 0, 0);
    }
    public static Point3D StartingPoint
    {
        get { return Point3D.startingPoint; }
    }
    public double Z
    {
        get { return this.z; }
        set { this.z = value; }
    }

    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public double X
    {
        get { return this.x; }
        set { this.x = value; }
    }
    //Constructor
    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public override string ToString()
    {
        return String.Format("{{ {0:F},{1:F},{2:F} }}", this.X.ToString(), this.Y.ToString(), this.Z.ToString());
    }
}


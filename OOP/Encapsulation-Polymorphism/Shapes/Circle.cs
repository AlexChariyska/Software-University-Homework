using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be positive number");
                }
                this.radius = value;
            }
        }
        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return 2 * this.Radius * Math.PI;
        }
    }
}
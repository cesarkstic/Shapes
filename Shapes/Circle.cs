using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle(string name, string color, double radius) : base(name, color)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            Radius = radius;
        }

        public override double Area() => (double)(Math.PI * Math.Pow((double)Radius, 2));

        public override double Perimeter() => (double)Math.PI * Radius * 2;

    }
}

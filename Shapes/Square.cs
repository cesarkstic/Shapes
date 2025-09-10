using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shapes
    {
        public double SideLength { get; set; }
        public Square(string name, string color, double sideLength) : base(name, color)
        {
            if (sideLength < 0)
                throw new ArgumentOutOfRangeException(nameof(sideLength));

            SideLength = sideLength;
        }
        public override double Area() => SideLength * SideLength;

        public override double Perimeter() => SideLength * 4;

    }
}

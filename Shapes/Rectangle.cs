using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(string name, string color, double length, double width) : base(name, color)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length));

            if (width < 0)
                throw new ArgumentOutOfRangeException(nameof(width));

            Length = length;
            Width = width;
        }
        public override double Area() => Length * Width;

        public override double Perimeter() => (Length + Width) * 2;

    }
}

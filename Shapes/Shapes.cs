using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shapes : IShapes
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Shapes(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public string Draw() => $"Drawing {Color} {Name}. Total area: {Area()}, perimeter {Perimeter()}";

    }
}

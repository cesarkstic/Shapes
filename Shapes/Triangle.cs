using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shapes
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }


        public Triangle(string name, string color, double sideA, double sideB, double sideC) : base(name, color)
        {
            if (sideA < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sideA));
            }

            if (sideB < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sideB));
            }

            if (sideC < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sideC));
            }

            if ((sideA + sideB <= sideC) ||
                (sideA + sideC <= sideB) ||
                (sideB + sideC <= sideA))
            {
                throw new ArgumentOutOfRangeException(nameof(sideA));
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double Perimeter() => SideA + SideB + SideC;
    }
}

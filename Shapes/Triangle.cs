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

            double[] s = new[] { sideA, sideB, sideC };
            Array.Sort(s);

            if ((s[0] + s[1]) <= s[2])
            {
                throw new ArgumentOutOfRangeException(nameof(s));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        private const double Eps = 1e-6;

        [Theory]
        [InlineData(3, 4, 5, 6, 12)]
        [InlineData(4, 7, 10, 10.928746497197197, 21)]
        public void Triangle_Computes_Area_And_Perimeter(double a, double b, double c, double expectedArea, double expectedPerimeter)
        {
            var t = new Triangle("", "", a, b, c);
            Assert.InRange(Math.Abs(t.Area() - expectedArea), 0, Eps);
            Assert.InRange(Math.Abs(t.Perimeter() - expectedPerimeter), 0, Eps);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 3)]
        public void Triangle_Throws_On_Degenerate(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle("", "", a, b, c));
        }
    }
}

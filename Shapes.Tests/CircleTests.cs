// CircleTests.cs
using System;
using Xunit;
using Shapes;

namespace Shapes
{
    public class CircleTests
    {
        private const double Eps = 1e-6;

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, Math.PI, 2 * Math.PI)]
        [InlineData(2.5, Math.PI * 2.5 * 2.5, 2 * Math.PI * 2.5)]
        public void Circle_Computes_Area_And_Perimeter(double r, double expectedArea, double expectedPerimeter)
        {
            var c = new Circle ("", "", r);
            Assert.InRange(Math.Abs(c.Area() - expectedArea), 0, Eps);
            Assert.InRange(Math.Abs(c.Perimeter() - expectedPerimeter), 0, Eps);
        }

        [Theory]
        [InlineData(-0.01)]
        [InlineData(-3)]
        public void Circle_Throws_On_Negative_Radius(double r)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle("", "", r));
        }
    }
}

// CircleTests.cs
using System;
using Xunit;
using Shapes;

namespace Shapes
{
    public class SquareTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 4, 8)]
        [InlineData(7, 49, 28)]

           public void Square_Computes_Area_And_Perimeter(double sl, double expectedArea, double expectedPerimeter)
        {
            var s = new Square ("", "", sl);
            Assert.Equal(expectedArea, s.Area());
            Assert.Equal(expectedPerimeter, s.Perimeter());
        }

        [Theory]
        [InlineData(-0.01)]
        [InlineData(-3)]
        public void Square_Throws_On_Negative_Radius(double r)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Square("", "", r));
        }
    }
}

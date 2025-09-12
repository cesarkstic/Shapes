// CircleTests.cs
using System;
using Xunit;
using Shapes;

namespace Shapes.Tests
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(2, 4, 8, 12)]
        [InlineData(7, 49, 343, 112)]

        public void Rectangle_Computes_Area_And_Perimeter(double l, double w, double expectedArea, double expectedPerimeter)
        {
            var r = new Rectangle ("", "", l, w);
            Assert.Equal(expectedArea, r.Area());
            Assert.Equal(expectedPerimeter,r.Perimeter());
        }

        [Theory]
        [InlineData(-0.01)]
        [InlineData(-3)]
        public void Rectangle_Throws_On_Negative_Side(double s)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle("", "", s, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle("", "", 1, s));

        }
    }
}

using System;
using Xunit;

namespace Square.Calc
{
    public class CircleTests
    {
        [Fact]
        public void Check_Circle_Square()
        {
            var radius = 5;
            var c = new Circle(radius);

            Assert.Equal(Math.Pow(radius, 2) * Math.PI, c.CalcSquare());
        }
        
        [Fact]
        public void Wrong_Radius_Should_Fail()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var c = new Circle(-1);                
            });
        }
    }
}
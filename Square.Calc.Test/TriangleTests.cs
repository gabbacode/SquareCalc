using System;
using Xunit;

namespace Square.Calc
{
    public class TriangleTests
    {
        [Fact]
        public void Check_PreCalculated_Square_01()
        {
            var t = new Triangle(3, 4,5);
            
            Assert.Equal(6, t.CalcSquare());
        }

        [Fact]
        public void Check_PreCalculated_Square_02()
        {
            var t = new Triangle(5, 5,5);
            
            Assert.Equal(10.82531754730548, t.CalcSquare(), 6);
        }

        [Fact]
        public void Check_PreCalculated_Square_03()
        {
            var t = new Triangle(5, 8,11);
            
            Assert.Equal(18.33030277982336, t.CalcSquare(), 6);
        }

        [Fact]
        public void Check_PreCalculated_HaveRightAngle()
        {
            var t1 = new Triangle(3, 4,5);
            Assert.True(t1.HaveRightAngle());

            var t2 = new Triangle(4, 3,5);
            Assert.True(t2.HaveRightAngle());
            
            var t3 = new Triangle(5, 4,3);
            Assert.True(t3.HaveRightAngle());            
        }
        
        [Fact]
        public void Wrong_Side_Length_Should_Fail()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var t = new Triangle(10, 2, 3);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var t = new Triangle(1, 20, 3);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var t = new Triangle(1, 2, 30);
            });
        }
        
        [Fact]
        public void Negative_Side_Length_Should_Fail()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var t = new Triangle(-1, 2, 3);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var t = new Triangle(1, -2, 3);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var t = new Triangle(1, 2, -3);
            });
        }
        
    }
}
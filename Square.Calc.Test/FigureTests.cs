using System.Collections.Generic;
using Xunit;

namespace Square.Calc
{
    public class FigureTests
    {
        [Fact]
        public void Abstract_Calculation_Tests()
        {
            var f1 = new Circle(5);
            var f2 = new Triangle(3,4,5);

            var figures = new Dictionary<IFigure, double>
            {
                { f1, 78.5398 }, 
                { f2, 6.0 }
            };


            foreach (var f in figures)
            {
                var s = f.Key.CalcSquare();
                Assert.Equal(f.Value, s, 4);
            }
        }
    }
}
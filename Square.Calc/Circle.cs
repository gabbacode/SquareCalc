using System;

namespace Square.Calc
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException( "radius of circle must be positive value");
            
            Radius = radius;
        }
        
        public double CalcSquare()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
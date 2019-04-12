using System;

namespace Square.Calc
{
    public class Triangle : IFigure
    {
        public double A { get; }

        public double B { get; }

        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException( $"side {nameof(a)} of triangle must be positive value");
            if (b <= 0)
                throw new ArgumentException( $"side {nameof(b)} of triangle must be positive value");
            if (c <= 0)
                throw new ArgumentException( $"side {nameof(c)} of triangle must be positive value");

            if (a >= b + c)
                throw new ArgumentException( $"not triangle! side {nameof(a)} must be less of sum of other");
            if (b >= a + c)
                throw new ArgumentException( $"not triangle! side {nameof(b)} must be less of sum of other");
            if (c >= a + b)
                throw new ArgumentException( $"not triangle! side {nameof(c)} must be less of sum of other");
            
            A = a;
            B = b;
            C = c;
        }
        
        public double CalcSquare()
        {
            // half-perimeter
            var hp = (A + B + C) / 2.0;

            var square = Math.Sqrt(hp * (hp - A) * (hp - B) * (hp - C));

            return square;
        }

        public bool HaveRightAngle()
        {
            var sideSquaresSum = Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2);

            var hypotenuse = Math.Max(A, Math.Max(B, C));

            if (sideSquaresSum - 2 * Math.Pow(hypotenuse, 2) < double.Epsilon)
            {
                return true;
            }
            
            return false;
        }
        
    }
}
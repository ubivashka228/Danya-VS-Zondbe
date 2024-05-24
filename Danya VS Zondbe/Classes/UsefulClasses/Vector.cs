using System;

namespace Danya_VS_Zondbe
{
    public class Vector
    {
        public readonly double X;
        public readonly double Y;

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Length => Math.Sqrt(X * X + Y * Y);

        public double Angle => Math.Atan2(Y, X);
        
        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y);

        public Vector Rotate(double angle) => new Vector
            (X * Math.Cos(angle) - Y * Math.Sin(angle), 
             X * Math.Sin(angle) + Y * Math.Cos(angle));
}
}


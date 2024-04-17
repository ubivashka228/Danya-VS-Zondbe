namespace Danya_VS_Zondbe;

public record Vector(double X, double Y)
{
    public static readonly Vector Zero = new(0, 0);

    public double Length => Math.Sqrt(X * X + Y * Y);

    public double Angle => Math.Atan2(Y, X);

    public override string ToString() => $"X: {X}, Y: {Y}";

    public static Vector operator -(Vector a, Vector b) => new(a.X - b.X, a.Y - b.Y);

    public static Vector operator *(Vector a, double k) => new(a.X * k, a.Y * k);

    public static Vector operator /(Vector a, double k) => new(a.X / k, a.Y / k);

    public static Vector operator *(double k, Vector a) => a * k;

    public static Vector operator +(Vector a, Vector b) => new(a.X + b.X, a.Y + b.Y);

    public Vector Normalize() => Length > 0 ? this * (1 / Length) : this;

    public Vector Rotate(double angle) =>
        new(X * Math.Cos(angle) - Y * Math.Sin(angle), X * Math.Sin(angle) + Y * Math.Cos(angle));
}
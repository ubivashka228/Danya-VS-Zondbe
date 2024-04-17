namespace Danya_VS_Zondbe
{
    public readonly struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get;}
        public int Y { get; }

        public static bool operator ==(Point point, Point other) => point.X == other.X && point.Y == other.Y;
        public static bool operator !=(Point point, Point other) => point.X != other.X || point.Y != other.Y;
        public static Point operator +(Point point, Point other) => new Point(point.X + other.X, point.Y + other.Y);
        public static Point operator -(Point point, Point other) => new Point(point.X - other.X, point.Y - other.Y);
    }
}


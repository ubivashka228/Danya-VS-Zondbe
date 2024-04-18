using System.Drawing;

namespace Danya_VS_Zondbe
{
    public class Bullet
    {
        public readonly int Movement;
        public readonly int Damage;
        public readonly int Penetration;
        public readonly int Width;
        public readonly int Range;
        public readonly Vector Direction;
        public readonly Point Position;
        public readonly Color Coloration;

        public Bullet(int movement, int damage, int bulletPenetration, int width, int range, Vector direction, Point position, Color coloration)
        {
            Movement = movement;
            Damage = damage;
            Penetration = bulletPenetration;
            Width = width;
            Range = range;
            Direction = direction;
            Position = position;
            Coloration = coloration;
        }
    }
}


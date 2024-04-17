using System.Drawing;

namespace Danya_VS_Zondbe
{
    public class Bullet
    {
        public readonly int Movement;
        public readonly int Damage;
        public readonly Vector Direction;
        public readonly Point Position;
        public readonly Color Coloration;

        public Bullet(int movement, int damage, Vector direction, Point position, Color coloration)
        {
            Movement = movement;
            Damage = damage;
            Direction = direction;
            Position = position;
            Coloration = coloration;
        }
    }
}


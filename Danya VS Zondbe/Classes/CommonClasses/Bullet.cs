using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Bullet
    {
        public Bitmap Image;
        public readonly int Movement;
        public readonly int Damage;
        public readonly int Penetration;
        public readonly int Width;
        public readonly int Range;
        public readonly Vector Direction;
        public readonly Point Position;
        public readonly PictureBox Picture = new PictureBox();

        public Bullet(Bitmap image, int movement, int damage, int bulletPenetration,
                      int width, int range, Vector direction, Point position)
        {
            Movement = movement;
            Damage = damage;
            Penetration = bulletPenetration;
            Width = width;
            Range = range;
            Direction = direction;
            Position = position;
        }
    }
}


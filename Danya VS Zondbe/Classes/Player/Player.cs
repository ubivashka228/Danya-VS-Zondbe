using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Player
    {
        public Bitmap Image;
        public int Health;
        public int Speed;
        public Point Position;
        public Vector Direction;
        public Weapon PlayerWeapon;
        
        public WeaponCharasteristics WeaponInfo => PlayerWeapon.CreateWeapon();
        public Bullet Shot => PlayerWeapon.Shot();

        public Player(Bitmap image, int health, int speed, Point position, Vector direction, Weapon weapon)
        {
            Image = image;
            Health = health;
            Speed = speed;
            Position = position;
            Direction = direction;
            PlayerWeapon = weapon;
        }

        public void Move(int mapWidth, int mapHeight)
        {
            var shift = new Vector(Speed, 0).Rotate(Direction.Angle);
            var newPosition = new Point((int)shift.X + Position.X, (int)shift.Y + Position.Y);
            if (newPosition.X > 0 && newPosition.X < mapWidth && newPosition.Y > 0 && newPosition.Y < mapHeight)
                Position = newPosition;
        }
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Player
    {
        public readonly PictureBox Picture;
        public int Health;
        private readonly int _speed;
        public Point Position;
        public Vector MoveDirection = new Vector(0, 0);
        public Vector ShotDirection;
        public readonly Weapon PlayerWeapon;
        public readonly WeaponCharasteristics WeaponInfo;
        
        public Bullet Shot()
        {
            WeaponInfo.GunAmmo--;
            return PlayerWeapon.Shot();
        }
        

        public Player(PictureBox picture, int health, int speed, Point position, Weapon weapon)
        {
            Picture = picture;
            Health = health;
            _speed = speed;
            Position = position;
            PlayerWeapon = weapon;
            WeaponInfo = PlayerWeapon.CreateWeapon();
        }

        public void Move(int mapWidth, int mapHeight)
        {
            var shift = new Vector(_speed, 0).Rotate(MoveDirection.Angle);
            var newPosition = new Point((int)shift.X + Position.X, (int)shift.Y + Position.Y);
            if (newPosition.X > 0 && newPosition.X < mapWidth && newPosition.Y > 40 && newPosition.Y < mapHeight)
                Position = newPosition;
        }
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Player
    {
        public Bitmap Image;
        public int Health;
        private readonly int _speed;
        public Point Position;
        public Vector MoveDirection;
        private readonly Weapon _playerWeapon;
        
        public WeaponCharasteristics WeaponInfo => _playerWeapon.CreateWeapon();
        public Bullet Shot => _playerWeapon.Shot();

        public Player(Bitmap image, int health, int speed, Point position, Vector moveDirection, Weapon weapon)
        {
            Image = image;
            Health = health;
            _speed = speed;
            Position = position;
            MoveDirection = moveDirection;
            _playerWeapon = weapon;
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
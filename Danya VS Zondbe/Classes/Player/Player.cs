using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Player
    {
        public readonly PictureBox Picture;
        public int Health = 100;
        public int MaxHealth = 100;
        private const int Speed = 15;
        public Point Position;
        public Vector MoveDirection = new Vector(0, 0);
        public Vector ShotDirection;
        private Weapon _playerWeapon;
        public WeaponCharasteristics WeaponInfo;
        
        public Bullet Shoot()
        {
            WeaponInfo.GunAmmo--;
            return _playerWeapon.Shoot();
        }
        
        public Player(PictureBox picture, Point position, Weapon weapon)
        {
            Picture = picture;
            Position = position;
            _playerWeapon = weapon;
            WeaponInfo = _playerWeapon.CreateWeapon();
        }

        public void ChangeWeapon(Weapon newWeapon)
        {
            _playerWeapon = newWeapon;
            WeaponInfo = newWeapon.CreateWeapon();
        }
        
        public void Move(int mapWidth, int mapHeight)
        {
            var shift = new Vector(Speed, 0).Rotate(MoveDirection.Angle);
            var newPosition = new Point((int)shift.X + Position.X, (int)shift.Y + Position.Y);
            if (newPosition.X > 0 && newPosition.X < mapWidth && newPosition.Y > 40 && newPosition.Y < mapHeight)
                Position = newPosition;
        }
    }
}
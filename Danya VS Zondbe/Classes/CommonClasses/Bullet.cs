using System;
using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Bullet
    {
        public Bitmap Image;
        private readonly int _speed;
        public readonly int Damage;
        public readonly int Penetration;
        public readonly int Width;
        public readonly int Range;
        private readonly Vector _direction;
        private Point _position;
        private readonly PictureBox _picture = new PictureBox();
        public bool OnMap = false;

        public Bullet(Bitmap image, int speed, int damage, int bulletPenetration,
                      int width, int range, Vector direction, Point position)
        {
            Image = image;
            _speed = speed;
            Damage = damage;
            Penetration = bulletPenetration;
            Width = width;
            Range = range;
            _direction = direction;
            _position = position;
        }

        public void Move()
        {
            var shift = new Vector(_speed, 0).Rotate(_direction.Angle);
            var newPosition = new Point((int)Math.Round(shift.X + _position.X), (int)Math.Round(shift.Y + _position.Y));
            if (newPosition.X > 10 && newPosition.X < 1500 && newPosition.Y > 10 && newPosition.Y < 780)
            {
                _position = newPosition;
                _picture.Left = _position.X;
                _picture.Top = _position.Y;
            }
            else
            {
                _picture.Dispose();
            }
        }
        
        public void MakeBullet(Form form)
        {
            _picture.BackColor = Color.White;
            _picture.Size = new Size(5, 5);
            _picture.Tag = "bullet";
            _picture.Left = _position.X;
            _picture.Top = _position.Y;
            _picture.BringToFront();
            
            form.Controls.Add(_picture);
            
            Console.WriteLine("created");
        }
    }
}


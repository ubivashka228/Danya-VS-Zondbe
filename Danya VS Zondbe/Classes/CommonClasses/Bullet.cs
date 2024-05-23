using System;
using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Bullet
    {
        private readonly Color _color;
        private const int Speed = 40;
        public readonly int Damage;
        public int Penetration;
        private readonly int _width;
        private int _range;
        private readonly Vector _direction;
        private Point Position { get; set; }
        public readonly PictureBox Picture = new PictureBox();
        public bool OnMap = false;
        public bool Deleted;

        public Bullet(Color color, int damage, int bulletPenetration,
                      int width, int range, Vector direction, Point position)
        {
            _color = color;
            Damage = damage;
            Penetration = bulletPenetration;
            _width = width;
            _range = range;
            _direction = direction;
            Position = position;
        }

        public void Move()
        {
            var shift = new Vector(Speed, 0).Rotate(_direction.Angle);
            var newPosition = new Point((int)Math.Round(shift.X + Position.X), (int)Math.Round(shift.Y + Position.Y));
            if (newPosition.X > 10 && newPosition.X < 1500 && newPosition.Y > 10 && newPosition.Y < 780 && _range > 0)
            {
                Position = newPosition;
                Picture.Left = Position.X;
                Picture.Top = Position.Y;
                _range -= Speed;
            }
            else
            {
                Deleted = true;
                Remove();
            }
        }

        public void Remove()
        {
            Picture.Dispose();
            Deleted = true;
        }
        
        public void MakeBullet(Form form)
        {
            Picture.BackColor = _color;
            Picture.Size = new Size(_width, _width);
            Picture.Tag = "bullet";
            Picture.Left = Position.X;
            Picture.Top = Position.Y;
            Picture.BringToFront();
            
            form.Controls.Add(Picture);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public class Bullet
    {
        public Bitmap Image;
        public readonly int Speed;
        public readonly int Damage;
        public readonly int Penetration;
        public readonly int Width;
        public readonly int Range;
        public readonly Vector Direction;
        private Point _position;
        private PictureBox _picture = new PictureBox();
        private Timer _bulletTimer = new Timer();
        public bool OnMap = false;

        public Bullet(Bitmap image, int speed, int damage, int bulletPenetration,
                      int width, int range, Vector direction, Point position)
        {
            Image = image;
            Speed = speed;
            Damage = damage;
            Penetration = bulletPenetration;
            Width = width;
            Range = range;
            Direction = direction;
            _position = position;
        }

        private void Move(object sender, EventArgs e)
        {
            var shift = new Vector(Speed, 0).Rotate(Direction.Angle);
            var newPosition = new Point((int)Math.Round(shift.X + _position.X), (int)Math.Round(shift.Y + _position.Y));
            if (newPosition.X > 10 && newPosition.X < 1500 && newPosition.Y > 10 && newPosition.Y < 780)
            {
                _position = newPosition;
                _picture.Left = _position.X;
                _picture.Top = _position.Y;
            }
            else
            {
                _bulletTimer.Stop();
                _bulletTimer.Dispose();
                _picture.Dispose();
                _bulletTimer = null;
                _picture = null;

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

            _bulletTimer.Interval = 40;
            _bulletTimer.Tick += new EventHandler(Move);
            _bulletTimer.Start();
            Console.WriteLine("created");
        }
    }
}


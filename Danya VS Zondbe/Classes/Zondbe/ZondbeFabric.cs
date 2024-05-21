using System;
using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public abstract class ZondbeFabric
    {
        public abstract ZondbeCharasteristics CreateZondbe();
        public abstract WalkingStrategy CreateWalkingStrategy();
        public abstract ZondbeSkull CreateSkull();
    }

    public class StandardZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(10, 8, 1, 0, Properties.Resources.z1, 10000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new NotSkulls();
        }
    }

    public class MediumZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(25, 12, 3, 0, Properties.Resources.z2, 10000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new NotSkulls();
        }
    }

    public class HighZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(50, 12, 5, 1, Properties.Resources.z3, 10000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new NotSkulls();
        }
    }

    public class ToxicZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(50, 11, 2, 0, Properties.Resources.z4, 4000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new ShooterWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new ToxicShoot();
        }
    }

    public class FatZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(500, 10, 5, 2, Properties.Resources.z5, 10000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new NotSkulls();
        }
    }

    public class NecromantZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(500, 9, 10, 2, Properties.Resources.z6, 8000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new ShooterWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new NecromantRecruitment();
        }
    }

    public class LichZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(1000, 15, 15, 2, Properties.Resources.z7, 2000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new ShooterWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new MagicShoot();
        }
    }

    public class SprinterZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(2000, 20, 10, 3, Properties.Resources.z8, 10000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new NotSkulls();
        }
    }

    public class DarkKnightZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(10000, 13, 20, 50, Properties.Resources.z9, 10000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new NotSkulls();
        }
    }

    public class JerkZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(100000, 10, 50, 60, Properties.Resources.z10, 8000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            return new BossRecruitment();
        }
    }

    public class Zondbe
    {
        public readonly ZondbeCharasteristics Charasteristics;
        private readonly ZondbeSkull _skull;
        private readonly WalkingStrategy _walkingStrategy;
        private Point Position { get; set; }
        public readonly PictureBox Picture = new PictureBox();
        public bool OnMap = false;
        public int TimerTicksLastHit;
        public int TimerTicksLastCast;
        
        public void MakeZondbe(Form form)
        {
            Picture.Image = Charasteristics.ZondbeImage;
            Picture.Location = Position;
            Picture.Tag = "zondbe";
            Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture.BringToFront();
            
            form.Controls.Add(Picture);
        }

        public void Remove()
        {
            Picture.Dispose();
        }

        public void Cast(Form1 form)
        {
            _skull.Cast(Position, GameModel.PlayerModel.Position, form);
        }

        public void Move()
        {
            var newPosition = _walkingStrategy.Move(GameModel.PlayerModel.Position, Position, Charasteristics.Movement);
            
            var direction = new Point(GameModel.PlayerModel.Position.X - Position.X, 
                                      GameModel.PlayerModel.Position.Y - Position.Y);
            var img = new Bitmap(Charasteristics.ZondbeImage);
            if (Math.Abs(direction.X) > Math.Abs(direction.Y) && direction.X < 0)
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else if (Math.Abs(direction.X) < Math.Abs(direction.Y) && direction.Y < 0)
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            else if (Math.Abs(direction.X) > Math.Abs(direction.Y) && direction.X > 0)
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Picture.Image = img;
            
            Picture.Location = newPosition;
            Position = newPosition;
        }
        
        public Zondbe(ZondbeFabric zondbeFabric, Point position)
        {
            Charasteristics = zondbeFabric.CreateZondbe();
            _skull = zondbeFabric.CreateSkull();
            _walkingStrategy = zondbeFabric.CreateWalkingStrategy();
            Position = position;
        }
    }
}
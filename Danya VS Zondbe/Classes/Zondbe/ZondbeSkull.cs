using System.Drawing;

namespace Danya_VS_Zondbe
{
    public abstract class ZondbeSkull
    {
        public abstract void Cast(Point zondbePosition, Point playerPosition, Form1 form);
    }

    public class NotSkulls : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition, Form1 form)
        {
        }
    }
        
    public class ToxicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition, Form1 form)
        {
            var direction = new Vector(playerPosition.X - zondbePosition.X, playerPosition.Y - zondbePosition.Y);
            GameModel.ZondbeBulletList.Add(new Bullet(Color.Chartreuse, 4, 1, 5, 800, direction, zondbePosition));
        }
    }

    public class NecromantRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition, Form1 form)
        {
            GameModel.ZondbeList.Add(new Zondbe(new MediumZondbeFabric(), zondbePosition));
            GameModel.ZondbeList.Add(new Zondbe(new ToxicZondbeFabric(), zondbePosition));
        }
    }

    public class MagicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition, Form1 form)
        {
            var direction = new Vector(playerPosition.X - zondbePosition.X, playerPosition.Y - zondbePosition.Y);
            
            GameModel.ZondbeBulletList.Add(new Bullet(Color.Crimson, 25, 1, 7, 1000, direction, zondbePosition));
        }
    }

    public class BossRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition, Form1 form)
        {
            GameModel.ZondbeList.Add(new Zondbe(new DarkKnightZondbeFabric(), zondbePosition));
            GameModel.ZondbeList.Add(new Zondbe(new LichZondbeFabric(), zondbePosition));
            GameModel.ZondbeList.Add(new Zondbe(new SprinterZondbeFabric(), zondbePosition));
        }
    }
}
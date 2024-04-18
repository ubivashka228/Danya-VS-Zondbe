using System.Drawing;

namespace Danya_VS_Zondbe
{
    public abstract class ZondbeSkull
    {
        public abstract void Cast(Point zondbePosition, Point playerPosition);
    }

    public class ToxicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var direction = new Vector((playerPosition - zondbePosition).X, (playerPosition - zondbePosition).Y);
            var bullet = new Bullet(20, 10, 1, 5, 800, direction, zondbePosition, Color.Chartreuse);
        }
    }

    public class NecromantRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var recruits = new[]
            {
                new Zondbe(new MediumZondbeFabric(), zondbePosition),
                new Zondbe(new HighZondbeFabric(), zondbePosition),
                new Zondbe(new ToxicZondbeFabric(), zondbePosition)
            };
        }
    }

    public class MagicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var direction = new Vector((playerPosition - zondbePosition).X, (playerPosition - zondbePosition).Y);
            var bullet = new Bullet(30, 50, 1, 7, 1000, direction, zondbePosition, Color.Crimson);
        }
    }

    public class BossRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var recruits = new[]
            {
                new Zondbe(new DarkKnightZondbeFabric(), zondbePosition),
                new Zondbe(new DarkKnightZondbeFabric(), zondbePosition),
                new Zondbe(new LichZondbeFabric(), zondbePosition),
                new Zondbe(new SprinterZondbeFabric(), zondbePosition)
            };
        }
    }
}
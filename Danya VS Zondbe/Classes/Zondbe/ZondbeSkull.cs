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
            var bullet = new Bullet(20, 10, direction, zondbePosition, Color.Chartreuse);
        }
    }

    public class NecromantRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var recruits = new[]
            {
                new Zondbe(new MediumZondbeFabric()),
                new Zondbe(new HighZondbeFabric()),
                new Zondbe(new ToxicZondbeFabric())
            };
        }
    }

    public class MagicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var direction = new Vector((playerPosition - zondbePosition).X, (playerPosition - zondbePosition).Y);
            var bullet = new Bullet(30, 50, direction, zondbePosition, Color.Crimson);
        }
    }

    public class BossRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var recruits = new[]
            {
                new Zondbe(new DarkKnightZondbeFabric()),
                new Zondbe(new DarkKnightZondbeFabric()),
                new Zondbe(new LichZondbeFabric()),
                new Zondbe(new SprinterZondbeFabric())
            };
        }
    }
}
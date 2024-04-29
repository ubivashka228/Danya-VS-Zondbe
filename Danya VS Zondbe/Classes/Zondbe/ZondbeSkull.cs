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
            var direction = new Vector((playerPosition.X - zondbePosition.X), (playerPosition.Y - zondbePosition.Y));
            var bullet = new Bullet(Drawer.DrawBullet(Color.Chartreuse), 20, 10, 1, 5, 800, direction, zondbePosition);
        }
    }

    public class NecromantRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var recruits = new[]
            {
                new Zondbe(new MediumZondbeFabric(), zondbePosition, Properties.Resources.zup),
                new Zondbe(new HighZondbeFabric(), zondbePosition, Properties.Resources.zup),
                new Zondbe(new ToxicZondbeFabric(), zondbePosition, Properties.Resources.zup)
            };
        }
    }

    public class MagicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var direction = new Vector((playerPosition.X - zondbePosition.X), (playerPosition.Y - zondbePosition.Y));
            var bullet = new Bullet(Drawer.DrawBullet(Color.Crimson), 30, 50, 1, 7, 1000, direction, zondbePosition);
        }
    }

    public class BossRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var recruits = new[]
            {
                new Zondbe(new DarkKnightZondbeFabric(), zondbePosition, Properties.Resources.zup),
                new Zondbe(new DarkKnightZondbeFabric(), zondbePosition, Properties.Resources.zup),
                new Zondbe(new LichZondbeFabric(), zondbePosition, Properties.Resources.zup),
                new Zondbe(new SprinterZondbeFabric(), zondbePosition, Properties.Resources.zup)
            };
        }
    }
}
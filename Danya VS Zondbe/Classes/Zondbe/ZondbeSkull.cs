using System.Drawing;

namespace Danya_VS_Zondbe
{
    public abstract class ZondbeSkull
    {
        public abstract void Cast(Point zondbePosition, Point playerPosition);
    }

    public class NotSkulls : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
        }
    }
        
    public class ToxicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var direction = new Vector(playerPosition.X - zondbePosition.X, playerPosition.Y - zondbePosition.Y);
            GameModel.ZondbeBulletHashSet.Add(new Bullet(Color.Chartreuse, 4, 1, 10, 800, direction, zondbePosition));
        }
    }

    public class NecromantRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            GameModel.ZondbeList.Add(new Zondbe(new MediumZondbeFabric(), 
                new Point(zondbePosition.X, zondbePosition.Y + 70)));
            GameModel.ZondbeList.Add(new Zondbe(new ToxicZondbeFabric(), 
                new Point(zondbePosition.X, zondbePosition.Y - 70)));
        }
    }

    public class MagicShoot : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            var direction = new Vector(playerPosition.X - zondbePosition.X, playerPosition.Y - zondbePosition.Y);
            
            GameModel.ZondbeBulletHashSet.Add(new Bullet(Color.Crimson, 25, 1, 10, 1000, direction, zondbePosition));
        }
    }

    public class BossRecruitment : ZondbeSkull
    {
        public override void Cast(Point zondbePosition, Point playerPosition)
        {
            GameModel.ZondbeList.Add(new Zondbe(new DarkKnightZondbeFabric(), 
                new Point(zondbePosition.X, zondbePosition.Y + 150)));
            GameModel.ZondbeList.Add(new Zondbe(new LichZondbeFabric(), 
                new Point(zondbePosition.X, zondbePosition.Y - 150)));
            GameModel.ZondbeList.Add(new Zondbe(new SprinterZondbeFabric(), 
                new Point(zondbePosition.X + 150, zondbePosition.Y)));
        }
    }
}
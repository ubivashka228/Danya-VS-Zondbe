using System;

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
            return new ZondbeCharasteristics(1, 3, 1, 0, 1);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            throw new NotImplementedException();
        }
    }

    public class MediumZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(25, 5, 5, 0, 5);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            throw new NotImplementedException();
        }
    }

    public class HighZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(50, 5, 10, 1, 10);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            throw new NotImplementedException();
        }
    }

    public class ToxicZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(50, 4, 2, 0, 25);
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
            return new ZondbeCharasteristics(500, 3, 15, 2, 50);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            throw new NotImplementedException();
        }
    }

    public class NecromantZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(500, 5, 10, 2, 100);
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
            return new ZondbeCharasteristics(1000, 6, 20, 2, 250);
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
            return new ZondbeCharasteristics(2000, 20, 40, 3, 250);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            throw new NotImplementedException();
        }
    }

    public class DarkKnightZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(25000, 7, 100, 50, 1000);
        }

        public override WalkingStrategy CreateWalkingStrategy()
        {
            return new SimpleWalkingStrategy();
        }

        public override ZondbeSkull CreateSkull()
        {
            throw new NotImplementedException();
        }
    }

    public class JerkZondbeFabric : ZondbeFabric
    {
        public override ZondbeCharasteristics CreateZondbe()
        {
            return new ZondbeCharasteristics(250000, 10, 200, 60, 10);
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
        public Point Position;

        public void Cast()
        {
            _skull.Cast(Position, Player.Position);
        }

        public Point Move()
        {
            return _walkingStrategy.Move(Player.Position, Position, Charasteristics.Movement);
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
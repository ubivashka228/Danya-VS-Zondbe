using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Danya_VS_Zondbe
{
    public static class GameModel
    {
        public static int Score;
        public static Player PlayerModel;
        public static List<Zondbe> ZondbeList = new List<Zondbe>();
        public static HashSet<Bullet> PlayerBulletList = new HashSet<Bullet>();
        public static readonly HashSet<Bullet> ZondbeBulletList = new HashSet<Bullet>();

        public static void CreatePlayer(Form1 form)
        {
            PlayerModel = new Player(form.player,100, 15,
                new Point(750, 380), new LaserBurning());
        }
        
        private static Point GetRandomPoint()
        {
            var rand = new Random();
            return new Point(rand.Next(1, 1400), rand.Next(1, 850));
        }
        
        public static void CreateZondbe()
        {
            if (ZondbeList.Count > 10) return;
            var randomNumber = new Random().Next(1 + Score / 20, 4 + Score / 20);
            switch (randomNumber)
            {
                case 1:
                    ZondbeList.Add(new Zondbe(new StandardZondbeFabric(), GetRandomPoint()));
                    break;
                case 2:
                    ZondbeList.Add(new Zondbe(new MediumZondbeFabric(), GetRandomPoint()));
                    break;
                case 3:
                    ZondbeList.Add(new Zondbe(new HighZondbeFabric(), GetRandomPoint()));
                    break;
                case 4:
                    ZondbeList.Add(new Zondbe(new ToxicZondbeFabric(), GetRandomPoint()));
                    break;
                case 5:
                    ZondbeList.Add(new Zondbe(new FatZondbeFabric(), GetRandomPoint()));
                    break;
                case 6:
                    ZondbeList.Add(new Zondbe(new NecromantZondbeFabric(), GetRandomPoint()));
                    break;
                case 7:
                    ZondbeList.Add(new Zondbe(new LichZondbeFabric(), GetRandomPoint()));
                    break;
                case 8:
                    ZondbeList.Add(new Zondbe(new SprinterZondbeFabric(), GetRandomPoint()));
                    break;
                case 9:
                    ZondbeList.Add(new Zondbe(new DarkKnightZondbeFabric(), GetRandomPoint()));
                    break;
            }
        }
        
        public static void CheckBulletHitZondbe()
        {
            foreach (var bullet in PlayerBulletList)
            {
                foreach (var zondbe in ZondbeList.Where(zondbe => zondbe.Picture.Bounds.IntersectsWith(bullet.Picture.Bounds)))
                {
                    if (bullet.Damage > zondbe.Charasteristics.Armor)
                        zondbe.Charasteristics.Hp -= bullet.Damage - zondbe.Charasteristics.Armor;
                    bullet.Penetration -= 1;
                    if (bullet.Penetration < 1) bullet.Remove();
                    if (zondbe.Charasteristics.Hp >= 1) continue;
                    zondbe.Remove();
                    Score++;
                }
            }
            PlayerBulletList = PlayerBulletList.Where(bullet => !bullet.Deleted).ToHashSet();
            ZondbeList = ZondbeList.Where(zondbe => zondbe.Charasteristics.Hp > 0).ToList();
        }

        public static void CheckBulletHitPlayer()
        {
            foreach (var bullet in ZondbeBulletList.Where(bullet => PlayerModel.Picture.Bounds.IntersectsWith(bullet.Picture.Bounds)))
            {
                PlayerModel.Health -= bullet.Damage;
            }
        }
        
        public static void CheckZondbeHitPlayer(int timerTicks)
        {
            foreach (var zondbe in ZondbeList.Where(zondbe => timerTicks - zondbe.TimerTicksLastHit > 100 && 
                                                              zondbe.Picture.Bounds.IntersectsWith(PlayerModel.Picture.Bounds)))
            {
                PlayerModel.Health -= zondbe.Charasteristics.Damage;
                zondbe.TimerTicksLastHit = timerTicks;
            }
        }

        public static void CheckZondbeCanCast(int timerTicks, Form1 form)
        {
            for (var i = 0; i < ZondbeList.Count; ++i)
            {
                if ((timerTicks - ZondbeList[i].TimerTicksLastHit) * 10 >
                    ZondbeList[i].Charasteristics.SkullReloadTime)
                {
                    ZondbeList[i].Cast(form);
                    ZondbeList[i].TimerTicksLastHit = timerTicks;
                }
            }
        }
    }
}
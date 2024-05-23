using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Danya_VS_Zondbe
{
    public static class GameModel
    {
        public enum DifficultLevel
        {
            Easy,
            Medium,
            Hard
        }
        public static DifficultLevel LastDifficultLevel;
        
        public static int Score;
        public static int DifficultScoreStep = 5;
        public static Player PlayerModel;
        private static bool _bossOnMap;
        public static bool GameOver;
        public static List<Zondbe> ZondbeList = new List<Zondbe>();
        public static HashSet<Bullet> PlayerBulletList = new HashSet<Bullet>();
        public static HashSet<Bullet> ZondbeBulletList = new HashSet<Bullet>();

        public static void CreatePlayer(Game form)
        {
            PlayerModel = new Player(form.player, new Point(750, 380), new LaserBurning());
        }
        
        private static Point GetRandomPoint()
        {
            var rand = new Random();
            return new Point(rand.Next(1, 1400), rand.Next(1, 850));
        }
        
        public static void CreateZondbe()
        {
            if (ZondbeList.Count > 10 || _bossOnMap || GameOver) return;
            var randomNumber = new Random().Next(1 + Score / DifficultScoreStep - Score / (DifficultScoreStep * 3), 4 + Score / DifficultScoreStep);
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
                default:
                    ZondbeList.Add(new Zondbe(new LichZondbeFabric(), GetRandomPoint()));
                    break;
            }
        }
        
        public static void CheckPlayerBulletHitZondbe()
        {
            foreach (var bullet in PlayerBulletList)
            {
                foreach (var t in ZondbeList)
                {
                    if (!t.Picture.Bounds.IntersectsWith(bullet.Picture.Bounds)) continue;
                    if (bullet.Damage > t.Charasteristics.Armor)
                        t.Charasteristics.Hp -= bullet.Damage - t.Charasteristics.Armor;
                    bullet.Penetration -= 1;
                    if (bullet.Penetration < 1) bullet.Remove();
                    if (t.Charasteristics.Hp >= 1) continue;
                    t.Remove();
                    Score++;
                }
            }
            CheckScore();
            PlayerBulletList = PlayerBulletList.Where(bullet => !bullet.Deleted).ToHashSet();
            ZondbeList = ZondbeList.Where(zondbe => zondbe.Charasteristics.Hp > 0).ToList();
        }

        public static void CheckZondbeBulletHitPlayer()
        {
            foreach (var bullet in ZondbeBulletList.Where(bullet => PlayerModel.Picture.Bounds.IntersectsWith(bullet.Picture.Bounds)))
            {
                PlayerModel.Health -= bullet.Damage;
                bullet.Deleted = true;
                bullet.Remove();
            }

            ZondbeBulletList = ZondbeBulletList.Where(bullet => !bullet.Deleted).ToHashSet();
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

        public static void CheckZondbeCanCast(int timerTicks, Game form)
        {
            if (GameOver) return;
            for (var i = 0; i < ZondbeList.Count; ++i)
            {
                if ((timerTicks - ZondbeList[i].TimerTicksLastHit) * 10 <=
                    ZondbeList[i].Charasteristics.SkullReloadTime) continue;
                ZondbeList[i].Cast(form);
                ZondbeList[i].TimerTicksLastHit = timerTicks;
            }
        }

        private static void CheckScore()
        {
            if (GameOver) return;
            
            if (Score % DifficultScoreStep != 0) return;
            if (Score >= 5 * DifficultScoreStep)
            {
                PlayerModel.Health = 100 + (Score / DifficultScoreStep - 4) * 50;
                PlayerModel.MaxHealth = 100 + (Score / DifficultScoreStep - 4) * 50;
            }
            else
                PlayerModel.Health = 100;
            var weaponNumber = Score / DifficultScoreStep;
            switch (weaponNumber)
            {
                case 1:
                    PlayerModel.ChangeWeapon(new DesertEagle());
                    break;
                case 2:
                    PlayerModel.ChangeWeapon(new Mp5());
                    break;
                case 3:
                    PlayerModel.ChangeWeapon(new Ak47());
                    break;
                case 4:
                    PlayerModel.ChangeWeapon(new Ak12());
                    break;
                case 5:
                    PlayerModel.ChangeWeapon(new Remington());
                    break;
                case 6:
                    PlayerModel.ChangeWeapon(new Gau());
                    break;
                case 7:
                    PlayerModel.ChangeWeapon(new LaserMachine());
                    break;
                case 9:
                    PlayerModel.ChangeWeapon(new LaserBurning());
                    break;
            }

            if (Score >= 10 * DifficultScoreStep && !_bossOnMap)
            {
                _bossOnMap = true;
                foreach (var zondbe in ZondbeList)
                {
                    zondbe.Remove();
                }
                ZondbeList = new List<Zondbe> { new Zondbe(new JerkZondbeFabric(), new Point(20, 20)) };
            }
        }
    }
}
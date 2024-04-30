using System;
using System.Collections.Generic;
using System.Drawing;

namespace Danya_VS_Zondbe
{
    public static class GameModel
    {
        public static int Score;
        public static readonly Player PlayerModel = new Player(Properties.Resources.up,100, 15,new Point(450, 375), 
            new Vector(0, 0), new Beretta());
        public static List<Zondbe> ZondbeList = new List<Zondbe>();
        public static List<Bullet> BulletList = new List<Bullet>();

        public static Point GetRandomPoint()
        {
            var rand = new Random();
            return new Point(rand.Next(1, 1400), rand.Next(1, 850));
        }
        
        public static void CreateZondbe()
        {
            var randomNumber = new Random().Next(1 + GameModel.Score % 20, 3 + GameModel.Score % 20);
            switch (randomNumber)
            {
                case 1:
                    GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(), 
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 2:
                    GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(), 
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 3:
                    GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(), 
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 4:GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(),
                    GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 5:GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(),
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 6:GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(),
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 7:GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(),
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 8:GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(),
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 9:GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(),
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
                case 10:GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(),
                        GetRandomPoint(), Properties.Resources.zup));
                    break;
            }
        }
    }
}
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public static class GameModel
    {
        public static int Score;
        public static Player PlayerModel = new Player(Properties.Resources.up,100, 15,new Point(450, 375), 
            new Vector(0, 0), new Beretta());
        public static List<Zondbe> ZondbeList= new List<Zondbe>();
    }
}
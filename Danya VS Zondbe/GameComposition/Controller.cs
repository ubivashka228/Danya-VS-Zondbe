using System.Drawing;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public static class Controller
    {
        private static bool _wFlag, _sFlag, _dFlag, _aFlag;
        public static void KeyIsDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (!_wFlag)
                    {
                        GameModel.PlayerModel.Image = Properties.Resources.up;
                        GameModel.PlayerModel.MoveDirection += new Vector(0, -1);
                        _wFlag = true;
                    }
                    break;
                case Keys.S:
                    if (!_sFlag)
                    {
                        GameModel.PlayerModel.Image = Properties.Resources.down;
                        GameModel.PlayerModel.MoveDirection += new Vector(0, 1);
                        _sFlag = true;
                    }
                    break;
                case Keys.D:
                    if (!_dFlag)
                    {
                        GameModel.PlayerModel.Image = Properties.Resources.right;
                        GameModel.PlayerModel.MoveDirection += new Vector(1, 0);
                        _dFlag = true;
                    }
                    break;
                case Keys.A:
                    if (!_aFlag)
                    {
                        GameModel.PlayerModel.Image = Properties.Resources.left;
                        GameModel.PlayerModel.MoveDirection += new Vector(-1, 0);
                        _aFlag = true;
                    }
                    break;
            }
            GameModel.PlayerModel.Move(1000, 610);
        }
        
        public static void KeyIsUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (_wFlag)
                    {
                        GameModel.PlayerModel.MoveDirection += new Vector(0, 1);
                        _wFlag = false;
                    }
                    break;
                case Keys.S:
                    if (_sFlag)
                    {
                        GameModel.PlayerModel.MoveDirection += new Vector(0, -1);
                        _sFlag = false;
                    }
                    break;
                case Keys.D:
                    if (_dFlag)
                    {
                        GameModel.PlayerModel.MoveDirection += new Vector(-1, 0);
                        _dFlag = false;
                    }
                    break;
                case Keys.A:
                    if (_aFlag)
                    {
                        GameModel.PlayerModel.MoveDirection += new Vector(1, 0);
                        _aFlag = false;
                    }
                    break;
            }
        }

        public static void CreateZondbe(int zondbeNumber)
        {
            if (zondbeNumber == 1)
                GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(), 
                    new Point(10, 10), Properties.Resources.zup));
            if (zondbeNumber == 2)
                GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(), 
                    new Point(100, 10), Properties.Resources.zup));
            if (zondbeNumber == 3)
                GameModel.ZondbeList.Add(new Zondbe(new StandardZondbeFabric(), 
                    new Point(200, 10), Properties.Resources.zup));
        }
    }
}
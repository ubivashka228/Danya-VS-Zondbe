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
                        GameModel.PlayerModel.Direction += new Vector(0, -1);
                        _wFlag = true;
                    }
                    GameModel.PlayerModel.Move(1000, 600);
                    break;
                case Keys.S:
                    if (!_sFlag)
                    {
                        GameModel.PlayerModel.Image = Properties.Resources.down;
                        GameModel.PlayerModel.Direction += new Vector(0, 1);
                        _sFlag = true;
                    }
                    GameModel.PlayerModel.Move(1000, 600);
                    break;
                case Keys.D:
                    if (!_dFlag)
                    {
                        GameModel.PlayerModel.Image = Properties.Resources.right;
                        GameModel.PlayerModel.Direction += new Vector(1, 0);
                        _dFlag = true;
                    }
                    GameModel.PlayerModel.Move(1000, 600);
                    break;
                case Keys.A:
                    if (!_aFlag)
                    {
                        GameModel.PlayerModel.Image = Properties.Resources.left;
                        GameModel.PlayerModel.Direction += new Vector(-1, 0);
                        _aFlag = true;
                    }
                    GameModel.PlayerModel.Move(1000, 600);
                    break;
            }
        }
        
        public static void KeyIsUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (_wFlag)
                    {
                        GameModel.PlayerModel.Direction += new Vector(0, 1);
                        _wFlag = false;
                    }
                    break;
                case Keys.S:
                    if (_sFlag)
                    {
                        GameModel.PlayerModel.Direction += new Vector(0, -1);
                        _sFlag = false;
                    }
                    break;
                case Keys.D:
                    if (_dFlag)
                    {
                        GameModel.PlayerModel.Direction += new Vector(-1, 0);
                        _dFlag = false;
                    }
                    break;
                case Keys.A:
                    if (_aFlag)
                    {
                        GameModel.PlayerModel.Direction += new Vector(1, 0);
                        _aFlag = false;
                    }
                    break;
            }
        }
    }
}
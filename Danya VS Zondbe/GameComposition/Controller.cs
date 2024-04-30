using System;
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
            if (_aFlag || _dFlag || _sFlag || _wFlag)
                GameModel.PlayerModel.Move(1450, 720);
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
                case Keys.R:
                    if (!GameModel.PlayerModel.WeaponInfo.IsReloading)
                        GameModel.PlayerModel.PlayerWeapon.Reload();
                    break;
            }
        }

        public static void MouseIsMove()
        {
            GameModel.PlayerModel.ShotDirection = new Vector(Cursor.Position.X - GameModel.PlayerModel.Position.X,
                Cursor.Position.Y - GameModel.PlayerModel.Position.Y);
        }

        public static void MouseIsClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && GameModel.PlayerModel.WeaponInfo.GunAmmo != 0)
            {
                GameModel.BulletList.Add(GameModel.PlayerModel.Shot());
                Console.WriteLine(GameModel.PlayerModel.WeaponInfo.GunAmmo);
            }
        }
    }
}
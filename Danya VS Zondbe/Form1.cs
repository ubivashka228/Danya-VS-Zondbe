using System;
using System.Timers;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameModel.CreatePlayer(this);
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;
            this.MouseMove += MouseIsMove;
            this.MouseClick += MouseIsClick;
        }

        private int _timerTicks;
        private void MainTimerEvent(object sender, ElapsedEventArgs e)
        {
            _timerTicks++;
            if ((_timerTicks + 1) % 4 == 0) UpdatePlayerBullets();
            if (_timerTicks % 4 == 0) UpdateZondbeBullets();
            if (_timerTicks % 10 == 0) GameModel.CheckZondbeCanCast(_timerTicks, this);
            if (_timerTicks % 10 == 0) UpdateBars();
            if ((_timerTicks + 3) % 4 == 0) UpdateZondbes();
            if (_timerTicks % 200 == 0) GameModel.CreateZondbe();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            Controller.KeyIsDown(e);
            UpdatePlayer();
        }
        
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Controller.KeyIsUp(e);
            UpdatePlayer();
        }
        
        private void MouseIsMove(object sender, MouseEventArgs e)
        {
            Controller.MouseIsMove();
        }
        
        private void MouseIsClick(object sender, MouseEventArgs e)
        {
            Controller.MouseIsClick(e);
            UpdatePlayerBullets();
        }

        private void UpdatePlayer()
        {
            player.Image = GameModel.PlayerModel.Picture.Image;
            player.Location = GameModel.PlayerModel.Position;
        }

        private void UpdateBars()
        {
            if (GameModel.PlayerModel.Health > 0)
                healthBar.Value = GameModel.PlayerModel.Health;
            txtAmmo.Text = $@"Ammo {GameModel.PlayerModel.WeaponInfo.GunAmmo} / {GameModel.PlayerModel.WeaponInfo.AmmoCapacity}";
            txtKills.Text = @"Kills: " + GameModel.Score;
        }
        
        private void UpdatePlayerBullets()
        {
            foreach (var bullet in GameModel.PlayerBulletList)
            {
                if (!bullet.OnMap)
                {
                    bullet.MakeBullet(this);
                    bullet.OnMap = true;
                }

                bullet.Move();
            }
            GameModel.CheckBulletHitZondbe();
        }
        
        private void UpdateZondbeBullets()
        {
            foreach (var bullet in GameModel.ZondbeBulletList)
            {
                if (!bullet.OnMap)
                {
                    bullet.MakeBullet(this);
                    bullet.OnMap = true;
                }

                bullet.Move();
            }
            
            GameModel.CheckBulletHitPlayer();
        }
        
        private void UpdateZondbes()
        {
            foreach (var zondbe in GameModel.ZondbeList)
            {
                if (!zondbe.OnMap)
                {
                    zondbe.MakeZondbe(this);
                    zondbe.OnMap = true;
                }

                zondbe.Move();
            }
            GameModel.CheckZondbeHitPlayer(_timerTicks);
            Console.WriteLine(GameModel.PlayerModel.Health);
        }
    }
}
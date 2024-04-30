using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;
            this.MouseMove += MouseIsMove;
            this.MouseClick += MouseIsClick;
        }

        private int _timerTicks;
        private void MainTimerEvent(object sender, ElapsedEventArgs e)
        {
            _timerTicks++;
            UpdateBullets();
            UpdateBars();
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
            UpdateBullets();
        }

        private void UpdatePlayer()
        {
            player.Image = GameModel.PlayerModel.Image;
            player.Location = GameModel.PlayerModel.Position;
        }

        private void UpdateBars()
        {
            if (GameModel.PlayerModel.Health > 0)
                healthBar.Value = GameModel.PlayerModel.Health;
            txtAmmo.Text = $@"Ammo {GameModel.PlayerModel.WeaponInfo.GunAmmo} / {GameModel.PlayerModel.WeaponInfo.AmmoCapacity}";
            txtKills.Text = @"Kills: " + GameModel.Score;
        }
        
        private void UpdateBullets()
        {
            foreach (var bullet in GameModel.BulletList)
            {
                if (!bullet.OnMap)
                {
                    bullet.MakeBullet(this);
                    bullet.OnMap = true;
                }

                bullet.Move();
            }
        }
    }
}
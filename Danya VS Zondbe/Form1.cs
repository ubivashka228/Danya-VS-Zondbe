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
            this.KeyDown += new KeyEventHandler(KeyIsDown);
            this.KeyUp += new KeyEventHandler(KeyIsUp);
        }
        
        private void MainTimerEvent(object sender, ElapsedEventArgs e)
        {
            var random = new Random();
            var zondbeNumber = random.Next(1, 3);
            if (GameModel.PlayerModel.Health > 0)
                healthBar.Value = GameModel.PlayerModel.Health;
            txtAmmo.Text = 
                           $@"Ammo {GameModel.PlayerModel.WeaponInfo.GunAmmo} / {GameModel.PlayerModel.WeaponInfo.AmmoCapacity}";
            txtKills.Text = @"Kills: " + GameModel.Score;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            Controller.KeyIsDown(e);
            UpdateMap();
        }
        
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Controller.KeyIsUp(e);
        }

        private void UpdateMap()
        {
            player.Image = GameModel.PlayerModel.Image;
            player.Location = GameModel.PlayerModel.Position;
        }
    }
}
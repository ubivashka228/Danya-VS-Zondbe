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
            var a = 0;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
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
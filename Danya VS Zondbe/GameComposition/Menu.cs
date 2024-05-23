using System;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var frm = new Game();
            frm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var frm = new Settings();
            frm.Show();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
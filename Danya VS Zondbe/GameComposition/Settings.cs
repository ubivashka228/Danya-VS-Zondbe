using System;
using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            SetDifficultLevel();
        }

        private void SetDifficultLevel()
        {
            switch (GameModel.LastDifficultLevel)
            {
                case GameModel.DifficultLevel.Easy:
                    easyField.Checked = true;
                    break;
                case GameModel.DifficultLevel.Medium:
                    mediumField.Checked = true;
                    break;
                case GameModel.DifficultLevel.Hard:
                    hardField.Checked = true;
                    break;
                default:
                    easyField.Checked = true;
                    break;
            }
        }
        
        private void toMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void easyField_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                GameModel.DifficultScoreStep = 5;
                GameModel.LastDifficultLevel = GameModel.DifficultLevel.Easy;
            }
        }

        private void mediumField_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                GameModel.DifficultScoreStep = 20;
                GameModel.LastDifficultLevel = GameModel.DifficultLevel.Medium;
            }
        }

        private void hardField_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                GameModel.DifficultScoreStep = 50;
                GameModel.LastDifficultLevel = GameModel.DifficultLevel.Hard;
            }
        }
    }
}
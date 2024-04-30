using System.Windows.Forms;

namespace Danya_VS_Zondbe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAmmo.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAmmo.Location = new System.Drawing.Point(12, 9);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(300, 29);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo:";
            // 
            // txtKills
            // 
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtKills.ForeColor = System.Drawing.SystemColors.Control;
            this.txtKills.Location = new System.Drawing.Point(980, 9);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(200, 29);
            this.txtKills.TabIndex = 1;
            this.txtKills.Text = "Kills:";
            // 
            // txtHealth
            // 
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtHealth.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHealth.Location = new System.Drawing.Point(1735, 9);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(112, 29);
            this.txtHealth.TabIndex = 2;
            this.txtHealth.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(1825, 12);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(216, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // player
            // 
            this.player.Image = global::Danya_VS_Zondbe.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(600, 450);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20D;
            this.GameTimer.SynchronizingObject = this;
            this.GameTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1902, 853);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtAmmo);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Danya VS Zondbe";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Timers.Timer GameTimer;

        public System.Windows.Forms.PictureBox player;

        private System.Windows.Forms.ProgressBar healthBar;

        private System.Windows.Forms.Label txtHealth;

        private System.Windows.Forms.Label txtKills;

        private Control txtAmmo;

        #endregion
    }
}
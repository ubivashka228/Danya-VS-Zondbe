using System.ComponentModel;

namespace Danya_VS_Zondbe
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.toMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.easyField = new System.Windows.Forms.RadioButton();
            this.mediumField = new System.Windows.Forms.RadioButton();
            this.hardField = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // toMenu
            // 
            this.toMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toMenu.Font = new System.Drawing.Font("Brush Script MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMenu.ForeColor = System.Drawing.Color.Red;
            this.toMenu.Location = new System.Drawing.Point(0, 650);
            this.toMenu.Name = "toMenu";
            this.toMenu.Size = new System.Drawing.Size(500, 87);
            this.toMenu.TabIndex = 1;
            this.toMenu.Text = "ГЛАВНОЕ МЕНЮ";
            this.toMenu.UseVisualStyleBackColor = false;
            this.toMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.Location = new System.Drawing.Point(0, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "СЛОЖНОСТЬ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // easyField
            // 
            this.easyField.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.easyField.Location = new System.Drawing.Point(0, 336);
            this.easyField.Name = "easyField";
            this.easyField.Size = new System.Drawing.Size(500, 70);
            this.easyField.TabIndex = 4;
            this.easyField.TabStop = true;
            this.easyField.Text = "ЛЁГКАЯ";
            this.easyField.UseVisualStyleBackColor = false;
            this.easyField.CheckedChanged += new System.EventHandler(this.easyField_CheckedChanged);
            // 
            // mediumField
            // 
            this.mediumField.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mediumField.Location = new System.Drawing.Point(0, 406);
            this.mediumField.Name = "mediumField";
            this.mediumField.Size = new System.Drawing.Size(500, 70);
            this.mediumField.TabIndex = 5;
            this.mediumField.TabStop = true;
            this.mediumField.Text = "СРЕДНЯЯ";
            this.mediumField.UseVisualStyleBackColor = false;
            this.mediumField.CheckedChanged += new System.EventHandler(this.mediumField_CheckedChanged);
            // 
            // hardField
            // 
            this.hardField.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.hardField.Location = new System.Drawing.Point(0, 476);
            this.hardField.Name = "hardField";
            this.hardField.Size = new System.Drawing.Size(500, 70);
            this.hardField.TabIndex = 6;
            this.hardField.TabStop = true;
            this.hardField.Text = "СЛОЖНАЯ";
            this.hardField.UseVisualStyleBackColor = false;
            this.hardField.CheckedChanged += new System.EventHandler(this.hardField_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.hardField);
            this.Controls.Add(this.mediumField);
            this.Controls.Add(this.easyField);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toMenu);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton hardField;

        private System.Windows.Forms.RadioButton easyField;
        private System.Windows.Forms.RadioButton mediumField;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button toMenu;

        #endregion
    }
}
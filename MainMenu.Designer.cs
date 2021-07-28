namespace Idle_Game
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txPick = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dev = new System.Windows.Forms.Label();
            this.clickerGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txPick
            // 
            this.txPick.AutoSize = true;
            this.txPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPick.Location = new System.Drawing.Point(70, 9);
            this.txPick.Name = "txPick";
            this.txPick.Size = new System.Drawing.Size(638, 126);
            this.txPick.TabIndex = 10;
            this.txPick.Text = "Click \'n Fight \r\nThe Fantasy Clicker RPG\r\n";
            this.txPick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 83);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = "Start Game!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(439, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 83);
            this.button2.TabIndex = 12;
            this.button2.TabStop = false;
            this.button2.Text = "Patch Notes!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(218, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 83);
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.Text = "Exit!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Copyright ⓒ 2020-2021 Dennis Vasilev All Rights Reserved\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dev
            // 
            this.dev.AutoSize = true;
            this.dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev.Location = new System.Drawing.Point(219, 135);
            this.dev.Name = "dev";
            this.dev.Size = new System.Drawing.Size(348, 46);
            this.dev.TabIndex = 15;
            this.dev.Text = "Developer Version\r\n";
            this.dev.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dev.Visible = false;
            // 
            // clickerGame
            // 
            this.clickerGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickerGame.Location = new System.Drawing.Point(439, 217);
            this.clickerGame.Name = "clickerGame";
            this.clickerGame.Size = new System.Drawing.Size(349, 83);
            this.clickerGame.TabIndex = 16;
            this.clickerGame.TabStop = false;
            this.clickerGame.Text = "Clicker Game!";
            this.clickerGame.UseVisualStyleBackColor = true;
            this.clickerGame.Visible = false;
            this.clickerGame.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.clickerGame);
            this.Controls.Add(this.dev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txPick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Click \'n Fight The Fantasy Clicker RPG";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txPick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dev;
        private System.Windows.Forms.Button clickerGame;
    }
}
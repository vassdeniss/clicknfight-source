namespace ClickNFight.Windows
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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.PatchNotesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
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
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(12, 217);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(349, 83);
            this.StartGameButton.TabIndex = 11;
            this.StartGameButton.TabStop = false;
            this.StartGameButton.Text = "Start Game!";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // PatchNotesButton
            // 
            this.PatchNotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchNotesButton.Location = new System.Drawing.Point(439, 217);
            this.PatchNotesButton.Name = "PatchNotesButton";
            this.PatchNotesButton.Size = new System.Drawing.Size(349, 83);
            this.PatchNotesButton.TabIndex = 12;
            this.PatchNotesButton.TabStop = false;
            this.PatchNotesButton.Text = "Patch Notes!";
            this.PatchNotesButton.UseVisualStyleBackColor = true;
            this.PatchNotesButton.Click += new System.EventHandler(this.PatchNotesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(218, 321);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(349, 83);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Exit!";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.clickerGame.Click += new System.EventHandler(this.ClickerGame_CLick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.clickerGame);
            this.Controls.Add(this.dev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PatchNotesButton);
            this.Controls.Add(this.StartGameButton);
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
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button PatchNotesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dev;
        private System.Windows.Forms.Button clickerGame;
    }
}
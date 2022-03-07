namespace ClickNFight
{
    partial class Form1
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
            this.fightButton = new System.Windows.Forms.Button();
            this.currencyString = new System.Windows.Forms.Label();
            this.monsterKillsString = new System.Windows.Forms.Label();
            this.BT2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT3 = new System.Windows.Forms.Button();
            this.easterAndrej = new System.Windows.Forms.Label();
            this.hitpointsString = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.gpKill = new System.Windows.Forms.Label();
            this.potionMenu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.noH = new System.Windows.Forms.Label();
            this.defenceString = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.btMagic = new System.Windows.Forms.Button();
            this.CPS = new System.Windows.Forms.Label();
            this.btCrafting = new System.Windows.Forms.Button();
            this.finalBoss = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.levelString = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.newPlus = new System.Windows.Forms.Label();
            this.btMine = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nameSave = new System.Windows.Forms.Label();
            this.btCamp = new System.Windows.Forms.Button();
            this.xpString = new System.Windows.Forms.Label();
            this.xpGot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(188, 12);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(169, 85);
            this.fightButton.TabIndex = 0;
            this.fightButton.Text = "Fight!";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // LB1
            // 
            this.currencyString.AutoSize = true;
            this.currencyString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyString.Location = new System.Drawing.Point(363, 41);
            this.currencyString.Name = "LB1";
            this.currencyString.Size = new System.Drawing.Size(144, 29);
            this.currencyString.TabIndex = 1;
            this.currencyString.Text = "Clickerency:";
            // 
            // LB2
            // 
            this.monsterKillsString.AutoSize = true;
            this.monsterKillsString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterKillsString.Location = new System.Drawing.Point(363, 12);
            this.monsterKillsString.Name = "LB2";
            this.monsterKillsString.Size = new System.Drawing.Size(186, 29);
            this.monsterKillsString.TabIndex = 2;
            this.monsterKillsString.Text = "Monsters Killed:";
            // 
            // BT2
            // 
            this.BT2.Location = new System.Drawing.Point(188, 193);
            this.BT2.Name = "BT2";
            this.BT2.Size = new System.Drawing.Size(169, 85);
            this.BT2.TabIndex = 3;
            this.BT2.Text = "Shop!";
            this.BT2.UseVisualStyleBackColor = true;
            this.BT2.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Release v3.2";
            // 
            // BT3
            // 
            this.BT3.Location = new System.Drawing.Point(188, 102);
            this.BT3.Name = "BT3";
            this.BT3.Size = new System.Drawing.Size(169, 85);
            this.BT3.TabIndex = 5;
            this.BT3.Text = "Inventory!";
            this.BT3.UseVisualStyleBackColor = true;
            this.BT3.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // easterAndrej
            // 
            this.easterAndrej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.easterAndrej.AutoSize = true;
            this.easterAndrej.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easterAndrej.Location = new System.Drawing.Point(10, 553);
            this.easterAndrej.Name = "easterAndrej";
            this.easterAndrej.Size = new System.Drawing.Size(197, 39);
            this.easterAndrej.TabIndex = 8;
            this.easterAndrej.Text = "Thanks for breaking the game Andrej <3\r\n\r\n\r\n";
            this.easterAndrej.Visible = false;
            // 
            // label5
            // 
            this.hitpointsString.AutoSize = true;
            this.hitpointsString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitpointsString.Location = new System.Drawing.Point(363, 70);
            this.hitpointsString.Name = "label5";
            this.hitpointsString.Size = new System.Drawing.Size(115, 29);
            this.hitpointsString.TabIndex = 9;
            this.hitpointsString.Text = "HitPoints:";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(363, 164);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 29);
            this.info.TabIndex = 11;
            // 
            // gpKill
            // 
            this.gpKill.AutoSize = true;
            this.gpKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpKill.Location = new System.Drawing.Point(363, 193);
            this.gpKill.Name = "gpKill";
            this.gpKill.Size = new System.Drawing.Size(0, 29);
            this.gpKill.TabIndex = 12;
            // 
            // potionMenu
            // 
            this.potionMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.potionMenu.FormattingEnabled = true;
            this.potionMenu.Location = new System.Drawing.Point(13, 448);
            this.potionMenu.Name = "potionMenu";
            this.potionMenu.Size = new System.Drawing.Size(232, 21);
            this.potionMenu.TabIndex = 14;
            this.potionMenu.Text = "Potions";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Equipment:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(251, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "Heal!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HealButton_Click);
            // 
            // noH
            // 
            this.noH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.noH.AutoSize = true;
            this.noH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noH.Location = new System.Drawing.Point(8, 375);
            this.noH.Name = "noH";
            this.noH.Size = new System.Drawing.Size(0, 29);
            this.noH.TabIndex = 17;
            // 
            // defence
            // 
            this.defenceString.AutoSize = true;
            this.defenceString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenceString.Location = new System.Drawing.Point(363, 103);
            this.defenceString.Name = "defence";
            this.defenceString.Size = new System.Drawing.Size(0, 29);
            this.defenceString.TabIndex = 18;
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Red;
            this.healthBar.Location = new System.Drawing.Point(601, 70);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(233, 27);
            this.healthBar.TabIndex = 19;
            // 
            // btMagic
            // 
            this.btMagic.Enabled = false;
            this.btMagic.Location = new System.Drawing.Point(13, 102);
            this.btMagic.Name = "btMagic";
            this.btMagic.Size = new System.Drawing.Size(169, 85);
            this.btMagic.TabIndex = 20;
            this.btMagic.Text = "Magic!";
            this.btMagic.UseVisualStyleBackColor = true;
            this.btMagic.Click += new System.EventHandler(this.MagiButton_Click);
            // 
            // CPS
            // 
            this.CPS.AutoSize = true;
            this.CPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPS.Location = new System.Drawing.Point(363, 134);
            this.CPS.Name = "CPS";
            this.CPS.Size = new System.Drawing.Size(0, 29);
            this.CPS.TabIndex = 21;
            // 
            // btCrafting
            // 
            this.btCrafting.Enabled = false;
            this.btCrafting.Location = new System.Drawing.Point(13, 193);
            this.btCrafting.Name = "btCrafting";
            this.btCrafting.Size = new System.Drawing.Size(169, 85);
            this.btCrafting.TabIndex = 22;
            this.btCrafting.Text = "RuneCrafting!";
            this.btCrafting.UseVisualStyleBackColor = true;
            this.btCrafting.Click += new System.EventHandler(this.CraftingButton_Click);
            // 
            // finalBoss
            // 
            this.finalBoss.Enabled = false;
            this.finalBoss.Location = new System.Drawing.Point(13, 12);
            this.finalBoss.Name = "finalBoss";
            this.finalBoss.Size = new System.Drawing.Size(169, 85);
            this.finalBoss.TabIndex = 23;
            this.finalBoss.Text = "Final Boss!";
            this.finalBoss.UseVisualStyleBackColor = true;
            this.finalBoss.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(310, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 85);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(490, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 85);
            this.button3.TabIndex = 25;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // levelText
            // 
            this.levelString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.levelString.AutoSize = true;
            this.levelString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelString.Location = new System.Drawing.Point(704, 396);
            this.levelString.Name = "levelText";
            this.levelString.Size = new System.Drawing.Size(0, 29);
            this.levelString.TabIndex = 26;
            // 
            // newGame
            // 
            this.newGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newGame.Location = new System.Drawing.Point(490, 396);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(174, 85);
            this.newGame.TabIndex = 27;
            this.newGame.Text = "New Game ";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Visible = false;
            this.newGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // newPlus
            // 
            this.newPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newPlus.AutoSize = true;
            this.newPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlus.Location = new System.Drawing.Point(659, 340);
            this.newPlus.Name = "newPlus";
            this.newPlus.Size = new System.Drawing.Size(0, 29);
            this.newPlus.TabIndex = 28;
            // 
            // btMine
            // 
            this.btMine.Enabled = false;
            this.btMine.Location = new System.Drawing.Point(13, 284);
            this.btMine.Name = "btMine";
            this.btMine.Size = new System.Drawing.Size(169, 85);
            this.btMine.TabIndex = 30;
            this.btMine.Text = "Mine!";
            this.btMine.UseVisualStyleBackColor = true;
            this.btMine.Click += new System.EventHandler(this.MineButton_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(670, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 85);
            this.button4.TabIndex = 31;
            this.button4.Text = "Exit!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // nameSave
            // 
            this.nameSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameSave.AutoSize = true;
            this.nameSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSave.Location = new System.Drawing.Point(9, 487);
            this.nameSave.Name = "nameSave";
            this.nameSave.Size = new System.Drawing.Size(0, 29);
            this.nameSave.TabIndex = 32;
            // 
            // btCamp
            // 
            this.btCamp.Enabled = false;
            this.btCamp.Location = new System.Drawing.Point(188, 284);
            this.btCamp.Name = "btCamp";
            this.btCamp.Size = new System.Drawing.Size(169, 85);
            this.btCamp.TabIndex = 33;
            this.btCamp.Text = "Camping!";
            this.btCamp.UseVisualStyleBackColor = true;
            this.btCamp.Click += new System.EventHandler(this.CampButton_Click);
            // 
            // xpTracker
            // 
            this.xpString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xpString.AutoSize = true;
            this.xpString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpString.Location = new System.Drawing.Point(704, 440);
            this.xpString.Name = "xpTracker";
            this.xpString.Size = new System.Drawing.Size(0, 29);
            this.xpString.TabIndex = 34;
            // 
            // xpGot
            // 
            this.xpGot.AutoSize = true;
            this.xpGot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpGot.Location = new System.Drawing.Point(363, 222);
            this.xpGot.Name = "xpGot";
            this.xpGot.Size = new System.Drawing.Size(0, 29);
            this.xpGot.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 585);
            this.Controls.Add(this.xpGot);
            this.Controls.Add(this.xpString);
            this.Controls.Add(this.btCamp);
            this.Controls.Add(this.nameSave);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btMine);
            this.Controls.Add(this.newPlus);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.levelString);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finalBoss);
            this.Controls.Add(this.btCrafting);
            this.Controls.Add(this.CPS);
            this.Controls.Add(this.btMagic);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.defenceString);
            this.Controls.Add(this.noH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.potionMenu);
            this.Controls.Add(this.gpKill);
            this.Controls.Add(this.info);
            this.Controls.Add(this.hitpointsString);
            this.Controls.Add(this.easterAndrej);
            this.Controls.Add(this.BT3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT2);
            this.Controls.Add(this.monsterKillsString);
            this.Controls.Add(this.currencyString);
            this.Controls.Add(this.fightButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Click \'n Fight: The Fantasy Clicker RPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label monsterKillsString;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label currencyString;
        public System.Windows.Forms.Label hitpointsString;
        public System.Windows.Forms.Label info;
        public System.Windows.Forms.Label gpKill;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox potionMenu;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label noH;
        public System.Windows.Forms.Label defenceString;
        public System.Windows.Forms.Label CPS;
        public System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label levelString;
        public System.Windows.Forms.Button newGame;
        public System.Windows.Forms.Button fightButton;
        public System.Windows.Forms.Button BT2;
        public System.Windows.Forms.Button BT3;
        public System.Windows.Forms.Button btMagic;
        public System.Windows.Forms.Button btCrafting;
        public System.Windows.Forms.Button finalBoss;
        public System.Windows.Forms.Label newPlus;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label nameSave;
        public System.Windows.Forms.Label easterAndrej;
        public System.Windows.Forms.Button btMine;
        public System.Windows.Forms.Button btCamp;
        private System.Windows.Forms.Label xpString;
        public System.Windows.Forms.Label xpGot;
    }
}


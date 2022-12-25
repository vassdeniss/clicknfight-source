namespace ClickNFight
{
    partial class Boss
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
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.bossBar = new System.Windows.Forms.ProgressBar();
            this.BT1 = new System.Windows.Forms.Button();
            this.bossHP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.potionMenu2 = new System.Windows.Forms.ComboBox();
            this.noH = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.Label();
            this.boop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Red;
            this.healthBar.Location = new System.Drawing.Point(12, 241);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(233, 27);
            this.healthBar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Your HP:";
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.Location = new System.Drawing.Point(12, 271);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(0, 29);
            this.hp.TabIndex = 22;
            // 
            // bossBar
            // 
            this.bossBar.BackColor = System.Drawing.Color.Red;
            this.bossBar.Location = new System.Drawing.Point(92, 83);
            this.bossBar.Name = "bossBar";
            this.bossBar.Size = new System.Drawing.Size(614, 27);
            this.bossBar.TabIndex = 23;
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(314, 153);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(169, 85);
            this.BT1.TabIndex = 24;
            this.BT1.Text = "Fight!";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // bossHP
            // 
            this.bossHP.AutoSize = true;
            this.bossHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bossHP.Location = new System.Drawing.Point(276, 51);
            this.bossHP.Name = "bossHP";
            this.bossHP.Size = new System.Drawing.Size(0, 29);
            this.bossHP.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 21);
            this.button1.TabIndex = 28;
            this.button1.Text = "Heal!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Equipment:";
            // 
            // potionMenu2
            // 
            this.potionMenu2.FormattingEnabled = true;
            this.potionMenu2.Location = new System.Drawing.Point(17, 352);
            this.potionMenu2.Name = "potionMenu2";
            this.potionMenu2.Size = new System.Drawing.Size(232, 21);
            this.potionMenu2.TabIndex = 26;
            this.potionMenu2.Text = "Potions";
            // 
            // noH
            // 
            this.noH.AutoSize = true;
            this.noH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noH.Location = new System.Drawing.Point(12, 375);
            this.noH.Name = "noH";
            this.noH.Size = new System.Drawing.Size(0, 29);
            this.noH.TabIndex = 29;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(561, 123);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(227, 240);
            this.end.TabIndex = 30;
            this.end.Text = "Congratulations!\r\nYou have done it! \r\nYou have saved the world\r\n and beaten the \r" +
    "\nYou have gained: \r\n+ 1,000,000 Clickerency! \r\n+ Excalibur!\r\n+ God Mode! \r\n\r\nEnj" +
    "oy the post game!";
            this.end.Visible = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(565, 375);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(223, 59);
            this.exit.TabIndex = 31;
            this.exit.Text = "Exit Back!";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.Location = new System.Drawing.Point(18, 375);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(409, 72);
            this.hint.TabIndex = 32;
            this.hint.Text = "At the main screen you may find that controlling \r\nthe shifting tides may work. \r" +
    "\nAlternately you may press G";
            this.hint.Visible = false;
            // 
            // boop
            // 
            this.boop.AutoSize = true;
            this.boop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boop.Location = new System.Drawing.Point(696, 195);
            this.boop.Name = "boop";
            this.boop.Size = new System.Drawing.Size(63, 24);
            this.boop.TabIndex = 33;
            this.boop.Text = "game!";
            this.boop.Visible = false;
            this.boop.Click += new System.EventHandler(this.label2_Click);
            // 
            // Boss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boop);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.end);
            this.Controls.Add(this.noH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.potionMenu2);
            this.Controls.Add(this.bossHP);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.bossBar);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthBar);
            this.Name = "Boss";
            this.Text = "Final Boss";
            this.Load += new System.EventHandler(this.Boss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hp;
        public System.Windows.Forms.ProgressBar bossBar;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.Label bossHP;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox potionMenu2;
        public System.Windows.Forms.Label noH;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Label boop;
    }
}
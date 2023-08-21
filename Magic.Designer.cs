namespace ClickNFight
{
    partial class Magic
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fireBolt = new System.Windows.Forms.Button();
            this.fireCooldown = new System.Windows.Forms.Timer(this.components);
            this.exDefence = new System.Windows.Forms.Button();
            this.maxDefence = new System.Windows.Forms.Button();
            this.defenceUp = new System.Windows.Forms.Button();
            this.voltSwtich = new System.Windows.Forms.Button();
            this.waterWave = new System.Windows.Forms.Button();
            this.healara = new System.Windows.Forms.Button();
            this.rearise = new System.Windows.Forms.Button();
            this.cureraga = new System.Windows.Forms.Button();
            this.waterCooldown = new System.Windows.Forms.Timer(this.components);
            this.defenceCooldown = new System.Windows.Forms.Timer(this.components);
            this.defenceBoost = new System.Windows.Forms.Timer(this.components);
            this.healaraCooldown = new System.Windows.Forms.Timer(this.components);
            this.attackBoost = new System.Windows.Forms.Timer(this.components);
            this.hpUp = new System.Windows.Forms.Timer(this.components);
            this.attackBoost2 = new System.Windows.Forms.Timer(this.components);
            this.extraDefenceCooldown = new System.Windows.Forms.Timer(this.components);
            this.defenceBoost2 = new System.Windows.Forms.Timer(this.components);
            this.cureragaCooldown = new System.Windows.Forms.Timer(this.components);
            this.hpUp2 = new System.Windows.Forms.Timer(this.components);
            this.voltCooldown = new System.Windows.Forms.Timer(this.components);
            this.attackBoost3 = new System.Windows.Forms.Timer(this.components);
            this.defenceCooldown3 = new System.Windows.Forms.Timer(this.components);
            this.defenceBoost3 = new System.Windows.Forms.Timer(this.components);
            this.reariseCooldown = new System.Windows.Forms.Timer(this.components);
            this.hpUp3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.offensiveSpellsTab = new System.Windows.Forms.TabPage();
            this.defensiveSpellsTab = new System.Windows.Forms.TabPage();
            this.supportiveSpellsTab = new System.Windows.Forms.TabPage();
            this.offensiveSpellsComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.offensiveSpellsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Offensive Spells:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Defensive Spells:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Supportive Spells:";
            // 
            // fireBolt
            // 
            this.fireBolt.Location = new System.Drawing.Point(23, 66);
            this.fireBolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fireBolt.Name = "fireBolt";
            this.fireBolt.Size = new System.Drawing.Size(207, 59);
            this.fireBolt.TabIndex = 15;
            this.fireBolt.TabStop = false;
            this.fireBolt.Text = "Fire Bolt";
            this.fireBolt.UseVisualStyleBackColor = true;
            this.fireBolt.Click += new System.EventHandler(this.fireBolt_Click);
            // 
            // exDefence
            // 
            this.exDefence.Enabled = false;
            this.exDefence.Location = new System.Drawing.Point(344, 133);
            this.exDefence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exDefence.Name = "exDefence";
            this.exDefence.Size = new System.Drawing.Size(207, 59);
            this.exDefence.TabIndex = 17;
            this.exDefence.TabStop = false;
            this.exDefence.Text = "Extra Defence \r\n";
            this.exDefence.UseVisualStyleBackColor = true;
            this.exDefence.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxDefence
            // 
            this.maxDefence.Enabled = false;
            this.maxDefence.Location = new System.Drawing.Point(344, 199);
            this.maxDefence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxDefence.Name = "maxDefence";
            this.maxDefence.Size = new System.Drawing.Size(207, 59);
            this.maxDefence.TabIndex = 18;
            this.maxDefence.TabStop = false;
            this.maxDefence.Text = "Max Defence\r\n";
            this.maxDefence.UseVisualStyleBackColor = true;
            this.maxDefence.Click += new System.EventHandler(this.maxDefence_Click);
            // 
            // defenceUp
            // 
            this.defenceUp.Enabled = false;
            this.defenceUp.Location = new System.Drawing.Point(344, 66);
            this.defenceUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.defenceUp.Name = "defenceUp";
            this.defenceUp.Size = new System.Drawing.Size(207, 59);
            this.defenceUp.TabIndex = 19;
            this.defenceUp.TabStop = false;
            this.defenceUp.Text = "Defence Up\r\n";
            this.defenceUp.UseVisualStyleBackColor = true;
            this.defenceUp.Click += new System.EventHandler(this.defenceUp_Click);
            // 
            // voltSwtich
            // 
            this.voltSwtich.Enabled = false;
            this.voltSwtich.Location = new System.Drawing.Point(23, 199);
            this.voltSwtich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.voltSwtich.Name = "voltSwtich";
            this.voltSwtich.Size = new System.Drawing.Size(207, 59);
            this.voltSwtich.TabIndex = 20;
            this.voltSwtich.TabStop = false;
            this.voltSwtich.Text = "Volt Switch\r\n";
            this.voltSwtich.UseVisualStyleBackColor = true;
            this.voltSwtich.Click += new System.EventHandler(this.voltSwtich_Click);
            // 
            // waterWave
            // 
            this.waterWave.Enabled = false;
            this.waterWave.Location = new System.Drawing.Point(23, 133);
            this.waterWave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waterWave.Name = "waterWave";
            this.waterWave.Size = new System.Drawing.Size(207, 59);
            this.waterWave.TabIndex = 21;
            this.waterWave.TabStop = false;
            this.waterWave.Text = "Water Wave\r\n";
            this.waterWave.UseVisualStyleBackColor = true;
            this.waterWave.Click += new System.EventHandler(this.button5_Click);
            // 
            // healara
            // 
            this.healara.Enabled = false;
            this.healara.Location = new System.Drawing.Point(661, 66);
            this.healara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.healara.Name = "healara";
            this.healara.Size = new System.Drawing.Size(207, 59);
            this.healara.TabIndex = 24;
            this.healara.TabStop = false;
            this.healara.Text = "Healara \r\n";
            this.healara.UseVisualStyleBackColor = true;
            this.healara.Click += new System.EventHandler(this.healara_Click);
            // 
            // rearise
            // 
            this.rearise.Enabled = false;
            this.rearise.Location = new System.Drawing.Point(661, 199);
            this.rearise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rearise.Name = "rearise";
            this.rearise.Size = new System.Drawing.Size(207, 59);
            this.rearise.TabIndex = 23;
            this.rearise.TabStop = false;
            this.rearise.Text = "ReArise\r\n";
            this.rearise.UseVisualStyleBackColor = true;
            this.rearise.Click += new System.EventHandler(this.rearise_Click);
            // 
            // cureraga
            // 
            this.cureraga.Enabled = false;
            this.cureraga.Location = new System.Drawing.Point(661, 133);
            this.cureraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cureraga.Name = "cureraga";
            this.cureraga.Size = new System.Drawing.Size(207, 59);
            this.cureraga.TabIndex = 22;
            this.cureraga.TabStop = false;
            this.cureraga.Text = "Cureraga\r\n";
            this.cureraga.UseVisualStyleBackColor = true;
            this.cureraga.Click += new System.EventHandler(this.cureraga_Click);
            // 
            // defenceCooldown
            // 
            this.defenceCooldown.Tick += new System.EventHandler(this.defenceCooldown_Tick);
            // 
            // defenceBoost
            // 
            this.defenceBoost.Tick += new System.EventHandler(this.defenceBoost_Tick);
            // 
            // healaraCooldown
            // 
            this.healaraCooldown.Tick += new System.EventHandler(this.healaraCooldown_Tick);
            // 
            // attackBoost
            // 
            this.attackBoost.Tick += new System.EventHandler(this.attackBoost_Tick);
            // 
            // hpUp
            // 
            this.hpUp.Tick += new System.EventHandler(this.hpUp_Tick);
            // 
            // extraDefenceCooldown
            // 
            this.extraDefenceCooldown.Tick += new System.EventHandler(this.extraDefenceCooldown_Tick);
            // 
            // defenceBoost2
            // 
            this.defenceBoost2.Tick += new System.EventHandler(this.defenceBoost2_Tick);
            // 
            // cureragaCooldown
            // 
            this.cureragaCooldown.Tick += new System.EventHandler(this.cureragaCooldown_Tick);
            // 
            // hpUp2
            // 
            this.hpUp2.Tick += new System.EventHandler(this.hpUp2_Tick);
            // 
            // voltCooldown
            // 
            this.voltCooldown.Tick += new System.EventHandler(this.voltCooldown_Tick);
            // 
            // attackBoost3
            // 
            this.attackBoost3.Tick += new System.EventHandler(this.attackBoost3_Tick);
            // 
            // defenceCooldown3
            // 
            this.defenceCooldown3.Tick += new System.EventHandler(this.defenceCooldown3_Tick);
            // 
            // defenceBoost3
            // 
            this.defenceBoost3.Tick += new System.EventHandler(this.defenceBoost3_Tick);
            // 
            // reariseCooldown
            // 
            this.reariseCooldown.Tick += new System.EventHandler(this.reariseCooldown_Tick);
            // 
            // hpUp3
            // 
            this.hpUp3.Tick += new System.EventHandler(this.hpUp3_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.offensiveSpellsTab);
            this.tabControl1.Controls.Add(this.defensiveSpellsTab);
            this.tabControl1.Controls.Add(this.supportiveSpellsTab);
            this.tabControl1.Location = new System.Drawing.Point(284, 358);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 122);
            this.tabControl1.TabIndex = 25;
            // 
            // offensiveSpellsTab
            // 
            this.offensiveSpellsTab.Controls.Add(this.offensiveSpellsComboBox);
            this.offensiveSpellsTab.Location = new System.Drawing.Point(4, 25);
            this.offensiveSpellsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offensiveSpellsTab.Name = "offensiveSpellsTab";
            this.offensiveSpellsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offensiveSpellsTab.Size = new System.Drawing.Size(591, 93);
            this.offensiveSpellsTab.TabIndex = 0;
            this.offensiveSpellsTab.Text = "Offensive Spells";
            this.offensiveSpellsTab.UseVisualStyleBackColor = true;
            // 
            // defensiveSpellsTab
            // 
            this.defensiveSpellsTab.Location = new System.Drawing.Point(4, 25);
            this.defensiveSpellsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.defensiveSpellsTab.Name = "defensiveSpellsTab";
            this.defensiveSpellsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.defensiveSpellsTab.Size = new System.Drawing.Size(591, 93);
            this.defensiveSpellsTab.TabIndex = 1;
            this.defensiveSpellsTab.Text = "Defensive Spells";
            this.defensiveSpellsTab.UseVisualStyleBackColor = true;
            // 
            // supportiveSpellsTab
            // 
            this.supportiveSpellsTab.Location = new System.Drawing.Point(4, 25);
            this.supportiveSpellsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supportiveSpellsTab.Name = "supportiveSpellsTab";
            this.supportiveSpellsTab.Size = new System.Drawing.Size(591, 93);
            this.supportiveSpellsTab.TabIndex = 2;
            this.supportiveSpellsTab.Text = "Supportive Spells";
            this.supportiveSpellsTab.UseVisualStyleBackColor = true;
            // 
            // offensiveSpellsComboBox
            // 
            this.offensiveSpellsComboBox.FormattingEnabled = true;
            this.offensiveSpellsComboBox.Location = new System.Drawing.Point(7, 7);
            this.offensiveSpellsComboBox.Name = "offensiveSpellsComboBox";
            this.offensiveSpellsComboBox.Size = new System.Drawing.Size(105, 24);
            this.offensiveSpellsComboBox.TabIndex = 0;
            this.offensiveSpellsComboBox.SelectedIndexChanged += new System.EventHandler(this.SpellsComboBox_SelectedIndexChanged);
            // 
            // Magic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 508);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.healara);
            this.Controls.Add(this.rearise);
            this.Controls.Add(this.cureraga);
            this.Controls.Add(this.waterWave);
            this.Controls.Add(this.voltSwtich);
            this.Controls.Add(this.defenceUp);
            this.Controls.Add(this.maxDefence);
            this.Controls.Add(this.exDefence);
            this.Controls.Add(this.fireBolt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Magic";
            this.Text = "Magic";
            this.tabControl1.ResumeLayout(false);
            this.offensiveSpellsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer attackBoost;
        public System.Windows.Forms.Timer fireCooldown;
        public System.Windows.Forms.Button fireBolt;
        public System.Windows.Forms.Button exDefence;
        public System.Windows.Forms.Button maxDefence;
        public System.Windows.Forms.Button defenceUp;
        public System.Windows.Forms.Button voltSwtich;
        public System.Windows.Forms.Button waterWave;
        public System.Windows.Forms.Button healara;
        public System.Windows.Forms.Button rearise;
        public System.Windows.Forms.Button cureraga;
        public System.Windows.Forms.Timer healaraCooldown;
        public System.Windows.Forms.Timer waterCooldown;
        public System.Windows.Forms.Timer defenceCooldown;
        public System.Windows.Forms.Timer defenceBoost;
        public System.Windows.Forms.Timer hpUp;
        private System.Windows.Forms.Timer attackBoost2;
        private System.Windows.Forms.Timer defenceBoost2;
        public System.Windows.Forms.Timer extraDefenceCooldown;
        public System.Windows.Forms.Timer cureragaCooldown;
        private System.Windows.Forms.Timer hpUp2;
        public System.Windows.Forms.Timer voltCooldown;
        private System.Windows.Forms.Timer attackBoost3;
        public System.Windows.Forms.Timer defenceCooldown3;
        private System.Windows.Forms.Timer defenceBoost3;
        public System.Windows.Forms.Timer reariseCooldown;
        private System.Windows.Forms.Timer hpUp3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage offensiveSpellsTab;
        private System.Windows.Forms.TabPage defensiveSpellsTab;
        private System.Windows.Forms.TabPage supportiveSpellsTab;
        private System.Windows.Forms.ComboBox offensiveSpellsComboBox;
    }
}
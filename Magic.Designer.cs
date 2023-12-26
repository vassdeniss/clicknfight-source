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
            this.castButton = new System.Windows.Forms.Button();
            this.exDefence = new System.Windows.Forms.Button();
            this.maxDefence = new System.Windows.Forms.Button();
            this.voltSwtich = new System.Windows.Forms.Button();
            this.waterWave = new System.Windows.Forms.Button();
            this.healara = new System.Windows.Forms.Button();
            this.rearise = new System.Windows.Forms.Button();
            this.cureraga = new System.Windows.Forms.Button();
            this.waterCooldown = new System.Windows.Forms.Timer(this.components);
            this.healaraCooldown = new System.Windows.Forms.Timer(this.components);
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
            this.spellsComboBox = new System.Windows.Forms.ComboBox();
            this.spellInfoTextBox = new System.Windows.Forms.TextBox();
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
            // castButton
            // 
            this.castButton.Location = new System.Drawing.Point(23, 346);
            this.castButton.Margin = new System.Windows.Forms.Padding(4);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(197, 34);
            this.castButton.TabIndex = 15;
            this.castButton.TabStop = false;
            this.castButton.Text = "Cast!";
            this.castButton.UseVisualStyleBackColor = true;
            this.castButton.Click += new System.EventHandler(this.CastButton_Clicked);
            // 
            // exDefence
            // 
            this.exDefence.Enabled = false;
            this.exDefence.Location = new System.Drawing.Point(344, 133);
            this.exDefence.Margin = new System.Windows.Forms.Padding(4);
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
            this.maxDefence.Margin = new System.Windows.Forms.Padding(4);
            this.maxDefence.Name = "maxDefence";
            this.maxDefence.Size = new System.Drawing.Size(207, 59);
            this.maxDefence.TabIndex = 18;
            this.maxDefence.TabStop = false;
            this.maxDefence.Text = "Max Defence\r\n";
            this.maxDefence.UseVisualStyleBackColor = true;
            this.maxDefence.Click += new System.EventHandler(this.maxDefence_Click);
            // 
            // voltSwtich
            // 
            this.voltSwtich.Enabled = false;
            this.voltSwtich.Location = new System.Drawing.Point(37, 66);
            this.voltSwtich.Margin = new System.Windows.Forms.Padding(4);
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
            this.waterWave.Margin = new System.Windows.Forms.Padding(4);
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
            this.healara.Margin = new System.Windows.Forms.Padding(4);
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
            this.rearise.Margin = new System.Windows.Forms.Padding(4);
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
            this.cureraga.Margin = new System.Windows.Forms.Padding(4);
            this.cureraga.Name = "cureraga";
            this.cureraga.Size = new System.Drawing.Size(207, 59);
            this.cureraga.TabIndex = 22;
            this.cureraga.TabStop = false;
            this.cureraga.Text = "Cureraga\r\n";
            this.cureraga.UseVisualStyleBackColor = true;
            this.cureraga.Click += new System.EventHandler(this.cureraga_Click);
            // 
            // healaraCooldown
            // 
            this.healaraCooldown.Tick += new System.EventHandler(this.healaraCooldown_Tick);
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
            // spellsComboBox
            // 
            this.spellsComboBox.FormattingEnabled = true;
            this.spellsComboBox.Location = new System.Drawing.Point(23, 218);
            this.spellsComboBox.Name = "spellsComboBox";
            this.spellsComboBox.Size = new System.Drawing.Size(197, 24);
            this.spellsComboBox.TabIndex = 0;
            this.spellsComboBox.SelectedIndexChanged += new System.EventHandler(this.SpellsComboBox_SelectedIndexChanged);
            // 
            // spellInfoTextBox
            // 
            this.spellInfoTextBox.Location = new System.Drawing.Point(23, 248);
            this.spellInfoTextBox.Multiline = true;
            this.spellInfoTextBox.Name = "spellInfoTextBox";
            this.spellInfoTextBox.ReadOnly = true;
            this.spellInfoTextBox.Size = new System.Drawing.Size(197, 91);
            this.spellInfoTextBox.TabIndex = 26;
            this.spellInfoTextBox.Text = "Select a spell from the list!";
            // 
            // Magic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 392);
            this.Controls.Add(this.spellInfoTextBox);
            this.Controls.Add(this.spellsComboBox);
            this.Controls.Add(this.healara);
            this.Controls.Add(this.rearise);
            this.Controls.Add(this.cureraga);
            this.Controls.Add(this.waterWave);
            this.Controls.Add(this.voltSwtich);
            this.Controls.Add(this.maxDefence);
            this.Controls.Add(this.exDefence);
            this.Controls.Add(this.castButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Magic";
            this.Text = "Magic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button castButton;
        public System.Windows.Forms.Button exDefence;
        public System.Windows.Forms.Button maxDefence;
        public System.Windows.Forms.Button voltSwtich;
        public System.Windows.Forms.Button waterWave;
        public System.Windows.Forms.Button healara;
        public System.Windows.Forms.Button rearise;
        public System.Windows.Forms.Button cureraga;
        public System.Windows.Forms.Timer healaraCooldown;
        public System.Windows.Forms.Timer waterCooldown;
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
        private System.Windows.Forms.ComboBox spellsComboBox;
        private System.Windows.Forms.TextBox spellInfoTextBox;
    }
}
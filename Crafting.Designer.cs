namespace ClickNFight
{
    partial class Crafting
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
            this.craftBR = new System.Windows.Forms.Button();
            this.buyWS = new System.Windows.Forms.Label();
            this.noCraft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.craftCR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.craftLR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.craftWR = new System.Windows.Forms.Button();
            this.craftAR = new System.Windows.Forms.Label();
            this.craftSR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.craftSoS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // craftBR
            // 
            this.craftBR.Location = new System.Drawing.Point(12, 12);
            this.craftBR.Name = "craftBR";
            this.craftBR.Size = new System.Drawing.Size(150, 50);
            this.craftBR.TabIndex = 0;
            this.craftBR.Text = "Craft!";
            this.craftBR.UseVisualStyleBackColor = true;
            this.craftBR.Click += new System.EventHandler(this.craftBR_Click);
            // 
            // buyWS
            // 
            this.buyWS.AutoSize = true;
            this.buyWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyWS.Location = new System.Drawing.Point(168, 22);
            this.buyWS.Name = "buyWS";
            this.buyWS.Size = new System.Drawing.Size(386, 25);
            this.buyWS.TabIndex = 2;
            this.buyWS.Text = "Blood Rune - 5 Water Runes/2 Mind Runes";
            // 
            // noCraft
            // 
            this.noCraft.AutoSize = true;
            this.noCraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCraft.Location = new System.Drawing.Point(12, 349);
            this.noCraft.Name = "noCraft";
            this.noCraft.Size = new System.Drawing.Size(365, 25);
            this.noCraft.TabIndex = 3;
            this.noCraft.Text = "You don\'t have enough runes to craft this";
            this.noCraft.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cosmic Rune - 5 Lava Runes/2 Air Runes/2 Mind Runes";
            // 
            // craftCR
            // 
            this.craftCR.Location = new System.Drawing.Point(12, 68);
            this.craftCR.Name = "craftCR";
            this.craftCR.Size = new System.Drawing.Size(150, 50);
            this.craftCR.TabIndex = 4;
            this.craftCR.Text = "Craft!";
            this.craftCR.UseVisualStyleBackColor = true;
            this.craftCR.Click += new System.EventHandler(this.craftCR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Life Rune - 6 Nature Runes/3 Air Runes/3 Mind Runes";
            // 
            // craftLR
            // 
            this.craftLR.Enabled = false;
            this.craftLR.Location = new System.Drawing.Point(12, 124);
            this.craftLR.Name = "craftLR";
            this.craftLR.Size = new System.Drawing.Size(150, 50);
            this.craftLR.TabIndex = 6;
            this.craftLR.Text = "Craft!";
            this.craftLR.UseVisualStyleBackColor = true;
            this.craftLR.Click += new System.EventHandler(this.craftLR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wrath Rune - 7 Blood Runes/4 Air Runes\r\n/4 Mind Runes/1 Electric Rune";
            // 
            // craftWR
            // 
            this.craftWR.Enabled = false;
            this.craftWR.Location = new System.Drawing.Point(12, 180);
            this.craftWR.Name = "craftWR";
            this.craftWR.Size = new System.Drawing.Size(150, 50);
            this.craftWR.TabIndex = 8;
            this.craftWR.Text = "Craft!";
            this.craftWR.UseVisualStyleBackColor = true;
            this.craftWR.Click += new System.EventHandler(this.craftWR_Click);
            // 
            // craftAR
            // 
            this.craftAR.AutoSize = true;
            this.craftAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftAR.Location = new System.Drawing.Point(168, 236);
            this.craftAR.Name = "craftAR";
            this.craftAR.Size = new System.Drawing.Size(380, 50);
            this.craftAR.TabIndex = 11;
            this.craftAR.Text = "Astral Rune - 8 Cosmic Runes/5 Air Runes\r\n/5 Mind Runes/1 Steam Rune";
            // 
            // craftSR
            // 
            this.craftSR.Enabled = false;
            this.craftSR.Location = new System.Drawing.Point(12, 236);
            this.craftSR.Name = "craftSR";
            this.craftSR.Size = new System.Drawing.Size(150, 50);
            this.craftSR.TabIndex = 10;
            this.craftSR.Text = "Craft!";
            this.craftSR.UseVisualStyleBackColor = true;
            this.craftSR.Click += new System.EventHandler(this.craftSR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 50);
            this.label4.TabIndex = 13;
            this.label4.Text = "Soul Rune - 8 Life Runes/5 Air Runes\r\n/5 Mind Runes/1 Revive Rune";
            // 
            // craftSoS
            // 
            this.craftSoS.Enabled = false;
            this.craftSoS.Location = new System.Drawing.Point(12, 292);
            this.craftSoS.Name = "craftSoS";
            this.craftSoS.Size = new System.Drawing.Size(150, 50);
            this.craftSoS.TabIndex = 12;
            this.craftSoS.Text = "Craft!";
            this.craftSoS.UseVisualStyleBackColor = true;
            this.craftSoS.Click += new System.EventHandler(this.craftSoS_Click);
            // 
            // Crafting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.craftSoS);
            this.Controls.Add(this.craftAR);
            this.Controls.Add(this.craftSR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.craftWR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.craftLR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.craftCR);
            this.Controls.Add(this.noCraft);
            this.Controls.Add(this.buyWS);
            this.Controls.Add(this.craftBR);
            this.Name = "Crafting";
            this.Text = "RuneCrafting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button craftBR;
        private System.Windows.Forms.Label buyWS;
        private System.Windows.Forms.Label noCraft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button craftCR;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button craftLR;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button craftWR;
        private System.Windows.Forms.Label craftAR;
        public System.Windows.Forms.Button craftSR;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button craftSoS;
    }
}
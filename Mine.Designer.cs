namespace Idle_Game
{
    partial class Mine
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
            this.button3 = new System.Windows.Forms.Button();
            this.cbPick = new System.Windows.Forms.ComboBox();
            this.cbOre = new System.Windows.Forms.ComboBox();
            this.pickPick = new System.Windows.Forms.Button();
            this.orePicker = new System.Windows.Forms.Button();
            this.lbOre = new System.Windows.Forms.Label();
            this.txPick = new System.Windows.Forms.Label();
            this.txOre = new System.Windows.Forms.Label();
            this.titalSilver = new System.Windows.Forms.Label();
            this.totalGold = new System.Windows.Forms.Label();
            this.platinumTotal = new System.Windows.Forms.Label();
            this.cobaltTotal = new System.Windows.Forms.Label();
            this.starTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(243, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 116);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mine!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbPick
            // 
            this.cbPick.FormattingEnabled = true;
            this.cbPick.Location = new System.Drawing.Point(12, 152);
            this.cbPick.Name = "cbPick";
            this.cbPick.Size = new System.Drawing.Size(225, 21);
            this.cbPick.TabIndex = 3;
            // 
            // cbOre
            // 
            this.cbOre.FormattingEnabled = true;
            this.cbOre.Location = new System.Drawing.Point(12, 210);
            this.cbOre.Name = "cbOre";
            this.cbOre.Size = new System.Drawing.Size(225, 21);
            this.cbOre.TabIndex = 4;
            // 
            // pickPick
            // 
            this.pickPick.Location = new System.Drawing.Point(58, 179);
            this.pickPick.Name = "pickPick";
            this.pickPick.Size = new System.Drawing.Size(122, 25);
            this.pickPick.TabIndex = 5;
            this.pickPick.Text = "Pick!";
            this.pickPick.UseVisualStyleBackColor = true;
            this.pickPick.Click += new System.EventHandler(this.pickPick_Click);
            // 
            // orePicker
            // 
            this.orePicker.Location = new System.Drawing.Point(58, 234);
            this.orePicker.Name = "orePicker";
            this.orePicker.Size = new System.Drawing.Size(122, 25);
            this.orePicker.TabIndex = 6;
            this.orePicker.Text = "Pick!";
            this.orePicker.UseVisualStyleBackColor = true;
            this.orePicker.Click += new System.EventHandler(this.orePicker_Click);
            // 
            // lbOre
            // 
            this.lbOre.AutoSize = true;
            this.lbOre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOre.Location = new System.Drawing.Point(306, 102);
            this.lbOre.Name = "lbOre";
            this.lbOre.Size = new System.Drawing.Size(0, 31);
            this.lbOre.TabIndex = 7;
            this.lbOre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txPick
            // 
            this.txPick.AutoSize = true;
            this.txPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPick.Location = new System.Drawing.Point(7, 9);
            this.txPick.Name = "txPick";
            this.txPick.Size = new System.Drawing.Size(180, 25);
            this.txPick.TabIndex = 9;
            this.txPick.Text = "Pickaxe Equipped: \r\n";
            // 
            // txOre
            // 
            this.txOre.AutoSize = true;
            this.txOre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txOre.Location = new System.Drawing.Point(7, 34);
            this.txOre.Name = "txOre";
            this.txOre.Size = new System.Drawing.Size(115, 25);
            this.txOre.TabIndex = 10;
            this.txOre.Text = "Ore Picked:\r\n";
            // 
            // titalSilver
            // 
            this.titalSilver.AutoSize = true;
            this.titalSilver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titalSilver.Location = new System.Drawing.Point(7, 298);
            this.titalSilver.Name = "titalSilver";
            this.titalSilver.Size = new System.Drawing.Size(164, 25);
            this.titalSilver.TabIndex = 11;
            this.titalSilver.Text = "Silver Ore Mined:";
            // 
            // totalGold
            // 
            this.totalGold.AutoSize = true;
            this.totalGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGold.Location = new System.Drawing.Point(7, 323);
            this.totalGold.Name = "totalGold";
            this.totalGold.Size = new System.Drawing.Size(156, 25);
            this.totalGold.TabIndex = 12;
            this.totalGold.Text = "Gold Ore Mined:";
            // 
            // platinumTotal
            // 
            this.platinumTotal.AutoSize = true;
            this.platinumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platinumTotal.Location = new System.Drawing.Point(7, 348);
            this.platinumTotal.Name = "platinumTotal";
            this.platinumTotal.Size = new System.Drawing.Size(190, 25);
            this.platinumTotal.TabIndex = 13;
            this.platinumTotal.Text = "Platinum Ore Mined:";
            // 
            // cobaltTotal
            // 
            this.cobaltTotal.AutoSize = true;
            this.cobaltTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobaltTotal.Location = new System.Drawing.Point(7, 373);
            this.cobaltTotal.Name = "cobaltTotal";
            this.cobaltTotal.Size = new System.Drawing.Size(172, 25);
            this.cobaltTotal.TabIndex = 14;
            this.cobaltTotal.Text = "Cobalt Ore Mined:";
            // 
            // starTotal
            // 
            this.starTotal.AutoSize = true;
            this.starTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starTotal.Location = new System.Drawing.Point(7, 398);
            this.starTotal.Name = "starTotal";
            this.starTotal.Size = new System.Drawing.Size(188, 25);
            this.starTotal.TabIndex = 15;
            this.starTotal.Text = "Stardust Ore Mined:";
            // 
            // Mine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 434);
            this.Controls.Add(this.starTotal);
            this.Controls.Add(this.cobaltTotal);
            this.Controls.Add(this.platinumTotal);
            this.Controls.Add(this.totalGold);
            this.Controls.Add(this.titalSilver);
            this.Controls.Add(this.txOre);
            this.Controls.Add(this.txPick);
            this.Controls.Add(this.lbOre);
            this.Controls.Add(this.orePicker);
            this.Controls.Add(this.pickPick);
            this.Controls.Add(this.cbOre);
            this.Controls.Add(this.cbPick);
            this.Controls.Add(this.button3);
            this.Name = "Mine";
            this.Text = "Mine";
            this.Load += new System.EventHandler(this.Mine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbPick;
        private System.Windows.Forms.ComboBox cbOre;
        private System.Windows.Forms.Button pickPick;
        private System.Windows.Forms.Button orePicker;
        private System.Windows.Forms.Label lbOre;
        private System.Windows.Forms.Label txPick;
        private System.Windows.Forms.Label txOre;
        private System.Windows.Forms.Label titalSilver;
        private System.Windows.Forms.Label totalGold;
        private System.Windows.Forms.Label platinumTotal;
        private System.Windows.Forms.Label cobaltTotal;
        private System.Windows.Forms.Label starTotal;
    }
}
namespace ClickNFight
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
            this.mineButton = new System.Windows.Forms.Button();
            this.pickaxeComboBox = new System.Windows.Forms.ComboBox();
            this.oreComboBox = new System.Windows.Forms.ComboBox();
            this.pickLabel = new System.Windows.Forms.Label();
            this.oreLabel = new System.Windows.Forms.Label();
            this.oreStatsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mineButton
            // 
            this.mineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineButton.Location = new System.Drawing.Point(243, 152);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(278, 116);
            this.mineButton.TabIndex = 2;
            this.mineButton.Text = "Mine!";
            this.mineButton.UseVisualStyleBackColor = true;
            this.mineButton.Click += new System.EventHandler(this.MineButton_Click);
            // 
            // pickaxeComboBox
            // 
            this.pickaxeComboBox.FormattingEnabled = true;
            this.pickaxeComboBox.Location = new System.Drawing.Point(12, 152);
            this.pickaxeComboBox.Name = "pickaxeComboBox";
            this.pickaxeComboBox.Size = new System.Drawing.Size(225, 21);
            this.pickaxeComboBox.TabIndex = 3;
            this.pickaxeComboBox.SelectedIndexChanged += new System.EventHandler(this.PickaxeComboBox_SelectedIndexChanged);
            // 
            // oreComboBox
            // 
            this.oreComboBox.FormattingEnabled = true;
            this.oreComboBox.Location = new System.Drawing.Point(12, 179);
            this.oreComboBox.Name = "oreComboBox";
            this.oreComboBox.Size = new System.Drawing.Size(225, 21);
            this.oreComboBox.TabIndex = 4;
            this.oreComboBox.SelectedIndexChanged += new System.EventHandler(this.OreComboBox_SelectedIndexChanged);
            // 
            // pickLabel
            // 
            this.pickLabel.AutoSize = true;
            this.pickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickLabel.Location = new System.Drawing.Point(7, 9);
            this.pickLabel.Name = "pickLabel";
            this.pickLabel.Size = new System.Drawing.Size(180, 25);
            this.pickLabel.TabIndex = 9;
            this.pickLabel.Text = "Pickaxe Equipped: \r\n";
            // 
            // oreLabel
            // 
            this.oreLabel.AutoSize = true;
            this.oreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oreLabel.Location = new System.Drawing.Point(7, 34);
            this.oreLabel.Name = "oreLabel";
            this.oreLabel.Size = new System.Drawing.Size(115, 25);
            this.oreLabel.TabIndex = 10;
            this.oreLabel.Text = "Ore Picked:\r\n";
            // 
            // oreStatsLabel
            // 
            this.oreStatsLabel.AutoSize = true;
            this.oreStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oreStatsLabel.Location = new System.Drawing.Point(7, 298);
            this.oreStatsLabel.Name = "oreStatsLabel";
            this.oreStatsLabel.Size = new System.Drawing.Size(164, 25);
            this.oreStatsLabel.TabIndex = 11;
            this.oreStatsLabel.Text = "Silver Ore Mined:";
            // 
            // Mine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 434);
            this.Controls.Add(this.oreStatsLabel);
            this.Controls.Add(this.oreLabel);
            this.Controls.Add(this.pickLabel);
            this.Controls.Add(this.oreComboBox);
            this.Controls.Add(this.pickaxeComboBox);
            this.Controls.Add(this.mineButton);
            this.Name = "Mine";
            this.Text = "Mine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mineButton;
        private System.Windows.Forms.ComboBox pickaxeComboBox;
        private System.Windows.Forms.ComboBox oreComboBox;
        private System.Windows.Forms.Label pickLabel;
        private System.Windows.Forms.Label oreLabel;
        private System.Windows.Forms.Label oreStatsLabel;
    }
}
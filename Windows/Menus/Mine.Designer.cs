namespace ClickNFight.Windows.Menus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mine));
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
            this.mineButton.Location = new System.Drawing.Point(16, 161);
            this.mineButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(435, 143);
            this.mineButton.TabIndex = 2;
            this.mineButton.Text = "Mine!";
            this.mineButton.UseVisualStyleBackColor = true;
            this.mineButton.Click += new System.EventHandler(this.MineButton_Click);
            // 
            // pickaxeComboBox
            // 
            this.pickaxeComboBox.FormattingEnabled = true;
            this.pickaxeComboBox.Location = new System.Drawing.Point(16, 95);
            this.pickaxeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pickaxeComboBox.Name = "pickaxeComboBox";
            this.pickaxeComboBox.Size = new System.Drawing.Size(433, 24);
            this.pickaxeComboBox.TabIndex = 3;
            this.pickaxeComboBox.SelectedIndexChanged += new System.EventHandler(this.PickaxeComboBox_SelectedIndexChanged);
            // 
            // oreComboBox
            // 
            this.oreComboBox.FormattingEnabled = true;
            this.oreComboBox.Location = new System.Drawing.Point(16, 128);
            this.oreComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oreComboBox.Name = "oreComboBox";
            this.oreComboBox.Size = new System.Drawing.Size(433, 24);
            this.oreComboBox.TabIndex = 4;
            this.oreComboBox.SelectedIndexChanged += new System.EventHandler(this.OreComboBox_SelectedIndexChanged);
            // 
            // pickLabel
            // 
            this.pickLabel.AutoSize = true;
            this.pickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickLabel.Location = new System.Drawing.Point(9, 11);
            this.pickLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pickLabel.Name = "pickLabel";
            this.pickLabel.Size = new System.Drawing.Size(230, 29);
            this.pickLabel.TabIndex = 9;
            this.pickLabel.Text = "Pickaxe Equipped: \r\n";
            // 
            // oreLabel
            // 
            this.oreLabel.AutoSize = true;
            this.oreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oreLabel.Location = new System.Drawing.Point(9, 42);
            this.oreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oreLabel.Name = "oreLabel";
            this.oreLabel.Size = new System.Drawing.Size(145, 29);
            this.oreLabel.TabIndex = 10;
            this.oreLabel.Text = "Ore Picked:\r\n";
            // 
            // oreStatsLabel
            // 
            this.oreStatsLabel.AutoSize = true;
            this.oreStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oreStatsLabel.Location = new System.Drawing.Point(9, 322);
            this.oreStatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oreStatsLabel.Name = "oreStatsLabel";
            this.oreStatsLabel.Size = new System.Drawing.Size(208, 29);
            this.oreStatsLabel.TabIndex = 11;
            this.oreStatsLabel.Text = "Silver Ore Mined:";
            // 
            // Mine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 508);
            this.Controls.Add(this.oreStatsLabel);
            this.Controls.Add(this.oreLabel);
            this.Controls.Add(this.pickLabel);
            this.Controls.Add(this.oreComboBox);
            this.Controls.Add(this.pickaxeComboBox);
            this.Controls.Add(this.mineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
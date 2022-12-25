namespace ClickNFight
{
    partial class Inventory
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
            this.potionsTextBox = new System.Windows.Forms.TextBox();
            this.weaponsTextBox = new System.Windows.Forms.TextBox();
            this.runes = new System.Windows.Forms.TextBox();
            this.ores = new System.Windows.Forms.TextBox();
            this.picks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.potionsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.potionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potionsTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.potionsTextBox.Location = new System.Drawing.Point(12, 12);
            this.potionsTextBox.Multiline = true;
            this.potionsTextBox.Name = "potionsTextBox";
            this.potionsTextBox.ReadOnly = true;
            this.potionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.potionsTextBox.Size = new System.Drawing.Size(193, 212);
            this.potionsTextBox.TabIndex = 2;
            this.potionsTextBox.TabStop = false;
            // 
            // neznam
            // 
            this.weaponsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.weaponsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponsTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.weaponsTextBox.Location = new System.Drawing.Point(211, 12);
            this.weaponsTextBox.Multiline = true;
            this.weaponsTextBox.Name = "weaponsTextBox";
            this.weaponsTextBox.ReadOnly = true;
            this.weaponsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.weaponsTextBox.Size = new System.Drawing.Size(216, 212);
            this.weaponsTextBox.TabIndex = 3;
            this.weaponsTextBox.TabStop = false;
            // 
            // runes
            // 
            this.runes.Cursor = System.Windows.Forms.Cursors.Default;
            this.runes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.runes.Location = new System.Drawing.Point(433, 12);
            this.runes.Multiline = true;
            this.runes.Name = "runes";
            this.runes.ReadOnly = true;
            this.runes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.runes.Size = new System.Drawing.Size(216, 212);
            this.runes.TabIndex = 4;
            this.runes.TabStop = false;
            // 
            // ores
            // 
            this.ores.Cursor = System.Windows.Forms.Cursors.Default;
            this.ores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ores.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ores.Location = new System.Drawing.Point(877, 12);
            this.ores.Multiline = true;
            this.ores.Name = "ores";
            this.ores.ReadOnly = true;
            this.ores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ores.Size = new System.Drawing.Size(216, 212);
            this.ores.TabIndex = 5;
            this.ores.TabStop = false;
            // 
            // picks
            // 
            this.picks.Cursor = System.Windows.Forms.Cursors.Default;
            this.picks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picks.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.picks.Location = new System.Drawing.Point(655, 12);
            this.picks.Multiline = true;
            this.picks.Name = "picks";
            this.picks.ReadOnly = true;
            this.picks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.picks.Size = new System.Drawing.Size(216, 212);
            this.picks.TabIndex = 6;
            this.picks.TabStop = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 232);
            this.Controls.Add(this.picks);
            this.Controls.Add(this.ores);
            this.Controls.Add(this.runes);
            this.Controls.Add(this.weaponsTextBox);
            this.Controls.Add(this.potionsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventory";
            this.Text = "Inventory!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox potionsTextBox;
        private System.Windows.Forms.TextBox weaponsTextBox;
        private System.Windows.Forms.TextBox runes;
        private System.Windows.Forms.TextBox ores;
        private System.Windows.Forms.TextBox picks;
    }
}
namespace Idle_Game
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.neznam = new System.Windows.Forms.TextBox();
            this.runes = new System.Windows.Forms.TextBox();
            this.ores = new System.Windows.Forms.TextBox();
            this.picks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(193, 212);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            // 
            // neznam
            // 
            this.neznam.Cursor = System.Windows.Forms.Cursors.Default;
            this.neznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neznam.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.neznam.Location = new System.Drawing.Point(211, 12);
            this.neznam.Multiline = true;
            this.neznam.Name = "neznam";
            this.neznam.ReadOnly = true;
            this.neznam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.neznam.Size = new System.Drawing.Size(216, 212);
            this.neznam.TabIndex = 3;
            this.neznam.TabStop = false;
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
            this.Controls.Add(this.neznam);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventory";
            this.Text = "Inventory!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox neznam;
        private System.Windows.Forms.TextBox runes;
        private System.Windows.Forms.TextBox ores;
        private System.Windows.Forms.TextBox picks;
    }
}
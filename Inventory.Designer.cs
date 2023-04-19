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
            this.runesTextBox = new System.Windows.Forms.TextBox();
            this.oresTextBox = new System.Windows.Forms.TextBox();
            this.picksTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // potionsTextBox
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
            // weaponsTextBox
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
            // runesTextBox
            // 
            this.runesTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.runesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runesTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.runesTextBox.Location = new System.Drawing.Point(433, 12);
            this.runesTextBox.Multiline = true;
            this.runesTextBox.Name = "runesTextBox";
            this.runesTextBox.ReadOnly = true;
            this.runesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.runesTextBox.Size = new System.Drawing.Size(216, 212);
            this.runesTextBox.TabIndex = 4;
            this.runesTextBox.TabStop = false;
            // 
            // oresTextBox
            // 
            this.oresTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.oresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oresTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.oresTextBox.Location = new System.Drawing.Point(877, 12);
            this.oresTextBox.Multiline = true;
            this.oresTextBox.Name = "oresTextBox";
            this.oresTextBox.ReadOnly = true;
            this.oresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.oresTextBox.Size = new System.Drawing.Size(216, 212);
            this.oresTextBox.TabIndex = 5;
            this.oresTextBox.TabStop = false;
            // 
            // picksTextBox
            // 
            this.picksTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.picksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picksTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.picksTextBox.Location = new System.Drawing.Point(655, 12);
            this.picksTextBox.Multiline = true;
            this.picksTextBox.Name = "picksTextBox";
            this.picksTextBox.ReadOnly = true;
            this.picksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.picksTextBox.Size = new System.Drawing.Size(216, 212);
            this.picksTextBox.TabIndex = 6;
            this.picksTextBox.TabStop = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 232);
            this.Controls.Add(this.picksTextBox);
            this.Controls.Add(this.oresTextBox);
            this.Controls.Add(this.runesTextBox);
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
        private System.Windows.Forms.TextBox runesTextBox;
        private System.Windows.Forms.TextBox oresTextBox;
        private System.Windows.Forms.TextBox picksTextBox;
    }
}
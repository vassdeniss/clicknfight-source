namespace Idle_Game
{
    partial class PatchNotes
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
            this.notes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notes
            // 
            this.notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes.Location = new System.Drawing.Point(12, 12);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Size = new System.Drawing.Size(370, 314);
            this.notes.TabIndex = 0;
            this.notes.TabStop = false;
            this.notes.Text = "Release v3.2 is official! \r\n\r\n- Added New Game Updates\r\n- Mining Re-Design\r\n- Bug" +
    " Fixes!\r\n\r\n- More information can be found on the game\'s itch.io page\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open DevLog\r\n(opens in browser)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatchNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PatchNotes";
            this.Text = "Patch Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Button button1;
    }
}
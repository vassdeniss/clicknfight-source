namespace ClickNFight.Windows
{
    partial class Name
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
            this.label6 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.dnoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Please enter name for save:";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(17, 37);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(250, 20);
            this.txName.TabIndex = 13;
            this.txName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dnoe
            // 
            this.dnoe.Location = new System.Drawing.Point(17, 63);
            this.dnoe.Name = "dnoe";
            this.dnoe.Size = new System.Drawing.Size(250, 33);
            this.dnoe.TabIndex = 14;
            this.dnoe.Text = "Done!";
            this.dnoe.UseVisualStyleBackColor = true;
            this.dnoe.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 109);
            this.Controls.Add(this.dnoe);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Name";
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Button dnoe;
    }
}
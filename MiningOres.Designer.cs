namespace Idle_Game
{
    partial class MiningOres
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
            this.oreName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mine = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // oreName
            // 
            this.oreName.AutoSize = true;
            this.oreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oreName.Location = new System.Drawing.Point(30, 9);
            this.oreName.Name = "oreName";
            this.oreName.Size = new System.Drawing.Size(0, 25);
            this.oreName.TabIndex = 24;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 35);
            this.progressBar1.TabIndex = 25;
            // 
            // mine
            // 
            this.mine.Tick += new System.EventHandler(this.mine_Tick);
            // 
            // MiningOres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 90);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.oreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiningOres";
            this.Text = "CampingWood";
            this.Load += new System.EventHandler(this.MiningOres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label oreName;
        public System.Windows.Forms.Timer mine;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}
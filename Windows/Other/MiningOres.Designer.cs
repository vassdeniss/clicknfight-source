namespace ClickNFight.Windows.Other
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiningOres));
            this.oreName = new System.Windows.Forms.Label();
            this.miningBar = new System.Windows.Forms.ProgressBar();
            this.mineTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // oreName
            // 
            this.oreName.AutoSize = true;
            this.oreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oreName.Location = new System.Drawing.Point(40, 11);
            this.oreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oreName.Name = "oreName";
            this.oreName.Size = new System.Drawing.Size(0, 29);
            this.oreName.TabIndex = 24;
            // 
            // miningBar
            // 
            this.miningBar.Location = new System.Drawing.Point(40, 46);
            this.miningBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miningBar.Name = "miningBar";
            this.miningBar.Size = new System.Drawing.Size(436, 43);
            this.miningBar.TabIndex = 25;
            // 
            // mineTimer
            // 
            this.mineTimer.Tick += new System.EventHandler(this.MineTimer_Tick);
            // 
            // MiningOres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 111);
            this.ControlBox = false;
            this.Controls.Add(this.miningBar);
            this.Controls.Add(this.oreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MiningOres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mining...";
            this.Load += new System.EventHandler(this.MiningOres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label oreName;
        public System.Windows.Forms.Timer mineTimer;
        public System.Windows.Forms.ProgressBar miningBar;
    }
}
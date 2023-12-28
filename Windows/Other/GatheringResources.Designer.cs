namespace ClickNFight
{
    partial class GatheringResources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GatheringResources));
            this.gather = new System.Windows.Forms.Label();
            this.gatheringBar = new System.Windows.Forms.ProgressBar();
            this.gatherTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gather
            // 
            this.gather.AutoSize = true;
            this.gather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gather.Location = new System.Drawing.Point(148, 11);
            this.gather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gather.Name = "gather";
            this.gather.Size = new System.Drawing.Size(0, 29);
            this.gather.TabIndex = 24;
            // 
            // gatheringBar
            // 
            this.gatheringBar.Location = new System.Drawing.Point(40, 46);
            this.gatheringBar.Margin = new System.Windows.Forms.Padding(4);
            this.gatheringBar.Name = "gatheringBar";
            this.gatheringBar.Size = new System.Drawing.Size(436, 43);
            this.gatheringBar.TabIndex = 25;
            // 
            // gatherTimer
            // 
            this.gatherTimer.Tick += new System.EventHandler(this.GatherTimer_Tick);
            // 
            // GatheringResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 137);
            this.ControlBox = false;
            this.Controls.Add(this.gatheringBar);
            this.Controls.Add(this.gather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GatheringResources";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gathering...";
            this.Load += new System.EventHandler(this.GatheringResources_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label gather;
        private System.Windows.Forms.Timer gatherTimer;
        public System.Windows.Forms.ProgressBar gatheringBar;
    }
}
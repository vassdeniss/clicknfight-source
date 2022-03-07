namespace ClickNFight
{
    partial class CampingMaterials
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
            this.gather = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gather
            // 
            this.gather.AutoSize = true;
            this.gather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gather.Location = new System.Drawing.Point(111, 9);
            this.gather.Name = "gather";
            this.gather.Size = new System.Drawing.Size(0, 25);
            this.gather.TabIndex = 24;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 35);
            this.progressBar1.TabIndex = 25;
            // 
            // cut
            // 
            this.cut.Tick += new System.EventHandler(this.cut_Tick);
            // 
            // CampingWood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 90);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CampingWood";
            this.Text = "CampingWood";
            this.Load += new System.EventHandler(this.CampingWood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label gather;
        private System.Windows.Forms.Timer cut;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}
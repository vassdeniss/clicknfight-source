namespace Idle_Game
{
    partial class Clicker
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
            this.Exit = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.btUpgrades = new System.Windows.Forms.Button();
            this.click = new System.Windows.Forms.Label();
            this.btClick = new System.Windows.Forms.Button();
            this.passive = new System.Windows.Forms.Label();
            this.passiveTimer = new System.Windows.Forms.Timer(this.components);
            this.warriorTotal = new System.Windows.Forms.Label();
            this.warriorTimer = new System.Windows.Forms.Timer(this.components);
            this.knightTimer = new System.Windows.Forms.Timer(this.components);
            this.knightTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mageTimer = new System.Windows.Forms.Timer(this.components);
            this.wizardTimer = new System.Windows.Forms.Timer(this.components);
            this.mageTotal = new System.Windows.Forms.Label();
            this.wizardTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.AutoSize = true;
            this.Exit.Location = new System.Drawing.Point(360, 209);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(169, 85);
            this.Exit.TabIndex = 62;
            this.Exit.Text = "Exit!";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // load
            // 
            this.load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load.AutoSize = true;
            this.load.Location = new System.Drawing.Point(185, 209);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(169, 85);
            this.load.TabIndex = 57;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.AutoSize = true;
            this.save.Location = new System.Drawing.Point(10, 209);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(169, 85);
            this.save.TabIndex = 56;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // btUpgrades
            // 
            this.btUpgrades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btUpgrades.Location = new System.Drawing.Point(10, 106);
            this.btUpgrades.Name = "btUpgrades";
            this.btUpgrades.Size = new System.Drawing.Size(169, 85);
            this.btUpgrades.TabIndex = 39;
            this.btUpgrades.Text = "Upgrades!";
            this.btUpgrades.UseVisualStyleBackColor = true;
            this.btUpgrades.Click += new System.EventHandler(this.btUpgrades_Click);
            // 
            // click
            // 
            this.click.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.click.AutoSize = true;
            this.click.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click.Location = new System.Drawing.Point(187, 15);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(84, 29);
            this.click.TabIndex = 38;
            this.click.Text = "Clicks:";
            // 
            // btClick
            // 
            this.btClick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btClick.Location = new System.Drawing.Point(10, 15);
            this.btClick.Name = "btClick";
            this.btClick.Size = new System.Drawing.Size(169, 85);
            this.btClick.TabIndex = 36;
            this.btClick.Text = "Click!";
            this.btClick.UseVisualStyleBackColor = true;
            this.btClick.Click += new System.EventHandler(this.btClick_Click);
            // 
            // passive
            // 
            this.passive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passive.AutoSize = true;
            this.passive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passive.Location = new System.Drawing.Point(187, 44);
            this.passive.Name = "passive";
            this.passive.Size = new System.Drawing.Size(0, 29);
            this.passive.TabIndex = 63;
            // 
            // passiveTimer
            // 
            this.passiveTimer.Tick += new System.EventHandler(this.passiveTimer_Tick);
            // 
            // warriorTotal
            // 
            this.warriorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warriorTotal.AutoSize = true;
            this.warriorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warriorTotal.Location = new System.Drawing.Point(187, 73);
            this.warriorTotal.Name = "warriorTotal";
            this.warriorTotal.Size = new System.Drawing.Size(0, 29);
            this.warriorTotal.TabIndex = 64;
            // 
            // warriorTimer
            // 
            this.warriorTimer.Tick += new System.EventHandler(this.warriorTimer_Tick);
            // 
            // knightTimer
            // 
            this.knightTimer.Tick += new System.EventHandler(this.knightTimer_Tick);
            // 
            // knightTotal
            // 
            this.knightTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.knightTotal.AutoSize = true;
            this.knightTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knightTotal.Location = new System.Drawing.Point(187, 101);
            this.knightTotal.Name = "knightTotal";
            this.knightTotal.Size = new System.Drawing.Size(0, 29);
            this.knightTotal.TabIndex = 65;
            // 
            // mageTimer
            // 
            this.mageTimer.Tick += new System.EventHandler(this.mageTimer_Tick);
            // 
            // wizardTimer
            // 
            this.wizardTimer.Tick += new System.EventHandler(this.wizardTimer_Tick);
            // 
            // mageTotal
            // 
            this.mageTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mageTotal.AutoSize = true;
            this.mageTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mageTotal.Location = new System.Drawing.Point(187, 130);
            this.mageTotal.Name = "mageTotal";
            this.mageTotal.Size = new System.Drawing.Size(0, 29);
            this.mageTotal.TabIndex = 66;
            // 
            // wizardTotal
            // 
            this.wizardTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wizardTotal.AutoSize = true;
            this.wizardTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardTotal.Location = new System.Drawing.Point(187, 159);
            this.wizardTotal.Name = "wizardTotal";
            this.wizardTotal.Size = new System.Drawing.Size(0, 29);
            this.wizardTotal.TabIndex = 67;
            // 
            // Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 309);
            this.Controls.Add(this.wizardTotal);
            this.Controls.Add(this.mageTotal);
            this.Controls.Add(this.knightTotal);
            this.Controls.Add(this.warriorTotal);
            this.Controls.Add(this.passive);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.btUpgrades);
            this.Controls.Add(this.click);
            this.Controls.Add(this.btClick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clicker";
            this.Text = "Clicker";
            this.Load += new System.EventHandler(this.Clicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        public System.Windows.Forms.Button btUpgrades;
        private System.Windows.Forms.Label click;
        public System.Windows.Forms.Button btClick;
        private System.Windows.Forms.Label passive;
        private System.Windows.Forms.Timer passiveTimer;
        private System.Windows.Forms.Label warriorTotal;
        private System.Windows.Forms.Timer warriorTimer;
        private System.Windows.Forms.Timer knightTimer;
        private System.Windows.Forms.Label knightTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer mageTimer;
        private System.Windows.Forms.Timer wizardTimer;
        private System.Windows.Forms.Label mageTotal;
        private System.Windows.Forms.Label wizardTotal;
    }
}
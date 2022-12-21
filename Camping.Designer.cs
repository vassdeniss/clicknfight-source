namespace Idle_Game
{
    partial class Camping
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getWood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.getStone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.getFlint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.getSteel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.steelTotal = new System.Windows.Forms.Label();
            this.flintTotal = new System.Windows.Forms.Label();
            this.stoneTotal = new System.Windows.Forms.Label();
            this.woodTotal = new System.Windows.Forms.Label();
            this.woodCooldown = new System.Windows.Forms.Timer(this.components);
            this.stoneCooldown = new System.Windows.Forms.Timer(this.components);
            this.flintCooldown = new System.Windows.Forms.Timer(this.components);
            this.steelCooldown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(427, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 39);
            this.label7.TabIndex = 17;
            this.label7.Text = "Build a camp!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "30 Sticks, 20 Stones, 10 Flint, 5 Steel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gather Wood:";
            // 
            // getWood
            // 
            this.getWood.Location = new System.Drawing.Point(17, 83);
            this.getWood.Name = "getWood";
            this.getWood.Size = new System.Drawing.Size(119, 30);
            this.getWood.TabIndex = 20;
            this.getWood.Text = "Gather!";
            this.getWood.UseVisualStyleBackColor = true;
            this.getWood.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Gather Stone:";
            // 
            // getStone
            // 
            this.getStone.Location = new System.Drawing.Point(17, 169);
            this.getStone.Name = "getStone";
            this.getStone.Size = new System.Drawing.Size(119, 30);
            this.getStone.TabIndex = 22;
            this.getStone.Text = "Gather!";
            this.getStone.UseVisualStyleBackColor = true;
            this.getStone.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Resource Gathering";
            // 
            // getFlint
            // 
            this.getFlint.Location = new System.Drawing.Point(203, 83);
            this.getFlint.Name = "getFlint";
            this.getFlint.Size = new System.Drawing.Size(113, 30);
            this.getFlint.TabIndex = 25;
            this.getFlint.Text = "Gather!";
            this.getFlint.UseVisualStyleBackColor = true;
            this.getFlint.Click += new System.EventHandler(this.getFlint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gather Flint:";
            // 
            // getSteel
            // 
            this.getSteel.Location = new System.Drawing.Point(203, 169);
            this.getSteel.Name = "getSteel";
            this.getSteel.Size = new System.Drawing.Size(122, 30);
            this.getSteel.TabIndex = 27;
            this.getSteel.Text = "Gather!";
            this.getSteel.UseVisualStyleBackColor = true;
            this.getSteel.Click += new System.EventHandler(this.getSteel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Gather Steel:";
            // 
            // steelTotal
            // 
            this.steelTotal.AutoSize = true;
            this.steelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steelTotal.Location = new System.Drawing.Point(12, 308);
            this.steelTotal.Name = "steelTotal";
            this.steelTotal.Size = new System.Drawing.Size(57, 25);
            this.steelTotal.TabIndex = 31;
            this.steelTotal.Text = "Steel";
            // 
            // flintTotal
            // 
            this.flintTotal.AutoSize = true;
            this.flintTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flintTotal.Location = new System.Drawing.Point(12, 283);
            this.flintTotal.Name = "flintTotal";
            this.flintTotal.Size = new System.Drawing.Size(54, 25);
            this.flintTotal.TabIndex = 30;
            this.flintTotal.Text = "Flint:";
            // 
            // stoneTotal
            // 
            this.stoneTotal.AutoSize = true;
            this.stoneTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoneTotal.Location = new System.Drawing.Point(12, 258);
            this.stoneTotal.Name = "stoneTotal";
            this.stoneTotal.Size = new System.Drawing.Size(70, 25);
            this.stoneTotal.TabIndex = 29;
            this.stoneTotal.Text = "Stone:";
            // 
            // woodTotal
            // 
            this.woodTotal.AutoSize = true;
            this.woodTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodTotal.Location = new System.Drawing.Point(12, 233);
            this.woodTotal.Name = "woodTotal";
            this.woodTotal.Size = new System.Drawing.Size(71, 25);
            this.woodTotal.TabIndex = 28;
            this.woodTotal.Text = "Wood:";
            // 
            // woodCooldown
            // 
            this.woodCooldown.Tick += new System.EventHandler(this.woodCooldown_Tick);
            // 
            // stoneCooldown
            // 
            this.stoneCooldown.Tick += new System.EventHandler(this.stoneCooldown_Tick);
            // 
            // steelCooldown
            // 
            this.steelCooldown.Tick += new System.EventHandler(this.steelCooldown_Tick);
            // 
            // Camping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.steelTotal);
            this.Controls.Add(this.flintTotal);
            this.Controls.Add(this.stoneTotal);
            this.Controls.Add(this.woodTotal);
            this.Controls.Add(this.getSteel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getFlint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getStone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getWood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Name = "Camping";
            this.Text = "Camping";
            this.Load += new System.EventHandler(this.Camping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getWood;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getStone;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getFlint;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getSteel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label steelTotal;
        public System.Windows.Forms.Label flintTotal;
        public System.Windows.Forms.Label stoneTotal;
        public System.Windows.Forms.Label woodTotal;
        private System.Windows.Forms.Timer woodCooldown;
        private System.Windows.Forms.Timer stoneCooldown;
        private System.Windows.Forms.Timer flintCooldown;
        private System.Windows.Forms.Timer steelCooldown;
    }
}
namespace ClickNFight
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.buyItemButton = new System.Windows.Forms.Button();
            this.buyFR = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.buyAR = new System.Windows.Forms.Button();
            this.buyWR = new System.Windows.Forms.Button();
            this.buyER = new System.Windows.Forms.Button();
            this.buyMR = new System.Windows.Forms.Button();
            this.buyLR = new System.Windows.Forms.Button();
            this.buyNR = new System.Windows.Forms.Button();
            this.buyElR = new System.Windows.Forms.Button();
            this.buySR = new System.Windows.Forms.Button();
            this.buyRR = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellIngots = new System.Windows.Forms.TextBox();
            this.sellSilver = new System.Windows.Forms.Button();
            this.sellGO = new System.Windows.Forms.Button();
            this.orePickGold = new System.Windows.Forms.NumericUpDown();
            this.orePickSilver = new System.Windows.Forms.NumericUpDown();
            this.orePickPlat = new System.Windows.Forms.NumericUpDown();
            this.sellPO = new System.Windows.Forms.Button();
            this.orePickCob = new System.Windows.Forms.NumericUpDown();
            this.sellCO = new System.Windows.Forms.Button();
            this.orePickStar = new System.Windows.Forms.NumericUpDown();
            this.sellSO = new System.Windows.Forms.Button();
            this.itemPickerComboBox = new System.Windows.Forms.ComboBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orePickGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickPlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickCob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickStar)).BeginInit();
            this.SuspendLayout();
            // 
            // buyItemButton
            // 
            this.buyItemButton.Location = new System.Drawing.Point(828, 229);
            this.buyItemButton.Name = "buyItemButton";
            this.buyItemButton.Size = new System.Drawing.Size(61, 22);
            this.buyItemButton.TabIndex = 12;
            this.buyItemButton.TabStop = false;
            this.buyItemButton.Text = "Buy!";
            this.buyItemButton.UseVisualStyleBackColor = true;
            this.buyItemButton.Click += new System.EventHandler(this.BuyItem_Click);
            // 
            // buyFR
            // 
            this.buyFR.Enabled = false;
            this.buyFR.Location = new System.Drawing.Point(321, 601);
            this.buyFR.Name = "buyFR";
            this.buyFR.Size = new System.Drawing.Size(98, 22);
            this.buyFR.TabIndex = 41;
            this.buyFR.TabStop = false;
            this.buyFR.Text = "Buy!";
            this.buyFR.UseVisualStyleBackColor = true;
            this.buyFR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label27.Location = new System.Drawing.Point(13, 461);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 25);
            this.label27.TabIndex = 39;
            this.label27.Text = "Runes:";
            // 
            // buyAR
            // 
            this.buyAR.Enabled = false;
            this.buyAR.Location = new System.Drawing.Point(321, 501);
            this.buyAR.Name = "buyAR";
            this.buyAR.Size = new System.Drawing.Size(98, 22);
            this.buyAR.TabIndex = 35;
            this.buyAR.TabStop = false;
            this.buyAR.Text = "Buy!";
            this.buyAR.UseVisualStyleBackColor = true;
            this.buyAR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyWR
            // 
            this.buyWR.Enabled = false;
            this.buyWR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buyWR.Location = new System.Drawing.Point(755, 501);
            this.buyWR.Name = "buyWR";
            this.buyWR.Size = new System.Drawing.Size(98, 22);
            this.buyWR.TabIndex = 46;
            this.buyWR.TabStop = false;
            this.buyWR.Text = "Buy!";
            this.buyWR.UseVisualStyleBackColor = true;
            this.buyWR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyER
            // 
            this.buyER.Enabled = false;
            this.buyER.Location = new System.Drawing.Point(321, 721);
            this.buyER.Name = "buyER";
            this.buyER.Size = new System.Drawing.Size(98, 22);
            this.buyER.TabIndex = 51;
            this.buyER.TabStop = false;
            this.buyER.Text = "Buy!";
            this.buyER.UseVisualStyleBackColor = true;
            this.buyER.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyMR
            // 
            this.buyMR.Enabled = false;
            this.buyMR.Location = new System.Drawing.Point(321, 839);
            this.buyMR.Name = "buyMR";
            this.buyMR.Size = new System.Drawing.Size(98, 22);
            this.buyMR.TabIndex = 67;
            this.buyMR.TabStop = false;
            this.buyMR.Text = "Buy!";
            this.buyMR.UseVisualStyleBackColor = true;
            this.buyMR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyLR
            // 
            this.buyLR.Enabled = false;
            this.buyLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.26F);
            this.buyLR.Location = new System.Drawing.Point(755, 601);
            this.buyLR.Name = "buyLR";
            this.buyLR.Size = new System.Drawing.Size(98, 22);
            this.buyLR.TabIndex = 77;
            this.buyLR.TabStop = false;
            this.buyLR.Text = "Buy!";
            this.buyLR.UseVisualStyleBackColor = true;
            this.buyLR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyNR
            // 
            this.buyNR.Enabled = false;
            this.buyNR.Location = new System.Drawing.Point(755, 701);
            this.buyNR.Name = "buyNR";
            this.buyNR.Size = new System.Drawing.Size(98, 22);
            this.buyNR.TabIndex = 82;
            this.buyNR.TabStop = false;
            this.buyNR.Text = "Buy!";
            this.buyNR.UseVisualStyleBackColor = true;
            this.buyNR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyElR
            // 
            this.buyElR.Enabled = false;
            this.buyElR.Location = new System.Drawing.Point(1189, 504);
            this.buyElR.Name = "buyElR";
            this.buyElR.Size = new System.Drawing.Size(98, 22);
            this.buyElR.TabIndex = 87;
            this.buyElR.TabStop = false;
            this.buyElR.Text = "Buy!";
            this.buyElR.UseVisualStyleBackColor = true;
            this.buyElR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buySR
            // 
            this.buySR.Enabled = false;
            this.buySR.Location = new System.Drawing.Point(1189, 601);
            this.buySR.Name = "buySR";
            this.buySR.Size = new System.Drawing.Size(98, 22);
            this.buySR.TabIndex = 92;
            this.buySR.TabStop = false;
            this.buySR.Text = "Buy!";
            this.buySR.UseVisualStyleBackColor = true;
            this.buySR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyRR
            // 
            this.buyRR.Enabled = false;
            this.buyRR.Location = new System.Drawing.Point(1189, 701);
            this.buyRR.Name = "buyRR";
            this.buyRR.Size = new System.Drawing.Size(98, 22);
            this.buyRR.TabIndex = 97;
            this.buyRR.TabStop = false;
            this.buyRR.Text = "Buy!";
            this.buyRR.UseVisualStyleBackColor = true;
            this.buyRR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(19, 498);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(296, 456);
            this.textBox3.TabIndex = 104;
            this.textBox3.TabStop = false;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(434, 498);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(315, 303);
            this.textBox4.TabIndex = 105;
            this.textBox4.TabStop = false;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(868, 501);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(315, 300);
            this.textBox5.TabIndex = 106;
            this.textBox5.TabStop = false;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(429, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 107;
            this.label1.Text = "Mid Level Runes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(863, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 108;
            this.label2.Text = "High Level Runes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(429, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 109;
            this.label3.Text = "Sell:";
            // 
            // sellIngots
            // 
            this.sellIngots.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellIngots.Location = new System.Drawing.Point(434, 56);
            this.sellIngots.Multiline = true;
            this.sellIngots.Name = "sellIngots";
            this.sellIngots.ReadOnly = true;
            this.sellIngots.Size = new System.Drawing.Size(264, 301);
            this.sellIngots.TabIndex = 110;
            this.sellIngots.TabStop = false;
            this.sellIngots.Text = "Silver Ingots\r\nSell Price: 10 Clicks \r\n\r\nGold Ingots\r\nSell Price: 20 Clicks\r\n\r\nPl" +
    "atinum Ingots\r\nSell Price: 30 Clicks\r\n\r\nCobalt Ingots\r\nSell Price: 40 Clicks\r\n\r\n" +
    "Star Ingots\r\nSell Price: 50 Clicks";
            // 
            // sellSilver
            // 
            this.sellSilver.Location = new System.Drawing.Point(721, 85);
            this.sellSilver.Name = "sellSilver";
            this.sellSilver.Size = new System.Drawing.Size(98, 22);
            this.sellSilver.TabIndex = 111;
            this.sellSilver.TabStop = false;
            this.sellSilver.Text = "Sell!";
            this.sellSilver.UseVisualStyleBackColor = true;
            this.sellSilver.Click += new System.EventHandler(this.allSellButtons_Click);
            // 
            // sellGO
            // 
            this.sellGO.Location = new System.Drawing.Point(721, 145);
            this.sellGO.Name = "sellGO";
            this.sellGO.Size = new System.Drawing.Size(98, 22);
            this.sellGO.TabIndex = 112;
            this.sellGO.TabStop = false;
            this.sellGO.Text = "Sell!";
            this.sellGO.UseVisualStyleBackColor = true;
            this.sellGO.Click += new System.EventHandler(this.allSellButtons_Click);
            // 
            // orePickGold
            // 
            this.orePickGold.Location = new System.Drawing.Point(619, 117);
            this.orePickGold.Name = "orePickGold";
            this.orePickGold.Size = new System.Drawing.Size(52, 20);
            this.orePickGold.TabIndex = 116;
            // 
            // orePickSilver
            // 
            this.orePickSilver.Location = new System.Drawing.Point(627, 56);
            this.orePickSilver.Name = "orePickSilver";
            this.orePickSilver.Size = new System.Drawing.Size(52, 20);
            this.orePickSilver.TabIndex = 117;
            // 
            // orePickPlat
            // 
            this.orePickPlat.Location = new System.Drawing.Point(647, 176);
            this.orePickPlat.Name = "orePickPlat";
            this.orePickPlat.Size = new System.Drawing.Size(52, 20);
            this.orePickPlat.TabIndex = 119;
            // 
            // sellPO
            // 
            this.sellPO.Location = new System.Drawing.Point(722, 202);
            this.sellPO.Name = "sellPO";
            this.sellPO.Size = new System.Drawing.Size(98, 22);
            this.sellPO.TabIndex = 120;
            this.sellPO.TabStop = false;
            this.sellPO.Text = "Sell!";
            this.sellPO.UseVisualStyleBackColor = true;
            this.sellPO.Click += new System.EventHandler(this.allSellButtons_Click);
            // 
            // orePickCob
            // 
            this.orePickCob.Location = new System.Drawing.Point(632, 236);
            this.orePickCob.Name = "orePickCob";
            this.orePickCob.Size = new System.Drawing.Size(52, 20);
            this.orePickCob.TabIndex = 122;
            // 
            // sellCO
            // 
            this.sellCO.Location = new System.Drawing.Point(722, 265);
            this.sellCO.Name = "sellCO";
            this.sellCO.Size = new System.Drawing.Size(98, 22);
            this.sellCO.TabIndex = 123;
            this.sellCO.TabStop = false;
            this.sellCO.Text = "Sell!";
            this.sellCO.UseVisualStyleBackColor = true;
            this.sellCO.Click += new System.EventHandler(this.allSellButtons_Click);
            // 
            // orePickStar
            // 
            this.orePickStar.Location = new System.Drawing.Point(612, 295);
            this.orePickStar.Name = "orePickStar";
            this.orePickStar.Size = new System.Drawing.Size(52, 20);
            this.orePickStar.TabIndex = 125;
            // 
            // sellSO
            // 
            this.sellSO.Location = new System.Drawing.Point(722, 321);
            this.sellSO.Name = "sellSO";
            this.sellSO.Size = new System.Drawing.Size(98, 22);
            this.sellSO.TabIndex = 126;
            this.sellSO.TabStop = false;
            this.sellSO.Text = "Sell!";
            this.sellSO.UseVisualStyleBackColor = true;
            this.sellSO.Click += new System.EventHandler(this.allSellButtons_Click);
            // 
            // itemPickerComboBox
            // 
            this.itemPickerComboBox.FormattingEnabled = true;
            this.itemPickerComboBox.Location = new System.Drawing.Point(828, 202);
            this.itemPickerComboBox.Name = "itemPickerComboBox";
            this.itemPickerComboBox.Size = new System.Drawing.Size(134, 21);
            this.itemPickerComboBox.TabIndex = 128;
            this.itemPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemPickerComboBox_SelectedIndexChanged);
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(977, 202);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(266, 172);
            this.itemDescriptionTextBox.TabIndex = 129;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1297, 857);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(this.itemPickerComboBox);
            this.Controls.Add(this.sellSO);
            this.Controls.Add(this.orePickStar);
            this.Controls.Add(this.sellCO);
            this.Controls.Add(this.orePickCob);
            this.Controls.Add(this.sellPO);
            this.Controls.Add(this.orePickPlat);
            this.Controls.Add(this.orePickSilver);
            this.Controls.Add(this.orePickGold);
            this.Controls.Add(this.sellGO);
            this.Controls.Add(this.sellSilver);
            this.Controls.Add(this.sellIngots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buyRR);
            this.Controls.Add(this.buySR);
            this.Controls.Add(this.buyElR);
            this.Controls.Add(this.buyNR);
            this.Controls.Add(this.buyLR);
            this.Controls.Add(this.buyMR);
            this.Controls.Add(this.buyER);
            this.Controls.Add(this.buyWR);
            this.Controls.Add(this.buyFR);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.buyAR);
            this.Controls.Add(this.buyItemButton);
            this.Name = "Shop";
            this.Text = "       ";
            ((System.ComponentModel.ISupportInitialize)(this.orePickGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickPlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickCob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orePickStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.Button buyItemButton;
        public System.Windows.Forms.Button buyFR;
        public System.Windows.Forms.Button buyAR;
        public System.Windows.Forms.Button buyER;
        public System.Windows.Forms.Button buyMR;
        public System.Windows.Forms.Button buyWR;
        public System.Windows.Forms.Button buyLR;
        public System.Windows.Forms.Button buyNR;
        public System.Windows.Forms.Button buyElR;
        public System.Windows.Forms.Button buySR;
        public System.Windows.Forms.Button buyRR;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellIngots;
        public System.Windows.Forms.Button sellSilver;
        public System.Windows.Forms.Button sellGO;
        private System.Windows.Forms.NumericUpDown orePickGold;
        private System.Windows.Forms.NumericUpDown orePickSilver;
        private System.Windows.Forms.NumericUpDown orePickPlat;
        public System.Windows.Forms.Button sellPO;
        private System.Windows.Forms.NumericUpDown orePickCob;
        public System.Windows.Forms.Button sellCO;
        private System.Windows.Forms.NumericUpDown orePickStar;
        public System.Windows.Forms.Button sellSO;
        private System.Windows.Forms.ComboBox itemPickerComboBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
    }
}
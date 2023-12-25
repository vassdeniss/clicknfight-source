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
            this.buyWR = new System.Windows.Forms.Button();
            this.buyLR = new System.Windows.Forms.Button();
            this.buyNR = new System.Windows.Forms.Button();
            this.buyElR = new System.Windows.Forms.Button();
            this.buySR = new System.Windows.Forms.Button();
            this.buyRR = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sellPickNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buyItemPickerComboBox = new System.Windows.Forms.ComboBox();
            this.buyItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.shopTabControl = new System.Windows.Forms.TabControl();
            this.buyTabPage = new System.Windows.Forms.TabPage();
            this.sellTabPage = new System.Windows.Forms.TabPage();
            this.sellItemButton = new System.Windows.Forms.Button();
            this.sellItemPickerComboBox = new System.Windows.Forms.ComboBox();
            this.sellItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellPickNumericUpDown)).BeginInit();
            this.shopTabControl.SuspendLayout();
            this.buyTabPage.SuspendLayout();
            this.sellTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyItemButton
            // 
            this.buyItemButton.Location = new System.Drawing.Point(27, 63);
            this.buyItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyItemButton.Name = "buyItemButton";
            this.buyItemButton.Size = new System.Drawing.Size(355, 27);
            this.buyItemButton.TabIndex = 12;
            this.buyItemButton.TabStop = false;
            this.buyItemButton.Text = "Buy!";
            this.buyItemButton.UseVisualStyleBackColor = true;
            this.buyItemButton.Click += new System.EventHandler(this.BuyItem_Click);
            // 
            // buyWR
            // 
            this.buyWR.Enabled = false;
            this.buyWR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buyWR.Location = new System.Drawing.Point(486, 504);
            this.buyWR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyWR.Name = "buyWR";
            this.buyWR.Size = new System.Drawing.Size(131, 27);
            this.buyWR.TabIndex = 46;
            this.buyWR.TabStop = false;
            this.buyWR.Text = "Buy!";
            this.buyWR.UseVisualStyleBackColor = true;
            this.buyWR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyLR
            // 
            this.buyLR.Enabled = false;
            this.buyLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.26F);
            this.buyLR.Location = new System.Drawing.Point(486, 563);
            this.buyLR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyLR.Name = "buyLR";
            this.buyLR.Size = new System.Drawing.Size(131, 27);
            this.buyLR.TabIndex = 77;
            this.buyLR.TabStop = false;
            this.buyLR.Text = "Buy!";
            this.buyLR.UseVisualStyleBackColor = true;
            this.buyLR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyNR
            // 
            this.buyNR.Enabled = false;
            this.buyNR.Location = new System.Drawing.Point(496, 643);
            this.buyNR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyNR.Name = "buyNR";
            this.buyNR.Size = new System.Drawing.Size(131, 27);
            this.buyNR.TabIndex = 82;
            this.buyNR.TabStop = false;
            this.buyNR.Text = "Buy!";
            this.buyNR.UseVisualStyleBackColor = true;
            this.buyNR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyElR
            // 
            this.buyElR.Enabled = false;
            this.buyElR.Location = new System.Drawing.Point(984, 105);
            this.buyElR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyElR.Name = "buyElR";
            this.buyElR.Size = new System.Drawing.Size(131, 27);
            this.buyElR.TabIndex = 87;
            this.buyElR.TabStop = false;
            this.buyElR.Text = "Buy!";
            this.buyElR.UseVisualStyleBackColor = true;
            this.buyElR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buySR
            // 
            this.buySR.Enabled = false;
            this.buySR.Location = new System.Drawing.Point(984, 224);
            this.buySR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buySR.Name = "buySR";
            this.buySR.Size = new System.Drawing.Size(131, 27);
            this.buySR.TabIndex = 92;
            this.buySR.TabStop = false;
            this.buySR.Text = "Buy!";
            this.buySR.UseVisualStyleBackColor = true;
            this.buySR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // buyRR
            // 
            this.buyRR.Enabled = false;
            this.buyRR.Location = new System.Drawing.Point(984, 347);
            this.buyRR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyRR.Name = "buyRR";
            this.buyRR.Size = new System.Drawing.Size(131, 27);
            this.buyRR.TabIndex = 97;
            this.buyRR.TabStop = false;
            this.buyRR.Text = "Buy!";
            this.buyRR.UseVisualStyleBackColor = true;
            this.buyRR.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(20, 442);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(419, 372);
            this.textBox4.TabIndex = 105;
            this.textBox4.TabStop = false;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(556, 101);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(419, 368);
            this.textBox5.TabIndex = 106;
            this.textBox5.TabStop = false;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(32, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 107;
            this.label1.Text = "Mid Level Runes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(549, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 108;
            this.label2.Text = "High Level Runes:";
            // 
            // sellPickNumericUpDown
            // 
            this.sellPickNumericUpDown.Location = new System.Drawing.Point(389, 62);
            this.sellPickNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellPickNumericUpDown.Name = "sellPickNumericUpDown";
            this.sellPickNumericUpDown.ReadOnly = true;
            this.sellPickNumericUpDown.Size = new System.Drawing.Size(68, 22);
            this.sellPickNumericUpDown.TabIndex = 117;
            // 
            // buyItemPickerComboBox
            // 
            this.buyItemPickerComboBox.FormattingEnabled = true;
            this.buyItemPickerComboBox.Location = new System.Drawing.Point(27, 26);
            this.buyItemPickerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyItemPickerComboBox.Name = "buyItemPickerComboBox";
            this.buyItemPickerComboBox.Size = new System.Drawing.Size(353, 24);
            this.buyItemPickerComboBox.TabIndex = 128;
            this.buyItemPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.BuyItemPickerComboBox_SelectedIndexChanged);
            // 
            // buyItemDescriptionTextBox
            // 
            this.buyItemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buyItemDescriptionTextBox.Location = new System.Drawing.Point(27, 102);
            this.buyItemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyItemDescriptionTextBox.Multiline = true;
            this.buyItemDescriptionTextBox.Name = "buyItemDescriptionTextBox";
            this.buyItemDescriptionTextBox.ReadOnly = true;
            this.buyItemDescriptionTextBox.Size = new System.Drawing.Size(434, 211);
            this.buyItemDescriptionTextBox.TabIndex = 129;
            // 
            // shopTabControl
            // 
            this.shopTabControl.Controls.Add(this.buyTabPage);
            this.shopTabControl.Controls.Add(this.sellTabPage);
            this.shopTabControl.Location = new System.Drawing.Point(16, 15);
            this.shopTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shopTabControl.Name = "shopTabControl";
            this.shopTabControl.SelectedIndex = 0;
            this.shopTabControl.Size = new System.Drawing.Size(492, 356);
            this.shopTabControl.TabIndex = 130;
            // 
            // buyTabPage
            // 
            this.buyTabPage.Controls.Add(this.buyItemButton);
            this.buyTabPage.Controls.Add(this.buyItemPickerComboBox);
            this.buyTabPage.Controls.Add(this.buyItemDescriptionTextBox);
            this.buyTabPage.Location = new System.Drawing.Point(4, 25);
            this.buyTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyTabPage.Name = "buyTabPage";
            this.buyTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyTabPage.Size = new System.Drawing.Size(484, 327);
            this.buyTabPage.TabIndex = 0;
            this.buyTabPage.Text = "Buy";
            this.buyTabPage.UseVisualStyleBackColor = true;
            // 
            // sellTabPage
            // 
            this.sellTabPage.Controls.Add(this.sellItemButton);
            this.sellTabPage.Controls.Add(this.sellItemPickerComboBox);
            this.sellTabPage.Controls.Add(this.sellItemDescriptionTextBox);
            this.sellTabPage.Controls.Add(this.sellPickNumericUpDown);
            this.sellTabPage.Location = new System.Drawing.Point(4, 25);
            this.sellTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellTabPage.Name = "sellTabPage";
            this.sellTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellTabPage.Size = new System.Drawing.Size(484, 327);
            this.sellTabPage.TabIndex = 1;
            this.sellTabPage.Text = "Sell";
            this.sellTabPage.UseVisualStyleBackColor = true;
            // 
            // sellItemButton
            // 
            this.sellItemButton.Location = new System.Drawing.Point(27, 62);
            this.sellItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellItemButton.Name = "sellItemButton";
            this.sellItemButton.Size = new System.Drawing.Size(355, 27);
            this.sellItemButton.TabIndex = 130;
            this.sellItemButton.TabStop = false;
            this.sellItemButton.Text = "Sell!";
            this.sellItemButton.UseVisualStyleBackColor = true;
            this.sellItemButton.Click += new System.EventHandler(this.SellItem_Click);
            // 
            // sellItemPickerComboBox
            // 
            this.sellItemPickerComboBox.FormattingEnabled = true;
            this.sellItemPickerComboBox.Location = new System.Drawing.Point(27, 25);
            this.sellItemPickerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellItemPickerComboBox.Name = "sellItemPickerComboBox";
            this.sellItemPickerComboBox.Size = new System.Drawing.Size(353, 24);
            this.sellItemPickerComboBox.TabIndex = 131;
            this.sellItemPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.SellItemPickerComboBox_SelectedIndexChanged);
            // 
            // sellItemDescriptionTextBox
            // 
            this.sellItemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.sellItemDescriptionTextBox.Location = new System.Drawing.Point(27, 101);
            this.sellItemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellItemDescriptionTextBox.Multiline = true;
            this.sellItemDescriptionTextBox.Name = "sellItemDescriptionTextBox";
            this.sellItemDescriptionTextBox.ReadOnly = true;
            this.sellItemDescriptionTextBox.Size = new System.Drawing.Size(430, 211);
            this.sellItemDescriptionTextBox.TabIndex = 132;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1161, 830);
            this.Controls.Add(this.shopTabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buyRR);
            this.Controls.Add(this.buySR);
            this.Controls.Add(this.buyElR);
            this.Controls.Add(this.buyNR);
            this.Controls.Add(this.buyLR);
            this.Controls.Add(this.buyWR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.sellPickNumericUpDown)).EndInit();
            this.shopTabControl.ResumeLayout(false);
            this.buyTabPage.ResumeLayout(false);
            this.buyTabPage.PerformLayout();
            this.sellTabPage.ResumeLayout(false);
            this.sellTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buyItemButton;
        public System.Windows.Forms.Button buyWR;
        public System.Windows.Forms.Button buyLR;
        public System.Windows.Forms.Button buyNR;
        public System.Windows.Forms.Button buyElR;
        public System.Windows.Forms.Button buySR;
        public System.Windows.Forms.Button buyRR;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sellPickNumericUpDown;
        private System.Windows.Forms.ComboBox buyItemPickerComboBox;
        private System.Windows.Forms.TextBox buyItemDescriptionTextBox;
        private System.Windows.Forms.TabControl shopTabControl;
        private System.Windows.Forms.TabPage buyTabPage;
        private System.Windows.Forms.TabPage sellTabPage;
        public System.Windows.Forms.Button sellItemButton;
        private System.Windows.Forms.ComboBox sellItemPickerComboBox;
        private System.Windows.Forms.TextBox sellItemDescriptionTextBox;
    }
}
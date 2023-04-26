using System;
using System.Media;
using System.Windows.Forms;

using ClickNFight.Items;

namespace ClickNFight
{
    public partial class Shop : Form
    {
        private readonly Hero hero;
        private readonly SoundPlayer soundPlayer;

        public Shop()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.icon;

            this.buyItemDescriptionTextBox.Multiline = true;
            this.buyItemDescriptionTextBox.ReadOnly = true;

            this.soundPlayer = new SoundPlayer(Properties.Resources.coin);
        }

        public Shop(Hero hero)
            : this()
        {
            this.hero = hero;

            foreach (BuyableItem item in this.hero.Inventory.BuyableItems)
            {
                if (!this.hero.Inventory.HasCapacity(item))
                {
                    continue;
                }

                this.buyItemPickerComboBox.Items.Add(item);
            }

            this.buyItemPickerComboBox.DisplayMember = "Name";
            this.buyItemPickerComboBox.Text = "Select an item";

            foreach (SellableItem item in this.hero.Inventory.SellableItems)
            {
                if (!this.hero.Inventory.HasItem(item))
                {
                    continue;
                }

                this.sellItemPickerComboBox.Items.Add(item);
            }

            this.sellItemPickerComboBox.DisplayMember = "Name";
            this.sellItemPickerComboBox.Text = "Select an item";

            this.sellPickNumericUpDown.Minimum = 0;
        }

        private void allButtons_Click(object sender, EventArgs e)
        {
            //else if (button.Equals(buyFR))
            //{
            //    if (Engine.count >= 50)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.fireRunes++;
            //        Engine.count = Engine.count - 50;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyER))
            //{
            //    if (Engine.count >= 50)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.earthRunes++;
            //        Engine.count = Engine.count - 50;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyMR))
            //{
            //    if (Engine.count >= 50)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.mindRunes++;
            //        Engine.count = Engine.count - 50;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyWR))
            //{
            //    if (Engine.count >= 60)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.waterRunes++;
            //        Engine.count = Engine.count - 60;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyLR))
            //{
            //    if (Engine.count >= 60)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.lavaRunes++;
            //        Engine.count = Engine.count - 60;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyNR))
            //{
            //    if (Engine.count >= 60)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.natureRunes++;
            //        Engine.count = Engine.count - 60;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyElR))
            //{
            //    if (Engine.count >= 70)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.electricRunes++;
            //        Engine.count = Engine.count - 70;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buySR))
            //{
            //    if (Engine.count >= 80)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.steamRunes++;
            //        Engine.count = Engine.count - 80;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyRR))
            //{
            //    if (Engine.count >= 80)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.reviveRunes++;
            //        Engine.count = Engine.count - 80;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
        }

        private void BuyItemPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuyableItem item = this.buyItemPickerComboBox.SelectedItem as BuyableItem;
            this.buyItemDescriptionTextBox.Text = item.ShopInformation();
        }

        private void SellItemPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SellableItem item = this.sellItemPickerComboBox.SelectedItem as SellableItem;
            this.sellItemDescriptionTextBox.Text = item.ShopInformation();
            this.sellPickNumericUpDown.Maximum = this.hero.Inventory.GetCount(item);
        }

        private void BuyItem_Click(object sender, EventArgs e)
        {
            if (this.buyItemPickerComboBox.SelectedIndex is -1)
            {
                MessageBox.Show(
                    "Please select an item from the list!",
                    "Warning!",
                    MessageBoxButtons.OK
                );
                return;
            }

            BuyableItem item = this.buyItemPickerComboBox.SelectedItem as BuyableItem;
            if (item is null)
            {
                MessageBox.Show("You cannot buy this item", "Warning!", MessageBoxButtons.OK);
                return;
            }

            if (!this.hero.Inventory.HasCapacity(item))
            {
                MessageBox.Show(
                    "You have reached the items limit",
                    "Warning!",
                    MessageBoxButtons.OK
                );
                return;
            }

            if (!item.CanAfford(hero, out string failMessage))
            {
                MessageBox.Show(failMessage, "Warning!", MessageBoxButtons.OK);
                return;
            }

            this.soundPlayer.Play();
            item.BuyItem(this.hero);
        }

        private void SellItem_Click(object sender, EventArgs e)
        {
            if (this.sellItemPickerComboBox.SelectedIndex is -1)
            {
                MessageBox.Show(
                    "Please select an item from the list!",
                    "Warning!",
                    MessageBoxButtons.OK
                );
                return;
            }

            SellableItem item = this.sellItemPickerComboBox.SelectedItem as SellableItem;
            if (item is null)
            {
                MessageBox.Show("You cannot sell this item", "Warning!", MessageBoxButtons.OK);
                return;
            }

            if (!this.hero.Inventory.HasItem(item))
            {
                MessageBox.Show(
                    "You don't have anyomore of this item to sell",
                    "Warning!",
                    MessageBoxButtons.OK
                );
                return;
            }

            this.soundPlayer.Play();
            item.SellItem(this.hero, (int)this.sellPickNumericUpDown.Value);
        }
    }
}

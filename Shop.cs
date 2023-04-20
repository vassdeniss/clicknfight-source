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

            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.ReadOnly = true;

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

                this.itemPickerComboBox.Items.Add(item);
            }

            this.itemPickerComboBox.DisplayMember = "Name";
            this.itemPickerComboBox.Text = "Select an item";
        }

        private void allButtons_Click(object sender, EventArgs e)
        {
            //else if (button.Equals(buyAR))
            //{
            //    if (Engine.count >= 30)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.airRunes++;
            //        Engine.count = Engine.count - 30;
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

        // Handles all sell buttons

        private void allSellButtons_Click(object sender, EventArgs e)
        {
            Button sell = (Button)sender;

            if (sell.Equals(sellSilver))
            {
                if (Engine.silverOreTake > 0)
                {
                    if (orePickSilver.Value == 0)
                    {
                        var notEnough = MessageBox.Show("Please select how much ingots to sell", "Warning!", MessageBoxButtons.OK);
                    }
                    else if (orePickSilver.Value > Engine.silverOreTake)
                    {
                        var notEnough = MessageBox.Show("You don't have that much ingots to sell!", "Warning!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickSilver.Value * 10;
                        Engine.silverOreTake = Engine.silverOreTake - System.Convert.ToInt32(orePickSilver.Value);
                        Engine.count = Engine.count + System.Convert.ToInt32(profit);
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have anything to sell!", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (sell.Equals(sellGO))
            {
                if (Engine.goldOreTake > 0)
                {
                    if (orePickGold.Value == 0)
                    {
                        var notEnough = MessageBox.Show("Please select how much ingots to sell", "Warning!", MessageBoxButtons.OK);
                    }
                    else if (orePickGold.Value > Engine.goldOreTake)
                    {
                        var notEnough = MessageBox.Show("You don't have that much ingots to sell!", "Warning!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickGold.Value * 20;
                        Engine.goldOreTake = Engine.goldOreTake - System.Convert.ToInt32(orePickGold.Value);
                        Engine.count = Engine.count + System.Convert.ToInt32(profit);
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have anything to sell!", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (sell.Equals(sellPO))
            {
                if (Engine.platinumOreTake > 0)
                {
                    if (orePickPlat.Value == 0)
                    {
                        var notEnough = MessageBox.Show("Please select how much ingots to sell", "Warning!", MessageBoxButtons.OK);
                    }
                    else if (orePickPlat.Value > Engine.platinumOreTake)
                    {
                        var notEnough = MessageBox.Show("You don't have that much ingots to sell!", "Warning!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickPlat.Value * 30;
                        Engine.platinumOreTake = Engine.platinumOreTake - System.Convert.ToInt32(orePickPlat.Value);
                        Engine.count = Engine.count + System.Convert.ToInt32(profit);
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have anything to sell!", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (sell.Equals(sellCO))
            {
                if (Engine.cobaltOreTake > 0)
                {
                    if (orePickCob.Value == 0)
                    {
                        var notEnough = MessageBox.Show("Please select how much ingots to sell", "Warning!", MessageBoxButtons.OK);
                    }
                    else if (orePickCob.Value > Engine.cobaltOreTake)
                    {
                        var notEnough = MessageBox.Show("You don't have that much ingots to sell!", "Warning!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickCob.Value * 40;
                        Engine.cobaltOreTake = Engine.cobaltOreTake - System.Convert.ToInt32(orePickCob.Value);
                        Engine.count = Engine.count + System.Convert.ToInt32(profit);
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have anything to sell!", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (sell.Equals(sellSO))
            {
                if (Engine.starOreTake > 0)
                {
                    if (orePickStar.Value == 0)
                    {
                        var notEnough = MessageBox.Show("Please select how much ingots to sell", "Warning!", MessageBoxButtons.OK);
                    }
                    else if (orePickStar.Value > Engine.starOreTake)
                    {
                        var notEnough = MessageBox.Show("You don't have that much ingots to sell!", "Warning!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = this.orePickStar.Value * 50;
                        Engine.starOreTake = Engine.starOreTake - System.Convert.ToInt32(orePickStar.Value);
                        Engine.count = Engine.count + System.Convert.ToInt32(profit);
                    }
                }
                else
                {
                    MessageBox.Show("You don't have anything to sell!", "Warning!", MessageBoxButtons.OK);
                }
            }
        }

        private void ItemPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = this.itemPickerComboBox.SelectedItem as Item;
            this.itemDescriptionTextBox.Text = item.ShopInformation();
        }

        private void BuyItem_Click(object sender, EventArgs e)
        {
            if (this.itemPickerComboBox.SelectedIndex is -1)
            {
                MessageBox.Show(
                    "Please select an item from the list!",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            BuyableItem item = this.itemPickerComboBox.SelectedItem as BuyableItem;
            if (item is null)
            {
                throw new InvalidOperationException("Item is not buyable!");
            }

            if (!this.hero.Inventory.HasCapacity(item))
            {
                MessageBox.Show("You have reached the items limit",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            if (!item.CanAfford(hero, out string failMessage))
            {
                MessageBox.Show(
                    failMessage,
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            this.soundPlayer.Play();
            item.BuyItem(this.hero);
        }
    }
}

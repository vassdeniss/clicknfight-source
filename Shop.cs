using System;
using System.Management.Instrumentation;
using System.Media;
using System.Windows.Forms;

using ClickNFight.Items;
using ClickNFight.Items.Weapons;

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

            foreach (Item item in this.hero.Inventory.UnlockedItems)
            {
                this.itemPickerComboBox.Items.Add(item);
            }

            this.itemPickerComboBox.DisplayMember = "Name";
            this.itemPickerComboBox.Text = "Select an item";
        }

        private void allButtons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Weapon weapon;
            if (button.Equals(this.buyWoodenSword))
            {
                weapon = new WoodenSword();
                //if (!this.CanAffordWeapon<WoodenSword>())
                //{
                //    return;
                //}

                //this.BuyItem<Weapon>(weapon, this.hero.Weapons);
            }
            else if (button.Equals(this.buyStoneSword))
            {
                weapon = new StoneSword();
                //if (!this.CanAffordWeapon<StoneSword>())
                //{
                //    return;
                //}

                //this.BuyItem<Weapon>(weapon, this.hero.Weapons);
            }
            else if (button.Equals(this.buyIronSword))
            {
                weapon = new IronSword();
                //if (!this.CanAffordWeapon<IronSword>())
                //{
                //    return;
                //}

                this.soundPlayer.Play();

                this.hero.Clickerency -= weapon.BuyPrice;
                //this.hero.Weapons.Add(weapon);

                this.screenUpdate.UpdateUi();

                //if (Engine.ironSword >= 5)
                //{
                //    var limit = MessageBox.Show("You have reached the buy limit", "Warning!", MessageBoxButtons.OK);
                //}
                if (Engine.count >= 350)
                {
                    SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
                    coin.Play();
                    //Engine.ironSword++;
                    Engine.count = Engine.count - 350;
                    if (screenUpdate != null)
                    {
                        screenUpdate.UpdateUi();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (button.Equals(buyDS))
            {
                if (Engine.diamondSword >= 3)
                {
                    var limit = MessageBox.Show("You have reached the buy limit", "Warning!", MessageBoxButtons.OK);
                }
                else if (Engine.count >= 500)
                {
                    SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
                    coin.Play();
                    Engine.diamondSword++;
                    Engine.count = Engine.count - 500;
                    if (screenUpdate != null)
                    {
                        screenUpdate.UpdateUi();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
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
            //else if (button.Equals(buySP))
            //{
            //    if (Engine.count >= 100 && Engine.silverOreTake >= 20 && Engine.silverPick == false)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.silverPick = true;
            //        Engine.count = Engine.count - 100;
            //        Engine.silverOreTake = Engine.silverOreTake - 20;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else if (Engine.silverPick == true)
            //    {
            //        var notEnough = MessageBox.Show("You already have a silver pickaxe!", "Warning!", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyGP))
            //{
            //    if (Engine.count >= 200 && Engine.goldOreTake >= 30 && Engine.goldPick == false)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.goldPick = true;
            //        Engine.count = Engine.count - 200;
            //        Engine.goldOreTake = Engine.goldOreTake - 30;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else if (Engine.goldPick == true)
            //    {
            //        var notEnough = MessageBox.Show("You already have a gold pickaxe!", "Warning!", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyPP))
            //{
            //    if (Engine.count >= 300 && Engine.platinumOreTake >= 40 && Engine.platPick == false)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.platPick = true;
            //        Engine.count = Engine.count - 300;
            //        Engine.platinumOreTake = Engine.platinumOreTake - 40;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else if (Engine.platPick == true)
            //    {
            //        var notEnough = MessageBox.Show("You already have a platinum pickaxe!", "Warning!", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buyCP))
            //{
            //    if (Engine.count >= 400 && Engine.cobaltOreTake >= 50 && Engine.cobPick == false)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.cobPick = true;
            //        Engine.count = Engine.count - 400;
            //        Engine.cobaltOreTake = Engine.cobaltOreTake - 50;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else if (Engine.cobPick == true)
            //    {
            //        var notEnough = MessageBox.Show("You already have a cobalt pickaxe!", "Warning!", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            //    }
            //}
            //else if (button.Equals(buySdP))
            //{
            //    if (Engine.count >= 500 && Engine.starOreTake >= 60 && Engine.starPick == false)
            //    {
            //        SoundPlayer coin = new SoundPlayer(Properties.Resources.coin);
            //        coin.Play();
            //        Engine.starPick = true;
            //        Engine.count = Engine.count - 500;
            //        Engine.starOreTake = Engine.starOreTake - 70;
            //        if (screenUpdate != null)
            //        {
            //            screenUpdate.UpdateUi();
            //        }
            //    }
            //    else if (Engine.starPick == true)
            //    {
            //        var notEnough = MessageBox.Show("You already have a star pickaxe!", "Warning!", MessageBoxButtons.OK);
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
                        if (screenUpdate != null)
                        {
                            screenUpdate.UpdateUi();
                        }
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
                        if (screenUpdate != null)
                        {
                            screenUpdate.UpdateUi();
                        }
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
                        if (screenUpdate != null)
                        {
                            screenUpdate.UpdateUi();
                        }
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
                        if (screenUpdate != null)
                        {
                            screenUpdate.UpdateUi();
                        }
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
                        if (screenUpdate != null)
                        {
                            screenUpdate.UpdateUi();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You don't have anything to sell!", "Warning!", MessageBoxButtons.OK);
                }
            }
        }

        // Interfaces 

        public IUiRefreshers screenUpdate;

        private void ItemPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Use '?'
            Item item = this.itemPickerComboBox.SelectedItem as Item;

            //! Temporary
            if (item is null)
            {
                throw new InstanceNotFoundException();
            }

            this.itemDescriptionTextBox.Text = item.ShopInformation();
        }

        private void BuyItem_click(object sender, EventArgs e)
        {
            if (this.itemPickerComboBox.SelectedIndex is -1)
            {
                MessageBox.Show(
                    "Please select an item from the list!",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            // TODO: Use '?'
            Item item = this.itemPickerComboBox.SelectedItem as Item;

            //! Temporary
            if (item is null)
            {
                throw new InstanceNotFoundException();
            }

            if (this.hero.Clickerency < item.BuyPrice)
            {
                MessageBox.Show("You don't have enough clicks to buy",
                    "Warning!",
                    MessageBoxButtons.OK);
                return;
            }

            this.BuyItem(item);
        }

        private void BuyItem(Item item)
        {
            this.soundPlayer.Play();
            this.hero.Clickerency -= item.BuyPrice;
            this.hero.Inventory.Add(item);
        }

        //private bool CanAffordWeapon<T>()
        //    where T : Weapon, new()
        //{
        //    T genericWeapon = new T();
        //    if (this.hero.Weapons.OfType<T>().Count() > genericWeapon.Limit)
        //    {
        //        MessageBox.Show("You have reached the buy limit",
        //            "Warning!",
        //            MessageBoxButtons.OK);
        //        return false;
        //    }

        //    if (this.hero.Clickerency < genericWeapon.BuyPrice)
        //    {
        //        MessageBox.Show("You don't have enough clicks to buy",
        //            "Warning!",
        //            MessageBoxButtons.OK);
        //        return false;
        //    }

        //    return true;
        //}
    }
}

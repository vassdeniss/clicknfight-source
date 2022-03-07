using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace ClickNFight
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            this.Icon = ClickNFight.Properties.Resources.icon;
        }

        // All button event handlerer but the potions

        private void allButtons_Click(object sender, EventArgs e)
        {

            Button owo = (Button)sender;

            if (owo.Equals(buySword))
            {
                if (Engine.woodenSword >= 10)
                {
                    var limit = MessageBox.Show("You have reached the buy limit", "Warning!", MessageBoxButtons.OK);
                }
                else if (Engine.currency >= 50)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play(); 
                    Engine.woodenSword++;
                    Engine.currency = Engine.currency - 50;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buySW))
            {
                if (Engine.stoneSword >= 7)
                {
                    var limit = MessageBox.Show("You have reached the buy limit", "Warning!", MessageBoxButtons.OK);
                }
                else if (Engine.currency >= 200)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.stoneSword++;
                    Engine.currency = Engine.currency - 200;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyIS))
            {
                if (Engine.ironSword >= 5)
                {
                    var limit = MessageBox.Show("You have reached the buy limit", "Warning!", MessageBoxButtons.OK);
                }
                else if (Engine.currency >= 350)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.ironSword++;
                    Engine.currency = Engine.currency - 350;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyDS))
            {
                if (Engine.diamondSword >= 3)
                {
                    var limit = MessageBox.Show("You have reached the buy limit", "Warning!", MessageBoxButtons.OK);
                }
                else if (Engine.currency >= 500)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.diamondSword++;
                    Engine.currency = Engine.currency - 500;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyAR))
            {
                if (Engine.currency >= 30)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.airRunes++;
                    Engine.currency = Engine.currency - 30;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyFR))
            {
                if (Engine.currency >= 50)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.fireRunes++;
                    Engine.currency = Engine.currency - 50;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyER))
            {
                if (Engine.currency >= 50)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play(); 
                    Engine.earthRunes++;
                    Engine.currency = Engine.currency - 50;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyMR))
            {
                if (Engine.currency >= 50)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.mindRunes++;
                    Engine.currency = Engine.currency - 50;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyWR))
            {
                if (Engine.currency >= 60)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.waterRunes++; 
                    Engine.currency = Engine.currency - 60;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyLR))
            {
                if (Engine.currency >= 60)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.lavaRunes++;
                    Engine.currency = Engine.currency - 60;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyNR))
            {
                if (Engine.currency >= 60)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.natureRunes++;
                    Engine.currency = Engine.currency - 60;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyElR))
            {
                if (Engine.currency >= 70)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.electricRunes++;
                    Engine.currency = Engine.currency - 70;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buySR))
            {
                if (Engine.currency >= 80)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.steamRunes++;
                    Engine.currency = Engine.currency - 80;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyRR))
            {
                if (Engine.currency >= 80)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.reviveRunes++;
                    Engine.currency = Engine.currency - 80;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buySP))
            {
                if (Engine.currency >= 100 && Engine.silverOreTake >= 20 && Engine.silverPick == false)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.silverPick = true;
                    Engine.currency = Engine.currency - 100;
                    Engine.silverOreTake = Engine.silverOreTake - 20;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else if (Engine.silverPick == true)
                {
                    var notEnough = MessageBox.Show("You already have a silver pickaxe!", "Warning!", MessageBoxButtons.OK);
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyGP))
            {
                if (Engine.currency >= 200 && Engine.goldOreTake >= 30 && Engine.goldPick == false)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.goldPick = true;
                    Engine.currency = Engine.currency - 200;
                    Engine.goldOreTake = Engine.goldOreTake - 30;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else if (Engine.goldPick == true)
                {
                    var notEnough = MessageBox.Show("You already have a gold pickaxe!", "Warning!", MessageBoxButtons.OK);
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyPP))
            {
                if (Engine.currency >= 300 && Engine.platinumOreTake >= 40 && Engine.platPick == false)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.platPick = true;
                    Engine.currency = Engine.currency - 300;
                    Engine.platinumOreTake = Engine.platinumOreTake - 40;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else if (Engine.platPick == true)
                {
                    var notEnough = MessageBox.Show("You already have a platinum pickaxe!", "Warning!", MessageBoxButtons.OK);
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buyCP))
            {
                if (Engine.currency >= 400 && Engine.cobaltOreTake >= 50 && Engine.cobPick == false)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.cobPick = true;
                    Engine.currency = Engine.currency - 400;
                    Engine.cobaltOreTake = Engine.cobaltOreTake - 50;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else if (Engine.cobPick == true)
                {
                    var notEnough = MessageBox.Show("You already have a cobalt pickaxe!", "Warning!", MessageBoxButtons.OK);
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (owo.Equals(buySdP))
            {
                if (Engine.currency >= 500 && Engine.starOreTake >= 60 && Engine.starPick == false)
                {
                    SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                    coin.Play();
                    Engine.starPick = true;
                    Engine.currency = Engine.currency - 500;
                    Engine.starOreTake = Engine.starOreTake - 70;
                    if (UpdateScreenInterface != null)
                    {
                        UpdateScreenInterface.UpdadeScreen();
                    }
                }
                else if (Engine.starPick == true)
                {
                    var notEnough = MessageBox.Show("You already have a star pickaxe!", "Warning!", MessageBoxButtons.OK);
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
                }
            }
        }

        private void buyPT_click(object sender, EventArgs e)
        {
            if (Engine.currency >= 15)
            {
                SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                coin.Play();
                Engine.potion++;
                Engine.currency = Engine.currency - 15;
                if (updateNormalPotion != null)
                {
                    updateNormalPotion.UpdateScreenPotion(); 
                }
            }
            else
            {
                var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void buyUHP_Click(object sender, EventArgs e)
        {
            if (Engine.currency >= 30)
            {
                SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                coin.Play();
                Engine.upgradedPotion++;
                Engine.currency = Engine.currency - 30;
                if (updatePotion != null)
                {
                    updatePotion.UpdateScreenUpgradedPotion();
                }
            }
            else
            {
                var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void buySHP_Click(object sender, EventArgs e)
        {
            if (Engine.currency >= 60)
            {
                SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                coin.Play();
                Engine.superPotion++;
                Engine.currency = Engine.currency - 60;
                if (updateSuperPotion != null)
                {
                    updateSuperPotion.UpdateScreenSuperPotion();
                }
            }
            else
            {
                var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            }
        }

        private void buyUUHP_Click(object sender, EventArgs e)
        {
            if (Engine.currency >= 100)
            {
                SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin);
                coin.Play();
                Engine.ultraPotion++;
                Engine.currency = Engine.currency - 100;
                if (updateUltraPotion != null)
                {
                    updateUltraPotion.UpdateScreenUltraPotion();
                }
            }
            else
            {
                var notEnough = MessageBox.Show("You don't have enough clicks to buy", "Warning!", MessageBoxButtons.OK);
            }
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
                        SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickSilver.Value * 10;
                        Engine.silverOreTake = Engine.silverOreTake - System.Convert.ToInt32(orePickSilver.Value);
                        Engine.currency = Engine.currency + System.Convert.ToInt32(profit);
                        if (UpdateScreenInterface != null)
                        {
                            UpdateScreenInterface.UpdadeScreen();
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
                        SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickGold.Value * 20;
                        Engine.goldOreTake = Engine.goldOreTake - System.Convert.ToInt32(orePickGold.Value);
                        Engine.currency = Engine.currency + System.Convert.ToInt32(profit);
                        if (UpdateScreenInterface != null)
                        {
                            UpdateScreenInterface.UpdadeScreen();
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
                        SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickPlat.Value * 30;
                        Engine.platinumOreTake = Engine.platinumOreTake - System.Convert.ToInt32(orePickPlat.Value);
                        Engine.currency = Engine.currency + System.Convert.ToInt32(profit);
                        if (UpdateScreenInterface != null)
                        {
                            UpdateScreenInterface.UpdadeScreen();
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
                        SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickCob.Value * 40;
                        Engine.cobaltOreTake = Engine.cobaltOreTake - System.Convert.ToInt32(orePickCob.Value);
                        Engine.currency = Engine.currency + System.Convert.ToInt32(profit);
                        if (UpdateScreenInterface != null)
                        {
                            UpdateScreenInterface.UpdadeScreen();
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
                        SoundPlayer coin = new SoundPlayer(ClickNFight.Properties.Resources.coin2);
                        coin.Play();
                        decimal profit = orePickStar.Value * 50;
                        Engine.starOreTake = Engine.starOreTake - System.Convert.ToInt32(orePickStar.Value);
                        Engine.currency = Engine.currency + System.Convert.ToInt32(profit);
                        if (UpdateScreenInterface != null)
                        {
                            UpdateScreenInterface.UpdadeScreen();
                        }
                    }
                }
                else
                {
                    var notEnough = MessageBox.Show("You don't have anything to sell!", "Warning!", MessageBoxButtons.OK);
                }
            }
        }

        // Interfaces 

        public Interfaces UpdateScreenInterface;
        public Interfaces updateNormalPotion;
        public Interfaces updatePotion;
        public Interfaces updateSuperPotion;
        public Interfaces updateUltraPotion;
    }
}
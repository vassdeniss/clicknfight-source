using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idle_Game
{
    public partial class ClickerShop : Form
    {
        public ClickerShop()
        {
            InitializeComponent();
            this.Icon = Idle_Game.Properties.Resources.icon;
        }

        private void allBuyButtons_Click(object sender, EventArgs e)
        {
            Button buy = (Button)sender;

            if (buy.Equals(click))
            {
                if (ClickEngine.totalClicks >= ClickEngine.clickersPrice)
                {
                    ClickEngine.totalClicks = ClickEngine.totalClicks - ClickEngine.clickersPrice;
                    ClickEngine.clickers++;
                    double price = 15 * Math.Pow(1.15, ClickEngine.clickers);
                    ClickEngine.clickersPrice = System.Convert.ToInt32(price);
                    clickerPriceText.Text = ClickEngine.clickersPrice.ToString();
                    if (update != null)
                    {
                        update.UpdateUpgrades();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough clicks", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (buy.Equals(warriorBuy))
            {
                if (ClickEngine.totalClicks >= ClickEngine.warriorPrice)
                {
                    ClickEngine.totalClicks = ClickEngine.totalClicks - ClickEngine.warriorPrice;
                    ClickEngine.warrior++;
                    double price = 100 * Math.Pow(1.15, ClickEngine.warrior);
                    ClickEngine.warriorPrice = System.Convert.ToInt32(price);
                    warriorPrice.Text = ClickEngine.warriorPrice.ToString();
                    if (update != null)
                    {
                        update.UpdateUpgrades();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough clicks", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (buy.Equals(knightBuy))
            {
                if (ClickEngine.totalClicks >= ClickEngine.knightPrice)
                {
                    ClickEngine.totalClicks = ClickEngine.totalClicks - ClickEngine.knightPrice;
                    ClickEngine.knight++;
                    double price = 1100 * Math.Pow(1.15, ClickEngine.knight);
                    ClickEngine.knightPrice = System.Convert.ToInt32(price);
                    knightPrice.Text = ClickEngine.knightPrice.ToString();
                    if (update != null)
                    {
                        update.UpdateUpgrades();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough clicks", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (buy.Equals(mageBuy))
            {
                if (ClickEngine.totalClicks >= ClickEngine.magePrice)
                {
                    ClickEngine.totalClicks = ClickEngine.totalClicks - ClickEngine.magePrice;
                    ClickEngine.mage++;
                    double price = 12000 * Math.Pow(1.15, ClickEngine.mage);
                    ClickEngine.magePrice = System.Convert.ToInt32(price);
                    magePrice.Text = ClickEngine.magePrice.ToString();
                    if (update != null)
                    {
                        update.UpdateUpgrades();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough clicks", "Warning!", MessageBoxButtons.OK);
                }
            }
            else if (buy.Equals(wizardBuy))
            {
                if (ClickEngine.totalClicks >= ClickEngine.wizardPrice)
                {
                    ClickEngine.totalClicks = ClickEngine.totalClicks - ClickEngine.wizardPrice;
                    ClickEngine.wizard++;
                    double price = 130000 * Math.Pow(1.15, ClickEngine.wizard);
                    ClickEngine.wizardPrice = System.Convert.ToInt32(price);
                    wizardPrice.Text = ClickEngine.wizardPrice.ToString();
                    if (update != null)
                    {
                        update.UpdateUpgrades();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough clicks", "Warning!", MessageBoxButtons.OK);
                }
            }
        }

        public ClickerInterfaces update;

        private void ClickerShop_Load(object sender, EventArgs e)
        {
            clickerPriceText.Text = ClickEngine.clickersPrice.ToString();
            warriorPrice.Text = ClickEngine.warriorPrice.ToString();
            knightPrice.Text = ClickEngine.knightPrice.ToString();
            magePrice.Text = ClickEngine.magePrice.ToString();
            wizardPrice.Text = ClickEngine.wizardPrice.ToString();
        }
    }
}

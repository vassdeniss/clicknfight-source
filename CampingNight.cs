using System;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class CampingNight : Form
    {
        Random attack = new Random();

        int survive;

        public CampingNight()
        {
            InitializeComponent();
        }

        private void CampingNight_Load(object sender, EventArgs e)
        {
            cut.Interval = 1000;
            cut.Enabled = true;
            progressBar1.Maximum = 60;
            progressBar1.Value = 0;
        }

        private void cut_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                cut.Enabled = false;
                survive = attack.Next(1, 41);
                if (survive <= 20)
                {
                    MessageBox.Show("You survived the night!", "Congratulations!", MessageBoxButtons.OK);
                    var surviveNightHeal = MessageBox.Show("Your health has been restored!", "Congratulations!", MessageBoxButtons.OK);
                    if (surviveNightHeal == DialogResult.OK)
                    {
                        Engine.health = Engine.totalHealth;
                        this.Close();
                    }
                }
                else if (survive > 20)
                {
                    string[] inventoryItems = { "Potion", "Upgraded Potion", "Super Potion", "Ultra Potion", "Air Runes", "Fire Runes", "Earth Runes", 
                        "Mind Runes", "Water Runes", "Lava Runes", "Nature Runes", "Electric Runes", "Steam Runes", "Blood Runes", "Cosmic Runes", "Life Runes", 
                        "Revive Runes", "Wrath Runes", "Astral Runes", "Soul Runes", "Silver", "Gold", "Platinum", "Cobalt", "Star"};

                    var attackedNight = MessageBox.Show("You got attacked!", "Congratulations!", MessageBoxButtons.OK);
                    if (attackedNight == DialogResult.OK)
                    {
                        int tempA, tempB, tempC, take;
                        string a, b, c;

                        tempA = attack.Next(inventoryItems.Length);
                        tempB = attack.Next(inventoryItems.Length);
                        tempC = attack.Next(inventoryItems.Length);

                        a = inventoryItems[tempA];
                        b = inventoryItems[tempB];
                        c = inventoryItems[tempC];

                        while (a == b || b == a)
                        {
                            tempA = attack.Next(inventoryItems.Length);
                            a = inventoryItems[tempA];
                        }

                        while (a == c || c == a)
                        {
                            tempC = attack.Next(inventoryItems.Length);
                            c = inventoryItems[tempC];
                        }

                        while (b == c || c == b)
                        {
                            tempB = attack.Next(inventoryItems.Length);
                            b = inventoryItems[tempB];
                        }

                        if (a == "Potion" || b == "Potion" || c == "Potion")
                        {
                            if (Engine.potion > 0)
                            {
                                take = attack.Next(3, 8);
                                Engine.potion = Engine.potion - take;
                                if (Engine.potion < 0)
                                {
                                    Engine.potion = 0;
                                }
                                MessageBox.Show("You lost " + take + " Potions!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Upgraded Potion" || b == "Upgraded Potion" || c == "Upgraded Potion")
                        {
                            if (Engine.upgradedPotion > 0)
                            {
                                take = attack.Next(3, 8);
                                Engine.upgradedPotion = Engine.upgradedPotion - take;
                                if (Engine.upgradedPotion < 0)
                                {
                                    Engine.upgradedPotion = 0;
                                }
                                MessageBox.Show("You lost " + take + " Upgraded Potions!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Super Potion" || b == "Super Potion" || c == "Super Potion")
                        {
                            if (Engine.superPotion > 0)
                            {
                                take = attack.Next(3, 8);
                                Engine.superPotion = Engine.superPotion - take;
                                if (Engine.superPotion < 0)
                                {
                                    Engine.superPotion = 0;
                                }
                                MessageBox.Show("You lost " + take + " Super Potions!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Ultra Potion" || b == "Ultra Potion" || c == "Ultra Potion")
                        {
                            if (Engine.ultraPotion > 0)
                            {
                                take = attack.Next(3, 8);
                                Engine.ultraPotion = Engine.ultraPotion - take;
                                if (Engine.ultraPotion < 0)
                                {
                                    Engine.ultraPotion = 0;
                                }
                                MessageBox.Show("You lost " + take + " Ultra Potions!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }

                        if (a == "Air Runes" || b == "Air Runes" || c == "Air Runes")
                        {
                            if (Engine.airRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.airRunes = Engine.airRunes - take;
                                if (Engine.airRunes < 0)
                                {
                                    Engine.airRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Air Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Fire Runes" || b == "Fire Runes" || c == "Fire Runes")
                        {
                            if (Engine.fireRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.fireRunes = Engine.fireRunes - take;
                                if (Engine.fireRunes < 0)
                                {
                                    Engine.fireRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Fire Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Earth Runes" || b == "Earth Runes" || c == "Earth Runes")
                        {
                            if (Engine.earthRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.earthRunes = Engine.earthRunes - take;
                                if (Engine.earthRunes < 0)
                                {
                                    Engine.earthRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Earth Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Mind Runes" || b == "Mind Runes" || c == "Mind Runes")
                        {
                            if (Engine.mindRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.mindRunes = Engine.mindRunes - take;
                                if (Engine.mindRunes < 0)
                                {
                                    Engine.mindRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Mind Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Water Runes" || b == "Water Runes" || c == "Water Runes")
                        {
                            if (Engine.waterRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.waterRunes = Engine.waterRunes - take;
                                if (Engine.waterRunes < 0)
                                {
                                    Engine.waterRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Water Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Lava Runes" || b == "Lava Runes" || c == "Lava Runes")
                        {
                            if (Engine.lavaRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.lavaRunes = Engine.earthRunes - take;
                                if (Engine.lavaRunes < 0)
                                {
                                    Engine.lavaRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Lava Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Nature Runes" || b == "Nature Runes" || c == "Nature Runes")
                        {
                            if (Engine.natureRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.natureRunes = Engine.natureRunes - take;
                                if (Engine.natureRunes < 0)
                                {
                                    Engine.natureRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Nature Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Electric Runes" || b == "Electric Runes" || c == "Electric Runes")
                        {
                            if (Engine.electricRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.electricRunes = Engine.electricRunes - take;
                                if (Engine.electricRunes < 0)
                                {
                                    Engine.electricRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Electric Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Steam Runes" || b == "Steam Runes" || c == "Steam Runes")
                        {
                            if (Engine.steamRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.steamRunes = Engine.steamRunes - take;
                                if (Engine.steamRunes < 0)
                                {
                                    Engine.steamRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Steam Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Blood Runes" || b == "Blood Runes" || c == "Blood Runes")
                        {
                            if (Engine.bloodRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.bloodRunes = Engine.bloodRunes - take;
                                if (Engine.bloodRunes < 0)
                                {
                                    Engine.bloodRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Blood Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Cosmic Runes" || b == "Cosmic Runes" || c == "Cosmic Runes")
                        {
                            if (Engine.cosmicRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.cosmicRunes = Engine.cosmicRunes - take;
                                if (Engine.cosmicRunes < 0)
                                {
                                    Engine.cosmicRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Cosmic Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Life Runes" || b == "Life Runes" || c == "Life Runes")
                        {
                            if (Engine.lifeRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.lifeRunes = Engine.lifeRunes - take;
                                if (Engine.lifeRunes < 0)
                                {
                                    Engine.lifeRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Life Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Revive Runes" || b == "Revive Runes" || c == "Revive Runes")
                        {
                            if (Engine.reviveRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.reviveRunes = Engine.reviveRunes - take;
                                if (Engine.reviveRunes < 0)
                                {
                                    Engine.reviveRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Revive Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Wrath Runes" || b == "Wrath Runes" || c == "Wrath Runes")
                        {
                            if (Engine.wrathRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.wrathRunes = Engine.wrathRunes - take;
                                if (Engine.wrathRunes < 0)
                                {
                                    Engine.wrathRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Wrath Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Astral Runes" || b == "Astral Runes" || c == "Astral Runes")
                        {
                            if (Engine.astralRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.astralRunes = Engine.astralRunes - take;
                                if (Engine.astralRunes < 0)
                                {
                                    Engine.astralRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Astral Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Soul Runes" || b == "Soul Runes" || c == "Soul Runes")
                        {
                            if (Engine.soulRunes > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.soulRunes = Engine.soulRunes - take;
                                if (Engine.soulRunes < 0)
                                {
                                    Engine.soulRunes = 0;
                                }
                                MessageBox.Show("You lost " + take + " Soul Runes!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }

                        if (a == "Silver" || b == "Silver" || c == "Silver")
                        {
                            if (Engine.silverOreTake > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.silverOreTake = Engine.silverOreTake - take;
                                if (Engine.silverOreTake < 0)
                                {
                                    Engine.silverOreTake = 0;
                                }
                                MessageBox.Show("You lost " + take + " Silver Ingots!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Gold" || b == "Gold" || c == "Gold")
                        {
                            if (Engine.goldOreTake > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.goldOreTake = Engine.goldOreTake - take;
                                if (Engine.goldOreTake < 0)
                                {
                                    Engine.goldOreTake = 0;
                                }
                                MessageBox.Show("You lost " + take + " Gold Ingots!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Platinum" || b == "Platinum" || c == "Platinum")
                        {
                            if (Engine.platinumOreTake > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.platinumOreTake = Engine.platinumOreTake - take;
                                if (Engine.platinumOreTake < 0)
                                {
                                    Engine.platinumOreTake = 0;
                                }
                                MessageBox.Show("You lost " + take + " Platinum Ingots!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Cobalt" || b == "Cobalt" || c == "Cobalt")
                        {
                            if (Engine.cobaltOreTake > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.cobaltOreTake = Engine.cobaltOreTake - take;
                                if (Engine.cobaltOreTake < 0)
                                {
                                    Engine.cobaltOreTake = 0;
                                }
                                MessageBox.Show("You lost " + take + " Cobalt Ingots!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }
                        if (a == "Star" || b == "Star" || c == "Star")
                        {
                            if (Engine.starOreTake > 0)
                            {
                                take = attack.Next(10, 21);
                                Engine.starOreTake = Engine.starOreTake - take;
                                if (Engine.starOreTake < 0)
                                {
                                    Engine.starOreTake = 0;
                                }
                                MessageBox.Show("You lost " + take + " Star Ingots!", "Congratulations!", MessageBoxButtons.OK);
                            }
                        }

                        int healtLoss = attack.Next(100, 151);
                        Engine.health = Engine.health - healtLoss;
                        MessageBox.Show("You lost " + healtLoss + " Health!", "Congratulations!", MessageBoxButtons.OK);
                        if (updateVitals != null)
                        {
                            updateVitals.UpdateUi(); 
                        }
                        int moneyLoss = attack.Next(200, 501);
                        Engine.count = Engine.count - moneyLoss;
                        MessageBox.Show("You lost " + moneyLoss + " Clicks!", "Congratulations! You are a winner!", MessageBoxButtons.OK);
                        if (updateVitals != null)
                        {
                            updateVitals.UpdateUi();
                        }

                        this.Close();
                    }
                }
            }
        }

        public IUiRefreshers updateVitals;
    }
}

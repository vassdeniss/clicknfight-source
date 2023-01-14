using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ClickNFight.Items;
using ClickNFight.Items.Consumables;
using ClickNFight.Items.Weapons;
using Newtonsoft.Json;
using ConsumablesSettings = ClickNFight.Items.Consumables.ConsumablesSettings;

namespace ClickNFight
{
    public partial class Form1 : Form, IUiRefreshers
    {
        double please;
        string sSourceData;
        byte[] tmpSource, tmpHash;
        string sSourceData2;
        byte[] tmpSource2, tmpNewHash2;
        bool hpCheat = false;
        bool clickCheat = false;
        bool levelCheat = false;
        bool defenceCheat = false;

        private Hero hero;
        private Monster monster;

        // Instances 

        Magic idk = new Magic();
        Crafting runeCrafting = new Crafting();
        Camping camp = new Camping();

        public Form1()
        {
            this.InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.hero = new Hero();
            this.monster = new Monster();

            this.healthBar.Maximum = this.hero.MaxHealth;
            this.UpdateUI();

            this.Icon = Properties.Resources.icon;
            this.KeyPreview = true;
        }

        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.H)
            {
                hpCheat = true;
                if (hpCheat == true)
                {
                    Engine.health = Engine.totalHealth;
                    healthBar.Value = healthBar.Maximum;
                    heroHealthPointsLabel.Text = "HItPoints: " + Engine.health.ToString() + " / " + Engine.totalHealth;
                }
            }
            else if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.C)
            {
                clickCheat = true;
                if (clickCheat == true)
                {
                    Engine.count = Engine.count + 1000;
                    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();
                }
            }
            else if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.L)
            {
                levelCheat = true;
                if (levelCheat == true)
                {
                    Engine.level = 10;
                    levelLabel.Text = "Level: " + Engine.level + "/" + "10";
                    magicMenuButton.Enabled = true;
                    campMenuButton.Enabled = true;
                    mineMenuButton.Enabled = true;
                    runeCraftingButton.Enabled = true;
                }
            }
            else if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.D)
            {
                defenceCheat = true;
                if (defenceCheat == true)
                {
                    Engine.defenceReduction = Engine.defenceReduction + 10;
                    defenceLabel.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                }
            }
        }

        public void UpdateScreenPotion()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenUpgradedPotion()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenSuperPotion()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenUltraPotion()
        {
            throw new NotImplementedException();
        }

        void IUiRefreshers.UpdateUi()
        {
            this.UpdateUI();

            //int defence = 0;

            //clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();

            //monstersSlainLabel.Text = "Monsters Killed: " + Engine.monstersSlain.ToString();

            //defenceLabel.Text = "Defence: " + defence + " (Decreases damage by " + Engine.defenceReduction + ")";

            //string work = "Clicks Per Second: ";
            //please = 1;
            //CPS.Text = work + please;

            //if (Engine.isNewGameClicksOn3 == true)
            //{
            //    string workClicks = "Clicks Per Second: ";
            //    please = 15;
            //    CPS.Text = workClicks + please;
            //    if (Engine.woodenSword > 0)
            //    {
            //        please = Engine.woodenSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.stoneSword > 0)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.ironSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.diamondSword > 0)
            //                {
            //                    Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.excalibur > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                        CPS.Text = work + please;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (Engine.isNewGameClicksOn2 == true)
            //{
            //    string workClicks = "Clicks Per Second: ";
            //    please = 10;
            //    CPS.Text = workClicks + please;
            //    if (Engine.woodenSword > 0)
            //    {
            //        please = Engine.woodenSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.stoneSword > 0)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.ironSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.diamondSword > 0)
            //                {
            //                    Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.excalibur > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                        CPS.Text = work + please;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (Engine.isNewGameClicksOn == true)
            //{
            //    string workClicks = "Clicks Per Second: ";
            //    please = 5;
            //    CPS.Text = workClicks + please;
            //    if (Engine.woodenSword > 0)
            //    {
            //        please = Engine.woodenSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.stoneSword > 0)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.ironSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.diamondSword > 0)
            //                {
            //                    Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.excalibur > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                        CPS.Text = work + please;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (Engine.woodenSword > 0)
            //{
            //    Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
            //    please = Engine.woodenSwordAdd + 1;
            //    CPS.Text = work + please;
            //    if (Engine.stoneSword > 0)
            //    {
            //        Engine.stoneSwordAdd = Engine.stoneSword * 1;
            //        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.ironSword > 0)
            //        {
            //            Engine.ironSwordAdd = Engine.ironSword * 2;
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.diamondSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.excalibur > 0)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                    CPS.Text = work + please;
            //                }
            //            }
            //        }
            //    }
            //}

            //if (Engine.silverSword == true)
            //{
            //    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //    Engine.silverSwordAdd + 1;
            //    CPS.Text = work + please;
            //    if (Engine.goldSword == true)
            //    {
            //        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //        Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.platinumSword == true)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //            Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.cobaltSword == true)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.starSword == true)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                    Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                }
            //            }
            //        }
            //    }
            //}
        }

        public void UpdateScreenHeal()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenHeal2()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenHeal3()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenButton()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenButtonOff()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenNewGame()
        {
            throw new NotImplementedException();
        }

        public void UpdateScreenNewGameClicks()
        {
            throw new NotImplementedException();
        }

        // Updates player hp with heal spells

        //void IUiRefreshers.UpdateScreenHeal()
        //{
        //    healthBar.Maximum = Engine.totalHealth;

        //    try
        //    {
        //        healthBar.Value = healthBar.Value + 10;
        //    }
        //    catch (Exception e11)
        //    {
        //        healthBar.Value = Engine.totalHealth;
        //    }

        //    if (Engine.health > Engine.totalHealth)
        //    {
        //        Engine.health = Engine.totalHealth;
        //    }

        //    heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
        //}

        //public void UpdateScreenHeal2()
        //{
        //    healthBar.Maximum = Engine.totalHealth;

        //    try
        //    {
        //        healthBar.Value = healthBar.Value + 20;
        //    }
        //    catch (Exception e11)
        //    {
        //        healthBar.Value = Engine.totalHealth;
        //    }

        //    if (Engine.health > Engine.totalHealth)
        //    {
        //        Engine.health = Engine.totalHealth;
        //    }

        //    heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
        //}

        //public void UpdateScreenHeal3()
        //{
        //    healthBar.Maximum = Engine.totalHealth;

        //    try
        //    {
        //        healthBar.Value = healthBar.Value + 40;
        //    }
        //    catch (Exception e11)
        //    {
        //        healthBar.Value = Engine.totalHealth;
        //    }

        //    if (Engine.health > Engine.totalHealth)
        //    {
        //        Engine.health = Engine.totalHealth;
        //    }

        //    heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
        //}

        // Updates only the health potion

        //void IUiRefreshers.UpdateScreenPotion()
        //{
        //    potionMenu.Items.Add("Health Potion");

        //    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();
        //}

        // Updates only the upgraded health potion 

        //void IUiRefreshers.UpdateScreenUpgradedPotion()
        //{
        //    potionMenu.Items.Add("Upgraded Health Potion");

        //    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();
        //}

        // Updates only the super health potion 

        //void IUiRefreshers.UpdateScreenSuperPotion()
        //{
        //    potionMenu.Items.Add("Super Health Potion");

        //    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();
        //}

        // Updates only the ultra health potion

        //void IUiRefreshers.UpdateScreenUltraPotion()
        //{
        //    potionMenu.Items.Add("Ultra Health Potion");

        //    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();
        //}

        //void IUiRefreshers.UpdateScreenButton()
        //{
        //    newGameButton.Visible = true;
        //}

        //void IUiRefreshers.UpdateScreenButtonOff()
        //{
        //    newGameButton.Visible = false;
        //    finalBossButton.Enabled = false;
        //    magicMenuButton.Enabled = false;
        //    runeCraftingButton.Enabled = false;
        //    mineMenuButton.Enabled = false;
        //    campMenuButton.Enabled = false;
        //    potionMenu.Items.Clear();
        //    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();

        //    monstersSlainLabel.Text = "Monsters Killed: " + Engine.monstersSlain.ToString();

        //    defenceLabel.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

        //    heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

        //    if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
        //    {
        //        newPlus.Text = "New Game +";
        //        if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
        //        {
        //            newPlus.Text = "New Game ++";
        //            if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
        //            {
        //                newPlus.Text = "New Game +++";
        //            }
        //        }
        //    }

        //    string work = "Clicks Per Second: ";
        //    please = 1;
        //    CPS.Text = work + please;

        //    infoLabel.Text = "";
        //    clickerencyEarnedLabel.Text = "";
        //    levelLabel.Text = "Level: " + Engine.level + "/" + "10";
        //    xpTrackerLabel.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
        //    receivedXpLabel.Text = "";

        //    healthBar.Maximum = Engine.totalHealth;
        //    healthBar.Value = Engine.totalHealth;
        //}

        //void IUiRefreshers.UpdateScreenNewGame()
        //{
        //    newGameButton.Visible = false;
        //    finalBossButton.Enabled = false;
        //    magicMenuButton.Enabled = false;
        //    runeCraftingButton.Enabled = false;
        //    mineMenuButton.Enabled = false;
        //    campMenuButton.Enabled = false;
        //    potionMenu.Items.Clear();
        //    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();

        //    monstersSlainLabel.Text = "Monsters Killed: " + Engine.monstersSlain.ToString();

        //    defenceLabel.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

        //    heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

        //    if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
        //    {
        //        newPlus.Text = "New Game +";
        //        if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
        //        {
        //            newPlus.Text = "New Game ++";
        //            if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
        //            {
        //                newPlus.Text = "New Game +++";
        //            }
        //        }
        //    }

        //    levelLabel.Text = "Level: " + Engine.level + "/" + "10";
        //    xpTrackerLabel.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
        //    receivedXpLabel.Text = "";

        //    string work = "Clicks Per Second: ";
        //    please = 1;
        //    CPS.Text = work + please;

        //    infoLabel.Text = "";
        //    clickerencyEarnedLabel.Text = "";
        //}

        //void IUiRefreshers.UpdateScreenNewGameClicks()
        //{
        //    newGameButton.Visible = false;
        //    finalBossButton.Enabled = false;
        //    magicMenuButton.Enabled = false;
        //    runeCraftingButton.Enabled = false;
        //    mineMenuButton.Enabled = false;
        //    campMenuButton.Enabled = false;
        //    potionMenu.Items.Clear();
        //    clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();

        //    monstersSlainLabel.Text = "Monsters Killed: " + Engine.monstersSlain.ToString();

        //    defenceLabel.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

        //    heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

        //    if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
        //    {
        //        newPlus.Text = "New Game +";
        //        if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
        //        {
        //            newPlus.Text = "New Game ++";
        //            if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
        //            {
        //                newPlus.Text = "New Game +++";
        //            }
        //        }
        //    }

        //    levelLabel.Text = "Level: " + Engine.level + "/" + "10";
        //    xpTrackerLabel.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
        //    receivedXpLabel.Text = "";

        //    string work = "Clicks Per Second: ";
        //    please = 1;
        //    CPS.Text = work + please;


        //    if (Engine.isNewGameClicksOn3 == true)
        //    {
        //        string workClicks = "Clicks Per Second: ";
        //        please = 15;
        //        CPS.Text = workClicks + please;
        //        if (Engine.woodenSword > 0)
        //        {
        //            please = Engine.woodenSwordAdd + 1;
        //            CPS.Text = work + please;
        //            if (Engine.stoneSword > 0)
        //            {
        //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
        //                CPS.Text = work + please;
        //                if (Engine.ironSword > 0)
        //                {
        //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
        //                    CPS.Text = work + please;
        //                    if (Engine.diamondSword > 0)
        //                    {
        //                        Engine.diamondSwordAdd = Engine.diamondSword * 4;
        //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
        //                        CPS.Text = work + please;
        //                        if (Engine.excalibur > 0)
        //                        {
        //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
        //                            CPS.Text = work + please;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else if (Engine.isNewGameClicksOn2 == true)
        //    {
        //        string workClicks = "Clicks Per Second: ";
        //        please = 10;
        //        CPS.Text = workClicks + please;
        //        if (Engine.woodenSword > 0)
        //        {
        //            please = Engine.woodenSwordAdd + 1;
        //            CPS.Text = work + please;
        //            if (Engine.stoneSword > 0)
        //            {
        //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
        //                CPS.Text = work + please;
        //                if (Engine.ironSword > 0)
        //                {
        //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
        //                    CPS.Text = work + please;
        //                    if (Engine.diamondSword > 0)
        //                    {
        //                        Engine.diamondSwordAdd = Engine.diamondSword * 4;
        //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
        //                        CPS.Text = work + please;
        //                        if (Engine.excalibur > 0)
        //                        {
        //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
        //                            CPS.Text = work + please;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else if (Engine.isNewGameClicksOn == true)
        //    {
        //        string workClicks = "Clicks Per Second: ";
        //        please = 5;
        //        CPS.Text = workClicks + please;
        //        if (Engine.woodenSword > 0)
        //        {
        //            please = Engine.woodenSwordAdd + 1;
        //            CPS.Text = work + please;
        //            if (Engine.stoneSword > 0)
        //            {
        //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
        //                CPS.Text = work + please;
        //                if (Engine.ironSword > 0)
        //                {
        //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
        //                    CPS.Text = work + please;
        //                    if (Engine.diamondSword > 0)
        //                    {
        //                        Engine.diamondSwordAdd = Engine.diamondSword * 4;
        //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
        //                        CPS.Text = work + please;
        //                        if (Engine.excalibur > 0)
        //                        {
        //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
        //                            CPS.Text = work + please;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else if (Engine.woodenSword > 0)
        //    {
        //        Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
        //        please = Engine.woodenSwordAdd + 1;
        //        CPS.Text = work + please;
        //        if (Engine.stoneSword > 0)
        //        {
        //            Engine.stoneSwordAdd = Engine.stoneSword * 1;
        //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
        //            CPS.Text = work + please;
        //            if (Engine.ironSword > 0)
        //            {
        //                Engine.ironSwordAdd = Engine.ironSword * 2;
        //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
        //                CPS.Text = work + please;
        //                if (Engine.diamondSword > 0)
        //                {
        //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
        //                    CPS.Text = work + please;
        //                    if (Engine.excalibur > 0)
        //                    {
        //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
        //                        CPS.Text = work + please;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (Engine.silverSword == true)
        //    {
        //        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
        //        Engine.silverSwordAdd + 1;
        //        CPS.Text = work + please;
        //        if (Engine.goldSword == true)
        //        {
        //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
        //            Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
        //            CPS.Text = work + please;
        //            if (Engine.platinumSword == true)
        //            {
        //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
        //                Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
        //                CPS.Text = work + please;
        //                if (Engine.cobaltSword == true)
        //                {
        //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
        //                    Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
        //                    CPS.Text = work + please;
        //                    if (Engine.starSword == true)
        //                    {
        //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
        //                        Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
        //                        CPS.Text = work + please;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    infoLabel.Text = "";
        //    clickerencyEarnedLabel.Text = "";
        //}

        private void BT2_Click(object sender, EventArgs e)
        {
            Shop f2 = new Shop(this.hero);

            f2.buyWoodenSword.Enabled = true;

            //if (Engine.level >= 2)
            //{
            //    f2.buySword.Enabled = true;
            //}

            if (Engine.level >= 3)
            {
                f2.buyStoneSword.Enabled = true;
                f2.buyUPT.Enabled = true;
            }

            if (Engine.level >= 4)
            {
                f2.buySP.Enabled = true;
                f2.buyIronSword.Enabled = true;
            }

            if (Engine.level >= 5)
            {
                f2.buyFR.Enabled = true;
                f2.buyAR.Enabled = true;
                f2.buySHP.Enabled = true;
                f2.buyGP.Enabled = true;
            }

            if (Engine.level >= 6)
            {
                f2.buyER.Enabled = true;
                f2.buyDS.Enabled = true;
                f2.buyMR.Enabled = true;
                f2.buyPP.Enabled = true;
            }

            if (Engine.level >= 7)
            {
                f2.buyWR.Enabled = true;
                f2.buyUUHP.Enabled = true;
                f2.buyLR.Enabled = true;
                f2.buyCP.Enabled = true;
            }

            if (Engine.level >= 8)
            {
                f2.buyNR.Enabled = true;
                f2.buySdP.Enabled = true;
            }

            if (Engine.level >= 9)
            {
                f2.buyElR.Enabled = true;
            }

            if (Engine.level >= 10)
            {
                f2.buySR.Enabled = true;
                f2.buyRR.Enabled = true;
            }

            f2.screenUpdate = this;

            //f2.UpdateScreenInterface = this;
            //f2.updateNormalPotion = this;
            //f2.updatePotion = this;
            //f2.updateSuperPotion = this;
            //f2.updateUltraPotion = this;
            f2.ShowDialog();

            this.UpdateUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idk.owo = this;
            idk.healPlayer = this;
            idk.healPlayer2 = this;
            idk.healPlayer3 = this;

            if (idk.healaraCooldown.Enabled == true || idk.defenceCooldown.Enabled == true || idk.waterCooldown.Enabled == true
                || idk.extraDefenceCooldown.Enabled == true || idk.voltCooldown.Enabled == true || idk.defenceCooldown3.Enabled == true
                || idk.reariseCooldown.Enabled == true)
            {
                idk.ShowDialog();
            }
            else
            {
                if (Engine.level >= 6)
                {
                    idk.defenceUp.Enabled = true;
                    idk.healara.Enabled = true;
                    if (Engine.level >= 7)
                    {
                        idk.waterWave.Enabled = true;
                        idk.exDefence.Enabled = true;
                        if (Engine.level >= 8)
                        {
                            idk.cureraga.Enabled = true;
                            if (Engine.level >= 9)
                            {
                                idk.voltSwtich.Enabled = true;
                                if (Engine.level >= 10)
                                {
                                    idk.maxDefence.Enabled = true;
                                    idk.rearise.Enabled = true;
                                }
                            }
                        }
                    }
                    idk.ShowDialog();
                }
                else idk.ShowDialog();
            }
        }

        private void btCrafting_Click(object sender, EventArgs e)
        {
            if (Engine.level >= 8)
            {
                runeCrafting.craftLR.Enabled = true;
            }

            if (Engine.level >= 9)
            {
                runeCrafting.craftWR.Enabled = true;
            }

            if (Engine.level >= 10)
            {
                runeCrafting.craftSR.Enabled = true;
                runeCrafting.craftSoS.Enabled = true;
            }

            runeCrafting.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Boss boss = new Boss();
            //boss.reward = this;
            //boss.button = this;
            //for (int i = 0; i < potionMenu.Items.Count; i++)
            //{
            //    boss.potionMenu2.Items.Add(potionMenu.Items[i]);
            //}
            //boss.ShowDialog();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            //NewGame newGame = new NewGame();
            //newGame.button = this;
            //newGame.update = this;
            //newGame.newClicks = this;
            //newGame.ShowDialog();
        }

        private void btMine_Click(object sender, EventArgs e)
        {
            Mine mine = new Mine();
            mine.newSwords = this;
            mine.ShowDialog();
        }

        private void btCamp_Click(object sender, EventArgs e)
        {
            CampingNight night = new CampingNight();
            night.updateVitals = this;
            camp.ShowDialog();
        }

        private void HealHero(string potionName)
        {
            Consumable consumable = this.hero.Inventory.Consumables
                .First(c => c.Name == potionName);

            this.hero.Health += consumable.HealAmount;
            this.maxHealthLabel.Visible = false;

            try
            {
                this.healthBar.Value += consumable.HealAmount;
            }
            catch (Exception)
            {
                this.healthBar.Value = this.hero.MaxHealth;
            }

            this.hero.Inventory.Consumables.Remove(consumable);

            SoundPlayer player = new SoundPlayer(Properties.Resources.bottle);
            player.Play();

            this.UpdateUI();
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            if (this.potionMenu.SelectedIndex < 0)
            {
                this.maxHealthLabel.Visible = true;
                this.maxHealthLabel.Text = "You haven't selected a potion to use";
                return;
            }

            string[] potionNameSplit = this.potionMenu.SelectedItem
                .ToString()
                .Split();

            string potionName = string.Join(" ", potionNameSplit.Take(potionNameSplit.Length - 1).ToArray());

            if (this.hero.Health == this.hero.MaxHealth)
            {
                maxHealthLabel.Visible = true;
                maxHealthLabel.Text = "You have maximum health";
            }
            else if (potionName == ConsumablesSettings.PotionName)
            {
                this.HealHero(potionName);
            }
            else if (potionMenu.SelectedItem.ToString() == "Upgraded Health Potion")
            {
                SoundPlayer heal = new SoundPlayer(Properties.Resources.bottle);
                heal.Play();

                Engine.upgradedPotion = Engine.upgradedPotion - 1;
                maxHealthLabel.Visible = false;
                Engine.health = Engine.health + 25;

                try
                {
                    healthBar.Value = healthBar.Value + 25;
                }
                catch (Exception e2)
                {
                    healthBar.Value = Engine.totalHealth;
                }


                if (Engine.health > Engine.totalHealth)
                {
                    Engine.health = Engine.totalHealth;
                }

                heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                potionMenu.Items.Remove(potionMenu.SelectedItem);
            }
            else if (potionMenu.SelectedItem.ToString() == "Super Health Potion")
            {
                SoundPlayer heal = new SoundPlayer(Properties.Resources.bottle);
                heal.Play();

                Engine.superPotion = Engine.superPotion - 1;
                maxHealthLabel.Visible = false;
                Engine.health = Engine.health + 55;

                try
                {
                    healthBar.Value = healthBar.Value + 55;
                }
                catch (Exception e10)
                {
                    healthBar.Value = Engine.totalHealth;
                }

                if (Engine.health > Engine.totalHealth)
                {
                    Engine.health = Engine.totalHealth;
                }

                heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                potionMenu.Items.Remove(potionMenu.SelectedItem);
            }
            else if (potionMenu.SelectedItem.ToString() == "Ultra Health Potion")
            {
                SoundPlayer heal = new SoundPlayer(Properties.Resources.bottle);
                heal.Play();

                Engine.ultraPotion = Engine.ultraPotion - 1;
                maxHealthLabel.Visible = false;
                Engine.health = Engine.health + 115;

                try
                {
                    healthBar.Value = healthBar.Value + 115;
                }
                catch (Exception e10)
                {
                    healthBar.Value = Engine.totalHealth;
                }

                if (Engine.health > Engine.totalHealth)
                {
                    Engine.health = Engine.totalHealth;
                }

                heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                potionMenu.Items.Remove(potionMenu.SelectedItem);
            }
        }

        class Monster
        {
            public Monster()
            {
                this.MinRandomDamage = 0;
                this.MaxRandomDamage = 6;

                this.MinRandomClickerency = 1;
                this.MaxRandomClickerency = 6;
            }

            public int Damage { get; set; }

            public int MinRandomDamage { get; set; }

            public int MaxRandomDamage { get; set; }

            public double ClickerencyDrop { get; set; }

            public int MinRandomClickerency { get; set; }

            public int MaxRandomClickerency { get; set; }
        }

        private string UnlockItems(int level, int hp, int defence, params Item[] items)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"You have leveled up! You are now level {level}!");
            sb.AppendLine("You have unlocked:");
            sb.AppendLine();
            foreach (Item item in items)
            {
                // TODO: test
                sb.AppendLine($"- {item.Name}");
                this.hero.Inventory.UnlockedItems.Add(item);
                //if (!this.hero.UnlockedItems.ContainsKey(item.Name))
                //{
                //    this.hero.UnlockedItems.Add(item.Name, item);
                //}
            }
            sb.AppendLine();
            sb.AppendLine($"+ {hp} Total HP");
            sb.AppendLine($"+ {defence} Total Defence");
            sb.AppendLine();
            sb.AppendLine("Health Restored!");

            return sb.ToString();
        }

        private void LevelUpHero()
        {
            this.hero.Level++;
            this.hero.MaxHealth += 10 * this.hero.Level;
            this.hero.Health = this.hero.MaxHealth;
            this.healthBar.Maximum = this.hero.MaxHealth;
            this.healthBar.Value = this.hero.MaxHealth;
            this.hero.Defence++;
            this.hero.DefenceReduction++;
            this.hero.CurrentXp = 0;
            this.hero.TotalXp += 50;

            this.monster.MinRandomDamage += 6;
            this.monster.MaxRandomDamage += 6;

            this.monster.MaxRandomClickerency += 6;

            // TODO: this can be done better
            switch (this.hero.Level)
            {
                case 2:
                    MessageBox.Show(
                        this.UnlockItems(this.hero.Level, 10, 1, new WoodenSword()),
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    //this.hero.UnlockedItems.Add(new WoodenSword());
                    //MessageBox.Show(
                    //    "You have leveled up! You are now level 2!\nYou have unlocked:\n\n- Wooden Sword\n\n+ 10 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                    //    "Congratulations!",
                    //    MessageBoxButtons.OK);
                    break;
                case 3:
                    //this.hero.UnlockedItems.Add(new StoneSword());
                    //this.hero.UnlockedItems.Add(new UpgradedHealthPotion());
                    MessageBox.Show(
                        "You have leveled up! You are now level 3!\nYou have unlocked:\n\n- Mining!\n- Stone Sword\n- Upgraded Health Potion\n\n+ 20 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    this.mineMenuButton.Enabled = true;
                    break;
                case 4:
                    MessageBox.Show("You have leveled up! You are now level 4!\nYou have unlocked:\n\n- Silver Pickaxe\n- Gold Ore!\n- Iron Sword\n\n+ 30 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    break;
                case 5:
                    MessageBox.Show("You have leveled up! You are now level 5\nYou have unlocked:\n\n- Golden Pickaxe\n- Magic\n- Air Runes\n- Fire Runes\n- Super Health Potion\n\n+ 40 Total HP\n+ 1 Total Defence\n\nHealth Restored!", 
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    this.magicMenuButton.Enabled = true;
                    break;
                case 6:
                    MessageBox.Show("You have leveled up! You are now level 6!\nYou have unlocked:\n\n- Camping\n- Platinum Pickaxe\n- Defence Up spell!\n- Earth Runes\n- Healara spell!\n- Mind Runes\n- Diamond Sword\n\n+ 50 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    this.campMenuButton.Enabled = true;
                    break;
                case 7:
                    MessageBox.Show("You have leveled up! You are now level 7!\nYou have unlocked:\n\n- Rune Crafting\n- Cobalt Pickaxe\n- Water Wave Spell!\n- Water Runes\n- Extra Defence Spell\n- Cosmic Runes\n- Lava Runes\n- Ultra Health Potion\n\n+ 60 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    this.runeCraftingButton.Enabled = true;
                    break;
                case 8:
                    MessageBox.Show("You have leveled up! You are now level 8!\nYou have unlocked:\n\n- Star Pickaxe\n- Cureraga Spell\n- Nature Runes\n- Life Runes\n\n+ 70 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    break;
                case 9:
                    MessageBox.Show("You have leveled up! You are now level 9!\nYou have unlocked:\n\n- Volt Switch Spell\n- Electric Runes\n- Wrath Runes\n\n+ 80 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    break;
                case 10:
                    MessageBox.Show("You have leveled up! You are now level 10!\nYou have unlocked:\n\n- Max Defence Spell!\n- Steam Runes!\n- Astral Runes!\n- ReArise Spell!\n- Revive Runes!\n- Soul Runes!\n\n+ 90 Total HP\n+ 1 Total Defence\n\nHealth Restored!",
                        "Congratulations!",
                        MessageBoxButtons.OK);
                    this.finalBossButton.Enabled = true;
                    break;
            }
        }

        private void UpdateUI()
        {
            this.heroHealthPointsLabel.Text = $"HitPoints: {this.hero.Health} / {this.hero.MaxHealth}";
            this.healthBar.Value = this.hero.Health;
            this.defenceLabel.Text = $"Defence: {this.hero.Defence} (Decreases Damage By {this.hero.DefenceReduction})";
            this.CPS.Text = $"Clicks Per Second: {this.hero.Cps}";
            this.levelLabel.Text = $"Level: {this.hero.Level} / 10"; // TODO: for now
            this.xpTrackerLabel.Text = $"XP: {this.hero.CurrentXp} / {this.hero.TotalXp}";
            this.clickerencyLabel.Text = $"Clickerency: {this.hero.Clickerency}";
            this.monstersSlainLabel.Text = $"Monsters Slain: {this.hero.MonstersSlain}";

            this.maxHealthLabel.Visible = false;

            this.potionMenu.Items.Clear();
            foreach (Consumable consumable in this.hero.Inventory.Consumables)
            {
                this.potionMenu.Items.Add($"{consumable.Name} {consumable.HealAmount}");
            }

            this.potionMenu.Text = "Select Potion";
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            Random statRandomizer = new Random();

            this.monster.Damage = statRandomizer.Next(
                this.monster.MinRandomDamage,
                this.monster.MaxRandomDamage);

            this.monster.ClickerencyDrop = statRandomizer.Next(
                this.monster.MinRandomClickerency,
                this.monster.MaxRandomClickerency);

            // TODO: reduce monster damage by heros defence

            #region More Werid Logic
            //newDamage = Engine.damage - Engine.defenceReduction;
            //if (newDamage < 0)
            //{
            //    newDamage = 0;
            //}

            // TODO: ???
            //Engine.count = Engine.count + Engine.money;

            //if (Engine.isBossDead == true)
            //{
            //    Engine.damage = 0;
            //    newDamage = 0;
            //}

            //if (Engine.damage == 0)
            //{
            //    Engine.health = Engine.health - Engine.damage;
            //}
            //else if (Engine.damage > 0)
            //{
            //    Engine.health = Engine.health - newDamage;
            //}
            #endregion

            this.hero.Clickerency += this.monster.ClickerencyDrop;
            this.hero.Health -= this.monster.Damage;
            if (this.hero.Health <= 0)
            {
                this.hero.Health = 0;

                this.UpdateUI();

                Death gameOver = new Death();
                gameOver.ShowDialog();
            }

            string multipleDamageReceived = this.monster.Damage == 1 ? "point" : "points";
            this.infoLabel.Text =
                $"You have suffered {this.monster.Damage} {multipleDamageReceived} of damage";

            string multipleClickerencyEarned = this.monster.ClickerencyDrop == 1 ? "click" : "clicks";
            this.clickerencyEarnedLabel.Text
                = $"You got {this.monster.ClickerencyDrop} {multipleClickerencyEarned} from that monster";

            double xpMultiplier = 1;
            foreach (Weapon weapon in this.hero.Inventory.Weapons)
            {
                xpMultiplier += weapon.DamageMultiplier;
            }

            //Engine.ironSwordAdd = Engine.ironSword * 2;
            //Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //Engine.count2 = Engine.count2 + Engine.stoneSwordAdd;
            //Engine.count2 = Engine.count2 + Engine.ironSwordAdd;
            //Engine.count2 = Engine.count2 + Engine.diamondSwordAdd;
            //Engine.count2 = Engine.count2 + Engine.excaliburAdd;
            //Engine.count2 = Engine.count2 + Engine.fireboltAdd;
            //Engine.count2 = Engine.count2 + Engine.waterwaveAdd;
            //Engine.count2 = Engine.count2 + Engine.voltswtichAdd;
            //Engine.count2 = Engine.count2 + Engine.newgameAdd;
            //Engine.count2 = Engine.count2 + Engine.silverSwordAdd;
            //Engine.count2 = Engine.count2 + Engine.goldSwordAdd;
            //Engine.count2 = Engine.count2 + Engine.platinumSwordAdd;
            //Engine.count2 = Engine.count2 + Engine.cobaltSwordAdd;
            //Engine.count2 = Engine.count2 + Engine.starSwordAdd;

            Random xpRandomizer = new Random();
            int randomXp = xpRandomizer.Next(1, 6);

            int receivedXp = randomXp * (int)Math.Ceiling(xpMultiplier);

            this.hero.CurrentXp += receivedXp;
            this.hero.MonstersSlain += xpMultiplier;

            this.receivedXpLabel.Text = $"You gained {receivedXp} XP from that monster";

            // TODO: update correctly
            #region Weird New Game Display Logic

            //string work = "Clicks Per Second: ";
            //please = 1;
            //CPS.Text = work + please;

            //if (Engine.isNewGameClicksOn3 == true)
            //{
            //    string workClicks = "Clicks Per Second: ";
            //    please = 15;
            //    CPS.Text = workClicks + please;
            //    if (Engine.woodenSword > 0)
            //    {
            //        please = Engine.woodenSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.stoneSword > 0)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.ironSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.diamondSword > 0)
            //                {
            //                    Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.excalibur > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                        CPS.Text = work + please;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (Engine.isNewGameClicksOn2 == true)
            //{
            //    string workClicks = "Clicks Per Second: ";
            //    please = 10;
            //    CPS.Text = workClicks + please;
            //    if (Engine.woodenSword > 0)
            //    {
            //        please = Engine.woodenSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.stoneSword > 0)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.ironSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.diamondSword > 0)
            //                {
            //                    Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.excalibur > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                        CPS.Text = work + please;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (Engine.isNewGameClicksOn == true)
            //{
            //    string workClicks = "Clicks Per Second: ";
            //    please = 5;
            //    CPS.Text = workClicks + please;
            //    if (Engine.woodenSword > 0)
            //    {
            //        please = Engine.woodenSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.stoneSword > 0)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.ironSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.diamondSword > 0)
            //                {
            //                    Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.excalibur > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                        CPS.Text = work + please;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (Engine.woodenSword > 0)
            //{
            //    Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
            //    please = Engine.woodenSwordAdd + 1;
            //    CPS.Text = work + please;
            //    if (Engine.stoneSword > 0)
            //    {
            //        Engine.stoneSwordAdd = Engine.stoneSword * 1;
            //        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.ironSword > 0)
            //        {
            //            Engine.ironSwordAdd = Engine.ironSword * 2;
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.diamondSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.excalibur > 0)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                    CPS.Text = work + please;
            //                }
            //            }
            //        }
            //    }
            //}

            //if (Engine.silverSword == true)
            //{
            //    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //    Engine.silverSwordAdd + 1;
            //    CPS.Text = work + please;
            //    if (Engine.goldSword == true)
            //    {
            //        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //        Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
            //        CPS.Text = work + please;
            //        if (Engine.platinumSword == true)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //            Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.cobaltSword == true)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.starSword == true)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                    Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                }
            //            }
            //        }
            //    }
            //}

            #endregion

            if (this.hero.CurrentXp >= this.hero.TotalXp)
            {
                this.LevelUpHero();
            }

            this.UpdateUI();
        }

        // Refactored
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(this.hero);
            inventory.ShowDialog();
        }

        // Refactored
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure? Any unsaved progress will be lost!",
                "Warning!",
                MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] 

            //if (Engine.name == "GCND" || )

            //if (Engine.name == "GCND")
            //{
            //    nameSave.Text = Engine.name + "'s Save";
            //    easterAndrej.Visible = true;
            //}
            //else if (Engine.name == "Green Cyborg Ninja Dude")
            //{
            //    nameSave.Text = Engine.name + "'s Save";
            //    easterAndrej.Visible = true;
            //}
            //else if (Engine.name == "Andrej")
            //{
            //    nameSave.Text = Engine.name + "'s Save";
            //    easterAndrej.Visible = true;
            //}
            //else if (Engine.name == "Green")
            //{
            //    nameSave.Text = Engine.name + "'s Save";
            //    easterAndrej.Visible = true;
            //}
            //else
            //{
            //    nameSave.Text = Engine.name + "'s Save";
            //}

            this.nameSave.Text = $"{Engine.name}'s Save";

            CPS.Text = "Clicks Per Second: 1";

            #region Dev Tools
            //if (Engine.devTools == true)
            //{
            //    magicMenuButton.Enabled = true;
            //    Engine.level = 9;
            //    Engine.monstersSlain = 99;
            //    Engine.airRunes = 100;
            //    Engine.fireRunes = 100;
            //    Engine.mindRunes = 100;
            //    Engine.waterRunes = 100;
            //    Engine.bloodRunes = 100;
            //    Engine.count = 500;
            //    Engine.cosmicRunes = 100;
            //    Engine.earthRunes = 100;
            //    Engine.lavaRunes = 100;
            //    Engine.lifeRunes = 100;
            //    Engine.natureRunes = 100;
            //    runeCraftingButton.Enabled = true;
            //    Engine.wrathRunes = 100;
            //    Engine.electricRunes = 100;
            //    Engine.steamRunes = 100;
            //    Engine.astralRunes = 100;
            //    Engine.reviveRunes = 100;
            //    Engine.soulRunes = 100;
            //    finalBossButton.Enabled = true;
            //    Engine.woodenSword = 10;
            //    Engine.stoneSword = 7;
            //    Engine.ironSword = 5;
            //    Engine.diamondSword = 3000;
            //    Engine.excalibur = 1;
            //    Engine.excaliburAdd = 999;
            //    Engine.isBossDead = true;
            //    Engine.stoneSword = 10;
            //    mineMenuButton.Enabled = true;
            //    campMenuButton.Enabled = true;
            //    Engine.silverPick = true;
            //    Engine.goldPick = true;
            //    Engine.platPick = true;
            //    Engine.cobPick = true;
            //    Engine.starPick = true;
            //    Engine.health = 1000;
            //    Engine.silverOreTotal = 99;
            //    Engine.wood = 300;
            //    Engine.flint = 300;
            //    Engine.stone = 300;
            //    Engine.steel = 300;
            //    Engine.silverOreTake = 300;
            //    Engine.goldOreTake = 300;
            //    Engine.starOreTake = 300;
            //    Engine.ultraPotion = 300;
            //    Engine.fireRunes = 300;
            //    Engine.lifeRunes = 300;
            //    Engine.potion = 300;
            //    Engine.airRunes = 300;
            //    Engine.woodenSword = 2;
            //    newGameButton.Visible = true;
            //}
            #endregion
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            #region Save Logic
            //var confirmResult = MessageBox.Show("This will overwrite the previous save! Are you sure you want to save?", "Warning!", MessageBoxButtons.YesNo);

            //if (confirmResult == DialogResult.Yes)
            //{
            //    Engine.items = new string[potionMenu.Items.Count];
            //    for (int i = 0; i < potionMenu.Items.Count; i++)
            //    {
            //        Engine.items[i] = potionMenu.Items[i].ToString();
            //    }

            //    saving save = new saving
            //    {
            //        level = Engine.level,
            //        count = Engine.count,
            //        count2 = Engine.monstersSlain,
            //        count3 = Engine.count3,
            //        money = Engine.money,
            //        health = Engine.health,
            //        defence = Engine.defence,
            //        defenceReduction = Engine.defenceReduction,
            //        totalHealth = Engine.totalHealth,
            //        damage = Engine.damage,
            //        woodenSword = Engine.woodenSword,
            //        stoneSword = Engine.stoneSword,
            //        ironSword = Engine.ironSword,
            //        diamondSword = Engine.diamondSword,
            //        excalibur = Engine.excalibur,
            //        woodenSwordAdd = Engine.woodenSwordAdd,
            //        stoneSwordAdd = Engine.stoneSwordAdd,
            //        ironSwordAdd = Engine.ironSwordAdd,
            //        diamondSwordAdd = Engine.diamondSwordAdd,
            //        excaliburAdd = Engine.excaliburAdd,
            //        fireboltAdd = Engine.fireboltAdd,
            //        waterwaveAdd = Engine.waterwaveAdd,
            //        voltswtichAdd = Engine.voltswtichAdd,
            //        potion = Engine.potion,
            //        upgradedPotion = Engine.upgradedPotion,
            //        superPotion = Engine.superPotion,
            //        ultraPotion = Engine.ultraPotion,
            //        airRunes = Engine.airRunes,
            //        fireRunes = Engine.fireRunes,
            //        earthRunes = Engine.earthRunes,
            //        mindRunes = Engine.mindRunes,
            //        waterRunes = Engine.waterRunes,
            //        lavaRunes = Engine.lavaRunes,
            //        natureRunes = Engine.natureRunes,
            //        electricRunes = Engine.electricRunes,
            //        steamRunes = Engine.steamRunes,
            //        bloodRunes = Engine.bloodRunes,
            //        cosmicRunes = Engine.cosmicRunes,
            //        lifeRunes = Engine.lifeRunes,
            //        reviveRunes = Engine.reviveRunes,
            //        wrathRunes = Engine.wrathRunes,
            //        astralRunes = Engine.astralRunes,
            //        soulRunes = Engine.soulRunes,
            //        isBossDead = Engine.isBossDead,
            //        bar = healthBar.Value,
            //        barMaximum = healthBar.Maximum,
            //        items = Engine.items,
            //        buttonOn = newGameButton.Visible,
            //        isNewGameOn = Engine.isNewGameOn,
            //        isNewGameClicksOn = Engine.isNewGameClicksOn,
            //        newgameAdd = Engine.newgameAdd,
            //        isNewGameDefenceOn = Engine.isNewGameDefenceOn,
            //        FinalBoss = finalBossButton.Enabled,
            //        Magic = magicMenuButton.Enabled,
            //        Runes = runeCrafting.Enabled,
            //        Mine = mineMenuButton.Enabled,
            //        silverOreTake = Engine.silverOreTake,
            //        silverOreTotal = Engine.silverOreTotal,
            //        goldOreTake = Engine.goldOreTake,
            //        goldOreTotal = Engine.goldOreTotal,
            //        silverPick = Engine.silverPick,
            //        goldPick = Engine.goldPick,
            //        platOreTake = Engine.platinumOreTake,
            //        platOreTotal = Engine.platinumOreTotal,
            //        platPick = Engine.platPick,
            //        cobaltOreTake = Engine.cobaltOreTake,
            //        cobaltOreTotal = Engine.cobaltOreTotal,
            //        cobPick = Engine.cobPick,
            //        starOreTake = Engine.starOreTake,
            //        starOreTotal = Engine.starOreTotal,
            //        name = Engine.name,
            //        starPick = Engine.starPick,
            //        btCamp = campMenuButton.Enabled,
            //        XP = Engine.XP,
            //        totalXP = Engine.totalXP,
            //        silverSword = Engine.silverSword,
            //        goldSword = Engine.goldSword,
            //        platinumSword = Engine.platinumSword,
            //        cobaltSword = Engine.cobaltSword,
            //        starSword = Engine.starSword,
            //        silverSwordAdd = Engine.silverSwordAdd,
            //        goldSwordAdd = Engine.goldSwordAdd,
            //        platinumSwordAdd = Engine.platinumSwordAdd,
            //        cobaltSwordAdd = Engine.cobaltSwordAdd,
            //        starSwordAdd = Engine.starSwordAdd,
            //        wood = Engine.wood,
            //        stone = Engine.stone,
            //        flint = Engine.flint,
            //        steel = Engine.steel,
            //        isNewGameOn2 = Engine.isNewGameOn2,
            //        isNewGameDefenceOn2 = Engine.isNewGameDefenceOn2,
            //        isNewGameClicksOn2 = Engine.isNewGameClicksOn2,
            //        isNewGameOn3 = Engine.isNewGameOn3,
            //        isNewGameDefenceOn3 = Engine.isNewGameDefenceOn3,
            //        isNewGameClicksOn3 = Engine.isNewGameClicksOn3
            //    };

            //    string JSONsave = JsonConvert.SerializeObject(save);
            //    string directoryPath = string.Format(@"Saves\", Application.StartupPath);
            //    string path = String.Format(@"{0}\Saves\" + Engine.name + "'s Save.json", Application.StartupPath);
            //    string path2 = String.Format(@"{0}\Saves\" + Engine.name + "'s MD5Hash.txt", Application.StartupPath);

            //    DirectoryInfo saves = Directory.CreateDirectory(directoryPath);

            //    if (File.Exists(path))
            //    {
            //        File.Delete(path);
            //        using (var tw = new StreamWriter(path, true))
            //        {
            //            tw.WriteLine(JSONsave.ToString());
            //            tw.Close();
            //        }
            //    }
            //    else if (!File.Exists(path))
            //    {
            //        using (var tw = new StreamWriter(path, true))
            //        {
            //            tw.WriteLine(JSONsave.ToString());
            //            tw.Close();
            //        }
            //    }

            //    sSourceData = String.Format(path);
            //    tmpSource = File.ReadAllBytes(sSourceData);
            //    tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            //    int j;
            //    StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            //    for (j = 0; j < tmpHash.Length; j++)
            //    {
            //        sOutput.Append(tmpHash[j].ToString("X2"));
            //    }

            //    if (File.Exists(path2))
            //    {
            //        File.Delete(path2);
            //        using (var tw = new StreamWriter(path2, true))
            //        {
            //            tw.WriteLine(sOutput.ToString());
            //            tw.Close();
            //        }
            //    }
            //    else if (!File.Exists(path2))
            //    {
            //        using (var tw = new StreamWriter(path2, true))
            //        {
            //            tw.WriteLine(sOutput.ToString());
            //            tw.Close();
            //        }
            //    }

            //    string path3 = String.Format(@"{0}\Saves\" + Engine.name + "'s MD5Hash.txt", Application.StartupPath);
            //    File.SetAttributes(path3, File.GetAttributes(path3) | FileAttributes.Hidden);
            //}

            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            #region Load Logic
            //bool bEqual = false;
            //string path = String.Format(@"{0}\Saves\" + Engine.name + "'s Save.json", Application.StartupPath);

            //try
            //{
            //    sSourceData2 = String.Format(path);
            //    tmpSource2 = File.ReadAllBytes(sSourceData2);
            //    tmpNewHash2 = new MD5CryptoServiceProvider().ComputeHash(tmpSource2);

            //    int j;
            //    StringBuilder sOutput2 = new StringBuilder(tmpNewHash2.Length);
            //    for (j = 0; j < tmpNewHash2.Length; j++)
            //    {
            //        sOutput2.Append(tmpNewHash2[j].ToString("X2"));
            //    }

            //    string md5 = "";
            //    string path2 = String.Format(@"{0}\Saves\" + Engine.name + "'s MD5Hash.txt", Application.StartupPath);

            //    using (var tw = new StreamReader(path2, true))
            //    {
            //        md5 = tw.ReadToEnd();
            //        tw.Close();
            //    }

            //    int k;
            //    StringBuilder result = new StringBuilder(md5.Length);
            //    for (k = 0; k < md5.Length - 2; k++)
            //    {
            //        result.Append(md5[k].ToString());
            //    }

            //    if (sOutput2.Length == result.Length)
            //    {
            //        int i = 0;
            //        while ((i < sOutput2.Length) && (sOutput2[i] == result[i]))
            //        {
            //            i += 1;
            //        }
            //        if (i == sOutput2.Length)
            //        {
            //            bEqual = true;
            //        }
            //    }

            //    var confirmResult = MessageBox.Show("Are you sure you want to load your saved game? Any unsaved progress will be lost!", "Warning!", MessageBoxButtons.YesNo);

            //    if (confirmResult == DialogResult.Yes && bEqual == true)
            //    {
            //        string json = "";
            //        string path3 = String.Format(@"{0}\Saves\" + Engine.name + "'s Save.json", Application.StartupPath);
            //        using (var tw = new StreamReader(path3, true))
            //        {
            //            json = tw.ReadToEnd();
            //            tw.Close();
            //        }
            //        saving load = JsonConvert.DeserializeObject<saving>(json);

            //        Engine.level = load.level;
            //        Engine.count = load.count;
            //        Engine.monstersSlain = load.count2;
            //        Engine.count3 = load.count3;
            //        Engine.money = load.money;
            //        Engine.health = load.health;
            //        Engine.defence = load.defence;
            //        Engine.defenceReduction = load.defenceReduction;
            //        Engine.totalHealth = load.totalHealth;
            //        Engine.damage = load.damage;
            //        Engine.woodenSword = load.woodenSword;
            //        Engine.stoneSword = load.stoneSword;
            //        Engine.ironSword = load.ironSword;
            //        Engine.diamondSword = load.diamondSword;
            //        Engine.excalibur = load.excalibur;
            //        Engine.woodenSwordAdd = load.woodenSwordAdd;
            //        Engine.stoneSwordAdd = load.stoneSwordAdd;
            //        Engine.ironSwordAdd = load.ironSwordAdd;
            //        Engine.diamondSwordAdd = load.diamondSwordAdd;
            //        Engine.excaliburAdd = load.excaliburAdd;
            //        Engine.fireboltAdd = load.fireboltAdd;
            //        Engine.waterwaveAdd = load.waterwaveAdd;
            //        Engine.voltswtichAdd = load.voltswtichAdd;
            //        Engine.potion = load.potion;
            //        Engine.upgradedPotion = load.upgradedPotion;
            //        Engine.superPotion = load.superPotion;
            //        Engine.ultraPotion = load.ultraPotion;
            //        Engine.airRunes = load.airRunes;
            //        Engine.fireRunes = load.fireRunes;
            //        Engine.earthRunes = load.earthRunes;
            //        Engine.mindRunes = load.mindRunes;
            //        Engine.waterRunes = load.waterRunes;
            //        Engine.lavaRunes = load.lavaRunes;
            //        Engine.natureRunes = load.natureRunes;
            //        Engine.electricRunes = load.electricRunes;
            //        Engine.steamRunes = load.steamRunes;
            //        Engine.bloodRunes = load.bloodRunes;
            //        Engine.cosmicRunes = load.cosmicRunes;
            //        Engine.lifeRunes = load.lifeRunes;
            //        Engine.reviveRunes = load.reviveRunes;
            //        Engine.wrathRunes = load.wrathRunes;
            //        Engine.astralRunes = load.astralRunes;
            //        Engine.soulRunes = load.soulRunes;
            //        Engine.isBossDead = load.isBossDead;
            //        Engine.isNewGameOn = load.isNewGameOn;
            //        Engine.isNewGameDefenceOn = load.isNewGameDefenceOn;
            //        Engine.isNewGameDefenceOn2 = load.isNewGameDefenceOn2;
            //        Engine.isNewGameDefenceOn3 = load.isNewGameDefenceOn3;
            //        Engine.isNewGameOn2 = load.isNewGameOn2;
            //        Engine.isNewGameOn3 = load.isNewGameOn3;
            //        Engine.isNewGameClicksOn = load.isNewGameClicksOn;
            //        Engine.isNewGameClicksOn2 = load.isNewGameClicksOn2;
            //        Engine.isNewGameClicksOn3 = load.isNewGameClicksOn3;
            //        if (Engine.isNewGameOn == true)
            //        {
            //            healthBar.Maximum = 220;
            //            healthBar.Value = 220;
            //        }
            //        if (Engine.isNewGameOn2 == true)
            //        {
            //            healthBar.Maximum = Engine.totalHealth;
            //            healthBar.Value = Engine.totalHealth;
            //        }
            //        if (Engine.isNewGameOn3 == true)
            //        {
            //            healthBar.Maximum = Engine.totalHealth;
            //            healthBar.Value = Engine.totalHealth;
            //        }
            //        healthBar.Maximum = load.barMaximum;
            //        healthBar.Value = load.bar;
            //        Engine.items = load.items;
            //        newGameButton.Visible = load.buttonOn;
            //        Engine.newgameAdd = load.newgameAdd;
            //        finalBossButton.Enabled = load.FinalBoss;
            //        magicMenuButton.Enabled = load.Magic;
            //        runeCrafting.Enabled = load.Runes;
            //        mineMenuButton.Enabled = load.Mine;
            //        Engine.silverOreTake = load.silverOreTake;
            //        Engine.silverOreTotal = load.silverOreTotal;
            //        Engine.goldOreTake = load.goldOreTake;
            //        Engine.goldOreTotal = load.goldOreTotal;
            //        Engine.silverPick = load.silverPick;
            //        Engine.goldPick = load.goldPick;
            //        Engine.platinumOreTake = load.platOreTake;
            //        Engine.platinumOreTotal = load.platOreTotal;
            //        Engine.platPick = load.platPick;
            //        Engine.cobaltOreTotal = load.cobaltOreTotal;
            //        Engine.cobaltOreTake = load.cobaltOreTake;
            //        Engine.cobPick = load.cobPick;
            //        Engine.starOreTake = load.starOreTake;
            //        Engine.starOreTotal = load.starOreTotal;
            //        Engine.name = load.name;
            //        Engine.starPick = load.starPick;
            //        campMenuButton.Enabled = load.btCamp;
            //        Engine.XP = load.XP;
            //        Engine.totalXP = load.totalXP;
            //        Engine.silverSword = load.silverSword;
            //        Engine.goldSword = load.goldSword;
            //        Engine.platinumSword = load.platinumSword;
            //        Engine.cobaltSword = load.cobaltSword;
            //        Engine.starSword = load.starSword;
            //        Engine.silverSwordAdd = load.silverSwordAdd;
            //        Engine.goldSwordAdd = load.goldSwordAdd;
            //        Engine.platinumSwordAdd = load.platinumSwordAdd;
            //        Engine.cobaltSwordAdd = load.cobaltSwordAdd;
            //        Engine.starSwordAdd = load.starSwordAdd;
            //        Engine.wood = load.wood;
            //        Engine.stone = load.stone;
            //        Engine.steel = load.steel;
            //        Engine.flint = load.flint;

            //        for (int i = 0; i < Engine.items.Length; i++)
            //        {
            //            potionMenu.Items.Add(Engine.items[i]);
            //        }

            //        clickerencyLabel.Text = "Clickerency: " + Engine.count.ToString();

            //        monstersSlainLabel.Text = "Monsters Killed: " + Engine.monstersSlain.ToString();

            //        defenceLabel.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

            //        heroHealthPointsLabel.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

            //        levelLabel.Text = "Level: " + Engine.level + "/" + "10";

            //        xpTrackerLabel.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;

            //        if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
            //        {
            //            newPlus.Text = "New Game +";
            //            if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
            //            {
            //                newPlus.Text = "New Game ++";
            //                if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
            //                {
            //                    newPlus.Text = "New Game +++";
            //                }
            //            }
            //        }


            //        string work = "Clicks Per Second: ";
            //        please = 1;
            //        CPS.Text = work + please;

            //        if (Engine.isNewGameClicksOn3 == true)
            //        {
            //            string workClicks = "Clicks Per Second: ";
            //            please = 15;
            //            CPS.Text = workClicks + please;
            //            if (Engine.woodenSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.stoneSword > 0)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.ironSword > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                        CPS.Text = work + please;
            //                        if (Engine.diamondSword > 0)
            //                        {
            //                            Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                            CPS.Text = work + please;
            //                            if (Engine.excalibur > 0)
            //                            {
            //                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                                CPS.Text = work + please;
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        else if (Engine.isNewGameClicksOn2 == true)
            //        {
            //            string workClicks = "Clicks Per Second: ";
            //            please = 10;
            //            CPS.Text = workClicks + please;
            //            if (Engine.woodenSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.stoneSword > 0)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.ironSword > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                        CPS.Text = work + please;
            //                        if (Engine.diamondSword > 0)
            //                        {
            //                            Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                            CPS.Text = work + please;
            //                            if (Engine.excalibur > 0)
            //                            {
            //                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                                CPS.Text = work + please;
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        else if (Engine.isNewGameClicksOn == true)
            //        {
            //            string workClicks = "Clicks Per Second: ";
            //            please = 5;
            //            CPS.Text = workClicks + please;
            //            if (Engine.woodenSword > 0)
            //            {
            //                please = Engine.woodenSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.stoneSword > 0)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.ironSword > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                        CPS.Text = work + please;
            //                        if (Engine.diamondSword > 0)
            //                        {
            //                            Engine.diamondSwordAdd = Engine.diamondSword * 4;
            //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                            CPS.Text = work + please;
            //                            if (Engine.excalibur > 0)
            //                            {
            //                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                                CPS.Text = work + please;
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        else if (Engine.woodenSword > 0)
            //        {
            //            Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
            //            please = Engine.woodenSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.stoneSword > 0)
            //            {
            //                Engine.stoneSwordAdd = Engine.stoneSword * 1;
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.ironSword > 0)
            //                {
            //                    Engine.ironSwordAdd = Engine.ironSword * 2;
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.diamondSword > 0)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
            //                        CPS.Text = work + please;
            //                        if (Engine.excalibur > 0)
            //                        {
            //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
            //                            CPS.Text = work + please;
            //                        }
            //                    }
            //                }
            //            }
            //        }

            //        if (Engine.silverSword == true)
            //        {
            //            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //            Engine.silverSwordAdd + 1;
            //            CPS.Text = work + please;
            //            if (Engine.goldSword == true)
            //            {
            //                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
            //                CPS.Text = work + please;
            //                if (Engine.platinumSword == true)
            //                {
            //                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                    Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
            //                    CPS.Text = work + please;
            //                    if (Engine.cobaltSword == true)
            //                    {
            //                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                        Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
            //                        CPS.Text = work + please;
            //                        if (Engine.starSword == true)
            //                        {
            //                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
            //                            Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
            //                            CPS.Text = work + please;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    else if (confirmResult == DialogResult.Yes && bEqual == false)
            //    {
            //        MessageBox.Show("Save has been tampered with!" + "\r\n" + "Save cannot be loaded." + "\r\n" + "Why cheat?", "Error!", MessageBoxButtons.OK);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No save file detected!", "Warning!", MessageBoxButtons.OK);
            //}
            #endregion
        }
    }
}

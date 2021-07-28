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
using System.Runtime.InteropServices;
using System.Media;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;

namespace Idle_Game
{
    public partial class Form1 : Form, Interfaces
    {
        double please;
        double newDamage;
        string sSourceData;
        byte[] tmpSource, tmpHash, tmpNewHash;
        string sSourceData2;
        byte[] tmpSource2, tmpHash2, tmpNewHash2;
        bool hpCheat = false;
        bool clickCheat = false;
        bool levelCheat = false;
        bool defenceCheat = false;

        // Instances 

        Magic idk = new Magic();
        Shop f2 = new Shop();
        Crafting runeCrafting = new Crafting();
        Camping camp = new Camping();

        // Instances 

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public Form1()
        {
            InitializeComponent();
            this.Icon = Idle_Game.Properties.Resources.icon;
            this.KeyPreview = true;
            label5.Text = "HItPoints: " + Engine.health.ToString() + " / " + Engine.totalHealth;
            defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
            healthBar.Maximum = 100 + 100;
            healthBar.Value = healthBar.Maximum;
            levelText.Text = "Level: " + Engine.level + "/" + "10";
            xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
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
                    label5.Text = "HItPoints: " + Engine.health.ToString() + " / " + Engine.totalHealth;
                }
            }
            else if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.C)
            {
                clickCheat = true;
                if (clickCheat == true)
                {
                    Engine.count = Engine.count + 1000;
                    LB1.Text = "Clickerency: " + Engine.count.ToString();
                }
            }
            else if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.L)
            {
                levelCheat = true;
                if (levelCheat == true)
                {
                    Engine.level = 10;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    btMagic.Enabled = true;
                    btCamp.Enabled = true;
                    btMine.Enabled = true;
                    btCrafting.Enabled = true;
                }
            }
            else if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.D)
            {
                defenceCheat = true;
                if (defenceCheat == true)
                {
                    Engine.defenceReduction = Engine.defenceReduction + 10;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                }
            }
        }

        // Update potion count money and defence count 

        public void nameUpdate()
        {
            easterAndrej.Visible = true;
        }

        void Interfaces.UpdadeScreen()
        {
            LB1.Text = "Clickerency: " + Engine.count.ToString();

            LB2.Text = "Monsters Killed: " + Engine.count2.ToString();

            defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

            string work = "Clicks Per Second: ";
            please = 1;
            CPS.Text = work + please;

            if (Engine.isNewGameClicksOn3 == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 15;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.isNewGameClicksOn2 == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 10;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.isNewGameClicksOn == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 5;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.woodenSword > 0)
            {
                Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
                please = Engine.woodenSwordAdd + 1;
                CPS.Text = work + please;
                if (Engine.stoneSword > 0)
                {
                    Engine.stoneSwordAdd = Engine.stoneSword * 1;
                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.ironSword > 0)
                    {
                        Engine.ironSwordAdd = Engine.ironSword * 2;
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.diamondSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.excalibur > 0)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                CPS.Text = work + please;
                            }
                        }
                    }
                }
            }

            if (Engine.silverSword == true)
            {
                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                Engine.silverSwordAdd + 1;
                CPS.Text = work + please;
                if (Engine.goldSword == true)
                {
                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                    Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.platinumSword == true)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                        Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.cobaltSword == true)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                            Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.starSword == true)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                                Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
                                CPS.Text = work + please;
                            }
                        }
                    }
                }
            }
        }

        // Updates player hp with heal spells

        void Interfaces.UpdateScreenHeal()
        {
            healthBar.Maximum = Engine.totalHealth;

            try
            {
                healthBar.Value = healthBar.Value + 10;
            }
            catch (Exception e11)
            {
                healthBar.Value = Engine.totalHealth;
            }

            if (Engine.health > Engine.totalHealth)
            {
                Engine.health = Engine.totalHealth;
            }

            label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
        }

        public void UpdateScreenHeal2()
        {
            healthBar.Maximum = Engine.totalHealth;

            try
            {
                healthBar.Value = healthBar.Value + 20;
            }
            catch (Exception e11)
            {
                healthBar.Value = Engine.totalHealth;
            }

            if (Engine.health > Engine.totalHealth)
            {
                Engine.health = Engine.totalHealth;
            }

            label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
        }

        public void UpdateScreenHeal3()
        {
            healthBar.Maximum = Engine.totalHealth;

            try
            {
                healthBar.Value = healthBar.Value + 40;
            }
            catch (Exception e11)
            {
                healthBar.Value = Engine.totalHealth;
            }

            if (Engine.health > Engine.totalHealth)
            {
                Engine.health = Engine.totalHealth;
            }

            label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
        }

        // Updates only the health potion

        void Interfaces.UpdateScreenPotion()
        {
            potionMenu.Items.Add("Health Potion");

            LB1.Text = "Clickerency: " + Engine.count.ToString();
        }

        // Updates only the upgraded health potion 

        void Interfaces.UpdateScreenUpgradedPotion()
        {
            potionMenu.Items.Add("Upgraded Health Potion");

            LB1.Text = "Clickerency: " + Engine.count.ToString();
        }

        // Updates only the super health potion 

        void Interfaces.UpdateScreenSuperPotion()
        {
            potionMenu.Items.Add("Super Health Potion");

            LB1.Text = "Clickerency: " + Engine.count.ToString();
        }

        // Updates only the ultra health potion

        void Interfaces.UpdateScreenUltraPotion()
        {
            potionMenu.Items.Add("Ultra Health Potion");

            LB1.Text = "Clickerency: " + Engine.count.ToString();
        }

        void Interfaces.UpdateScreenButton()
        {
            newGame.Visible = true;
        }

        void Interfaces.UpdateScreenButtonOff()
        {
            newGame.Visible = false;
            finalBoss.Enabled = false;
            btMagic.Enabled = false;
            btCrafting.Enabled = false;
            btMine.Enabled = false;
            btCamp.Enabled = false;
            potionMenu.Items.Clear();
            LB1.Text = "Clickerency: " + Engine.count.ToString();

            LB2.Text = "Monsters Killed: " + Engine.count2.ToString();

            defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

            label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

            if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
            {
                newPlus.Text = "New Game +";
                if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
                {
                    newPlus.Text = "New Game ++";
                    if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
                    {
                        newPlus.Text = "New Game +++";
                    }
                }
            }

            string work = "Clicks Per Second: ";
            please = 1;
            CPS.Text = work + please;

            info.Text = "";
            gpKill.Text = "";
            levelText.Text = "Level: " + Engine.level + "/" + "10";
            xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
            xpGot.Text = "";

            healthBar.Maximum = Engine.totalHealth;
            healthBar.Value = Engine.totalHealth;
        }

        void Interfaces.UpdateScreenNewGame()
        {
            newGame.Visible = false;
            finalBoss.Enabled = false;
            btMagic.Enabled = false;
            btCrafting.Enabled = false;
            btMine.Enabled = false;
            btCamp.Enabled = false;
            potionMenu.Items.Clear();
            LB1.Text = "Clickerency: " + Engine.count.ToString();

            LB2.Text = "Monsters Killed: " + Engine.count2.ToString();

            defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

            label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

            if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
            {
                newPlus.Text = "New Game +";
                if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
                {
                    newPlus.Text = "New Game ++";
                    if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
                    {
                        newPlus.Text = "New Game +++";
                    }
                }
            }

            levelText.Text = "Level: " + Engine.level + "/" + "10";
            xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
            xpGot.Text = "";

            string work = "Clicks Per Second: ";
            please = 1;
            CPS.Text = work + please;

            info.Text = "";
            gpKill.Text = "";
        }

        void Interfaces.UpdateScreenNewGameClicks()
        {
            newGame.Visible = false;
            finalBoss.Enabled = false;
            btMagic.Enabled = false;
            btCrafting.Enabled = false;
            btMine.Enabled = false;
            btCamp.Enabled = false;
            potionMenu.Items.Clear();
            LB1.Text = "Clickerency: " + Engine.count.ToString();

            LB2.Text = "Monsters Killed: " + Engine.count2.ToString();

            defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

            label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

            if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
            {
                newPlus.Text = "New Game +";
                if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
                {
                    newPlus.Text = "New Game ++";
                    if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
                    {
                        newPlus.Text = "New Game +++";
                    }
                }
            }

            levelText.Text = "Level: " + Engine.level + "/" + "10";
            xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
            xpGot.Text = "";

            string work = "Clicks Per Second: ";
            please = 1;
            CPS.Text = work + please;


            if (Engine.isNewGameClicksOn3 == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 15;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.isNewGameClicksOn2 == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 10;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.isNewGameClicksOn == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 5;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.woodenSword > 0)
            {
                Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
                please = Engine.woodenSwordAdd + 1;
                CPS.Text = work + please;
                if (Engine.stoneSword > 0)
                {
                    Engine.stoneSwordAdd = Engine.stoneSword * 1;
                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.ironSword > 0)
                    {
                        Engine.ironSwordAdd = Engine.ironSword * 2;
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.diamondSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.excalibur > 0)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                CPS.Text = work + please;
                            }
                        }
                    }
                }
            }

            if (Engine.silverSword == true)
            {
                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                Engine.silverSwordAdd + 1;
                CPS.Text = work + please;
                if (Engine.goldSword == true)
                {
                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                    Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.platinumSword == true)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                        Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.cobaltSword == true)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                            Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.starSword == true)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                                Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
                                CPS.Text = work + please;
                            }
                        }
                    }
                }
            }

            info.Text = "";
            gpKill.Text = "";
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            Random dmgGold = new Random();

            if (Engine.level == 1)
            {
                Engine.damage = dmgGold.Next(0, 6);
                Engine.money = dmgGold.Next(1, 6);
            }

            if (Engine.level == 2)
            {
                Engine.damage = dmgGold.Next(6, 11);
                Engine.money = dmgGold.Next(1, 11);
            }

            if (Engine.level == 3)
            {
                Engine.damage = dmgGold.Next(11, 16);
                Engine.money = dmgGold.Next(1, 16);
            }

            if (Engine.level == 4)
            {
                Engine.damage = dmgGold.Next(16, 21);
                Engine.money = dmgGold.Next(1, 21);
            }

            if (Engine.level == 5)
            {
                Engine.damage = dmgGold.Next(21, 26);
                Engine.money = dmgGold.Next(1, 26);
            }

            if (Engine.level == 6)
            {
                Engine.damage = dmgGold.Next(26, 31);
                Engine.money = dmgGold.Next(1, 31);
            }

            if (Engine.level == 7)
            {
                Engine.damage = dmgGold.Next(31, 36);
                Engine.money = dmgGold.Next(1, 36);
            }

            if (Engine.level == 8)
            {
                Engine.damage = dmgGold.Next(36, 41);
                Engine.money = dmgGold.Next(1, 41);
            }

            if (Engine.level == 9)
            {
                Engine.damage = dmgGold.Next(41, 46);
                Engine.money = dmgGold.Next(1, 46);
            }

            if (Engine.level == 10)
            {
                Engine.damage = dmgGold.Next(46, 51);
                Engine.money = dmgGold.Next(1, 51);
            }

            newDamage = Engine.damage - Engine.defenceReduction;

            if (newDamage < 0)
            {
                newDamage = 0;
            }

            Engine.count = Engine.count + Engine.money;

            if (Engine.isBossDead == true)
            {
                Engine.damage = 0;
                newDamage = 0;
            }

            if (Engine.damage == 0)
            {
                Engine.health = Engine.health - Engine.damage;
            }
            else if (Engine.damage > 0)
            {
                Engine.health = Engine.health - newDamage;
            }


            // Health bar code 

            if (Engine.level == 1)
            {
                try
                {
                    healthBar.Value = healthBar.Value - Engine.damage;
                }
                catch (Exception e3)
                {
                    healthBar.Value = 0;
                }
            }

            if (Engine.level > 1)
            {
                try
                {
                    int owo = System.Convert.ToInt32(newDamage);
                    healthBar.Value = healthBar.Value - owo;
                }
                catch (Exception e4)
                {
                    healthBar.Value = 0;
                }
            }

            label5.Text = "HItPoints: " + Engine.health.ToString() + " / " + Engine.totalHealth;

            if (Engine.damage == 1)
            {
                info.Text = "You have suffered " + Engine.damage + " point of damage";
            }
            else
            {
                info.Text = "You have suffered " + Engine.damage + " points of damage";
            }

            if (Engine.money == 1)
            {
                gpKill.Text = "You got " + Engine.money + " click from that monster";
            }
            else
            {
                gpKill.Text = "You got " + Engine.money + " clicks from that monster";
            }

            // Weapon damage adders 

            Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
            Engine.stoneSwordAdd = Engine.stoneSword * 1;
            Engine.ironSwordAdd = Engine.ironSword * 2;
            Engine.diamondSwordAdd = Engine.diamondSword * 4;
            Engine.count2 = Engine.count2 + Engine.woodenSwordAdd;
            Engine.count2 = Engine.count2 + Engine.stoneSwordAdd;
            Engine.count2 = Engine.count2 + Engine.ironSwordAdd;
            Engine.count2 = Engine.count2 + Engine.diamondSwordAdd;
            Engine.count2 = Engine.count2 + Engine.excaliburAdd; 
            Engine.count2 = Engine.count2 + Engine.fireboltAdd;
            Engine.count2 = Engine.count2 + Engine.waterwaveAdd;
            Engine.count2 = Engine.count2 + Engine.voltswtichAdd;
            Engine.count2 = Engine.count2 + Engine.newgameAdd;
            Engine.count2 = Engine.count2 + Engine.silverSwordAdd;
            Engine.count2 = Engine.count2 + Engine.goldSwordAdd;
            Engine.count2 = Engine.count2 + Engine.platinumSwordAdd;
            Engine.count2 = Engine.count2 + Engine.cobaltSwordAdd;
            Engine.count2 = Engine.count2 + Engine.starSwordAdd;


            double xpMultiplyer = 1 + Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd +
                Engine.fireboltAdd + Engine.waterwaveAdd + Engine.voltswtichAdd + Engine.newgameAdd + Engine.silverSwordAdd + Engine.goldSwordAdd + 
                Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd;

            Random xpGiveRandom = new Random();
            double xpGive = xpGiveRandom.Next(1, 6);

            double xpGain = xpMultiplyer * xpGive;

            Engine.XP = Engine.XP + System.Convert.ToInt32(xpGain);

            xpGot.Text = "You gained " + xpGain + " XP from that monster";

            xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;

            Engine.count2++;
            LB1.Text = "Clickerency: " + Engine.count.ToString();
            LB2.Text = "Monsters Killed: " + Engine.count2.ToString();

            // CPS Counter 

            string work = "Clicks Per Second: ";
            please = 1;
            CPS.Text = work + please;

            if (Engine.isNewGameClicksOn3 == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 15;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.isNewGameClicksOn2 == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 10;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.isNewGameClicksOn == true)
            {
                string workClicks = "Clicks Per Second: ";
                please = 5;
                CPS.Text = workClicks + please;
                if (Engine.woodenSword > 0)
                {
                    please = Engine.woodenSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.stoneSword > 0)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.ironSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.diamondSword > 0)
                            {
                                Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.excalibur > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                    CPS.Text = work + please;
                                }
                            }
                        }
                    }
                }
            }
            else if (Engine.woodenSword > 0)
            {
                Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
                please = Engine.woodenSwordAdd + 1;
                CPS.Text = work + please;
                if (Engine.stoneSword > 0)
                {
                    Engine.stoneSwordAdd = Engine.stoneSword * 1;
                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.ironSword > 0)
                    {
                        Engine.ironSwordAdd = Engine.ironSword * 2;
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.diamondSword > 0)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.excalibur > 0)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                CPS.Text = work + please;
                            }
                        }
                    }
                }
            }

            if (Engine.silverSword == true)
            {
                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                Engine.silverSwordAdd + 1;
                CPS.Text = work + please;
                if (Engine.goldSword == true)
                {
                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                    Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
                    CPS.Text = work + please;
                    if (Engine.platinumSword == true)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                        Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.cobaltSword == true)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                            Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.starSword == true)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                                Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
                                CPS.Text = work + please;
                            }
                        }
                    }
                }
            }

            // Code for levels

            if (Engine.level < 2)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 10;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = Engine.totalHealth;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked:" + "\r\n" + "\r\n" +
                    "- Wooden Sword" + "\r\n" + "\r\n" + "+ 10 Total HP" + "\r\n" + "+ 1 Total Defence" + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!",
                    MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 3)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 20;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 20;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    btMine.Enabled = true;
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked: " + "\r\n" + "\r\n" + "- Mining!"
                    + "\r\n" + "- Stone Sword" + "\r\n" + "- Upgraded Health Potion" + "\r\n" + "\r\n" + "+ 20 Total HP" + "\r\n" + "+ 1 Total Defence" 
                    + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 4)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 30;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 30;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked: " + "\r\n" + "\r\n" +
                    "- Silver Pickaxe" + "\r\n" + "- Gold Ore!" + "\r\n" + "- Iron Sword" + "\r\n" + "\r\n" + "+ 30 Total HP" + "\r\n" + "+ 1 Total Defence"
                    + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 5)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    btMagic.Enabled = true;
                    Engine.totalHealth = Engine.totalHealth + 40;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 40;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked:" + "\r\n" + "\r\n" + "- Golden Pickaxe" + "\r\n" 
                    + "- Magic" + "\r\n" + "- Air Runes" + "\r\n" + "- Fire Runes" + "\r\n" + "- Super Health Potion" + "\r\n" + "\r\n" + "+ 40 Total HP" + "\r\n" + "+ 1 Total Defence"
                    + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 6)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 50;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 50;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    btCamp.Enabled = true;
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked:" + "\r\n" + "\r\n" + "- Camping" + "\r\n" +
                    "- Platinum Pickaxe" + "\r\n" + "- Defence Up spell!" + "\r\n" + "- Earth Runes" + "\r\n" + "- Healara spell!" + "\r\n" + "- Mind Runes" + "\r\n"
                    + "- Diamond Sword" + "\r\n" + "\r\n" + "+ 50 Total HP" + "\r\n" + "+ 1 Total Defence" 
                    + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 7)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 60;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 60;
                    healthBar.Value = Engine.totalHealth;
                    btCrafting.Enabled = true;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked:" + "\r\n" + "\r\n" + "- Crafting" + "\r\n" 
                    + "- Cobalt Pickaxe" + "\r\n" + "- Water Wave Spell!" + "\r\n" + "- Water Runes" + "\r\n" + "- Extra Defence Spell" + "\r\n" + "- Cosmic Runes" 
                    + "\r\n" + "- Lava Runes" + "\r\n" + "- Ultra Health Potion" + "\r\n" + "\r\n" + "+ 60 Total HP" + "\r\n" + "+ 1 Total Defence" 
                    +"\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 8)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 70;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 70;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked:" + "\r\n" + "\r\n" + "- Star Pickaxe" + "\r\n" 
                    + "- Cureraga Spell" + "\r\n" + "- Nature Runes" + "\r\n" + "- Life Runes" + "\r\n" + "\r\n" + "+ 70 Total HP" + "\r\n" + "+ 1 Total Defence"
                    + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 9)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 80;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 80;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked:" + "\r\n" + "\r\n" 
                    + "- Volt Switch Spell" + "\r\n" + "- Electric Runes" + "\r\n" + "- Wrath Runes" + "\r\n" + "\r\n" + "+ 80 Total HP" + "\r\n" + "+ 1 Total Defence"
                    + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level < 10)
            {
                if (Engine.XP >= Engine.totalXP)
                {
                    Engine.level++;
                    Engine.totalHealth = Engine.totalHealth + 90;
                    Engine.health = Engine.totalHealth;
                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    Engine.defence = Engine.defence + 1;
                    Engine.defenceReduction = Engine.defenceReduction + 1;
                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";
                    healthBar.Maximum = healthBar.Maximum + 90;
                    healthBar.Value = Engine.totalHealth;
                    levelText.Text = "Level: " + Engine.level + "/" + "10";
                    Engine.totalXP = Engine.totalXP + 50;
                    Engine.XP = 0;
                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;
                    MessageBox.Show("You have leveled up! You are now level " + Engine.level + "!" + "\r\n" + "You have unlocked:" + "\r\n" + "\r\n" + "- Max Defence Spell!" 
                    + "\r\n" + "- Steam Runes!" + "\r\n" + "- Astral Runes!" + "\r\n" + "- ReArise Spell!" + "\r\n" + "- Revive Runes!" + "\r\n" + "- Soul Runes!" + "\r\n" 
                    + "\r\n" + "+ 90 Total HP" + "\r\n" + "+ 1 Total Defence" + "\r\n" + "\r\n" + "Health Restored!", "Congratulations!", MessageBoxButtons.OK);
                }
            }

            if (Engine.level >= 10)
            {
                finalBoss.Enabled = true;
            }

            if (Engine.health <= 0)
            {
                Engine.health = Engine.totalHealth - Engine.totalHealth;
                label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                Death gOver = new Death();
                gOver.ShowDialog();
            }
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            if (Engine.level >= 2)
            {
                f2.buySword.Enabled = true;
            }

            if (Engine.level >= 3)
            {
                f2.buySW.Enabled = true;
                f2.buyUPT.Enabled = true;
            }

            if (Engine.level >= 4)
            {
                f2.buySP.Enabled = true;
                f2.buyIS.Enabled = true;
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

            f2.UpdateScreenInterface = this;
            f2.updateNormalPotion = this;
            f2.updatePotion = this;
            f2.updateSuperPotion = this;
            f2.updateUltraPotion = this;
            f2.ShowDialog();
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            Inventory f4 = new Inventory();
            f4.ShowDialog();
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
            Boss boss = new Boss();
            boss.reward = this;
            boss.button = this;
            for (int i = 0; i < potionMenu.Items.Count; i++)
            {
                boss.potionMenu2.Items.Add(potionMenu.Items[i]);
            }
            boss.ShowDialog();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            newGame.button = this;
            newGame.update = this;
            newGame.newClicks = this;
            newGame.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (potionMenu.SelectedIndex > -1)
            {
                if (Engine.health == Engine.totalHealth)
                {
                    noH.Visible = true;
                    noH.Text = "You have maximum health"; 
                }
                else if (potionMenu.SelectedItem.ToString() == "Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play(); 

                    Engine.potion = Engine.potion - 1; 
                    noH.Visible = false;
                    Engine.health = Engine.health + 10;

                    try
                    {
                        healthBar.Value = healthBar.Value + 10;
                    }
                    catch (Exception e1)
                    {
                        healthBar.Value = Engine.totalHealth;
                    }
 
                    if (Engine.health > Engine.totalHealth)
                    {
                       Engine.health = Engine.totalHealth;
                    }

                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    potionMenu.Items.Remove(potionMenu.SelectedItem);
                }
                else if (potionMenu.SelectedItem.ToString() == "Upgraded Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play();

                    Engine.upgradedPotion = Engine.upgradedPotion - 1;
                    noH.Visible = false;
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

                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    potionMenu.Items.Remove(potionMenu.SelectedItem);
                }
                else if (potionMenu.SelectedItem.ToString() == "Super Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play();

                    Engine.superPotion = Engine.superPotion - 1;
                    noH.Visible = false;
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

                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    potionMenu.Items.Remove(potionMenu.SelectedItem);
                }
                else if (potionMenu.SelectedItem.ToString() == "Ultra Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play();

                    Engine.ultraPotion = Engine.ultraPotion - 1;
                    noH.Visible = false;
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

                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;
                    potionMenu.Items.Remove(potionMenu.SelectedItem);
                }
            }
            else 
            {
                noH.Visible = true; 
                noH.Text = "You don't have a potion to use"; 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure? Any unsaved progress will be lost!", "Warning!", MessageBoxButtons.YesNo); 
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Engine.name == "GCND")
            {
                nameSave.Text = Engine.name + "'s Save";
                easterAndrej.Visible = true;
            }
            else if (Engine.name == "Green Cyborg Ninja Dude")
            {
                nameSave.Text = Engine.name + "'s Save";
                easterAndrej.Visible = true;
            }
            else if (Engine.name == "Andrej")
            {
                nameSave.Text = Engine.name + "'s Save";
                easterAndrej.Visible = true;
            }
            else if (Engine.name == "Green")
            {
                nameSave.Text = Engine.name + "'s Save";
                easterAndrej.Visible = true;
            }
            else
            {
                nameSave.Text = Engine.name + "'s Save";
            }

            CPS.Text = "Clicks Per Second: 1";

            // Dev Tools
            if (Engine.devTools == true)
            {
                btMagic.Enabled = true;
                Engine.level = 9;
                Engine.count2 = 99;
                Engine.airRunes = 100;
                Engine.fireRunes = 100;
                Engine.mindRunes = 100;
                Engine.waterRunes = 100;
                Engine.bloodRunes = 100;
                Engine.count = 500;
                Engine.cosmicRunes = 100;
                Engine.earthRunes = 100;
                Engine.lavaRunes = 100;
                Engine.lifeRunes = 100;
                Engine.natureRunes = 100;
                btCrafting.Enabled = true;
                Engine.wrathRunes = 100;
                Engine.electricRunes = 100;
                Engine.steamRunes = 100;
                Engine.astralRunes = 100;
                Engine.reviveRunes = 100;
                Engine.soulRunes = 100;
                finalBoss.Enabled = true;
                Engine.woodenSword = 10;
                Engine.stoneSword = 7;
                Engine.ironSword = 5;
                Engine.diamondSword = 3000;
                Engine.excalibur = 1;
                Engine.excaliburAdd = 999;
                Engine.isBossDead = true;
                Engine.stoneSword = 10;
                btMine.Enabled = true;
                btCamp.Enabled = true;
                Engine.silverPick = true;
                Engine.goldPick = true;
                Engine.platPick = true;
                Engine.cobPick = true;
                Engine.starPick = true;
                Engine.health = 1000;
                Engine.silverOreTotal = 99;
                Engine.wood = 300;
                Engine.flint = 300;
                Engine.stone = 300;
                Engine.steel = 300;
                Engine.silverOreTake = 300;
                Engine.goldOreTake = 300;
                Engine.starOreTake = 300;
                Engine.ultraPotion = 300;
                Engine.fireRunes = 300;
                Engine.lifeRunes = 300;
                Engine.potion = 300;
                Engine.airRunes = 300;
                Engine.woodenSword = 2;
                newGame.Visible = true;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will overwrite the previous save! Are you sure you want to save?", "Warning!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Engine.items = new string[potionMenu.Items.Count];
                for (int i = 0; i < potionMenu.Items.Count; i++)
                {
                    Engine.items[i] = potionMenu.Items[i].ToString();
                }

                saving save = new saving
                {
                    level = Engine.level,
                    count = Engine.count,
                    count2 = Engine.count2,
                    count3 = Engine.count3,
                    money = Engine.money,
                    health = Engine.health,
                    defence = Engine.defence,
                    defenceReduction = Engine.defenceReduction,
                    totalHealth = Engine.totalHealth,
                    damage = Engine.damage,
                    woodenSword = Engine.woodenSword,
                    stoneSword = Engine.stoneSword,
                    ironSword = Engine.ironSword,
                    diamondSword = Engine.diamondSword,
                    excalibur = Engine.excalibur,
                    woodenSwordAdd = Engine.woodenSwordAdd,
                    stoneSwordAdd = Engine.stoneSwordAdd,
                    ironSwordAdd = Engine.ironSwordAdd,
                    diamondSwordAdd = Engine.diamondSwordAdd,
                    excaliburAdd = Engine.excaliburAdd,
                    fireboltAdd = Engine.fireboltAdd,
                    waterwaveAdd = Engine.waterwaveAdd,
                    voltswtichAdd = Engine.voltswtichAdd,
                    potion = Engine.potion,
                    upgradedPotion = Engine.upgradedPotion,
                    superPotion = Engine.superPotion,
                    ultraPotion = Engine.ultraPotion,
                    airRunes = Engine.airRunes,
                    fireRunes = Engine.fireRunes,
                    earthRunes = Engine.earthRunes,
                    mindRunes = Engine.mindRunes,
                    waterRunes = Engine.waterRunes,
                    lavaRunes = Engine.lavaRunes,
                    natureRunes = Engine.natureRunes,
                    electricRunes = Engine.electricRunes,
                    steamRunes = Engine.steamRunes,
                    bloodRunes = Engine.bloodRunes,
                    cosmicRunes = Engine.cosmicRunes,
                    lifeRunes = Engine.lifeRunes,
                    reviveRunes = Engine.reviveRunes,
                    wrathRunes = Engine.wrathRunes,
                    astralRunes = Engine.astralRunes,
                    soulRunes = Engine.soulRunes,
                    isBossDead = Engine.isBossDead,
                    bar = healthBar.Value,
                    barMaximum = healthBar.Maximum,
                    items = Engine.items,
                    buttonOn = newGame.Visible,
                    isNewGameOn = Engine.isNewGameOn,
                    isNewGameClicksOn = Engine.isNewGameClicksOn,
                    newgameAdd = Engine.newgameAdd,
                    isNewGameDefenceOn = Engine.isNewGameDefenceOn,
                    FinalBoss = finalBoss.Enabled,
                    Magic = btMagic.Enabled,
                    Runes = runeCrafting.Enabled,
                    Mine = btMine.Enabled,
                    silverOreTake = Engine.silverOreTake,
                    silverOreTotal = Engine.silverOreTotal,
                    goldOreTake = Engine.goldOreTake,
                    goldOreTotal = Engine.goldOreTotal,
                    silverPick = Engine.silverPick,
                    goldPick = Engine.goldPick,
                    platOreTake = Engine.platinumOreTake,
                    platOreTotal = Engine.platinumOreTotal,
                    platPick = Engine.platPick,
                    cobaltOreTake = Engine.cobaltOreTake,
                    cobaltOreTotal = Engine.cobaltOreTotal,
                    cobPick = Engine.cobPick,
                    starOreTake = Engine.starOreTake,
                    starOreTotal = Engine.starOreTotal,
                    name = Engine.name,
                    starPick = Engine.starPick,
                    btCamp = btCamp.Enabled,
                    XP = Engine.XP,
                    totalXP = Engine.totalXP,
                    silverSword = Engine.silverSword,
                    goldSword = Engine.goldSword,
                    platinumSword = Engine.platinumSword,
                    cobaltSword = Engine.cobaltSword,
                    starSword = Engine.starSword,
                    silverSwordAdd = Engine.silverSwordAdd,
                    goldSwordAdd = Engine.goldSwordAdd,
                    platinumSwordAdd = Engine.platinumSwordAdd,
                    cobaltSwordAdd = Engine.cobaltSwordAdd,
                    starSwordAdd = Engine.starSwordAdd,
                    wood = Engine.wood,
                    stone = Engine.stone,
                    flint = Engine.flint,
                    steel = Engine.steel, 
                    isNewGameOn2 = Engine.isNewGameOn2,
                    isNewGameDefenceOn2 = Engine.isNewGameDefenceOn2,
                    isNewGameClicksOn2 = Engine.isNewGameClicksOn2, 
                    isNewGameOn3 = Engine.isNewGameOn3,
                    isNewGameDefenceOn3 = Engine.isNewGameDefenceOn3,
                    isNewGameClicksOn3 = Engine.isNewGameClicksOn3
                };

                string JSONsave = JsonConvert.SerializeObject(save);
                string directoryPath = string.Format(@"Saves\", Application.StartupPath);
                string path = String.Format(@"{0}\Saves\" + Engine.name + "'s Save.json", Application.StartupPath);
                string path2 = String.Format(@"{0}\Saves\" + Engine.name + "'s MD5Hash.txt", Application.StartupPath);

                DirectoryInfo saves = Directory.CreateDirectory(directoryPath);

                if (File.Exists(path))
                {
                    File.Delete(path);
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(JSONsave.ToString());
                        tw.Close();
                    }
                }
                else if (!File.Exists(path))
                {
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(JSONsave.ToString());
                        tw.Close();
                    }
                }

                sSourceData = String.Format(path);
                tmpSource = File.ReadAllBytes(sSourceData);
                tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

                int j;
                StringBuilder sOutput = new StringBuilder(tmpHash.Length);
                for (j = 0; j < tmpHash.Length; j++)
                {
                    sOutput.Append(tmpHash[j].ToString("X2"));
                }

                if (File.Exists(path2))
                {
                    File.Delete(path2);
                    using (var tw = new StreamWriter(path2, true))
                    {
                        tw.WriteLine(sOutput.ToString());
                        tw.Close();
                    }
                }
                else if (!File.Exists(path2))
                {
                    using (var tw = new StreamWriter(path2, true))
                    {
                        tw.WriteLine(sOutput.ToString());
                        tw.Close();
                    }
                }

                string path3 = String.Format(@"{0}\Saves\" + Engine.name + "'s MD5Hash.txt", Application.StartupPath);
                File.SetAttributes(path3, File.GetAttributes(path3) | FileAttributes.Hidden); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool bEqual = false;
            string path = String.Format(@"{0}\Saves\" + Engine.name + "'s Save.json", Application.StartupPath);

            try
            {
                sSourceData2 = String.Format(path);
                tmpSource2 = File.ReadAllBytes(sSourceData2);
                tmpNewHash2 = new MD5CryptoServiceProvider().ComputeHash(tmpSource2);

                int j;
                StringBuilder sOutput2 = new StringBuilder(tmpNewHash2.Length);
                for (j = 0; j < tmpNewHash2.Length; j++)
                {
                    sOutput2.Append(tmpNewHash2[j].ToString("X2"));
                }

                string md5 = "";
                string path2 = String.Format(@"{0}\Saves\" + Engine.name + "'s MD5Hash.txt", Application.StartupPath);

                using (var tw = new StreamReader(path2, true))
                {
                    md5 = tw.ReadToEnd();
                    tw.Close();
                }

                int k;
                StringBuilder result = new StringBuilder(md5.Length);
                for (k = 0; k < md5.Length - 2; k++)
                {
                    result.Append(md5[k].ToString());
                }

                if (sOutput2.Length == result.Length)
                {
                    int i = 0;
                    while ((i < sOutput2.Length) && (sOutput2[i] == result[i]))
                    {
                        i += 1;
                    }
                    if (i == sOutput2.Length)
                    {
                        bEqual = true;
                    }
                }

                var confirmResult = MessageBox.Show("Are you sure you want to load your saved game? Any unsaved progress will be lost!", "Warning!", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes && bEqual == true)
                {
                    string json = "";
                    string path3 = String.Format(@"{0}\Saves\" + Engine.name + "'s Save.json", Application.StartupPath);
                    using (var tw = new StreamReader(path3, true))
                    {
                        json = tw.ReadToEnd();
                        tw.Close();
                    }
                    saving load = JsonConvert.DeserializeObject<saving>(json);

                    Engine.level = load.level;
                    Engine.count = load.count;
                    Engine.count2 = load.count2;
                    Engine.count3 = load.count3;
                    Engine.money = load.money;
                    Engine.health = load.health;
                    Engine.defence = load.defence;
                    Engine.defenceReduction = load.defenceReduction;
                    Engine.totalHealth = load.totalHealth;
                    Engine.damage = load.damage;
                    Engine.woodenSword = load.woodenSword;
                    Engine.stoneSword = load.stoneSword;
                    Engine.ironSword = load.ironSword;
                    Engine.diamondSword = load.diamondSword;
                    Engine.excalibur = load.excalibur;
                    Engine.woodenSwordAdd = load.woodenSwordAdd;
                    Engine.stoneSwordAdd = load.stoneSwordAdd;
                    Engine.ironSwordAdd = load.ironSwordAdd;
                    Engine.diamondSwordAdd = load.diamondSwordAdd;
                    Engine.excaliburAdd = load.excaliburAdd;
                    Engine.fireboltAdd = load.fireboltAdd;
                    Engine.waterwaveAdd = load.waterwaveAdd;
                    Engine.voltswtichAdd = load.voltswtichAdd;
                    Engine.potion = load.potion;
                    Engine.upgradedPotion = load.upgradedPotion;
                    Engine.superPotion = load.superPotion;
                    Engine.ultraPotion = load.ultraPotion;
                    Engine.airRunes = load.airRunes;
                    Engine.fireRunes = load.fireRunes;
                    Engine.earthRunes = load.earthRunes;
                    Engine.mindRunes = load.mindRunes;
                    Engine.waterRunes = load.waterRunes;
                    Engine.lavaRunes = load.lavaRunes;
                    Engine.natureRunes = load.natureRunes;
                    Engine.electricRunes = load.electricRunes;
                    Engine.steamRunes = load.steamRunes;
                    Engine.bloodRunes = load.bloodRunes;
                    Engine.cosmicRunes = load.cosmicRunes;
                    Engine.lifeRunes = load.lifeRunes;
                    Engine.reviveRunes = load.reviveRunes;
                    Engine.wrathRunes = load.wrathRunes;
                    Engine.astralRunes = load.astralRunes;
                    Engine.soulRunes = load.soulRunes;
                    Engine.isBossDead = load.isBossDead;
                    Engine.isNewGameOn = load.isNewGameOn;
                    Engine.isNewGameDefenceOn = load.isNewGameDefenceOn;
                    Engine.isNewGameDefenceOn2 = load.isNewGameDefenceOn2;
                    Engine.isNewGameDefenceOn3 = load.isNewGameDefenceOn3;
                    Engine.isNewGameOn2 = load.isNewGameOn2;
                    Engine.isNewGameOn3 = load.isNewGameOn3;
                    Engine.isNewGameClicksOn = load.isNewGameClicksOn;
                    Engine.isNewGameClicksOn2 = load.isNewGameClicksOn2;
                    Engine.isNewGameClicksOn3 = load.isNewGameClicksOn3;
                    if (Engine.isNewGameOn == true)
                    {
                        healthBar.Maximum = 220;
                        healthBar.Value = 220;
                    }
                    if (Engine.isNewGameOn2 == true)
                    {
                        healthBar.Maximum = Engine.totalHealth;
                        healthBar.Value = Engine.totalHealth;
                    }
                    if (Engine.isNewGameOn3 == true)
                    {
                        healthBar.Maximum = Engine.totalHealth;
                        healthBar.Value = Engine.totalHealth;
                    }
                    healthBar.Maximum = load.barMaximum;
                    healthBar.Value = load.bar;
                    Engine.items = load.items;
                    newGame.Visible = load.buttonOn;
                    Engine.newgameAdd = load.newgameAdd;
                    finalBoss.Enabled = load.FinalBoss;
                    btMagic.Enabled = load.Magic;
                    runeCrafting.Enabled = load.Runes;
                    btMine.Enabled = load.Mine;
                    Engine.silverOreTake = load.silverOreTake;
                    Engine.silverOreTotal = load.silverOreTotal;
                    Engine.goldOreTake = load.goldOreTake;
                    Engine.goldOreTotal = load.goldOreTotal;
                    Engine.silverPick = load.silverPick;
                    Engine.goldPick = load.goldPick;
                    Engine.platinumOreTake = load.platOreTake;
                    Engine.platinumOreTotal = load.platOreTotal;
                    Engine.platPick = load.platPick;
                    Engine.cobaltOreTotal = load.cobaltOreTotal;
                    Engine.cobaltOreTake = load.cobaltOreTake;
                    Engine.cobPick = load.cobPick;
                    Engine.starOreTake = load.starOreTake;
                    Engine.starOreTotal = load.starOreTotal;
                    Engine.name = load.name;
                    Engine.starPick = load.starPick;
                    btCamp.Enabled = load.btCamp;
                    Engine.XP = load.XP;
                    Engine.totalXP = load.totalXP;
                    Engine.silverSword = load.silverSword;
                    Engine.goldSword = load.goldSword;
                    Engine.platinumSword = load.platinumSword;
                    Engine.cobaltSword = load.cobaltSword;
                    Engine.starSword = load.starSword;
                    Engine.silverSwordAdd = load.silverSwordAdd;
                    Engine.goldSwordAdd = load.goldSwordAdd;
                    Engine.platinumSwordAdd = load.platinumSwordAdd;
                    Engine.cobaltSwordAdd = load.cobaltSwordAdd;
                    Engine.starSwordAdd = load.starSwordAdd;
                    Engine.wood = load.wood;
                    Engine.stone = load.stone;
                    Engine.steel = load.steel;
                    Engine.flint = load.flint;

                    for (int i = 0; i < Engine.items.Length; i++)
                    {
                        potionMenu.Items.Add(Engine.items[i]);
                    }

                    LB1.Text = "Clickerency: " + Engine.count.ToString();

                    LB2.Text = "Monsters Killed: " + Engine.count2.ToString();

                    defence.Text = "Defence: " + Engine.defence + " (Decreases damage by " + Engine.defenceReduction + ")";

                    label5.Text = "HItPoints: " + Engine.health + " / " + Engine.totalHealth;

                    levelText.Text = "Level: " + Engine.level + "/" + "10";

                    xpTracker.Text = "XP: " + Engine.XP + "/" + Engine.totalXP;

                    if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameClicksOn2 == true)
                    {
                        newPlus.Text = "New Game +";
                        if (Engine.isNewGameOn2 == true || Engine.isNewGameDefenceOn2 == true || Engine.isNewGameDefenceOn3 == true)
                        {
                            newPlus.Text = "New Game ++";
                            if (Engine.isNewGameClicksOn3 == true || Engine.isNewGameClicksOn2 == true || Engine.isNewGameClicksOn3 == true)
                            {
                                newPlus.Text = "New Game +++";
                            }
                        }
                    }


                    string work = "Clicks Per Second: ";
                    please = 1;
                    CPS.Text = work + please;

                    if (Engine.isNewGameClicksOn3 == true)
                    {
                        string workClicks = "Clicks Per Second: ";
                        please = 15;
                        CPS.Text = workClicks + please;
                        if (Engine.woodenSword > 0)
                        {
                            please = Engine.woodenSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.stoneSword > 0)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.ironSword > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                                    CPS.Text = work + please;
                                    if (Engine.diamondSword > 0)
                                    {
                                        Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                        CPS.Text = work + please;
                                        if (Engine.excalibur > 0)
                                        {
                                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                            CPS.Text = work + please;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (Engine.isNewGameClicksOn2 == true)
                    {
                        string workClicks = "Clicks Per Second: ";
                        please = 10;
                        CPS.Text = workClicks + please;
                        if (Engine.woodenSword > 0)
                        {
                            please = Engine.woodenSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.stoneSword > 0)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.ironSword > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                                    CPS.Text = work + please;
                                    if (Engine.diamondSword > 0)
                                    {
                                        Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                        CPS.Text = work + please;
                                        if (Engine.excalibur > 0)
                                        {
                                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                            CPS.Text = work + please;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (Engine.isNewGameClicksOn == true)
                    {
                        string workClicks = "Clicks Per Second: ";
                        please = 5;
                        CPS.Text = workClicks + please;
                        if (Engine.woodenSword > 0)
                        {
                            please = Engine.woodenSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.stoneSword > 0)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.ironSword > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                                    CPS.Text = work + please;
                                    if (Engine.diamondSword > 0)
                                    {
                                        Engine.diamondSwordAdd = Engine.diamondSword * 4;
                                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                        CPS.Text = work + please;
                                        if (Engine.excalibur > 0)
                                        {
                                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                            CPS.Text = work + please;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (Engine.woodenSword > 0)
                    {
                        Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
                        please = Engine.woodenSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.stoneSword > 0)
                        {
                            Engine.stoneSwordAdd = Engine.stoneSword * 1;
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.ironSword > 0)
                            {
                                Engine.ironSwordAdd = Engine.ironSword * 2;
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.diamondSword > 0)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + 1;
                                    CPS.Text = work + please;
                                    if (Engine.excalibur > 0)
                                    {
                                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd + 1;
                                        CPS.Text = work + please;
                                    }
                                }
                            }
                        }
                    }

                    if (Engine.silverSword == true)
                    {
                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                        Engine.silverSwordAdd + 1;
                        CPS.Text = work + please;
                        if (Engine.goldSword == true)
                        {
                            please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                            Engine.silverSwordAdd + Engine.goldSwordAdd + 1;
                            CPS.Text = work + please;
                            if (Engine.platinumSword == true)
                            {
                                please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                                Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + 1;
                                CPS.Text = work + please;
                                if (Engine.cobaltSword == true)
                                {
                                    please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                                    Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + 1;
                                    CPS.Text = work + please;
                                    if (Engine.starSword == true)
                                    {
                                        please = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd + Engine.excaliburAdd +
                                        Engine.silverSwordAdd + Engine.goldSwordAdd + Engine.platinumSwordAdd + Engine.cobaltSwordAdd + Engine.starSwordAdd + 1;
                                        CPS.Text = work + please;
                                    }
                                }
                            }
                        }
                    }
                }

                else if (confirmResult == DialogResult.Yes && bEqual == false)
                {
                    MessageBox.Show("Save has been tampered with!" + "\r\n" + "Save cannot be loaded." + "\r\n" + "Why cheat?", "Error!", MessageBoxButtons.OK);
                }
            }
            catch (Exception e12)
            {
                MessageBox.Show("No save file detected!", "Warning!", MessageBoxButtons.OK);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace Idle_Game
{
    public partial class Boss : Form
    {
        int bossNumber = 5000;
        int bossDamage;
        Random bRandom = new Random();
        int bossDamageInflict;
        int finalHealth = Engine.totalHealth;
        SoundPlayer victory = new SoundPlayer(Idle_Game.Properties.Resources.victory);
        SoundPlayer battle = new SoundPlayer(Idle_Game.Properties.Resources.battle); 
        Form1 god = new Form1(); 

        public Boss()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Icon = Idle_Game.Properties.Resources.icon;
            hp.Text = "HItPoints: " + finalHealth.ToString() + " / " + Engine.totalHealth;
            healthBar.Maximum = Engine.totalHealth;
            healthBar.Value = healthBar.Maximum;
            bossBar.Maximum = 5000;
            bossBar.Value = bossBar.Maximum;
            bossHP.Text = "Boss HP: " + bossNumber + " / " + "5000";
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            Engine.woodenSwordAdd = Engine.woodenSword * 0.5;
            Engine.stoneSwordAdd = Engine.stoneSword * 1;
            Engine.ironSwordAdd = Engine.ironSword * 2;
            Engine.diamondSwordAdd = Engine.diamondSword * 4;
            Engine.count3 = Engine.count3 + Engine.woodenSwordAdd;
            Engine.count3 = Engine.count3 + Engine.stoneSwordAdd;
            Engine.count3 = Engine.count3 + Engine.ironSwordAdd;
            Engine.count3 = Engine.count3 + Engine.diamondSwordAdd;
            Engine.count3 = Engine.count3 + Engine.fireboltAdd;
            Engine.count3 = Engine.count3 + Engine.waterwaveAdd;
            Engine.count3 = Engine.count3 + Engine.voltswtichAdd;

            double damage = Engine.woodenSwordAdd + Engine.stoneSwordAdd + Engine.ironSwordAdd + Engine.diamondSwordAdd
                + Engine.fireboltAdd + Engine.waterwaveAdd + Engine.voltswtichAdd + 1;


            try
            {
                bossBar.Value = bossBar.Value - System.Convert.ToInt32(damage);
            }
            catch (Exception e6)
            {
                bossBar.Value = 0;
            }

            bossNumber = bossNumber - System.Convert.ToInt32(damage);

            if (bossNumber < 0)
            {
                bossNumber = 0;
            }

            bossHP.Text = "Boss HP: " + bossNumber + " / " + "5000";

            bossDamageInflict = bRandom.Next(1, 70);

            finalHealth = finalHealth - bossDamageInflict;

            try
            {
                healthBar.Value = healthBar.Value - bossDamageInflict;
            }
            catch (Exception e5)
            {
                healthBar.Value = 0;
            }

            if (finalHealth < 0)
            {
                finalHealth = 0;
            }

            if (finalHealth <= 0)
            {
                finalHealth = Engine.totalHealth - Engine.totalHealth;
                hp.Text = "HItPoints: " + finalHealth + " / " + Engine.totalHealth;
                Death gOver = new Death();
                gOver.ShowDialog();
            }

            hp.Text = "HItPoints: " + finalHealth.ToString() + " / " + Engine.totalHealth;

            if (bossNumber <= 0)
            {
                victory.Play();
                boop.Visible = true;
                end.Visible = true;
                exit.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (potionMenu2.SelectedIndex > -1)
            {
                if (finalHealth == Engine.totalHealth)
                {
                    noH.Visible = true;
                    noH.Text = "You have maximum health";
                }
                else if (potionMenu2.SelectedItem.ToString() == "Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play();

                    Engine.potion = Engine.potion - 1;
                    noH.Visible = false;
                    finalHealth = finalHealth + 10;

                    try
                    {
                        healthBar.Value = healthBar.Value + 10;
                    }
                    catch (Exception e1)
                    {
                        healthBar.Value = Engine.totalHealth;
                    }

                    if (finalHealth > Engine.totalHealth)
                    {
                        finalHealth = Engine.totalHealth;
                    }

                    hp.Text = "HItPoints: " + finalHealth + " / " + Engine.totalHealth;
                    potionMenu2.Items.Remove(potionMenu2.SelectedItem);
                }
                else if (potionMenu2.SelectedItem.ToString() == "Upgraded Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play();

                    Engine.upgradedPotion = Engine.upgradedPotion - 1;
                    noH.Visible = false;
                    finalHealth = finalHealth + 25;

                    try
                    {
                        healthBar.Value = healthBar.Value + 25;
                    }
                    catch (Exception e2)
                    {
                        healthBar.Value = Engine.totalHealth;
                    }


                    if (finalHealth > Engine.totalHealth)
                    {
                        finalHealth = Engine.totalHealth;
                    }

                    hp.Text = "HItPoints: " + finalHealth + " / " + Engine.totalHealth;
                    potionMenu2.Items.Remove(potionMenu2.SelectedItem);
                }
                else if (potionMenu2.SelectedItem.ToString() == "Super Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play();

                    Engine.superPotion = Engine.superPotion - 1;
                    noH.Visible = false;
                    finalHealth = finalHealth + 55;

                    try
                    {
                        healthBar.Value = healthBar.Value + 55;
                    }
                    catch (Exception e10)
                    {
                        healthBar.Value = Engine.totalHealth;
                    }

                    if (finalHealth > Engine.totalHealth)
                    {
                        finalHealth = Engine.totalHealth;
                    }

                    hp.Text = "HItPoints: " + finalHealth + " / " + Engine.totalHealth;
                    potionMenu2.Items.Remove(potionMenu2.SelectedItem);
                }
                else if (potionMenu2.SelectedItem.ToString() == "Ultra Health Potion")
                {
                    SoundPlayer heal = new SoundPlayer(Idle_Game.Properties.Resources.bottle);
                    heal.Play();

                    Engine.ultraPotion = Engine.ultraPotion - 1;
                    noH.Visible = false;
                    finalHealth = finalHealth + 115;

                    try
                    {
                        healthBar.Value = healthBar.Value + 115;
                    }
                    catch (Exception e10)
                    {
                        healthBar.Value = Engine.totalHealth;
                    }

                    if (finalHealth > Engine.totalHealth)
                    {
                        finalHealth = Engine.totalHealth;
                    }

                    hp.Text = "HItPoints: " + finalHealth + " / " + Engine.totalHealth;
                    potionMenu2.Items.Remove(potionMenu2.SelectedItem);
                }
            }
            else
            {
                noH.Visible = true;
                noH.Text = "You don't have a potion to use";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 buttonOwO = new Form1();

            Engine.isBossDead = true;
            Engine.count = Engine.count + 1000000;
            Engine.excalibur = 1;
            Engine.excaliburAdd = 999;
            buttonOwO.newGame.Visible = true;

            if (reward != null)
            {
                reward.UpdadeScreen(); 
            }

            if (button != null)
            {
                button.UpdateScreenButton(); 
            }

            victory.Stop(); 
            this.Close();  
        }

        public Interfaces reward;
        public Interfaces button;

        private void Boss_Load(object sender, EventArgs e)
        {
            battle.Play(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            hint.Visible = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;

namespace Idle_Game
{
    public partial class Clicker : Form, ClickerInterfaces
    {
        string sSourceData, sSourceData2;
        byte[] tmpSource, tmpHash, tmpNewHash, tmpSource2;
        double a = 0.1;

        public Clicker()
        {
            InitializeComponent();
            this.Icon = Idle_Game.Properties.Resources.icon;
            ToolTip cps = new ToolTip();
            double CPS = ClickEngine.clickers * a + ClickEngine.warrior + ClickEngine.knight * 8 + ClickEngine.mage * 47 + ClickEngine.wizard * 260; 
            cps.SetToolTip(btClick, "CPS: " + System.Convert.ToDouble(CPS)); 
        }

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

        private void Exit_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure? Any unsaved progress will be lost!", "Warning!", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btClick_Click(object sender, EventArgs e)
        {
            if (ClickEngine.clickers > 0)
            {
                passiveTimer.Interval = 1000;
                passiveTimer.Enabled = true;
                passive.Text = "Clickers: " + ClickEngine.clickers;
            }

            if (ClickEngine.warrior > 0)
            {
                warriorTimer.Interval = 1000;
                warriorTimer.Enabled = true;
                warriorTotal.Text = "Warriors: " + ClickEngine.warrior;
            }

            if (ClickEngine.knight > 0)
            {
                knightTimer.Interval = 1000;
                knightTimer.Enabled = true;
                knightTotal.Text = "Knights: " + ClickEngine.knight;
            }

            if (ClickEngine.mage > 0)
            {
                mageTimer.Interval = 1000;
                mageTimer.Enabled = true;
                mageTotal.Text = "Mages: " + ClickEngine.mage;
            }

            if (ClickEngine.wizard > 0)
            {
                wizardTimer.Interval = 1000;
                wizardTimer.Enabled = true;
                wizardTotal.Text = "Wizards: " + ClickEngine.wizard;
            }

            ClickEngine.totalClicks++;

            var opl = Convert.ToDecimal(ClickEngine.totalClicks.ToString().Split('.').FirstOrDefault());
            click.Text = "Clicks: " + opl;

            ToolTip cps = new ToolTip();
            double CPS = ClickEngine.clickers * a + ClickEngine.warrior + ClickEngine.knight * 8 + ClickEngine.mage * 47 + ClickEngine.wizard * 260;
            cps.SetToolTip(btClick, "CPS: " + System.Convert.ToDouble(CPS));
        }

        // Load

        private void Clicker_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a very basic and pointless clicker game I made as an extra so please do enjoy but don't except anything special!", "Warning!", MessageBoxButtons.OK);
            click.Text = "Clicks: " + ClickEngine.totalClicks;
        }

        // Load

        // Timers

        private void passiveTimer_Tick(object sender, EventArgs e)
        {
            double calculate = ClickEngine.clickers * a;
            ClickEngine.totalClicks = ClickEngine.totalClicks + calculate;
            var opl = Convert.ToDecimal(ClickEngine.totalClicks.ToString().Split('.').FirstOrDefault());
            click.Text = "Clicks: " + opl;
        }

        private void warriorTimer_Tick(object sender, EventArgs e)
        {
            ClickEngine.totalClicks = ClickEngine.totalClicks + ClickEngine.warrior;
            var opl = Convert.ToDecimal(ClickEngine.totalClicks.ToString().Split('.').FirstOrDefault());
            click.Text = "Clicks: " + opl;
        }

        private void knightTimer_Tick(object sender, EventArgs e)
        {
            int calculate = ClickEngine.knight * 8;
            ClickEngine.totalClicks = ClickEngine.totalClicks + calculate;
            var opl = Convert.ToDecimal(ClickEngine.totalClicks.ToString().Split('.').FirstOrDefault());
            click.Text = "Clicks: " + opl;
        }

        private void mageTimer_Tick(object sender, EventArgs e)
        {
            int calculate = ClickEngine.mage * 47;
            ClickEngine.totalClicks = ClickEngine.totalClicks + calculate;
            var opl = Convert.ToDecimal(ClickEngine.totalClicks.ToString().Split('.').FirstOrDefault());
            click.Text = "Clicks: " + opl;
        }

        private void wizardTimer_Tick(object sender, EventArgs e)
        {
            int calculate = ClickEngine.mage * 260;
            ClickEngine.totalClicks = ClickEngine.totalClicks + calculate;
            var opl = Convert.ToDecimal(ClickEngine.totalClicks.ToString().Split('.').FirstOrDefault());
            click.Text = "Clicks: " + opl;
        }

        // Timers

        // Just button

        private void btUpgrades_Click(object sender, EventArgs e)
        {
            ClickerShop shop = new ClickerShop();
            shop.update = this;
            shop.ShowDialog(); 
        }

        // Just button

        // Interface updater

        public void UpdateUpgrades()
        {
            click.Text = "Clicks: " + ClickEngine.totalClicks;

            if (ClickEngine.clickers > 0)
            {
                passive.Text = "Clickers: " + ClickEngine.clickers;
                passiveTimer.Interval = 1000;
                passiveTimer.Enabled = true;
            }

            if (ClickEngine.warrior > 0)
            {
                warriorTotal.Text = "Warriors: " + ClickEngine.warrior;
                warriorTimer.Interval = 1000;
                warriorTimer.Enabled = true;
            }

            if (ClickEngine.knight > 0)
            {
                knightTotal.Text = "Knights: " + ClickEngine.knight;
                warriorTimer.Interval = 1000;
                warriorTimer.Enabled = true;
            }

            if (ClickEngine.mage > 0)
            {
                mageTotal.Text = "Mages: " + ClickEngine.mage;
                mageTimer.Interval = 1000;
                mageTimer.Enabled = true;
            }

            if (ClickEngine.wizard > 0)
            {
                wizardTotal.Text = "Wizards: " + ClickEngine.wizard;
                wizardTimer.Interval = 1000;
                wizardTimer.Enabled = true;
            }
        }

        // Interface updater

        // Save/Load

        private void save_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will overwrite the previous save! Are you sure you want to save?", "Warning!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ClickerSaving save = new ClickerSaving
                {
                    totalClicks = ClickEngine.totalClicks,
                    clickers = ClickEngine.clickers,
                    clickerPrice = ClickEngine.clickersPrice,
                    woodenSword = ClickEngine.warrior,
                    woodenPrice = ClickEngine.warriorPrice,
                    stoneSword = ClickEngine.knight,
                    stonePrice = ClickEngine.knightPrice,
                    mage = ClickEngine.mage, 
                    magePrice = ClickEngine.magePrice, 
                    wizard = ClickEngine.wizard, 
                    wizardPrice = ClickEngine.wizardPrice
                };

                string JSONSave = JsonConvert.SerializeObject(save);
                string directoryPath = string.Format(@"Saves\", Application.StartupPath);
                string path = String.Format(@"{0}\Saves\" + Engine.name + "'s Clicker Save.json", Application.StartupPath);
                string path2 = String.Format(@"{0}\Saves\" + Engine.name + "'s Clicker MD5Hash.txt", Application.StartupPath);

                DirectoryInfo saves = Directory.CreateDirectory(directoryPath);

                if (File.Exists(path))
                {
                    File.Delete(path);
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(JSONSave.ToString());
                        tw.Close();
                    }
                }
                else if (!File.Exists(path))
                {
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(JSONSave.ToString());
                        tw.Close();
                    }
                }

                sSourceData = string.Format(path);
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

                string path3 = String.Format(@"{0}\Saves\" + Engine.name + "'s Clicker MD5Hash.txt", Application.StartupPath);
                File.SetAttributes(path3, File.GetAttributes(path3) | FileAttributes.Hidden);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            bool bEqual = false;
            string path = String.Format(@"{0}\Saves\" + Engine.name + "'s Clicker Save.json", Application.StartupPath);

            try
            {
                sSourceData2 = String.Format(path);
                tmpSource2 = File.ReadAllBytes(sSourceData2);
                tmpNewHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource2);

                int j;
                StringBuilder sOutput2 = new StringBuilder(tmpNewHash.Length);
                for (j = 0; j < tmpNewHash.Length; j++)
                {
                    sOutput2.Append(tmpNewHash[j].ToString("X2"));
                }

                string md5 = "";
                string path2 = String.Format(@"{0}\Saves\" + Engine.name + "'s Clicker MD5Hash.txt", Application.StartupPath);

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
                    string path3 = String.Format(@"{0}\Saves\" + Engine.name + "'s Clicker Save.json", Application.StartupPath);
                    using (var tw = new StreamReader(path3, true))
                    {
                        json = tw.ReadToEnd();
                        tw.Close();
                    }
                    ClickerSaving load = JsonConvert.DeserializeObject<ClickerSaving>(json);

                    ClickEngine.totalClicks = load.totalClicks;
                    ClickEngine.clickers = load.clickers;
                    ClickEngine.clickersPrice = load.clickerPrice;
                    ClickEngine.warrior = load.woodenSword;
                    ClickEngine.warriorPrice = load.woodenPrice;
                    ClickEngine.knight = load.stoneSword;
                    ClickEngine.knightPrice = load.stonePrice;
                    ClickEngine.mage = load.mage;
                    ClickEngine.magePrice = load.magePrice;
                    ClickEngine.wizard = load.wizard;
                    ClickEngine.wizardPrice = load.wizardPrice;

                    click.Text = "Clicks: " + ClickEngine.totalClicks;

                    if (ClickEngine.clickers > 0)
                    {
                        passiveTimer.Interval = 1000;
                        passiveTimer.Enabled = true;
                        passive.Text = "Clickers: " + ClickEngine.clickers;
                    }

                    if (ClickEngine.warrior > 0)
                    {
                        warriorTimer.Interval = 1000;
                        warriorTimer.Enabled = true;
                        warriorTotal.Text = "Warriors: " + ClickEngine.warrior;
                    }

                    if (ClickEngine.knight > 0)
                    {
                        knightTimer.Interval = 1000;
                        knightTimer.Enabled = true;
                        knightTotal.Text = "Knights: " + ClickEngine.knight;
                    }

                    if (ClickEngine.mage > 0)
                    {
                        mageTotal.Text = "Mages: " + ClickEngine.mage;
                        mageTimer.Interval = 1000;
                        mageTimer.Enabled = true;
                    }

                    if (ClickEngine.wizard > 0)
                    {
                        wizardTotal.Text = "Wizards: " + ClickEngine.wizard;
                        wizardTimer.Interval = 1000;
                        wizardTimer.Enabled = true;
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

        // Save;Load
    }
}

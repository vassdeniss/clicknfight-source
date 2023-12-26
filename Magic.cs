using ClickNFight.Spells;

using System;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class Magic : Form
    {
        public Magic()
        {
            this.InitializeComponent();
            this.Icon = Properties.Resources.icon;

            ToolTip description = new ToolTip();
            description.SetToolTip(
                waterWave,
                "4 Air, 5 Water and 3 Blood Rune"
                + "\r\n"
                + "+ 10 (Invinvible) Clicks Per Second"
                + "\r\n"
                + "Duration: 2 minutes"
                + "\r\n"
                + "Cooldown: 10 Minutes"
            );
            description.SetToolTip(
                voltSwtich,
                "6 Air, 7 Electric, 5 Blood Runes and a Wrath Rune"
                + "\r\n"
                + "+ 20 (Invinsible) Clicks Per Second"
                + "\r\n"
                + "Duration: 3 minutes"
                + "\r\n"
                + "Cooldown: 15 Minutes"
            );

            description.SetToolTip(
                exDefence,
                "4 Air, 5 Lava and 3 Cosmic Runes"
                + "\r\n"
                + "+ 2 Damage Reduction"
                + "\r\n"
                + "Duration: 2 minute"
                + "\r\n"
                + "Cooldown: 10 Minutes"
            );
            description.SetToolTip(
                maxDefence,
                "7 Air, 8 Steam, 6 Cosmic and 2 Astral Runes"
                + "\r\n"
                + "+ 4 Damage Reduction "
                + "\r\n"
                + "Duration: 3 minute"
                + "\r\n"
                + "Cooldown: 15 Minutes"
            );

            description.SetToolTip(
                healara,
                "3 Air and 4 Mind Runes"
                + "\r\n"
                + "Tmmporary + 10 Max Health"
                + "\r\n"
                + "Duration: 1 minute"
                + "\r\n"
                + "Cooldown: 5 Minutes"
            );
            description.SetToolTip(
                cureraga,
                "5 Air, 6 Nature and 4 Life Runes"
                + "\r\n"
                + "Temporary + 20 Max Health"
                + "\r\n"
                + "Duration: 2 minute"
                + "\r\n"
                + "Cooldown: 10 Minutes"
            );
            description.SetToolTip(
                rearise,
                "7 Air, 6 Life, 8 Revive and 2 Soul Runes "
                + "\r\n"
                + "Temporary + 40 Max Health"
                + "\r\n"
                + "Duration: 3 minute"
                + "\r\n"
                + "Cooldown: 15 Minutes"
            );
        }

        public Magic(Hero hero)
            : this()
        {
            this._hero = hero;

            foreach (Spell spell in this._hero.Spells)
            {
                this.spellsComboBox.Items.Add(spell);
            }

            if (this._hero.ActiveSpell != null && this._hero.ActiveSpell.IsOnCooldown)
            {
                this.castButton.Enabled = false;
            }
        }

        // Heal
        // Heal HP
        // Increase mas

        private readonly Hero _hero;

        private async void CastButton_Clicked(object sender, EventArgs e)
        {
            if (this._hero.ActiveSpell is null)
            {
                return;
            }

            if (!this._hero.ActiveSpell.CanCast(this._hero, out string message))
            {
                MessageBox.Show(message, "Warning!", MessageBoxButtons.OK);
                return;
            }

            await this._hero.ActiveSpell.Cast(this._hero);
        }

        private void SpellsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            Spell spell = box?.SelectedItem as Spell;
            this.spellInfoTextBox.Text = spell?.Description();

            if (this._hero.ActiveSpell == null || !this._hero.ActiveSpell.IsOnCooldown)
            {
                this._hero.ActiveSpell = spell;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 4 && Engine.lavaRunes >= 5 && Engine.cosmicRunes >= 3)
            {
                Engine.airRunes = Engine.airRunes - 4;
                Engine.lavaRunes = Engine.lavaRunes - 5;
                Engine.defence = Engine.defence + 2;
                Engine.defenceReduction = Engine.defenceReduction + 2;

                extraDefenceCooldown.Interval = 600000;
                extraDefenceCooldown.Tick += extraDefenceCooldown_Tick;
                extraDefenceCooldown.Enabled = true;
                exDefence.Enabled = false;

                defenceBoost2.Interval = 120000;
                defenceBoost2.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "You don't have enough runes to cast this spell",
                    "Not enough runes",
                    MessageBoxButtons.OK
                );
            }
        }

        private void extraDefenceCooldown_Tick(object sender, EventArgs e)
        {
            exDefence.Enabled = true;
            extraDefenceCooldown.Enabled = false;
        }

        private void defenceBoost2_Tick(object sender, EventArgs e)
        {
            Engine.defence = Engine.defence - 2;
            Engine.defenceReduction = Engine.defenceReduction - 2;

            defenceBoost2.Enabled = false;
        }

        private void maxDefence_Click(object sender, EventArgs e)
        {
            if (
                Engine.airRunes >= 7
                && Engine.steamRunes >= 8
                && Engine.cosmicRunes >= 6
                && Engine.astralRunes >= 2
            )
            {
                Engine.airRunes = Engine.airRunes - 7;
                Engine.steamRunes = Engine.steamRunes - 8;
                Engine.cosmicRunes = Engine.cosmicRunes - 6;
                Engine.astralRunes = Engine.astralRunes - 2;
                Engine.defence = Engine.defence + 4;
                Engine.defenceReduction = Engine.defenceReduction + 4;

                defenceCooldown3.Interval = 900000;
                defenceCooldown3.Tick += defenceCooldown3_Tick;
                defenceCooldown3.Enabled = true;
                maxDefence.Enabled = false;

                defenceBoost3.Interval = 120000;
                defenceBoost3.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "You don't have enough runes to cast this spell",
                    "Not enough runes",
                    MessageBoxButtons.OK
                );
            }
        }

        private void defenceCooldown3_Tick(object sender, EventArgs e)
        {
            maxDefence.Enabled = true;
            defenceBoost3.Enabled = false;
        }

        private void defenceBoost3_Tick(object sender, EventArgs e)
        {
            Engine.defence = Engine.defence - 4;
            Engine.defenceReduction = Engine.defenceReduction - 4;

            defenceBoost3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 4 && Engine.waterRunes >= 5 && Engine.bloodRunes >= 3)
            {
                Engine.airRunes = Engine.airRunes - 4;
                Engine.waterRunes = Engine.waterRunes - 5;
                Engine.bloodRunes = Engine.bloodRunes - 3;
                Engine.waterwaveAdd = 10;

                waterCooldown.Interval = 600000;
                waterCooldown.Tick += waterCooldown_Tick;
                waterCooldown.Enabled = true;
                waterWave.Enabled = false;

                attackBoost2.Interval = 120000;
                attackBoost2.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "You don't have enough runes to cast this spell",
                    "Not enough runes",
                    MessageBoxButtons.OK
                );
            }
        }

        private void waterCooldown_Tick(object sender, EventArgs e)
        {
            waterWave.Enabled = true;
            waterCooldown.Stop();
        }

        private void attackBoost2_Tick(object sender, EventArgs e)
        {
            Engine.waterwaveAdd = 0;
            attackBoost2.Enabled = false;
        }

        private void healara_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 3 && Engine.mindRunes >= 4)
            {
                Form1 bar = new Form1();

                Engine.airRunes = Engine.airRunes - 3;
                Engine.mindRunes = Engine.mindRunes - 4;
                Engine.health = Engine.health + 10;
                Engine.totalHealth = Engine.totalHealth + 10;

                if (healPlayer != null)
                {
                    healPlayer.UpdateScreenHeal();
                }

                healaraCooldown.Interval = 300000;
                healaraCooldown.Tick += healaraCooldown_Tick;
                healaraCooldown.Enabled = true;
                healara.Enabled = false;

                hpUp.Interval = 60000;
                hpUp.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "You don't have enough runes to cast this spell",
                    "Not enough runes",
                    MessageBoxButtons.OK
                );
            }
        }

        private void healaraCooldown_Tick(object sender, EventArgs e)
        {
            healara.Enabled = true;
            healaraCooldown.Stop();
        }

        private void hpUp_Tick(object sender, EventArgs e)
        {
            Engine.totalHealth = Engine.totalHealth - 10;
            hpUp.Enabled = false;

            if (healPlayer != null)
            {
                healPlayer.UpdateScreenHeal();
            }
        }

        private void cureraga_Click(object sender, EventArgs e)
        {
            if (Engine.airRunes >= 5 && Engine.natureRunes >= 6 && Engine.lifeRunes >= 4)
            {
                Form1 bar = new Form1();

                Engine.airRunes = Engine.airRunes - 5;
                Engine.natureRunes = Engine.natureRunes - 6;
                Engine.lifeRunes = Engine.lifeRunes - 4;
                Engine.health = Engine.health + 20;
                Engine.totalHealth = Engine.totalHealth + 20;

                if (healPlayer2 != null)
                {
                    healPlayer2.UpdateScreenHeal2();
                }

                cureragaCooldown.Interval = 600000;
                cureragaCooldown.Tick += cureragaCooldown_Tick;
                cureragaCooldown.Enabled = true;
                cureraga.Enabled = false;

                hpUp2.Interval = 120000;
                hpUp2.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "You don't have enough runes to cast this spell",
                    "Not enough runes",
                    MessageBoxButtons.OK
                );
            }
        }

        private void cureragaCooldown_Tick(object sender, EventArgs e)
        {
            cureraga.Enabled = true;
            cureragaCooldown.Enabled = false;
        }

        private void hpUp2_Tick(object sender, EventArgs e)
        {
            Engine.totalHealth = Engine.totalHealth - 20;
            hpUp2.Enabled = false;

            if (healPlayer2 != null)
            {
                healPlayer2.UpdateScreenHeal();
            }
        }

        private void voltSwtich_Click(object sender, EventArgs e)
        {
            if (
                Engine.airRunes >= 6
                && Engine.bloodRunes >= 5
                && Engine.electricRunes >= 7
                && Engine.wrathRunes >= 1
            )
            {
                Engine.airRunes = Engine.airRunes - 6;
                Engine.electricRunes = Engine.electricRunes - 7;
                Engine.bloodRunes = Engine.bloodRunes - 5;
                Engine.wrathRunes = Engine.wrathRunes - 1;
                Engine.voltswtichAdd = 20;

                voltCooldown.Interval = 900000;
                voltCooldown.Tick += voltCooldown_Tick;
                voltCooldown.Enabled = true;
                voltSwtich.Enabled = false;

                attackBoost3.Interval = 180000;
                attackBoost3.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "You don't have enough runes to cast this spell",
                    "Not enough runes",
                    MessageBoxButtons.OK
                );
            }
        }

        private void voltCooldown_Tick(object sender, EventArgs e)
        {
            voltSwtich.Enabled = true;
            voltCooldown.Enabled = false;
        }

        private void attackBoost3_Tick(object sender, EventArgs e)
        {
            Engine.voltswtichAdd = 0;
            attackBoost3.Enabled = false;
        }

        private void rearise_Click(object sender, EventArgs e)
        {
            if (
                Engine.airRunes >= 7
                && Engine.reviveRunes >= 8
                && Engine.lifeRunes >= 6
                && Engine.soulRunes >= 2
            )
            {
                Form1 bar = new Form1();

                Engine.airRunes = Engine.airRunes - 7;
                Engine.reviveRunes = Engine.reviveRunes - 8;
                Engine.lifeRunes = Engine.lifeRunes - 6;
                Engine.soulRunes = Engine.soulRunes - 2;
                Engine.health = Engine.health + 40;
                Engine.totalHealth = Engine.totalHealth + 40;

                if (healPlayer3 != null)
                {
                    healPlayer3.UpdateScreenHeal3();
                }

                reariseCooldown.Interval = 900000;
                reariseCooldown.Tick += reariseCooldown_Tick;
                reariseCooldown.Enabled = true;
                rearise.Enabled = false;

                hpUp3.Interval = 120000;
                hpUp3.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "You don't have enough runes to cast this spell",
                    "Not enough runes",
                    MessageBoxButtons.OK
                );
            }
        }

        private void reariseCooldown_Tick(object sender, EventArgs e)
        {
            rearise.Enabled = true;
            reariseCooldown.Enabled = false;
        }

        private void hpUp3_Tick(object sender, EventArgs e)
        {
            Engine.totalHealth = Engine.totalHealth - 40;
            hpUp3.Enabled = false;

            if (healPlayer3 != null)
            {
                healPlayer3.UpdateScreenHeal();
            }
        }

        public IUiRefreshers owo;
        public IUiRefreshers healPlayer;
        public IUiRefreshers healPlayer2;
        public IUiRefreshers healPlayer3;
    }
}

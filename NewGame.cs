using System;
using System.Windows.Forms;

namespace ClickNFight
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            Icon = ClickNFight.Properties.Resources.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 220;
            Engine.defence = 0;
            Engine.defenceReduction = 0;
            Engine.totalHealth = 220;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.silverSword = false;
            Engine.goldSword = false;
            Engine.platinumSword = false;
            Engine.cobaltSword = false;
            Engine.starSword = false;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.silverSwordAdd = 0;
            Engine.goldSwordAdd = 0;
            Engine.platinumSwordAdd = 0;
            Engine.cobaltSwordAdd = 0;
            Engine.starSwordAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;
            Engine.diamondSword = 999;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameOn = true;

            if (button != null)
            {
                button.UpdateScreenButtonOff();
            }

            this.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 200;
            Engine.defence = 2;
            Engine.defenceReduction = 2;
            Engine.totalHealth = 200;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;
            Engine.diamondSword = 999;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameDefenceOn = true;

            if (update != null)
            {
                update.UpdateScreenNewGame();
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 200;
            Engine.defence = 0;
            Engine.defenceReduction = 0;
            Engine.totalHealth = 200;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.isNewGameOn = false;
            Engine.newgameAdd = 4;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;
            Engine.diamondSword = 999;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameClicksOn = true;

            if (newClicks != null)
            {
                newClicks.UpdateScreenNewGameClicks();
            }

            this.Close();
        }

        public Interfaces button;
        public Interfaces update;
        public Interfaces newClicks;

        private void NewGame_Load(object sender, EventArgs e)
        {
            newGamePlusCPS2.Enabled = false;
            newGamePlusDef2.Enabled = false;
            newGamePlusHP2.Enabled = false;

            if (Engine.isNewGameClicksOn == true || Engine.isNewGameOn == true || Engine.isNewGameDefenceOn == true)
            {
                newGamePlusCPS.Enabled = false;
                newGamePlusDef.Enabled = false;
                newGamePlusHP.Enabled = false;
                newGamePlusCPS2.Enabled = true;
                newGamePlusDef2.Enabled = true;
                newGamePlusHP2.Enabled = true;
            }
        }

        private void newGamePlusHP2_Click(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 240;
            Engine.defence = 0;
            Engine.defenceReduction = 0;
            Engine.totalHealth = 240;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.silverSword = false;
            Engine.goldSword = false;
            Engine.platinumSword = false;
            Engine.cobaltSword = false;
            Engine.starSword = false;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.silverSwordAdd = 0;
            Engine.goldSwordAdd = 0;
            Engine.platinumSwordAdd = 0;
            Engine.cobaltSwordAdd = 0;
            Engine.starSwordAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameOn2 = true;

            if (button != null)
            {
                button.UpdateScreenButtonOff();
            }

            this.Close();
        }

        private void newGamePlusDef2_Click(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 200;
            Engine.defence = 4;
            Engine.defenceReduction = 4;
            Engine.totalHealth = 200;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameDefenceOn2 = true;

            if (update != null)
            {
                update.UpdateScreenNewGame();
            }

            this.Close();
        }

        private void newGamePlusCPS2_Click(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 200;
            Engine.defence = 0;
            Engine.defenceReduction = 0;
            Engine.totalHealth = 200;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.isNewGameOn = false;
            Engine.newgameAdd = 9;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameClicksOn2 = true;

            if (newClicks != null)
            {
                newClicks.UpdateScreenNewGameClicks();
            }

            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 260;
            Engine.defence = 0;
            Engine.defenceReduction = 0;
            Engine.totalHealth = 260;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.silverSword = false;
            Engine.goldSword = false;
            Engine.platinumSword = false;
            Engine.cobaltSword = false;
            Engine.starSword = false;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.silverSwordAdd = 0;
            Engine.goldSwordAdd = 0;
            Engine.platinumSwordAdd = 0;
            Engine.cobaltSwordAdd = 0;
            Engine.starSwordAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameOn3 = true;

            if (button != null)
            {
                button.UpdateScreenButtonOff();
            }

            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 200;
            Engine.defence = 6;
            Engine.defenceReduction = 6;
            Engine.totalHealth = 200;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameDefenceOn3 = true;

            if (update != null)
            {
                update.UpdateScreenNewGame();
            }

            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Engine.level = 1;
            Engine.currency = 0;
            Engine.kills = 0;
            Engine.count3 = 0;
            Engine.XP = 0;
            Engine.totalXP = 250;
            Engine.money = 0;
            Engine.health = 200;
            Engine.defence = 0;
            Engine.defenceReduction = 0;
            Engine.totalHealth = 200;
            Engine.damage = 0;
            Engine.woodenSword = 0;
            Engine.stoneSword = 0;
            Engine.ironSword = 0;
            Engine.diamondSword = 0;
            Engine.excalibur = 0;
            Engine.woodenSwordAdd = 0;
            Engine.stoneSwordAdd = 0;
            Engine.ironSwordAdd = 0;
            Engine.diamondSwordAdd = 0;
            Engine.excaliburAdd = 0;
            Engine.fireboltAdd = 0;
            Engine.waterwaveAdd = 0;
            Engine.voltswtichAdd = 0;
            Engine.potion = 0;
            Engine.upgradedPotion = 0;
            Engine.superPotion = 0;
            Engine.ultraPotion = 0;
            Engine.airRunes = 0;
            Engine.fireRunes = 0;
            Engine.earthRunes = 0;
            Engine.mindRunes = 0;
            Engine.waterRunes = 0;
            Engine.lavaRunes = 0;
            Engine.natureRunes = 0;
            Engine.electricRunes = 0;
            Engine.steamRunes = 0;
            Engine.bloodRunes = 0;
            Engine.cosmicRunes = 0;
            Engine.lifeRunes = 0;
            Engine.reviveRunes = 0;
            Engine.wrathRunes = 0;
            Engine.astralRunes = 0;
            Engine.soulRunes = 0;
            Engine.isBossDead = false;
            Engine.isNewGameOn = false;
            Engine.newgameAdd = 9;
            Engine.silverPick = false;
            Engine.goldPick = false;
            Engine.platPick = false;
            Engine.cobPick = false;
            Engine.starPick = false;
            Engine.silverOreTake = 0;
            Engine.goldOreTake = 0;
            Engine.platinumOreTake = 0;
            Engine.cobaltOreTake = 0;
            Engine.starOreTake = 0;
            Engine.silverOreTotal = 0;
            Engine.goldOreTotal = 0;
            Engine.platinumOreTotal = 0;
            Engine.cobaltOreTotal = 0;
            Engine.starOreTotal = 0;
            Engine.wood = 0;
            Engine.flint = 0;
            Engine.steel = 0;
            Engine.stone = 0;

            Form1 buttonOwO = new Form1();
            buttonOwO.finalBoss.Enabled = false;
            buttonOwO.btMagic.Enabled = false;
            buttonOwO.btCrafting.Enabled = false;
            buttonOwO.btMine.Enabled = false;
            buttonOwO.btCamp.Enabled = false;
            Engine.isNewGameClicksOn3 = true;

            if (newClicks != null)
            {
                newClicks.UpdateScreenNewGameClicks();
            }

            this.Close();
        }
    }
}

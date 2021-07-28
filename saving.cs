using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization; 


namespace Idle_Game
{
    public class saving
    {
        public int level { get; set; }

        public double count { get; set; }
        public double count2 { get; set; }
        public double count3 { get; set; }

        public int XP { get; set; }
        public int totalXP { get; set; }

        public double money { get; set; }

        public double health { get; set; }
        public int defence { get; set; }
        public double defenceReduction { get; set; }
        public int totalHealth { get; set; }
        public int damage { get; set; }

        public int woodenSword { get; set; }
        public int stoneSword { get; set; }
        public int ironSword { get; set; }
        public int diamondSword { get; set; }
        public int excalibur { get; set; }
        public bool silverSword { get; set; }
        public bool goldSword { get; set; }
        public bool platinumSword { get; set; }
        public bool cobaltSword { get; set; }
        public bool starSword { get; set; }

        public double woodenSwordAdd { get; set; }
        public double stoneSwordAdd { get; set; }
        public double ironSwordAdd { get; set; }
        public double diamondSwordAdd { get; set; }
        public double excaliburAdd { get; set; }
        public double fireboltAdd { get; set; }
        public double waterwaveAdd { get; set; }
        public double voltswtichAdd { get; set; }
        public double newgameAdd { get; set; }
        public double silverSwordAdd { get; set; }
        public double goldSwordAdd { get; set; }
        public double platinumSwordAdd { get; set; }
        public double cobaltSwordAdd { get; set; }
        public double starSwordAdd { get; set; }

        public int potion { get; set; }
        public int upgradedPotion { get; set; }
        public int superPotion { get; set; }
        public int ultraPotion { get; set; }

        public int airRunes { get; set; }
        public int fireRunes { get; set; }
        public int earthRunes { get; set; }
        public int mindRunes { get; set; }
        public int waterRunes { get; set; }
        public int lavaRunes { get; set; }
        public int natureRunes { get; set; }
        public int electricRunes { get; set; }
        public int steamRunes { get; set; }
        public int bloodRunes { get; set; }
        public int cosmicRunes { get; set; }
        public int lifeRunes { get; set; }
        public int reviveRunes { get; set; }
        public int wrathRunes { get; set; }
        public int astralRunes { get; set; }
        public int soulRunes { get; set; }

        public bool isBossDead { get; set; }
        public int bar { get; set; }
        public int barMaximum { get; set; }
        public string[] items { get; set; }

        public bool buttonOn { get; set; }
        public bool isNewGameOn { get; set; }
        public bool isNewGameOn2 { get; set; }
        public bool isNewGameOn3 { get; set; }
        public bool isNewGameClicksOn { get; set; }
        public bool isNewGameClicksOn2 { get; set; }
        public bool isNewGameClicksOn3 { get; set; }
        public bool isNewGameDefenceOn { get; set; }
        public bool isNewGameDefenceOn2 { get; set; }
        public bool isNewGameDefenceOn3 { get; set; }

        public bool FinalBoss { get; set; }
        public bool Magic { get; set; }
        public bool Runes { get; set; }
        public bool Mine { get; set; }

        public bool silverPick { get; set; }
        public bool goldPick { get; set; }
        public bool platPick { get; set; }
        public bool cobPick { get; set; }
        public bool starPick { get; set; }
        public int silverOreTake { get; set; }
        public int silverOreTotal { get; set; }
        public int goldOreTake { get; set; }
        public int goldOreTotal { get; set; }
        public int platOreTake { get; set; }
        public int platOreTotal { get; set; }
        public int cobaltOreTotal { get; set; }
        public int cobaltOreTake { get; set; }
        public int starOreTotal { get; set; }
        public int starOreTake { get; set; }

        public bool btCamp { get; set; }

        public string name { get; set; }

        public int wood { get; set; }
        public int stone { get; set; }
        public int flint { get; set; }
        public int steel { get; set; }
    }
}

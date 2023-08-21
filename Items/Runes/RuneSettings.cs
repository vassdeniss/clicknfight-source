using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickNFight.Items.Runes
{
    public class RuneSettings
    {
        public static string AirRuneName = "Air Runes";
        public static int AirRuneBuyPrice = 30;
        public static int AirRuneBuyLimit = -1;
        public static RuneLevelType AirRuneLevel = RuneLevelType.None;

        public static string FireRuneName = "Fire Runes";
        public static int FireRuneBuyPrice = 50;
        public static int FireRuneBuyLimit = -1;
        public static RuneLevelType FireRuneLevel = RuneLevelType.Low;
    }
}

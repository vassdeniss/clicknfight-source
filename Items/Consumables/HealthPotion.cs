using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickNFight.Items.Consumables
{
    public class HealthPotion : Consumable
    {
        public HealthPotion()
        {
            this.Name = ConsumableSettings.PotionName;
            this.BuyPrice = ConsumableSettings.PotionBuyPrice;
            this.Limit = ConsumableSettings.PotionLimit;
            this.HealAmount = ConsumableSettings.PotionHealAmount;
        }

        public sealed override string Name { get; set; }

        public sealed override int BuyPrice { get; set; }

        public sealed override int Limit { get; set; }

        public sealed override int HealAmount { get; set; }
    }
}

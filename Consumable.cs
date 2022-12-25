using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickNFight
{
    public abstract class Consumable : Item
    {
        public abstract int HealAmount { get; set; }
    }
}

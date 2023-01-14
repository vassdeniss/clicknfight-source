﻿namespace ClickNFight.Items
{
    public abstract class Item
    {
        public abstract string Name { get; set; }

        public abstract int BuyPrice { get; set; }

        public abstract string ShopInformation();
    }
}

using System.Collections.Generic;

namespace FinalBoss
{
    public class Player
    {
        public int Coins { get; private set; }
        public List<Item> ItemsPlayer { get; private set; }

        public Player(int coins)
        {
            this.Coins = coins;
            this.ItemsPlayer = new List<Item>();
        }

        public void BuyItem(Item item)
        {
            ItemsPlayer.Add(item);
            Coins -= item.Price;
        }
    }
}
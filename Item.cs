namespace FinalBoss
{
    public class Item
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Item (string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
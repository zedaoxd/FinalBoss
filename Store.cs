using System;
using System.Collections.Generic;

namespace FinalBoss
{
    public class Store
    {
        List<Item> ItemsStore;

        public Store()
        {
            ItemsStore = new List<Item>()
            {
                new Item("Pao de queijo", 1),
                new Item("Acaraje", 3),
                new Item("Feijoada", 3)
                
            };
        }

        public void PrintGreetigns()
        {
            Console.WriteLine("Bem Vindo a nosa loja!");
            Console.ReadKey();
            Console.WriteLine("Eu vejo que você tem muitos coins com voce...");
            Console.ReadKey();
            Console.WriteLine("Hmmm... Você quer dar uma olhda no nosso inventario? Sim ou Sim? :)");
            Console.ReadKey();
        }

        public void ExecuteStoreLoop(ref Player player)
        {
            while (canBuyAnyItem(player.Coins))
            {
                StoreMenu();

                bool success = int.TryParse(Console.ReadLine(), out int index);

                while (!success || (index<=0 || index > ItemsStore.Count))
                {
                    Console.WriteLine();
                    Console.WriteLine("Eu não conheco esse item, e você não sai daqui ate comprar!");
                    Console.Write("Digite o numero do item que voce quer comprar -> ");
                    success = int.TryParse(Console.ReadLine(), out index);
                }

                if (ItemsStore[index-1].Price <= player.Coins)
                {
                    player.BuyItem(ItemsStore[index-1]);
                    Console.WriteLine();
                    Console.WriteLine($"Você comprou um {ItemsStore[index-1].Name} por ${ItemsStore[index-1].Price}! Você so tem ${player.Coins} coins");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Este item custa ${ItemsStore[index-1].Price} mas você so tem ${player.Coins}");
                }

            }
        }

        void StoreMenu()
        {   
            int aux = 0;
            Console.WriteLine();
            Console.WriteLine("Essas são as nossas opcoes: ");
            foreach (Item item in ItemsStore)
            {
                Console.WriteLine($"{++aux}: {item.Name} - ${item.Price}");
            }
            Console.Write("Digite o numero do item que voce quer comprar -> ");
        }

        bool canBuyAnyItem(int coins)
        {
            foreach (Item item in ItemsStore)
            {
                if (item.Price <= coins)
                {
                    return true;
                }
            }
            return false;
        }

        public void printEnding(ref Player player)
        {
            Console.WriteLine();
            Console.WriteLine("Você não pode comprar mais nada, esses são seus itens: ");
            foreach (Item item in player.ItemsPlayer)
            {
                Console.WriteLine($"- {item.Name}");
            }
            Console.ReadKey();
        }
    }
}
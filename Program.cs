using System;

namespace FinalBoss
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(5);

            var store = new Store();

            store.PrintGreetigns();

            store.ExecuteStoreLoop(ref p1);

            store.printEnding(ref p1);
        }
    }
}

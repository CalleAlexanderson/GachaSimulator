public class Game
{
    public static void Gameplay()
    {
        Inventory inventory = new Inventory();

        string input = "";
        Text.Introduction();

        while (input != "end")
        {
            System.Console.WriteLine($"You currently own {Inventory.gold} gold");
            input = Console.ReadLine();
            if (input.Length >= 4 && input.Substring(0, 4) == "spin")
            {
                //tar input och gör så den bara kollar det som skrivs efter de första 4 bokstäverna
                string number = input.Substring(4, input.Length - 4);
                int result;
                bool converted = int.TryParse(number, out result); //tar det nummer man skriver in och gör till int
                if (Inventory.gold >= 200 * result)
                {
                    for (int i = 0; i < result; i++)
                    {
                        Inventory.UpdateInventory(GachaSpin.Gacha());
                        Inventory.gold = Inventory.gold - 200;
                    }
                }

            }
            else if (input == "inventory")
            {
                inventory.CheckInventory();
            }
            else if (input == "market")
            {
                SilkRoad.Market();
            }
            else if (input == "bounties")
            {
                Bounty.Bounties();
            }
            else if (input == "sell")
            {
                SilkRoad.Sell(inventory);
            }
            else if (input == "clear")
            {
                Console.Clear();
            }
            else if (input == "help")
            {
                Text.Instructions(); //visar vilka kommand/alnternativ man har
            }
            else if (input == "money") //temporär för testing
            {
                Inventory.gold = Inventory.gold + 10000;
            }
        }
    }
}

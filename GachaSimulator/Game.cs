public class Game
{
    public static void Gameplay()
    {
        Inventory inventory = new Inventory();
        Bounty bounty = new Bounty();

        string input = "";
        bool goldShowSwitch = false;
        Text.Introduction();

        while (input != "end")
        {
            if (goldShowSwitch == false)
            {
                System.Console.WriteLine($"You currently own {Inventory.gold} gold");
            }
            input = Console.ReadLine().ToLower();
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
                goldShowSwitch = true;
            }
            else if (input == "market")
            {
                SilkRoad.Market();
                goldShowSwitch = false;
            }
            else if (input == "bounties")
            {
                bounty.Bounties();
                goldShowSwitch = true;
            }
            else if (input == "sell")
            {
                SilkRoad.Sell(inventory);
                goldShowSwitch = false;
            }
            else if (input == "clear")
            {
                Console.Clear();
                goldShowSwitch = false;
            }
            else if (input == "help")
            {
                Text.Instructions(); //visar vilka kommand/alnternativ man har
            }
            else if (input == "money") //temporär för testing
            {
                Inventory.gold = Inventory.gold + 10000;
            }
            else if (input.Length >= 4 && input.Substring(0, 4) == "take")
            {
                //tar input och gör så den bara kollar det som skrivs efter de första 4 bokstäverna
                string quest = input.Substring(4, input.Length - 4);
                string result = bounty.FightManager(quest);
                if (result == "monster won")
                {
                    Console.Clear();
                    System.Console.WriteLine("You Died");
                    Console.ReadLine();
                    input = "end";
                }
            }
        }
    }

    public static string Fight(Player player, Monster monster)
    {
        player.ResetHp();
        while (monster.GetHp() != 0 && player.GetHp() != 0)
        {
            System.Console.WriteLine(player.GetHp());
            System.Console.WriteLine(monster.GetHp());

            string letters = QuickTimeEvents(monster);
            System.Console.WriteLine(letters);
            string input = Console.ReadLine();
            if (input == letters)
            {
                monster.TakeDamage(player);
            }
            else
            {
                player.TakeDamage(monster);
            }
        }

        if (player.GetHp() == 0)
        {
            return "monster won";
        }
        else if (monster.GetHp() == 0)
        {
            if (monster.GetDifficulty() == 3)
            {
                Inventory.gold = Inventory.gold + 2500;
            }
            else if (monster.GetDifficulty() == 2)
            {
                Inventory.gold = Inventory.gold + 1100;
            }
            else
            {
                Inventory.gold = Inventory.gold + 500;
            }
        }
        Console.Clear();

        return null;


        //fixa timer
    }

    private static string QuickTimeEvents(Monster monster)
    {
        Random generator = new Random();
        string letters = "abcdefghijklmnopqrstuvwxyz";
        int length;
        if (monster.GetDifficulty() == 2)
        {
            length = 3;
        }
        else if (monster.GetDifficulty() == 3)
        {
            length = 5;
        }
        else
        {
            length = 1;
        }
        char[] lett = new char[length];
        for (int i = 0; i < lett.Length; i++)
        {
            int pos = generator.Next(letters.Length);
            lett[i] = letters[pos];
        }
        string s = new String(lett);

        return s;
    }
}

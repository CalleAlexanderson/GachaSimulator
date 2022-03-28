public class Game
{
    public static void Gameplay()
    {
        Inventory inventory = new Inventory();
        Bounty bounty = new Bounty();
        Player player = new Player();

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
                string result = "";

                for (int i = 0; i < bounty.currentBounties.Count; i++)
                {
                    if (bounty.currentBounties[i].GetName().ToLower() == quest)
                    {
                        result = bounty.FightManager(quest, player);
                    }
                }

                if (result == "monster won")
                {
                    Console.Clear();
                    System.Console.WriteLine("You Died");
                    Console.ReadLine();
                    input = "end";
                }
            }
            else if (input == "equip")
            {
                string equipInput = Console.ReadLine();

                string[] equipableWeapons = File.ReadAllLines("weapons.txt");
                for (int i = 0; i < equipableWeapons.Length; i++) //går igenom vapnena som finns
                {
                    if (equipInput == equipableWeapons[i]) //kollar om equipInput är något av de vapnen som finns
                    {
                        if (Inventory.weaponInventory[equipInput] > 0)
                        {
                            //remove current equipment + add it to inventory
                            //player change equipment
                            Inventory.weaponInventory[equipInput] -= 1; //tar bort vapnet från inventory
                            System.Console.WriteLine($"you just equiped a {equipInput}");
                        }
                        else if (Inventory.weaponInventory[equipInput] < 1)
                        {
                            System.Console.WriteLine($"you don't own a {equipInput}");
                        }
                    }
                }
            }
        }
    }

    public static string Fight(Player player, Monster monster)
    {
        player.ResetHp();
        Console.Clear();
        while (monster.GetHp() != 0 && player.GetHp() != 0)
        {
            System.Console.WriteLine($"Player hp: {player.GetHp()}");
            System.Console.WriteLine($"{monster.GetName()} hp: {monster.GetHp()}");


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
            System.Console.WriteLine("You won");
            if (monster.GetDifficulty() == 3)
            {
                System.Console.WriteLine("You got 2500 gold");
                Inventory.gold = Inventory.gold + 2500;
            }
            else if (monster.GetDifficulty() == 2)
            {
                System.Console.WriteLine("You got 1100 gold");
                Inventory.gold = Inventory.gold + 1100;
            }
            else
            {
                System.Console.WriteLine("You got 500 gold");
                Inventory.gold = Inventory.gold + 500;
            }
            Console.ReadLine();
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

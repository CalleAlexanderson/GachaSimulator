public class SilkRoad
{
    public static Dictionary<string, int> weaponStock = new Dictionary<string, int>();

    public static void FixMarket(string[] weapons)
    {

        for (int i = 0; i < weapons.Length; i++)
        {
            weaponStock.Add(weapons[i], 10); //gör en ny plats i weaponStock
        }
    }

    public static void Market()
    {
        string[] weaponNames = File.ReadAllLines("weapons.txt"); //tar innehållet i txt filen och gör det till en string array'
        Console.Clear();
        for (int i = 0; i < weaponNames.Length; i++)
        {
            if (i == 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                System.Console.WriteLine($"Common weapons in stock, Price: 180 Gold");
            }
            if (i == 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine();
                System.Console.WriteLine($"Uncommon weapons in stock, Price: 650 Gold");
            }
            if (i == 16)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"Rare weapons in stock, Price: 1750 Gold");
                System.Console.WriteLine();
            }
            if (i == 22)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                System.Console.WriteLine();
                System.Console.WriteLine($"Epic weapons in stock, Price: 4500 Gold");
            }
            if (i == 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine();
                System.Console.WriteLine($"Legendary weapons in stock, Price: 15000 Gold");
            }
            Console.WriteLine($"{weaponStock.ElementAt(i).Key}, Avaliable: {weaponStock.ElementAt(i).Value}\n"); //skriver ut hur många jag har av varje
        }
        System.Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void Buy()
    {
        string[] weaponNames = File.ReadAllLines("weapons.txt"); //tar innehållet i txt filen och gör det till en string array
        string buyInput = Console.ReadLine();
        int goldRequired = 0;

        for (int i = 0; i < weaponNames.Length; i++) //går igenom vapnena som finns
        {
            if (i < 8)
            {
                goldRequired = 180;
            }
            else if (i < 16)
            {
                goldRequired = 650;
            }
            else if (i < 22)
            {
                goldRequired = 1750;
            }
            else if (i < 30)
            {
                goldRequired = 4500;
            }
            else if (i > 35)
            {
                goldRequired = 15000;
            }
            if (buyInput == weaponNames[i]) //kollar om buyInput är något av de vapnen som finns
            {

                if (weaponStock[buyInput] > 0 && Inventory.gold >= goldRequired)
                {
                    Inventory.weaponInventory[buyInput] += 1; //lägger till vapnet i inventory
                    weaponStock[buyInput] -= 1; //tar bort från stock
                    System.Console.WriteLine($"you just bought a {buyInput}");
                    RemoveGold(i); //skickar det vapnet man säljer vidare till AddGold
                }
                else if (Inventory.gold < goldRequired)
                {
                    System.Console.WriteLine($"You dont have enough gold for that, you need {goldRequired - Inventory.gold} more");
                }
                else if (weaponStock[buyInput] < 1)
                {
                    System.Console.WriteLine($"There are no {buyInput}s in stock");
                }
            }
        }
    }

    public static void Sell()
    {
        string[] weaponNames = File.ReadAllLines("weapons.txt"); //tar innehållet i txt filen och gör det till en string array
        string sellInput = Console.ReadLine();

        for (int i = 0; i < weaponNames.Length; i++) //går igenom vapnena som finns
        {
            if (sellInput == weaponNames[i]) //kollar om sellInput är något av de vapnen som finns
            {
                if (Inventory.weaponInventory[sellInput] > 0)
                {
                    Inventory.weaponInventory[sellInput] -= 1; //tar bort vapnet från inventory
                    weaponStock[sellInput] += 1; //lägger till i stock
                    System.Console.WriteLine($"you just sold a {sellInput}");
                    AddGold(i); //skickar det vapnet man säljer vidare till AddGold
                }
                else if (Inventory.weaponInventory[sellInput] < 1)
                {
                    System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
                }
            }
        }
    }

    public static void AddGold(int listPlace)
    {
        if (listPlace < 8)
        {
            Inventory.gold = Inventory.gold + 100; //ger spelaren 100 guld
        }
        else if (listPlace < 16 && listPlace > 7)
        {
            Inventory.gold = Inventory.gold + 150; //ger spelaren 150 guld
        }
        else if (listPlace < 22 && listPlace > 15)
        {
            Inventory.gold = Inventory.gold + 250; //ger spelaren 250 guld
        }
        else if (listPlace < 30 && listPlace > 21)
        {
            Inventory.gold = Inventory.gold + 500; //ger spelaren 500 guld
        }
        else if (listPlace < 35 && listPlace > 29)
        {
            Inventory.gold = Inventory.gold + 2000; //ger spelaren 2000 guld
        }
    }
    public static void RemoveGold(int listPlace)
    {
        if (listPlace < 8)
        {
            Inventory.gold = Inventory.gold - 180;
        }
        else if (listPlace < 16 && listPlace > 7)
        {
            Inventory.gold = Inventory.gold - 650;
        }
        else if (listPlace < 22 && listPlace > 15)
        {
            Inventory.gold = Inventory.gold - 1750;
        }
        else if (listPlace < 30 && listPlace > 21)
        {
            Inventory.gold = Inventory.gold - 4500;
        }
        else if (listPlace < 35 && listPlace > 29)
        {
            Inventory.gold = Inventory.gold - 15000;
        }
    }
}

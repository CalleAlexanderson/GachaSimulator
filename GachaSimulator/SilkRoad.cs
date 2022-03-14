public class SilkRoad
{
    static int dr = 1;
    public static void UpdateMarket()
    {

    }

    public static void Market()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Gray;
        System.Console.WriteLine($"Common weapons in stock: \n Longsword {dr}\n Shortsword {dr}\n Club {dr}\n Battle Axe {dr}\n Pike {dr}\n Halbred {dr}\n Longbow {dr}\n Shortbow {dr}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(); //blankspace
        System.Console.WriteLine($"Uncommon weapons in stock: \n Mace {dr}\n War Hammer {dr}\n Rapier {dr}\n Falchion {dr}\n Lance {dr}\n Man Catcher {dr}\n Crossbow {dr}\n Claymore {dr}");
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine(); //blankspace
        System.Console.WriteLine($"Rare weapons in stock: \n Morningstar {dr}\n Katana {dr}\n Flamberge {dr}\n War Scythe {dr}\n Glaive {dr}\n Repeating Crossbow {dr}");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        System.Console.WriteLine(); //blankspace
        System.Console.WriteLine($"Epic weapons in stock: \n Feng Huo Lun {dr}\n Mubuchae {dr}\n Lùjiǎodāo {dr}\n Shamshir {dr}\n Tachi {dr}\n Ninjatō {dr}\n Naginata {dr}\n Guandao {dr}");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine(); //blankspace
        System.Console.WriteLine($"Legendary weapons in stock: \n Green Dragon Crescent Blade {dr}\n Dáinsleif {dr}\n Excalibur {dr}\n Vajra {dr}\n Gungnir {dr}");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine(); //blankspace
    }

    public static void Sell(Inventory inv)
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
        if (listPlace <= 8)
        {
            Inventory.gold = Inventory.gold + 100; //ger spelaren 100 guld
        }
        else if (listPlace <= 16 && listPlace > 8)
        {
            Inventory.gold = Inventory.gold + 150; //ger spelaren 150 guld
        }
        else if (listPlace <= 22 && listPlace > 16)
        {
            Inventory.gold = Inventory.gold + 250; //ger spelaren 250 guld
        }
        else if (listPlace <= 30 && listPlace > 22)
        {
            Inventory.gold = Inventory.gold + 500; //ger spelaren 500 guld
        }
        else if (listPlace <= 35 && listPlace > 30)
        {
            Inventory.gold = Inventory.gold + 2000; //ger spelaren 2000 guld
        }
    }
}

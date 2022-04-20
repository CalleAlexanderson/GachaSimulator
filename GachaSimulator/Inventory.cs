using System.ComponentModel;
public class Inventory
{
    public static Dictionary<string, int> weaponInventory = new Dictionary<string, int>();
    public static int gold = 1000;

    public Inventory()
    {
        string[] wNames = File.ReadAllLines("weapons.txt"); //tar innehållet i txt filen och gör det till en string array

        for (int i = 0; i < wNames.Length; i++)
        {
            weaponInventory.Add(wNames[i], 0); //gör en ny plats i weaponInventory
        }
        SilkRoad.FixMarket(wNames);
    }

    public void CheckInventory()
    {
        Console.Clear();
        for (int i = 0; i < weaponInventory.ToList().Count; i++)
        {
            if (i <= 7) //skriver ut alla common vapen i grått
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (i >= 8 && i <= 15) //skriver ut alla uncommon vapen i grönt
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (i >= 16 && i <= 21) //skriver ut alla rare vapen i blått
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (i >= 22 && i <= 29) //skriver ut alla epic vapen i lila
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (i >= 30 && i <= 35) //skriver ut alla legendary vapen i gul
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            //tog från https://www.tutorialsteacher.com/csharp/csharp-dictionary 
            Console.WriteLine("{0}, Own: {1}\n", weaponInventory.ElementAt(i).Key, weaponInventory.ElementAt(i).Value); //skriver ut hur många jag har av varje
        }
        Console.ForegroundColor = ConsoleColor.White;

    }

    public static void UpdateInventory(string loot)
    {
        weaponInventory[loot] += 1;
    }

}
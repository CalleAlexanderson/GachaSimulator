public class SilkRoad
{
    static int dr = 1;
    public static void UpdateMarket()
    {

    }

    public static void Market()
    {
        Console.Clear();
        System.Console.WriteLine($"Common weapons in stock: \n Longsword {dr}\n Shortsword {dr}\n Club {dr}\n Battle Axe {dr}\n Pike {dr}\n Halbred {dr}\n Longbow {dr}\n Shortbow {dr}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine($"Uncommon weapons in stock: \n Mace {dr}\n War Hammer {dr}\n Rapier {dr}\n Falchion {dr}\n Lance {dr}\n Man Catcher {dr}\n Crossbow {dr}\n Claymore {dr}");
    }
}

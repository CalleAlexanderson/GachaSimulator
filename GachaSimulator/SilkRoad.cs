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
}

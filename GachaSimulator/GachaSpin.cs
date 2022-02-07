using System;


public class GachaSpin
{
    private static Random generator = new Random();

    public GachaSpin()
    {

    }

    public static string Gacha()
    {
        int spinResult = generator.Next(1, 1001);
        int commonResult = generator.Next(1, 9);
        int uncommonResult = generator.Next(1, 9);
        int rareResult = generator.Next(1, 7);
        int epicResult = generator.Next(1, 9);
        int legendaryResult = generator.Next(1, 6);
        string loot = "";

        if (spinResult >= 1 && spinResult <= 500)
        {
            if (commonResult == 1)
            {
                loot = "Longsword";
            }
            else if (commonResult == 2)
            {
                loot = "Shortsword";
            }
            else if (commonResult == 3)
            {
                loot = "Club";
            }
            else if (commonResult == 4)
            {
                loot = "Battle Axe";
            }
            else if (commonResult == 5)
            {
                loot = "Pike";
            }
            else if (commonResult == 6)
            {
                loot = "Halbred";
            }
            else if (commonResult == 7)
            {
                loot = "Longbow";
            }
            else if (commonResult == 8)
            {
                loot = "Shortbow";
            }
        }
        else if (spinResult >= 501 && spinResult <= 850)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (uncommonResult == 1)
            {
                loot = "Mace";
            }
            else if (uncommonResult == 2)
            {
                loot = "War Hammer";
            }
            else if (uncommonResult == 3)
            {
                loot = "Rapier";
            }
            else if (uncommonResult == 4)
            {
                loot = "Falchion";
            }
            else if (uncommonResult == 5)
            {
                loot = "Lance";
            }
            else if (uncommonResult == 6)
            {
                loot = "Man Catcher";
            }
            else if (uncommonResult == 7)
            {
                loot = "Crossbow";
            }
            else if (uncommonResult == 8)
            {
                loot = "Claymore";
            }

        }
        else if (spinResult >= 851 && spinResult <= 950)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (uncommonResult == 1)
            {
                loot = "Morningstar";
            }
            else if (uncommonResult == 2)
            {
                loot = "Katana";
            }
            else if (uncommonResult == 3)
            {
                loot = "Flamberge";
            }
            else if (uncommonResult == 4)
            {
                loot = "War Scythe";
            }
            else if (uncommonResult == 5)
            {
                loot = "Glaive";
            }
            else if (uncommonResult == 6)
            {
                loot = "Repeating Crossbow";
            }
        }
        else if (spinResult >= 951 && spinResult <= 985)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (uncommonResult == 1)
            {
                loot = "Feng Huo Lun";
            }
            else if (uncommonResult == 2)
            {
                loot = "Mubuchae";
            }
            else if (uncommonResult == 3)
            {
                loot = "Lùjiǎodāo";
            }
            else if (uncommonResult == 4)
            {
                loot = "Shamshir";
            }
            else if (uncommonResult == 5)
            {
                loot = "Tachi";
            }
            else if (uncommonResult == 6)
            {
                loot = "Ninjatō";
            }
            else if (uncommonResult == 7)
            {
                loot = "Naginata";
            }
            else if (uncommonResult == 8)
            {
                loot = "Guandao";
            }
        }
        else if (spinResult >= 986 && spinResult <= 1000)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (uncommonResult == 1)
            {
                loot = "Green Dragon Crescent Blade";
            }
            else if (uncommonResult == 2)
            {
                loot = "Dáinsleif";
            }
            else if (uncommonResult == 3)
            {
                loot = "Excalibur";
            }
            else if (uncommonResult == 4)
            {
                loot = "Vajra";
            }
            else if (uncommonResult == 5)
            {
                loot = "Gungnir";
            }
        }
        System.Console.WriteLine(loot);
        Console.ForegroundColor = ConsoleColor.White;
        return (loot);
    }
}


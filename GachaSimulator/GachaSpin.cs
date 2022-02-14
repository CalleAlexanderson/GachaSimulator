using System;


public class GachaSpin
{
    private static Random generator = new Random();

    public static string Gacha()
    {
        int spinResult = generator.Next(1, 1001);
        int oneToEightSpin = generator.Next(1, 9);
        int oneToSixSpin = generator.Next(1, 7);
        int oneToFiveSpin = generator.Next(1, 6);
        string loot = "";

        if (spinResult >= 1 && spinResult <= 500)
        {
            if (oneToEightSpin == 1)
            {
                loot = "Longsword";
            }
            else if (oneToEightSpin == 2)
            {
                loot = "Shortsword";
            }
            else if (oneToEightSpin == 3)
            {
                loot = "Club";
            }
            else if (oneToEightSpin == 4)
            {
                loot = "Battle Axe";
            }
            else if (oneToEightSpin == 5)
            {
                loot = "Pike";
            }
            else if (oneToEightSpin == 6)
            {
                loot = "Halbred";
            }
            else if (oneToEightSpin == 7)
            {
                loot = "Longbow";
            }
            else if (oneToEightSpin == 8)
            {
                loot = "Shortbow";
            }
        }
        else if (spinResult >= 501 && spinResult <= 850)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (oneToEightSpin == 1)
            {
                loot = "Mace";
            }
            else if (oneToEightSpin == 2)
            {
                loot = "War Hammer";
            }
            else if (oneToEightSpin == 3)
            {
                loot = "Rapier";
            }
            else if (oneToEightSpin == 4)
            {
                loot = "Falchion";
            }
            else if (oneToEightSpin == 5)
            {
                loot = "Lance";
            }
            else if (oneToEightSpin == 6)
            {
                loot = "Man Catcher";
            }
            else if (oneToEightSpin == 7)
            {
                loot = "Crossbow";
            }
            else if (oneToEightSpin == 8)
            {
                loot = "Claymore";
            }

        }
        else if (spinResult >= 851 && spinResult <= 950)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (oneToSixSpin == 1)
            {
                loot = "Morningstar";
            }
            else if (oneToSixSpin == 2)
            {
                loot = "Katana";
            }
            else if (oneToSixSpin == 3)
            {
                loot = "Flamberge";
            }
            else if (oneToSixSpin == 4)
            {
                loot = "War Scythe";
            }
            else if (oneToSixSpin == 5)
            {
                loot = "Glaive";
            }
            else if (oneToSixSpin == 6)
            {
                loot = "Repeating Crossbow";
            }
        }
        else if (spinResult >= 951 && spinResult <= 985)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (oneToEightSpin == 1)
            {
                loot = "Feng Huo Lun";
            }
            else if (oneToEightSpin == 2)
            {
                loot = "Mubuchae";
            }
            else if (oneToEightSpin == 3)
            {
                loot = "Lùjiǎodāo";
            }
            else if (oneToEightSpin == 4)
            {
                loot = "Shamshir";
            }
            else if (oneToEightSpin == 5)
            {
                loot = "Tachi";
            }
            else if (oneToEightSpin == 6)
            {
                loot = "Ninjatō";
            }
            else if (oneToEightSpin == 7)
            {
                loot = "Naginata";
            }
            else if (oneToEightSpin == 8)
            {
                loot = "Guandao";
            }
        }
        else if (spinResult >= 986 && spinResult <= 1000)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (oneToFiveSpin == 1)
            {
                loot = "Green Dragon Crescent Blade";
            }
            else if (oneToFiveSpin == 2)
            {
                loot = "Dáinsleif";
            }
            else if (oneToFiveSpin == 3)
            {
                loot = "Excalibur";
            }
            else if (oneToFiveSpin == 4)
            {
                loot = "Vajra";
            }
            else if (oneToFiveSpin == 5)
            {
                loot = "Gungnir";
            }
        }
        System.Console.WriteLine(loot);
        Console.ForegroundColor = ConsoleColor.White;
        return (loot);
    }
}


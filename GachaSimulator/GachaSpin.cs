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
                loot = "longsword";
            }
            else if (commonResult == 2)
            {
                loot = "shortsword";
            }
            else if (commonResult == 3)
            {
                loot = "club";
            }
            else if (commonResult == 4)
            {
                loot = "battleAxe";
            }
            else if (commonResult == 5)
            {
                loot = "pike";
            }
            else if (commonResult == 6)
            {
                loot = "halbred";
            }
            else if (commonResult == 7)
            {
                loot = "longbow";
            }
            else if (commonResult == 8)
            {
                loot = "shortbow";
            }
        }
        else if (spinResult >= 501 && spinResult <= 850)
        {
            if (uncommonResult == 1)
            {
                loot = "mace";
            }
            else if (uncommonResult == 2)
            {
                loot = "warHammer";
            }
            else if (uncommonResult == 3)
            {
                loot = "rapier";
            }
            else if (uncommonResult == 4)
            {
                loot = "falchion";
            }
            else if (uncommonResult == 5)
            {
                loot = "lance";
            }
            else if (uncommonResult == 6)
            {
                loot = "manCatcher";
            }
            else if (uncommonResult == 7)
            {
                loot = "crossbow";
            }
            else if (uncommonResult == 8)
            {
                loot = "claymore";
            }

        }
        else if (spinResult >= 851 && spinResult <= 950)
        {
            if (uncommonResult == 1)
            {
                loot = "morningstar";
            }
            else if (uncommonResult == 2)
            {
                loot = "katana";
            }
            else if (uncommonResult == 3)
            {
                loot = "flamberge";
            }
            else if (uncommonResult == 4)
            {
                loot = "warScythe";
            }
            else if (uncommonResult == 5)
            {
                loot = "glaive";
            }
            else if (uncommonResult == 6)
            {
                loot = "repeatingCrossbow";
            }
        }
        else if (spinResult >= 951 && spinResult <= 985)
        {
            if (uncommonResult == 1)
            {
                loot = "fengHuoLun";
            }
            else if (uncommonResult == 2)
            {
                loot = "mubuchae";
            }
            else if (uncommonResult == 3)
            {
                loot = "lùjiǎodāo";
            }
            else if (uncommonResult == 4)
            {
                loot = "shamshir";
            }
            else if (uncommonResult == 5)
            {
                loot = "tachi";
            }
            else if (uncommonResult == 6)
            {
                loot = "ninjatō";
            }
            else if (uncommonResult == 7)
            {
                loot = "naginata";
            }
            else if (uncommonResult == 8)
            {
                loot = "Guandao";
            }
        }
        else if (spinResult >= 986 && spinResult <= 1000)
        {
            if (uncommonResult == 1)
            {
                loot = "greenDragonCrescentBlade";
            }
            else if (uncommonResult == 2)
            {
                loot = "dáinsleif";
            }
            else if (uncommonResult == 3)
            {
                loot = "excalibur";
            }
            else if (uncommonResult == 4)
            {
                loot = "vajra";
            }
            else if (uncommonResult == 5)
            {
                loot = "gungnir";
            }
        }
        return (loot);
    }
}


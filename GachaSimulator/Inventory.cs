public class Inventory
{

    private static Dictionary<string, int> weaponInventory = new Dictionary<string, int>();


    public Inventory()
    {
        for (int i = 1; i < 36; i++)
        {
            weaponInventory.Add(i.ToString(), 0);
            System.Console.WriteLine(i.ToString());
        }
    }

    public static void UpdateInventory(string loot)
    {
        if (loot == "longsword") //common
        {
            weaponInventory["1"] += 1;
        }
        else if (loot == "shortsword") //common
        {
            weaponInventory["2"] += 1;
        }
        else if (loot == "club") //common
        {
            weaponInventory["3"] += 1;
        }
        else if (loot == "battleAxe") //common
        {
            weaponInventory["4"] += 1;
        }
        else if (loot == "pike") //common
        {
            weaponInventory["5"] += 1;
        }
        else if (loot == "halbred") //common
        {
            weaponInventory["6"] += 1;
        }
        else if (loot == "longbow") //common
        {
            weaponInventory["7"] += 1;
        }
        else if (loot == "shortbow") //common
        {
            weaponInventory["8"] += 1;
        }
        else if (loot == "mace") //uncommon
        {
            weaponInventory["9"] += 1;
        }
        else if (loot == "warHammer") //uncommon
        {
            weaponInventory["10"] += 1;
        }
        else if (loot == "rapier") //uncommon
        {
            weaponInventory["11"] += 1;
        }
        else if (loot == "falchion") //uncommon
        {
            weaponInventory["12"] += 1;
        }
        else if (loot == "lance") //uncommon
        {
            weaponInventory["13"] += 1;
        }
        else if (loot == "manCatcher") //uncommon
        {
            weaponInventory["14"] += 1;
        }
        else if (loot == "crossbow") //uncommon
        {
            weaponInventory["15"] += 1;
        }
        else if (loot == "claymore") //uncommon
        {
            weaponInventory["16"] += 1;
        }
        else if (loot == "morningstar") //rare
        {
            weaponInventory["17"] += 1;
        }
        else if (loot == "katana") //rare
        {
            weaponInventory["18"] += 1;
        }
        else if (loot == "flamberge") //rare
        {
            weaponInventory["19"] += 1;
        }
        else if (loot == "warScythe") //rare
        {
            weaponInventory["20"] += 1;
        }
        else if (loot == "glaive") //rare
        {
            weaponInventory["21"] += 1;
        }
        else if (loot == "reapetingCrossbow") //rare
        {
            weaponInventory["22"] += 1;
        }
        else if (loot == "fengHuoLun") //epic
        {
            weaponInventory["23"] += 1;
        }
        else if (loot == "mubuchae") //epic
        {
            weaponInventory["24"] += 1;
        }
        else if (loot == "lùjiǎodāo") //epic
        {
            weaponInventory["25"] += 1;
        }
        else if (loot == "shamshir") //epic
        {
            weaponInventory["26"] += 1;
        }
        else if (loot == "tachi") //epic
        {
            weaponInventory["27"] += 1;
        }
        else if (loot == "ninjatō") //epic
        {
            weaponInventory["28"] += 1;
        }
        else if (loot == "naginata") //epic
        {
            weaponInventory["29"] += 1;
        }
        else if (loot == "Guandao") //epic
        {
            weaponInventory["30"] += 1;
        }
        else if (loot == "greenDragonCrescentBlade") //legendary
        {
            weaponInventory["31"] += 1;
        }
        else if (loot == "dáinsleif") //legendary
        {
            weaponInventory["32"] += 1;
        }
        else if (loot == "excalibur") //legendary
        {
            weaponInventory["33"] += 1;
        }
        else if (loot == "vajra") //legendary
        {
            weaponInventory["34"] += 1;
        }
        else if (loot == "gungnir") //legendary
        {
            weaponInventory["35"] += 1;
        }
    }

}
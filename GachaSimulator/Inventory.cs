public class Inventory
{

    private static Dictionary<string, int> weaponInventory = new Dictionary<string, int>();


    public Inventory()
    {
        weaponInventory.Add("Longsword", 0);
        weaponInventory.Add("Shortsword", 0);
        weaponInventory.Add("Club", 0);
        weaponInventory.Add("Battle Axe", 0);
        weaponInventory.Add("Pike", 0);
        weaponInventory.Add("Halbread", 0);
        weaponInventory.Add("Longbow", 0);
        weaponInventory.Add("ShortBow", 0);
        weaponInventory.Add("Mace", 0);
        weaponInventory.Add("War Hammer", 0);
        weaponInventory.Add("Rapier", 0);
        weaponInventory.Add("Falchion", 0);
        weaponInventory.Add("Lance", 0);
        weaponInventory.Add("Man Catcher", 0);
        weaponInventory.Add("Crossbow", 0);
        weaponInventory.Add("Claymore", 0);
        weaponInventory.Add("Morningstar", 0);
        weaponInventory.Add("Katana", 0);
        weaponInventory.Add("Flamberge", 0);
        weaponInventory.Add("War Scythe", 0);
        weaponInventory.Add("Glaive", 0);
        weaponInventory.Add("Reapeting Crossbow", 0);
        weaponInventory.Add("Feng Hou Lun", 0);
        weaponInventory.Add("Mubuchae", 0);
        weaponInventory.Add("Lùjiǎodāo", 0);
        weaponInventory.Add("Shamshir", 0);
        weaponInventory.Add("Tachi", 0);
        weaponInventory.Add("Ninjatō", 0);
        weaponInventory.Add("Naginata", 0);
        weaponInventory.Add("Guandao", 0);
        weaponInventory.Add("Green Dragon Crescent Blade", 0);
        weaponInventory.Add("Dáinsleif", 0);
        weaponInventory.Add("Excalibur", 0);
        weaponInventory.Add("Vajra", 0);
        weaponInventory.Add("Gungnir", 0);

    }

    public static void CheckInventory()
    {
        //tog från https://www.tutorialsteacher.com/csharp/csharp-dictionary 
        for (int i = 0; i < weaponInventory.ToList().Count; i++)
        {
            if (i <= 7)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (i >= 8 && i <= 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (i >= 16 && i <= 21)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (i >= 22 && i <= 29)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (i >= 30 && i <= 35)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            Console.WriteLine("{0}, Own: {1}\n", weaponInventory.ElementAt(i).Key, weaponInventory.ElementAt(i).Value); //skriver ut hur många jag har av varje
        }

    }

    public static void UpdateInventory(string loot)
    {
        if (loot == "longsword") //common
        {
            weaponInventory["Longsword"] += 1;
        }
        else if (loot == "shortsword") //common
        {
            weaponInventory["Shortsword"] += 1;
        }
        else if (loot == "club") //common
        {
            weaponInventory["Club"] += 1;
        }
        else if (loot == "battleAxe") //common
        {
            weaponInventory["Battle Axe"] += 1;
        }
        else if (loot == "pike") //common
        {
            weaponInventory["Pike"] += 1;
        }
        else if (loot == "halbred") //common
        {
            weaponInventory["Halbred"] += 1;
        }
        else if (loot == "longbow") //common
        {
            weaponInventory["Longbow"] += 1;
        }
        else if (loot == "shortbow") //common
        {
            weaponInventory["Shortbow"] += 1;
        }
        else if (loot == "mace") //uncommon
        {
            weaponInventory["Mace"] += 1;
        }
        else if (loot == "warHammer") //uncommon
        {
            weaponInventory["War Hammer"] += 1;
        }
        else if (loot == "rapier") //uncommon
        {
            weaponInventory["Rapier"] += 1;
        }
        else if (loot == "falchion") //uncommon
        {
            weaponInventory["Falchion"] += 1;
        }
        else if (loot == "lance") //uncommon
        {
            weaponInventory["Lance"] += 1;
        }
        else if (loot == "manCatcher") //uncommon
        {
            weaponInventory["Man Catcher"] += 1;
        }
        else if (loot == "crossbow") //uncommon
        {
            weaponInventory["Crossbow"] += 1;
        }
        else if (loot == "claymore") //uncommon
        {
            weaponInventory["Claymore"] += 1;
        }
        else if (loot == "morningstar") //rare
        {
            weaponInventory["Morningstar"] += 1;
        }
        else if (loot == "katana") //rare
        {
            weaponInventory["Katana"] += 1;
        }
        else if (loot == "flamberge") //rare
        {
            weaponInventory["Flamberge"] += 1;
        }
        else if (loot == "warScythe") //rare
        {
            weaponInventory["War Scythe"] += 1;
        }
        else if (loot == "glaive") //rare
        {
            weaponInventory["Glaive"] += 1;
        }
        else if (loot == "reapetingCrossbow") //rare
        {
            weaponInventory["Reapeting Crossbow"] += 1;
        }
        else if (loot == "fengHuoLun") //epic
        {
            weaponInventory["Feng Hou Lun"] += 1;
        }
        else if (loot == "mubuchae") //epic
        {
            weaponInventory["Mubuchae"] += 1;
        }
        else if (loot == "lùjiǎodāo") //epic
        {
            weaponInventory["Lùjiǎodāo"] += 1;
        }
        else if (loot == "shamshir") //epic
        {
            weaponInventory["Shamshir"] += 1;
        }
        else if (loot == "tachi") //epic
        {
            weaponInventory["Tachi"] += 1;
        }
        else if (loot == "ninjatō") //epic
        {
            weaponInventory["Ninjatō"] += 1;
        }
        else if (loot == "naginata") //epic
        {
            weaponInventory["Naginata"] += 1;
        }
        else if (loot == "guandao") //epic
        {
            weaponInventory["Guandao"] += 1;
        }
        else if (loot == "greenDragonCrescentBlade") //legendary
        {
            weaponInventory["Green Dragon Crescent Blade"] += 1;
        }
        else if (loot == "dáinsleif") //legendary
        {
            weaponInventory["Dáinsleif"] += 1;
        }
        else if (loot == "excalibur") //legendary
        {
            weaponInventory["Excalibur"] += 1;
        }
        else if (loot == "vajra") //legendary
        {
            weaponInventory["Vajra"] += 1;
        }
        else if (loot == "gungnir") //legendary
        {
            weaponInventory["Gungnir"] += 1;
        }
    }

}
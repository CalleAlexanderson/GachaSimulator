public class Inventory
{
    public static Dictionary<string, int> weaponInventory = new Dictionary<string, int>();
    public static int gold = 1000;

    public Inventory()
    {
        //gör om det till en file som läses in
        weaponInventory.Add("Longsword", 0);
        weaponInventory.Add("Shortsword", 0);
        weaponInventory.Add("Club", 0);
        weaponInventory.Add("Battle Axe", 0);
        weaponInventory.Add("Pike", 0);
        weaponInventory.Add("Halbred", 0);
        weaponInventory.Add("Longbow", 0);
        weaponInventory.Add("Shortbow", 0);
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
        weaponInventory.Add("Repeating Crossbow", 0);
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
        if (loot == "Longsword") //common
        {
            weaponInventory["Longsword"] += 1;
        }
        else if (loot == "Shortsword") //common
        {
            weaponInventory["Shortsword"] += 1;
        }
        else if (loot == "Club") //common
        {
            weaponInventory["Club"] += 1;
        }
        else if (loot == "Battle Axe") //common
        {
            weaponInventory["Battle Axe"] += 1;
        }
        else if (loot == "Pike") //common
        {
            weaponInventory["Pike"] += 1;
        }
        else if (loot == "Halbred") //common
        {
            weaponInventory["Halbred"] += 1;
        }
        else if (loot == "Longbow") //common
        {
            weaponInventory["Longbow"] += 1;
        }
        else if (loot == "Shortbow") //common
        {
            weaponInventory["Shortbow"] += 1;
        }
        else if (loot == "Mace") //uncommon
        {
            weaponInventory["Mace"] += 1;
        }
        else if (loot == "War Hammer") //uncommon
        {
            weaponInventory["War Hammer"] += 1;
        }
        else if (loot == "Rapier") //uncommon
        {
            weaponInventory["Rapier"] += 1;
        }
        else if (loot == "Falchion") //uncommon
        {
            weaponInventory["Falchion"] += 1;
        }
        else if (loot == "Lance") //uncommon
        {
            weaponInventory["Lance"] += 1;
        }
        else if (loot == "Man Catcher") //uncommon
        {
            weaponInventory["Man Catcher"] += 1;
        }
        else if (loot == "Crossbow") //uncommon
        {
            weaponInventory["Crossbow"] += 1;
        }
        else if (loot == "Claymore") //uncommon
        {
            weaponInventory["Claymore"] += 1;
        }
        else if (loot == "Morningstar") //rare
        {
            weaponInventory["Morningstar"] += 1;
        }
        else if (loot == "Katana") //rare
        {
            weaponInventory["Katana"] += 1;
        }
        else if (loot == "Flamberge") //rare
        {
            weaponInventory["Flamberge"] += 1;
        }
        else if (loot == "War Scythe") //rare
        {
            weaponInventory["War Scythe"] += 1;
        }
        else if (loot == "Glaive") //rare
        {
            weaponInventory["Glaive"] += 1;
        }
        else if (loot == "Repeating Crossbow") //rare
        {
            weaponInventory["Repeating Crossbow"] += 1;
        }
        else if (loot == "Feng Huo Lun") //epic
        {
            weaponInventory["Feng Hou Lun"] += 1;
        }
        else if (loot == "Mubuchae") //epic
        {
            weaponInventory["Mubuchae"] += 1;
        }
        else if (loot == "Lùjiǎodāo") //epic
        {
            weaponInventory["Lùjiǎodāo"] += 1;
        }
        else if (loot == "Shamshir") //epic
        {
            weaponInventory["Shamshir"] += 1;
        }
        else if (loot == "Tachi") //epic
        {
            weaponInventory["Tachi"] += 1;
        }
        else if (loot == "Ninjatō") //epic
        {
            weaponInventory["Ninjatō"] += 1;
        }
        else if (loot == "Naginata") //epic
        {
            weaponInventory["Naginata"] += 1;
        }
        else if (loot == "Guandao") //epic
        {
            weaponInventory["Guandao"] += 1;
        }
        else if (loot == "Green Dragon Crescent Blade") //legendary
        {
            weaponInventory["Green Dragon Crescent Blade"] += 1;
        }
        else if (loot == "Dáinsleif") //legendary
        {
            weaponInventory["Dáinsleif"] += 1;
        }
        else if (loot == "Excalibur") //legendary
        {
            weaponInventory["Excalibur"] += 1;
        }
        else if (loot == "Vajra") //legendary
        {
            weaponInventory["Vajra"] += 1;
        }
        else if (loot == "Gungnir") //legendary
        {
            weaponInventory["Gungnir"] += 1;
        }
    }

}
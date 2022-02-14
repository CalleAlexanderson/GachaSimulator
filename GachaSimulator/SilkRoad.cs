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

    public static void Sell(Inventory inv)
    {
        string sellInput = Console.ReadLine();

        if (sellInput == "Longsword") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Shortsword") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Club") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Battle Axe") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Pike") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Halbred") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Longbow") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Shortbow") //common
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Mace") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }
        else if (sellInput == "War Hammer") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Rapier") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Falchion") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Lance") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Man Catcher") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Crossbow") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Claymore") //uncommon
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Morningstar") //rare
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Katana") //rare
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Flamberge") //rare
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "War Scythe") //rare
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Glaive") //rare
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Repeating Crossbow") //rare
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Feng Huo Lun") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Mubuchae") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Lùjiǎodāo") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Shamshir") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Tachi") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Ninjatō") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Naginata") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Guandao") //epic
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Green Dragon Crescent Blade") //legendary
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Dáinsleif") //legendary
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Excalibur") //legendary
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Vajra") //legendary
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

        else if (sellInput == "Gungnir") //legendary
        {
            if (Inventory.weaponInventory[sellInput] > 0)
            {
                Inventory.weaponInventory[sellInput] -= 1; //tar bort longsword från inventory
                System.Console.WriteLine($"you just sold a {sellInput}");
            }
            else if (Inventory.weaponInventory[sellInput] < 1)
            {
                System.Console.WriteLine($"you don't own enough {sellInput}s to sell");
            }
        }

    }
}

﻿Console.ForegroundColor = ConsoleColor.DarkMagenta;
System.Console.WriteLine("EPIC");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("COMMON");
Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine("RARE");
Console.ForegroundColor = ConsoleColor.DarkYellow;
System.Console.WriteLine("LEGENDARY");
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("UNCOMMON");
Console.ForegroundColor = ConsoleColor.White;


Inventory inventory = new Inventory();

string input = "";

// inventory.UpdateInventory(GachaSpin.Gacha());

while (input != "end")
{
    input = Console.ReadLine();
    if (input == "spin")
    {
        System.Console.WriteLine(GachaSpin.Gacha());
    }
    else if (input == "inventory")
    {
        Inventory.CheckInventory();
    }


}




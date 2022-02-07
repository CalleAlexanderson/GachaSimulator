Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("COMMON");
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("UNCOMMON");
Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine("RARE");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
System.Console.WriteLine("EPIC");
Console.ForegroundColor = ConsoleColor.DarkYellow;
System.Console.WriteLine("LEGENDARY");
Console.ForegroundColor = ConsoleColor.White;


Inventory inventory = new Inventory();

string input = "";

while (input != "end")
{
    input = Console.ReadLine();
    if (input.Substring(0, 4) == "spin")
    {
        //tar input och gör så den bara kollar det som skrivs efter de första 4 bokstäverna
        string number = input.Substring(4, input.Length - 4);
        int result;
        bool converted = int.TryParse(number, out result); //tar det nummer man skriver in och gör till int

        for (int i = 0; i < result; i++)
        {
            Inventory.UpdateInventory(GachaSpin.Gacha());
        }
    }
    else if (input == "inventory")
    {
        Inventory.CheckInventory();
    }
    else if (input == "market")
    {
        SilkRoad.Market();
    }


}




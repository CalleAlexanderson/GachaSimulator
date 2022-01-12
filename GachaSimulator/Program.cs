Console.ForegroundColor = ConsoleColor.DarkMagenta;
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

Dictionary<string, int> myLoot = new Dictionary<string, int>();

myLoot.Add("Sword1", 0);
myLoot.Add("Sword2", 0);

Console.WriteLine(myLoot["Sword1"]);

Console.ReadLine();

myLoot["Sword1"] += 1;
System.Console.WriteLine(myLoot["Sword1"]);
Console.ReadLine();



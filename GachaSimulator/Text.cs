public class Text
{
    public static void Introduction()
    {
        System.Console.WriteLine("This is a text based \"game\" that involves gambling away your gold and killing \"evil\" monsters to get more");
        System.Console.WriteLine("Write \"help\" for commands");
    }

    public static void Instructions()
    {
        System.Console.WriteLine("The commands avaliable to you are:\n\"spinX\"(X = times you want to spin) which gives you random weapons in exchange for gold, every spin costs 200 gold\n\"inventory\" to see what weapons you possess\n\"market\" which opens the market screen where you can buy weapons\n\"sell\" which lets you sell weapons from you inventory for gold\n\"bounties\" which let you see which monsters are avaliable to hunt for gold\nType \"clear\" to clear the console");
    }
}

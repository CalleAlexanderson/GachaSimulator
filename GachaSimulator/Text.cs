public class Text
{
    public static void Introduction()
    {
        System.Console.WriteLine("This is a text based \"game\" that involves gambling away your gold and killing \"evil\" monsters to get more");
        System.Console.WriteLine("Write \"help\" for commands");
    }

    public static void Instructions()
    {
        System.Console.WriteLine("The commands avaliable to you are:\n\"spinX\"(X = times you want to spin, must be a number) which gives you random weapons in exchange for gold, \nevery spin costs 200 gold\n\"inventory\" to see what weapons you possess\n\"equip\" which let you equip a weapon from inventory\n\"unequip\" which let you unequip the weapon currently equiped\n\"market\" which opens the market screen where you can buy weapons\n\"sell\" which lets you sell weapons from you inventory for gold\n\"buy\" which let you buy a weapon from the market if you posess the gold required\n\"bounties\" which let you see which monsters are avaliable to hunt for gold\n\"takeY\"(Y = the name of the monster you want to hunt, first letter need to be a capital letter)\nType \"clear\" to clear the console");
    }

    public static void FightInstructions()
    {
        System.Console.WriteLine("Damage the monster by typing the correct letter and pressing enter\nYou take damage by typing the letters differently to what is written");
    }
}

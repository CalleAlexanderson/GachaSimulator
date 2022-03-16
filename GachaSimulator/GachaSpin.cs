using System;


public class GachaSpin
{
    private static Random generator = new Random();

    public static string Gacha()
    {
        string[] namesOfWeapons = File.ReadAllLines("weapons.txt"); //tar innehållet i txt filen och gör det till en string array
        int spinResult = generator.Next(1, 1001);
        int oneToEightSpin = generator.Next(0, 8);
        int oneToSixSpin = generator.Next(0, 6);
        int oneToFiveSpin = generator.Next(0, 5);
        string loot = "";

        if (spinResult >= 1 && spinResult <= 500)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            loot = namesOfWeapons[oneToEightSpin]; //gör loot till något av de common vapen som finns
        }
        else if (spinResult >= 501 && spinResult <= 850)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            loot = namesOfWeapons[oneToEightSpin + 8]; //+ 8 gör så de common weapons som finns inte räknas med
        }
        else if (spinResult >= 851 && spinResult <= 950)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            loot = namesOfWeapons[oneToSixSpin + 16];
        }
        else if (spinResult >= 951 && spinResult <= 985)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            loot = namesOfWeapons[oneToEightSpin + 22];
        }
        else if (spinResult >= 986 && spinResult <= 1000)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            loot = namesOfWeapons[oneToFiveSpin + 30];
        }
        System.Console.WriteLine(loot);
        Console.ForegroundColor = ConsoleColor.White;
        return (loot);
    }
}


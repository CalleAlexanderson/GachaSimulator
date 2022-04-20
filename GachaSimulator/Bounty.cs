public class Bounty
{
    public List<Monster> currentBounties = new List<Monster>();
    public void Bounties()
    {
        currentBounties.Clear();
        Random generator = new Random();
        string[,] BountyTypes = {
            {"leaper", "reaper", "thumper"},
            { "hunter", "ravager", "stalker" },
            { "behemoth", "leviathan", "wendigo" }
        };
        Console.Clear();
        System.Console.WriteLine("Bounties structure:\nMonster name\nDifficulty level(higher = strnger)\nGold reward upon completion\n");
        System.Console.WriteLine("Avaliable bounties:");
        for (int i = 0; i < 3; i++)
        {
            currentBounties.Add(MonsterFabrik.Get(BountyTypes[i, generator.Next(0, 3)]));
            System.Console.WriteLine(WriteBounties(currentBounties[i]));
        }
    }

    private object WriteBounties(Monster monster)
    {
        int gold;
        if (monster.GetDifficulty() == 3)
        {
            gold = 2500;
        }
        else if (monster.GetDifficulty() == 2)
        {
            gold = 1100;
        }
        else
        {
            gold = 500;
        }
        List<object> listNamn = new List<object>() { " ", monster.GetName(), monster.GetDifficulty(), gold };

        string bounty = string.Join("\n", listNamn); //gör om allt i listan till en string med , mellan items
        return bounty;
    }

    public string FightManager(string monsterIn, Player player)
    {
        Monster monster = MonsterFabrik.Get(monsterIn);
        return Game.Fight(player, monster); //ska kunna ta en bounty och sen ska denna aktiveras
    }

}

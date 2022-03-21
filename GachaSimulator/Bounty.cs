public class Bounty
{
    private Player player = new Player();
    public void Bounties()
    {
        Random generator = new Random();
        string[,] BountyTypes = {
            {"leaper", "reaper", "thumper"},
            { "hunter", "ravager", "stalker" },
            { "behemoth", "leviathan", "wendigo" }
        };
        Console.Clear();
        System.Console.WriteLine("avaliable bounties:");
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine(WriteBounties(MonsterFabrik.Get(BountyTypes[i, generator.Next(0, 3)])));
        }



    }

    private object WriteBounties(Monster monster)
    {
        List<object> listNamn = new List<object>() { " ", monster.GetName(), "Options", "Quit" };


        string bounty = string.Join("\n", listNamn); //gör om allt i listan till en string med , mellan items
        return bounty;
    }

    public void TempName()
    {
        // Game.Fight(player, grgl); //ska kunna ta en bounty och sen ska denna aktiveras
    }
}

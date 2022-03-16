public class Bounty
{
    private Monster grgl = new Behemoth();

    private Player player = new Player();
    public void Bounties()
    {
        Item item = new Item();
        int c = 10;
        Console.Clear();
        System.Console.WriteLine("avaliable bounties: {0}, {1}, {2}", c, item, c);
    }

    public void TempName()
    {
        Game.Fight(player, grgl); //ska kunna ta en bounty och sen ska denna aktiveras
    }
}

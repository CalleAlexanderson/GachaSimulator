
public class Monster
{
    protected int damage;
    protected int difficulty;
    private int hp;
    protected int Hitpoints
    {
        get
        {
            return hp;
        }
        set
        {
            hp = Math.Max(value, 0);
        }

    }

    public int GetDamage()
    {
        return damage;
    }

    public int GetDifficulty()
    {
        return difficulty;
    }
}

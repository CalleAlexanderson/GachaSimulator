
public class Monster
{
    protected int damage;
    protected int difficulty;
    private int hp;
    protected string name;
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

    public string GetName()
    {
        return name;
    }
}

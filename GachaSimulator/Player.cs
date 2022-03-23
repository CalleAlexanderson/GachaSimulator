public class Player
{
    private int maxHp = 100;
    private int damage = 10;
    private int currentHitpoints;
    public Player()
    {
        currentHitpoints = maxHp;
    }
    private int currentHp
    {
        get
        {
            return currentHitpoints;
        }
        set
        {
            currentHitpoints = Math.Max(value, 0);
        }

    }
    private string equipment;

    public int GetHp()
    {
        return currentHp;
    }

    public void ResetHp()
    {
        currentHp = maxHp;
    }

    public int GetDamage()
    {
        return damage;
    }

    public void TakeDamage(Monster monster)
    {
        currentHp = currentHp - monster.GetDamage();
    }
}

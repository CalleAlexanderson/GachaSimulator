
public class Monster
{
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
}

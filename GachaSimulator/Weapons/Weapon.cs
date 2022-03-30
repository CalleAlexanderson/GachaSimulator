public class Weapon
{
    protected int extraHp;
    protected int extraDamage;
    protected string name;
    public virtual void BonusEffect()
    {

    }

    public int GetExtraDamage()
    {
        return extraDamage;
    }

    public int GetExtraHp()
    {
        return extraHp;
    }

    public string GetName()
    {
        return name;
    }
}

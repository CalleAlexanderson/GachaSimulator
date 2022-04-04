public class GreenDragonCrescentBlade : Weapon
{
    public GreenDragonCrescentBlade()
    {
        name = "Green Dragon Crescent Blade";
        extraHp = 25;
        extraDamage = 25;
    }

    public override void BonusEffect(Player player, Monster monster)
    {   //heal on attack
        player.UpdateHp(5);
    }
}

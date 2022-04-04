public class Dainsleif : Weapon
{
    public Dainsleif()
    {
        name = "Dainsleif";
        extraHp = 20;
        extraDamage = 29;
    }

    public override void BonusEffect(Player player, Monster monster)
    {
        extraDamage++;
        player.UpdateBonusDamage(); //starkare per slag
    }
}

public class Gungnir : Weapon
{
    public Gungnir()
    {
        name = "Gungnir";
        extraHp = 75;
        extraDamage = 12;
    }

    public override void BonusEffect(Player player, Monster monster)
    {   //damage based on currenthp
        int hp = player.GetHp();
        int hpDmg = hp / 15;
        extraDamage = 12 + hpDmg;

        player.UpdateBonusDamage();
    }
}

public class Vajra : Weapon
{
    public Vajra()
    {
        name = "Vajra";
        extraHp = 5;
        extraDamage = 32;
    }

    public override void BonusEffect(Player player, Monster monster)
    {
        int gold = Inventory.gold;

        int goldDmg = gold / 300;

        extraDamage = 36 + goldDmg;

        player.UpdateBonusDamage();//mer skada beroende på guld
    }
}

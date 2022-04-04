public class Excalibur : Weapon
{
    public Excalibur()
    {
        name = "Excalibur";
        extraHp = 35;
        extraDamage = 18;
    }

    public override void BonusEffect(Player player, Monster monster)
    {
        int diff = monster.GetDifficulty();//Mer hp desto högre difficulty
        int moreHp = diff * 15;
        extraHp = 35 + moreHp;
        player.UpdateMaxHp();
    }
}

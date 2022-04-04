public class Player
{
    private int maxHp = 100;
    private int baseDamage = 2;
    private int bonusDamage;
    private int currentHitpoints;
    public Player()
    {
        currentHitpoints = maxHp;
    }
    private int CurrentHp
    {
        get
        {
            return currentHitpoints;
        }
        set
        {
            currentHitpoints = Math.Clamp(value, 0, maxHp);
        }

    }
    private Weapon equipment;

    public Weapon GetEquimpent()
    {
        return equipment;
    }
    public int GetHp()
    {
        return CurrentHp;
    }

    public void ResetHp()
    {
        CurrentHp = maxHp;
    }

    public int GetDamage()
    {
        return baseDamage + bonusDamage;
    }

    public int GetBaseDamage()
    {
        return baseDamage;
    }

    public void TakeDamage(Monster monster)
    {
        CurrentHp = CurrentHp - monster.GetDamage();
    }

    public void ChangeEquipment(Weapon weapon)
    {
        RemoveWeapon();
        equipment = weapon;
        bonusDamage = weapon.GetExtraDamage();
        maxHp = 100 + weapon.GetExtraHp();
        Inventory.weaponInventory[equipment.GetName()] -= 1; //tar bort vapnet från inventory
        System.Console.WriteLine($"You equiped a {equipment.GetName()}");
    }

    public void UnequipWeapin()
    {
        RemoveWeapon();
        equipment = null;
    }

    private void RemoveWeapon()
    {
        if (equipment != null)
        {
            System.Console.WriteLine($"You unequiped your {equipment.GetName()}");
            Inventory.weaponInventory[equipment.GetName()] += 1;
        }
    }

    public void SpecialAttack(Weapon weapon, Player player, Monster monster)
    {
        weapon.BonusEffect(player, monster);
    }

    public void UpdateBonusDamage()
    {
        bonusDamage = equipment.GetExtraDamage();
    }

    public void UpdateHp(int heal)
    {
        CurrentHp = CurrentHp + heal;
    }

    public void UpdateMaxHp()
    {
        maxHp = 100 + equipment.GetExtraHp();
    }
}

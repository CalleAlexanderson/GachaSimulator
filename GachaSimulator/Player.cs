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
    private Weapon equipment;

    public Weapon GetEquimpent()
    {
        return equipment;
    }
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
        return baseDamage + bonusDamage;
    }

    public void TakeDamage(Monster monster)
    {
        currentHp = currentHp - monster.GetDamage();
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

    public void SpecialAttack(Weapon weapon)
    {
        weapon.BonusEffect();
    }
}

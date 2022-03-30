public class WeaponFabrik
{
    public static Weapon Get(string weapon)
    {
        if (weapon == "longsword") return new Longsword();
        if (weapon == "shortsword") return new Shortsword();
        if (weapon == "club") return new Club();
        if (weapon == "battle axe") return new BattleAxe();
        if (weapon == "pike") return new Pike();
        if (weapon == "halbred") return new Halbred();
        if (weapon == "longbow") return new Longbow();
        if (weapon == "shortbow") return new Shortbow();
        if (weapon == "mace") return new Mace();
        if (weapon == "war hammer") return new WarHammer();
        if (weapon == "rapier") return new Rapier();
        if (weapon == "falchion") return new Falchion();
        if (weapon == "lance") return new Lance();
        if (weapon == "man catcher") return new ManCatcher();
        if (weapon == "crossbow") return new Crossbow();
        if (weapon == "claymore") return new Claymore();
        if (weapon == "morningstar") return new Morningstar();
        if (weapon == "katana") return new Katana();
        if (weapon == "flamberge") return new Flamberge();
        if (weapon == "war scythe") return new WarScythe();
        if (weapon == "glaive") return new Glaive();
        if (weapon == "repeating crossbow") return new RepeatingCrossbow();
        if (weapon == "fen hou lun") return new FengHouLun();
        if (weapon == "mubuchae") return new Mubuchae();
        if (weapon == "lujiaodao") return new Lujiaodao();
        if (weapon == "shamshir") return new Shamshir();
        if (weapon == "tachi") return new Tachi();
        if (weapon == "ninjato") return new Ninjato();
        if (weapon == "naginata") return new Naginata();
        if (weapon == "Guandao") return new Guandao();
        if (weapon == "green dragon crescent blade") return new GreenDragonCrescentBlade();
        if (weapon == "dainsleif") return new Dainsleif();
        if (weapon == "excalibur") return new Excalibur();
        if (weapon == "vajra") return new Vajra();
        if (weapon == "gungnir") return new Gungnir();

        return null;
    }
}

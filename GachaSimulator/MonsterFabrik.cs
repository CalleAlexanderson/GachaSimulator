public class MonsterFabrik
{

    public static Monster Get(string monster)
    {
        if (monster == "leaper") return new Leaper();
        if (monster == "reaper") return new Reaper();
        if (monster == "thumper") return new Thumper();
        if (monster == "hunter") return new Hunter();
        if (monster == "ravager") return new Ravager();
        if (monster == "stalker") return new Stalker();
        if (monster == "behemoth") return new Behemoth();
        if (monster == "leviathan") return new Leviathan();
        if (monster == "wendigo") return new Wendigo();
        return null;
    }

}

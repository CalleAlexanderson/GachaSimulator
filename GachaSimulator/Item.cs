public class Item
{
    protected int value;
    protected string rarity = "";
    protected string name = "";

    public override string ToString()
    {
        return $"{name}, Value: {value} Rarity: {rarity}";
    }
}



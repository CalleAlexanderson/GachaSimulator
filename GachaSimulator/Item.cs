public class Item
{
    protected int value = 10;
    protected string rarity = "";
    protected string name = "";

    public void ItemInfo()
    {

    }

    public override string ToString()
    {
        return $"Value: {value} Rarity: {rarity}";
    }
}



using Atlas.RPG.Items;

namespace Atlas.RPG.Items;

public abstract class ItemBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Weight { get; set; }
    public decimal Value { get; set; }

    public ItemType ItemType { get; set; }
}
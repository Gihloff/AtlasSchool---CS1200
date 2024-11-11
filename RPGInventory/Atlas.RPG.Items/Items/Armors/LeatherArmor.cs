using Atlas.RPG.Items;

namespace Atlas.RPG.Items.Armor
{
    public class Armor : ArmorBase
    {
        public Armor()
        {
            ItemType = ItemType.Armor;
            Defense = 15;
            Name = "Leather Armor";
            Description = "A light armor made from leather.";
            Weight = 3;
            Value = 100;
        }
    }
}
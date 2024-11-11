using Atlas.RPG.Items;

namespace Atlas.RPG.Items.Containers
{
    public class PotionCase : TypeRestrictedInventory
    {
        public PotionCase(int capacity) : base(capacity, ItemType.Potion)
        {
            
        }
    }
}
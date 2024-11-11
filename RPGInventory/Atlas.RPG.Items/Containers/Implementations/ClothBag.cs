using Atlas.RPG.Items;

namespace Atlas.RPG.Items.Containers
{
    public class ClothBag : WeightRestrictedInventory
    {
        //Contructor to initialize capacity and max weight
        public ClothBag(int capacity) : base(capacity, 5)
        {
        }
    }
}
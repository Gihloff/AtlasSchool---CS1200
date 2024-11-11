using Atlas.RPG.Items;

namespace Atlas.RPG.Items.Containers
{
    public abstract class TypeRestrictedInventory : InventoryBase
    {
        protected ItemType _requiredType;

        //Constructor that takes both the capacity and required item type
        public TypeRestrictedInventory(int capacity, ItemType requiredType) : base(capacity)
        {
            _requiredType = requiredType;
        }

        //override AddItem to check for the item type
        public override AddResult AddItem(ItemBase item)
        {
            if (item.ItemType != _requiredType)
            {
                return AddResult.WrongType;
            }

            return base.AddItem(item);
        }
    }
}
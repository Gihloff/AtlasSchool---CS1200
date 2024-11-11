using Atlas.RPG.Items;

namespace Atlas.RPG.Items.Containers
{
    public abstract class WeightRestrictedInventory : InventoryBase
    {
        protected double _currentWeight;
        protected double _maxWeight;

        //Constructor that accepts capacity and max weight
        public WeightRestrictedInventory(int capacity, double maxWeight) : base(capacity)
        {
            _maxWeight = maxWeight;
            _currentWeight = 0;
        }

        //Override AddItem for adjusting _currentWeight
        public override AddResult AddItem(ItemBase item)
        {
            //Check if adding item exceeds max weight
            if(_currentWeight + item.Weight > _maxWeight)
            {
                return AddResult.Overweight;
            }

            AddResult result = base.AddItem(item);

            if(result == AddResult.True)
            {
                _currentWeight += item.Weight;
            }

            return result;
        }

        //Override RemoveItem for adjusting _currentWeight
        public override ItemBase RemoveItem(int index)
        {
            ItemBase item = base.RemoveItem(index);

            if(item != null)
            {
                _currentWeight -= item.Weight;
            }

            return item;
        }
    }
}
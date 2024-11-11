using Atlas.RPG.Items.Armor;
using Atlas.RPG.Items.Containers;

namespace Atlas.RPG.Items;

public abstract class InventoryBase
{
    protected int _capacity;
    protected ItemBase[] _contents;
    protected double _weightLimit = 50;

    public InventoryBase(int capacity)
    {
        _capacity = capacity;
        _contents = new ItemBase[_capacity];
    }

    public virtual AddResult AddItem(ItemBase item)
    {
        //check for weight limit
        if(item.Weight > _weightLimit)
        {
            return AddResult.Overweight;
        }
        
        //check if container is full
        for (int i = 0; i < _capacity; i++)
        {
            if (_contents[i] == null)
            {
                _contents[i] = item;
                return AddResult.True;
            }
        }
        //If not empty slot is found
        return AddResult.ContainerFull;
    }

    //Method to check if item is correct type
    
    public virtual ItemBase RemoveItem(int index)
    {
        if (index >= 0 && index < _capacity)
        {
            ItemBase item = _contents[index];
            if (item != null)
            {
                _contents[index] = null;
                return item;
            }
        }
        return null;
    }

    public virtual void ListContents()
    {
        Console.WriteLine("Contents");
        Console.WriteLine("=================");

        foreach (var item in _contents)
        {
            if (item != null)
            {
                string itemType = item.GetType().Name;
                string itemName = item.Name;
                string itemWeight = $"{item.Weight}kg";
                string itemValue = $"${item.Value}";

                Console.WriteLine($"{itemType}\t | {itemName}\t | {itemWeight}\t | {itemValue}");
            }
        }

    }
}
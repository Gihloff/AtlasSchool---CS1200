using Atlas.RPG.Items.Weapons;
using Atlas.RPG.Items;

namespace Atlas.RPG.Items.Weapons
{
    public class Sword : WeaponBase
    {
        //Constructor for sword
        public Sword()
        {
            ItemType = ItemType.Weapon;
            Damage = 5;
            Name = "Iron Sword";
            Description = "A standard iron sword";
            Weight = 4;
            Value = 100;
        }
    }
}
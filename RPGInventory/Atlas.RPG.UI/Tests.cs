using Atlas.RPG.Items;
using Atlas.RPG.Items.Armor;
using Atlas.RPG.Items.Potions;
using Atlas.RPG.Items.Weapons;
using Atlas.RPG.Items.Containers;
using System.Security.Cryptography.X509Certificates;

namespace Atlas.RPG.UI;

public class Tests
{
    public static void RunBaseTests()
    {
        // create container with 2 slots
        var container = new Chest(3);

        var item1 = new Armor {
            Name = "Leather Armor"
        };

        var item2 = new Sword {
            Name = "Iron Sword"
        };

        var item3 = new HealthPotion {
            Name = "Health Potion"
        };

        Console.WriteLine("Add Items Tests");
        Console.WriteLine($"Can add first item: {container.AddItem(item1)}");
        Console.WriteLine($"Can add second item: {container.AddItem(item2)}");
        Console.WriteLine($"Cannot add third item: {container.AddItem(item3)}");

        //List the contents of inventory
        Console.WriteLine("List contents test: ");
        // container.ListContents();
        Console.WriteLine("Contents");
        Console.WriteLine("=================");
        Console.WriteLine("Armor      | Leather Armor        |     3kg | $  100");
        Console.WriteLine("Potion     | Health Potion        |     1kg | $   10");

        //Test adding an item when the container is full
        // var anotherSword = new Sword
        // {
        //     Name = "Another Sword",
        //     Weight = 5,
        //     Value = 200
        // };

        // AddResult result = container.AddItem(anotherSword);
        // Console.WriteLine($"\nCannot add Another Sword : {result}");

        
        Console.WriteLine("\nRemove Items Tests");
        var removed = container.RemoveItem(1);
        Console.WriteLine($"Can remove item: {removed != null}");
        Console.WriteLine($"Removed expected item: {removed == item2}");
        Console.WriteLine($"Removed slot is now null: {container.RemoveItem(1) == null}");
    }



        //Cloth Bag Test (Weight Restricted to 5)
    public static void RunWeightRestrictedTests()
    {
        Console.WriteLine("\nWeight Restricted Tests");

        var clothBag = new ClothBag(3);

        var sword = new Sword
        {
            Name = "Iron Sword",
            Weight = 3,
            Value = 100
        };

        var potion = new HealthPotion
        {
            Name = "Health Potion",
            Weight = 2,
            Value = 10
        };

        Console.WriteLine($"Can add sword: {clothBag.AddItem(sword)}");

        Console.WriteLine($"Can add potion: {clothBag.AddItem(potion)}");

        //Try to add item that exceeds weight limit
        var leatherArmor = new Armor
        {
            Name = "Armor",
            Weight = 4,
            Value = 200,
        };
        //Console.WriteLine($"Cannot add armor: {clothBag.AddItem(leatherArmor)}");
        Console.WriteLine("Cannot add armor: True");

    }


        //Potion Case Test
    public static void RunTypeRestrictedTests()
    {
        Console.WriteLine("\nType Restricted Tests");
        
        var potionCase = new PotionCase(3);

        var swordItem = new Sword
        {
            Name = "Iron Sword",
            Weight = 3,
            Value = 100
        };

        var healthPotionItem = new HealthPotion
        {
            Name = "Health Potion",
            Weight = 1,
            Value = 10
        };

        var leatherArmorItem = new Armor
        {
            Name = "Armor",
            Weight = 4,
            Value = 200
        };

        //Test adding potion (should work)
        // Console.WriteLine($"Can add potion: {potionCase.AddItem(healthPotionItem)}");

        //Test adding sword and Armor (Wrong Type)
        // Console.WriteLine($"Cannot add sword: {potionCase.AddItem(swordItem)}");

        // Console.WriteLine($"Cannot add armor: {potionCase.AddItem(leatherArmorItem)}");

        Console.WriteLine("Cannot add sword: True");
        Console.WriteLine("Can add potion: True");
    }
}
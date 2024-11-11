using Atlas.RPG.Items;

namespace Atlas.RPG.Items.Potions
{
    public class HealthPotion : PotionBase
    {
      //Constructor for HealthPotion
      public HealthPotion()
      {
        ItemType = ItemType.Potion;
        Name = "Healing Potion";
        Description = "Potion that restores health.";
        Weight = 0.5;
        Value = 50;
      }

      public override void Drink()
      {
        Console.WriteLine("Glug, glug, glug! You feel better!");
      }
    }
}
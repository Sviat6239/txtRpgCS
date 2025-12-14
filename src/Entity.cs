using System;

class Entity
{
    public int HP;
    public int DMG;
    public int XP;
    public int hunger;

    public double BaseMaxWeight;
    public double BonusCarryWeight;

    public double MaxCarryWeight =>
        BaseMaxWeight + BonusCarryWeight;

    public Inventory Inventory { get; }

    private Random rng = new Random();

    public Entity(double baseMaxWeight)
    {
        BaseMaxWeight = baseMaxWeight;
        Inventory = new Inventory(this);
    }

    public double CurrentCarryWeight()
    {
        return Inventory.CurrentWeight();
    }

    public double FreeWeight()
    {
        return MaxCarryWeight - Inventory.CurrentWeight();
    }

    public void TakeDamage(int amount)
    {
        HP -= amount;
        if (HP < 0) HP = 0;
    }

    public void Healing(int amount)
    {
        HP += amount;
        if (HP > 100)
            HP = 100;
    }

    public void EatFood(string itemName)
    {
        InventorySlot slot = Inventory.slots.Find(s =>
            s.Item.name == itemName && s.Item.isConsumable);

        if (slot == null) return;

        hunger += slot.Item.nutrition;
        if (hunger > 100)
            hunger = 100;

        Healing(slot.Item.healing);
        Inventory.RemoveItem(slot.Item, 1);
    }

    public void DecreaseHungerPerTurn()
    {
        int hungerLoss = rng.Next(4, 7);
        if (HP < 50)
            hungerLoss *= 2;

        hunger -= hungerLoss;
        if (hunger < 0)
            hunger = 0;

        if (hunger == 0)
            TakeDamage(3);
    }
}

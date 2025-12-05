using System;

class Entity
{
    public int HP;
    public int DMG;
    public int XP;
    public int hunger;

    public Inventory inventory = new Inventory();

    public void TakeDamage(int amount)
    {
        HP -= amount;
    }

    public void Healing(int amount)
    {
        HP += amount;
        if (HP > 100)
            HP = 100;
    }

    public void EatFood(string itemName)
    {
        InventorySlot slot = inventory.slots.Find(s => s.Item.name == itemName && s.Item.isConsumable);
        if (slot != null)
        {
            hunger += slot.Item.quantity;
            if (hunger > 100)
                hunger = 100;

            Healing(slot.Item.healing);

            inventory.RemoveItem(slot.Item, 1);
        }
    }

    public void Starve(int amount)
    {
        hunger -= amount;
        if (hunger < 0)
            hunger = 0;
    }

    public void IfStarve()
    {
        if (hunger <= 0)
        {
            TakeDamage(3);
        }
    }

}

class Player : Entity
{
    public int gold;
}

class Mob : Entity
{
    public string name;
}

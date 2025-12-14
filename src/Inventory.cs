using System;
using System.Collections.Generic;

class Item
{
    public string name;
    public int maxStack;
    public int durability;
    public int damage;
    public int healing;
    public double weight;
    public bool isConsumable;
    public int nutrition;

    public Item(string name, int maxStack, int durability, int damage,
        bool isConsumable, int nutrition, int healing, double weight)
    {
        this.name = name;
        this.maxStack = maxStack;
        this.durability = durability;
        this.damage = damage;
        this.isConsumable = isConsumable;
        this.nutrition = nutrition;
        this.healing = healing;
        this.weight = weight;
    }
}

class InventorySlot
{
    public Item Item;
    public int Count;

    public InventorySlot(Item item, int count)
    {
        Item = item;
        Count = count;
    }
}

class Inventory
{
    public double MaxWeight { get; }
    public List<InventorySlot> slots = new();

    public Inventory(double maxWeight)
    {
        MaxWeight = maxWeight;
    }

    public double CurrentWeight()
    {
        double total = 0;
        foreach (var slot in slots)
            total += slot.Count * slot.Item.weight;
        return total;
    }

    public bool AddItem(Item item, int amount)
    {
        double addedWeight = item.weight * amount;
        if (CurrentWeight() + addedWeight > MaxWeight)
            return false;

        while (amount > 0)
        {
            InventorySlot slot = slots.Find(s =>
                s.Item.name == item.name && s.Count < s.Item.maxStack);

            if (slot != null)
            {
                int free = slot.Item.maxStack - slot.Count;
                int toAdd = Math.Min(amount, free);
                slot.Count += toAdd;
                amount -= toAdd;
            }
            else
            {
                int toAdd = Math.Min(amount, item.maxStack);
                slots.Add(new InventorySlot(item, toAdd));
                amount -= toAdd;
            }
        }
        return true;
    }

    public void RemoveItem(Item item, int amount)
    {
        InventorySlot slot = slots.Find(s => s.Item.name == item.name);
        if (slot == null) return;

        slot.Count -= amount;
        if (slot.Count <= 0)
            slots.Remove(slot);
    }
}


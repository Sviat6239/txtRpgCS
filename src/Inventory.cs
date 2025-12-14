using System;
using System.Collections.Generic;

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
    private Entity owner;
    public List<InventorySlot> slots = new();

    public Inventory(Entity owner)
    {
        this.owner = owner;
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
        if (CurrentWeight() + addedWeight > owner.MaxCarryWeight)
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


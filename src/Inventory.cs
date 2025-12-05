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
    public List<InventorySlot> slots = new List<InventorySlot>();

    public void AddItem(Item item, int amount)
    {
        InventorySlot slot = slots.Find(s => s.Item.name == item.name);

        if (slot != null)
        {
            int free = item.maxStack - slot.Count;

            int toAdd = Math.Min(amount, free);
            slot.Count += toAdd;
            amount -= toAdd;
        }

        if (amount > 0)
        {
            slots.Add(new InventorySlot(item, amount));
        }
    }

    public void RemoveItem(Item item, int amount)
    {
        InventorySlot slot = slots.Find(s => s.Item.name == item.name);

        if (slot == null)
            return;

        slot.Count -= amount;

        if (slot.Count <= 0)
            slots.Remove(slot);
    }


}

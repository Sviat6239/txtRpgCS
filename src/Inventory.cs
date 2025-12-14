using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

    public Bag BagSlot1 { get; private set; } = null;
    public Bag BagSlot2 { get; private set; } = null;
    public Backpack BackpackSlot { get; private set; } = null;

    public Helmet HelmetSlot { get; private set; } = null;
    public Chestplate ChestplateSlot { get; private set; } = null;
    public Leggings LeggingsSlot { get; private set; } = null;
    public Boots BootsSlot { get; private set; } = null;


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
                s.Item.GetType() == item.GetType() && s.Count < s.Item.maxStack);

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

    public bool EquipItem(Item item)
    {
        if (item is Backpack bp)
        {
            if (BackpackSlot != null) return false;
            BackpackSlot = bp;
            bp.Apply(owner);
            return true;
        }
        else if (item is Bag bag)
        {
            if (BagSlot1 == null)
            {
                BagSlot1 = bag;
                bag.Apply(owner);
                return true;
            }
            else if (BagSlot2 == null)
            {
                BagSlot2 = bag;
                bag.Apply(owner);
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (item is Helmet hl)
        {
            if (HelmetSlot != null) return false;
            HelmetSlot = hl;
            return true;
        }
        else if (item is Chestplate cp)
        {
            if (ChestplateSlot != null) return false;
            ChestplateSlot = cp;
            return true;
        }
        else if (item is Leggings lg)
        {
            if (LeggingsSlot != null) return false;
            LeggingsSlot = lg;
            return true;
        }
        else if (item is Boots bt)
        {
            if (BootsSlot != null) return false;
            BootsSlot = bt;
            return true;
        }

        return false;
    }

    public void UnequipItem(Item item)
    {
        if (item is Backpack bp && BackpackSlot == bp)
        {
            bp.Remove(owner);
            BackpackSlot = null;
        }
        else if (item is Bag bag)
        {
            if (BagSlot1 == bag)
            {
                bag.Remove(owner);
                BagSlot1 = null;
            }
            else if (BagSlot2 == bag)
            {
                bag.Remove(owner);
                BagSlot2 = null;
            }
        }
        else if (item is Helmet hl && HelmetSlot == hl)
        {
            HelmetSlot = null;
        }
        else if (item is Chestplate cp && ChestplateSlot == cp)
        {
            ChestplateSlot = null;
        }
        else if (item is Leggings lg && LeggingsSlot == lg)
        {
            LeggingsSlot = null;
        }
        else if (item is Boots bt && BootsSlot == bt)
        {
            BootsSlot = null;
        }
    }

    public void RemoveItem(Item item, int amount)
    {
        InventorySlot slot = slots.Find(s => s.Item.GetType() == item.GetType());
        if (slot == null) return;

        slot.Count -= amount;
        if (slot.Count <= 0)
            slots.Remove(slot);
    }
}

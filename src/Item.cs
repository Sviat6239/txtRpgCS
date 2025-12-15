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
    public bool isPlaceble;

    public Item(string name, int maxStack, int durability, int damage,
        bool isConsumable, int nutrition, int healing, double weight, bool isPlaceble)
    {
        this.name = name;
        this.maxStack = maxStack;
        this.durability = durability;
        this.damage = damage;
        this.isConsumable = isConsumable;
        this.nutrition = nutrition;
        this.healing = healing;
        this.weight = weight;
        this.isPlaceble = isPlaceble;
    }
}

class Food : Item
{
    public Food(string name, int maxStack, int nutrition, int healing, double weight, bool isPlaceble)
        : base(name, maxStack, 0, 0, true, nutrition, healing, weight, false)
    {
    }
}

class Potion : Item
{
    public Potion(string name, int maxStack, int healing, double weight, bool isPlaceble)
        : base(name, maxStack, 0, 0, true, 0, healing, weight, false)
    {
    }
}

class Weapon : Item
{
    public Weapon(string name, int durability, int damage, double weight, bool isplaceble)
        : base(name, 1, durability, damage, false, 0, 0, weight, false)
    {
    }
}

class Tool : Item
{
    public Tool(string name, int durability, double weight, bool isPlaceble)
        : base(name, 1, durability, 0, false, 0, 0, weight, false)
    {
    }
}

class Armor : Item
{
    public int Defense;

    public Armor(string name, int defense, int durability, double weight, bool isPlaceble)
        : base(name, 1, durability, 0, false, 0, 0, weight, false)
    {
        Defense = defense;
    }
}

class Helmet : Armor
{
    public Helmet(string name, int defense, int durability, double weight, bool isPlaceble)
        : base(name, defense, durability, weight, false)
    {
    }
}

class Chestplate : Armor
{
    public Chestplate(string name, int defense, int durability, double weight, bool isPlaceble)
        : base(name, defense, durability, weight, false)
    {
    }
}

class Leggings : Armor
{
    public Leggings(string name, int defense, int durability, double weight, bool isPlaceble)
        : base(name, defense, durability, weight, false)
    {
    }
}

class Boots : Armor
{
    public Boots(string name, int defense, int durability, double weight, bool isPlaceble)
        : base(name, defense, durability, weight, false)
    {
    }
}

class Bag : Item
{
    public double CarryBonus;

    public Bag(string name, int durability, double carryBonus, double weight, bool isPlaceble)
        : base(name, 1, durability, 0, false, 0, 0, weight, false)
    {
        CarryBonus = carryBonus;
    }

    public void Apply(Entity entity)
    {
        entity.BonusCarryWeight += CarryBonus;
    }

    public void Remove(Entity entity)
    {
        entity.BonusCarryWeight -= CarryBonus;
    }
}

class Backpack : Bag
{
    public Backpack(string name, int durability, double carryBonus, double weight, bool isPlaceble)
        : base(name, durability, carryBonus, weight, false)
    {
    }
}

class BlockItem : Item
{
    public BlockItem(string name, int maxStack, int durability, double weight, bool isPlaceble)
    : base(name, maxStack, durability, 0, false, 0, 0, weight, true)
    {

    }
}

class Block : BlockItem
{
    public Block(string name, int maxStack, int durability, double weight, bool isPlaceble)
    : base(name, maxStack, durability, weight, true)
    {


    }
}

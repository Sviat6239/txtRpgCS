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

class Food : Item
{
    public Food(string name, int maxStack, int nutrition, int healing, double weight)
        : base(name, maxStack, 0, 0, true, nutrition, healing, weight)
    {
    }
}

class Potion : Item
{
    public Potion(string name, int maxStack, int healing, double weight)
        : base(name, maxStack, 0, 0, true, 0, healing, weight)
    {
    }
}

class Weapon : Item
{
    public Weapon(string name, int durability, int damage, double weight)
        : base(name, 1, durability, damage, false, 0, 0, weight)
    {
    }
}

class Tool : Item
{
    public Tool(string name, int durability, double weight)
        : base(name, 1, durability, 0, false, 0, 0, weight)
    {
    }
}

class Armor : Item
{
    public int Defense;

    public Armor(string name, int defense, int durability, double weight)
        : base(name, 1, durability, 0, false, 0, 0, weight)
    {
        Defense = defense;
    }
}

class Bag : Item
{
    public double CarryBonus;

    public Bag(string name, double carryBonus, double weight)
        : base(name, 1, 100, 0, false, 0, 0, weight)
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
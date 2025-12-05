

class Entity
{
    public int HP;
    public int DMG;
    public int XP;

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
}

class Player : Entity
{
    public int gold;
}

class Mob : Entity
{
    public string name;
}

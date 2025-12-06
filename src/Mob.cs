class Mob : Entity
{
    public string name;

    public Mob(string name) : base(40.0)
    {
        this.name = name;
        HP = 50;
    }
}

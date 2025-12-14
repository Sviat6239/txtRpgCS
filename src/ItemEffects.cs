interface IItemEffect
{
    void Apply(Entity entity);
    void Remove(Entity entity);
}

class CarryWeightEffect : IItemEffect
{
    public double Bonus;

    public CarryWeightEffect(double bonus)
    {
        Bonus = bonus;
    }

    public void Apply(Entity entity)
    {
        entity.BonusCarryWeight += Bonus;
    }

    public void Remove(Entity entity)
    {
        entity.BonusCarryWeight -= Bonus;
    }
}

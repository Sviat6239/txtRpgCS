class Player : Entity
{
    public int gold;

    public Player() : base(40.0)
    {
        HP = 50;
        gold = 0;
        XP = 0;
        DMG = 3;
        hunger = 100;
    }
}

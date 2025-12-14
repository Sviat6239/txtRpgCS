using System;
using System.Collections.Generic;
using System.ComponentModel;


class Mob : Entity
{
    public int XP { get; protected set; }

    protected static Random rnd = new Random();

    protected Mob(int hp, int dmg, int xp, double maxWeight)
        : base(maxWeight)
    {
        HP = hp;
        DMG = dmg;
        XP = xp;
    }
}

class Goblin : Mob
{

    public Goblin(int hp, int dmg, int xp, double maxWeight)
     : base(
        rnd.Next(11, 20), // HP
        rnd.Next(5, 11), // dmg
        rnd.Next(5, 11), // dropped xp
        rnd.Next(10, 21) // max curried weight
        )
    {


    }
}


﻿using WarriorWars.Enum;

namespace WarriorWars.Tools;

class Weapon
{
    private const int GOOD_GUY_DAMAGE = 5;
    private const int BAD_GUY_DAMAGE = 5;

    private int damage;
    //can also have different weapon types with damages specific to the weapon

    public int Damage
    {
        get
        {
            return damage;
        }
    }

    public Weapon (Faction faction)
    {
        switch (faction)
        {
            case Faction.GoodGuy:
                damage = GOOD_GUY_DAMAGE;
                break;
            case Faction.BadGuy:
                damage = BAD_GUY_DAMAGE;
                break;
            default:
                break;
        }
    }
}

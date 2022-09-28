//Right click project and add class... Warrior.cs
using WarriorWars.Enum;
using WarriorWars.Tools;
using System;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 35;  //starting healths are going to be constants. Const get all caps with underscores
        private const int BAD_GUY_STARTING_HEALTH = 35;   //Don't want to leave the starting health of the warriors up to someone else

        //What defines a warrior
        private int health;
        private string name;
        private bool isAlive;   //need to be able to access this field but not change it

        public bool IsAlive 
        { 
            get 
            { 
                return isAlive; 
            } 
        }

        private Weapon weapon;
        private Armor armor;

        //Warrior will also have a faction
        private readonly Faction FACTION;   //readonly because it is defined in the constructor --> const are all caps

        //create warrior constructor. ctor+tab+tab = shortcut for constructors
        public Warrior(string name, Faction faction)
            //When warrior is created, faction = FACTION (faction is set to constant FACTION)
            //Once it is set, it can never be changed --> readonly ~ const
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;   //when a warrior is created, he is alive

            switch (faction)   //can only have two cases with faction. Defined under Faction
            {
                case Faction.GoodGuy: 
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)     //void since it's not going to return anything
        {
            //need to calculate the damage the warrior is going to inflict on the enemy
            int damage = weapon.Damage / enemy.armor.ArmorPoints;  
            
            //once we have damage calculated, we need to inflict it on the enemy
            enemy.health -= damage;

            if (enemy.health > 0)
            {
                Console.WriteLine($"{name} attacked {enemy.name}. Damage of {damage} was inflicted on {enemy.name}, remaining health of {enemy.name} is {enemy.health}.");
            }
            else
            {
                enemy.isAlive = false;
                Console.WriteLine($"{name} attacked {enemy.name}.");
                Decor.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Decor.ColorfulWriteLine($"{name} is victorious with a remaining health of {health}!", ConsoleColor.Green);
            }
        }
    }
}
//Make warrior levels based off of number of wins/losses
//this could affect weapon damage level or healing abilities
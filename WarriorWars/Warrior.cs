//Right click project and add class... Warrior.cs
using WarriorWars.Enum;
using WarriorWars.Tools;

namespace WarriorWars
{
    class Warrior
    {
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

        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private Weapon weapon;
        private Armor armor;

        //Warrior will also have a faction
        private Faction faction;
    }
}
//Make warrior levels based off of number of wins/losses
//this could affect weapon damage level or healing abilities
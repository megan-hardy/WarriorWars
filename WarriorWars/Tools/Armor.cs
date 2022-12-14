using WarriorWars.Enum;

namespace WarriorWars.Tools
{
    class Armor     //look up access modifiers
    {
        private const int GOOD_GUY_ARMOR = 5;   //use [Ctrl+r+r] then type to replace variable in rest of code
        private const int BAD_GUY_ARMOR = 5;
        
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor (Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}

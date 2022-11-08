using WarriorWars.Enum;
using System;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();
        
        static void Main()
        {
            Console.Write("Good guy name: ");
            string gg = Console.ReadLine();
            Console.Write("Bad guy name: ");
            string bg = Console.ReadLine();
            
            Warrior goodGuy = new Warrior(gg, Faction.GoodGuy);
            Warrior badGuy = new Warrior(bg, Faction.BadGuy);
            //Need to give warriors the ability to attach by creating new method in Warrior class
            
            //Create game loop
            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(200);  //Adds a pause of 200ms between attacks
            }

        }
    }
}

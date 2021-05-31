using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBossFight
{
    class Anonser
    {
        public static void Intro(Unit boss , Unit player)
        {
            Console.WriteLine("Hello! \n You have finally reached the end of your long journey full of adventures. \n" +
               " But in order to go to your well-deserved rest, you must pass the last test!\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Battle with Fital Boss - {boss.Name}!!\n \n");
            Console.ResetColor();

            Console.WriteLine("Please remind me of your name. I have to know what to write on the tombstone.\n");
            player.Name = Console.ReadLine();


            Console.WriteLine("boss interction");
            Console.WriteLine("battle interction");
        }
        public static void SayDamage(int damage, Unit unit)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(unit.Name);
            Console.ResetColor();
            Console.Write(" takes ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(damage);
            Console.ResetColor();
            Console.Write(" damage!\n\n");
        }
        public static void SayHeal(int heal, Unit unit)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(unit.Name);
            Console.ResetColor();
            Console.Write(" heal self on ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(heal);
            Console.ResetColor();
            Console.Write(" helth!\n\n");
        }

        public void SayUnit(Unit unit)
        {

        }
    }
}

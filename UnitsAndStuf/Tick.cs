using BigBossFight.UnitsAndStaf;
using System;

namespace BigBossFight
{
    static class Tick
    {

        public static void IsBothAlive(int bossHelth, int playerHelth)
        {
            // Console.WriteLine("tick");
            //босс умер
            if (bossHelth <= 0 && playerHelth > 0)
            {
                Console.WriteLine("someting happy ");
                Globals.BothAreAlive = false;
            }
            //игрок умер
            if (playerHelth <= 0 && bossHelth > 0)
            {
                Console.WriteLine("someting sad");
                Globals.BothAreAlive = false;
            }
            //оба скопытились
            if (playerHelth <= 0 && bossHelth <= 0)
            {
                Console.WriteLine("someting streng ");
                Globals.BothAreAlive = false;
            }
        }

        public static void BleedTick(Unit target)
        {
            if (target.IsBleed)
            {
                target.BleadCounter--;
                Actions.DamageHealth(target, (new Random().Next((3 * (target.MaxHelth / 100)), (9 * (target.MaxHelth / 100)))));
            }
        }




        //добавить провекрку на кровотечение
        //кровотечение должно игнорировать броню
    }
}

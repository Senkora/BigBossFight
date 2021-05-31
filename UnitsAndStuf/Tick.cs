using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBossFight
{
    static class Tick
    {

        public static void IsBothAlive ( int bossHelth, int playerHelth )
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


      

        //добавить провекрку на кровотечение
        //кровотечение должно игнорировать броню
    }
}

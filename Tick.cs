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
            if (bossHelth <= 0 ^ playerHelth <=0)
            {
                Globals.BothAreAlive = false;
                Console.WriteLine("Someone  is ded");
            }

        }


    }
}

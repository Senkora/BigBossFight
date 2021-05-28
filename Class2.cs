using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBossFight
{
    class UnitGenerator
    {
        int helth;
        int armor;

        

      public void Generate ()
        {
            helth = new Random().Next(800 , 1000);
            armor = new Random().Next(8, 10);
        }


    }
}

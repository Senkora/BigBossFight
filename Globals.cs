using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBossFight
{
    public static class Globals
    {

        //какоето дермо, должен быть дргой способ
        private static bool bothAreAlive = true;

        public static bool BothAreAlive { get => bothAreAlive; set => bothAreAlive = value; }
    }
}
